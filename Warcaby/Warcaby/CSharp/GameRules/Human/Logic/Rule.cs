﻿using System;
using System.Collections.Generic;
using Warcaby.Forms;
using Warcaby.Service.Human;

namespace Warcaby.CSharp.GameRules.Human.Logic
{
    public class Rule
    {
        public static Boolean SelectedPieceColorIs(int index, string color)
        {
            return GameService.gameBoard[index].color.Equals(color);
        }

        public static Boolean SelectedPieceIsPawn(int index)
        {
            return GameService.gameBoard[index].isPawn;
        }
        public static Boolean SelectedPieceIsDame(int index)
        {
            return GameService.gameBoard[index].isDame;
        }

        public static Boolean ThereAreForcedBeatingsForPawns()
        {
            return !Extend.IsNullOrEmpty(GameService.forcedBeatingForPawnsList);
        }

        public static Boolean ThereAreForcedBeatingsForDames()
        {
            return !Extend.IsNullOrEmpty(GameService.forcedBeatingForDamesList);
        }

        public static Boolean TheFieldWhereThePieceHasBeenDroppedIsEmpty(int index)
        {
            return GameService.gameBoard[index].isEmptyField;
        }

        public static Boolean ThePawnWasMovedAccordingToTheRules(int indexFrom, int indexTo, string color)
        {
            return color.Equals(Constant.WHITE)
                ? indexTo.Equals(indexFrom + 7) || indexTo.Equals(indexFrom + 9)
                : indexTo.Equals(indexFrom - 7) || indexTo.Equals(indexFrom - 9);
        }

        public static Boolean TheDameWasMovedAccordingToTheRules(int indexFrom, int indexTo)
        {
            Dame dame = new Dame();
            return dame.GetAllowedMoves(indexFrom).Contains(indexTo);
        }

        public static Boolean ThePawnWasBeatingAccordingToTheRules(int indexFrom, int indexTo)
        {
            foreach (Tuple<int, int, int> tuple in GameService.forcedBeatingForPawnsList)
            {
                if (tuple.Item3.Equals(indexTo) && tuple.Item1.Equals(indexFrom))
                {
                    GameLogic.indexThrough = tuple.Item2;
                    return true;
                }
            }
            return false;
        }

        public static Boolean TheDameWasBeatingAccordingToTheRules(int indexFrom, int indexTo)
        {
            foreach (KeyValuePair<Tuple<int, int>, List<int>> entry in GameService.forcedBeatingForDamesList)
            {
                if (entry.Value.Contains(indexTo) && entry.Key.Item1.Equals(indexFrom))
                {
                    GameLogic.indexThrough = entry.Key.Item2;
                    return true;
                }
            }
            return false;
        }

        public static Boolean ThePawnStoodInThePromotionField(int index, string color)
        {
            List<int> listOfPromotionalFieldsForWhite = new List<int>(new int[] { 57, 59, 61, 63 });
            List<int> listOfPromotionalFieldsForRed = new List<int>(new int[] { 2, 4, 6, 8 });
            return color.Equals(Constant.WHITE)
                ? listOfPromotionalFieldsForWhite.Contains(index)
                : listOfPromotionalFieldsForRed.Contains(index);
        }

        public static Boolean ThePawnWantsToMoveProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsPawn(indexFrom)
                && !Rule.ThereAreForcedBeatingsForPawns()
                && !Rule.ThereAreForcedBeatingsForDames()
                && Rule.ThePawnWasMovedAccordingToTheRules(indexFrom, indexTo, color)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }

        public static Boolean TheDameWantsToMoveProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsDame(indexFrom)
                && !Rule.ThereAreForcedBeatingsForPawns()
                && !Rule.ThereAreForcedBeatingsForDames()
                && Rule.TheDameWasMovedAccordingToTheRules(indexFrom, indexTo)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }

        public static Boolean ThePawnWantToExecuteBeatProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsPawn(indexFrom)
                && Rule.ThereAreForcedBeatingsForPawns()
                && Rule.ThePawnWasBeatingAccordingToTheRules(indexFrom, indexTo)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }

        public static Boolean TheDameWantToExecuteBeatProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsDame(indexFrom)
                && Rule.ThereAreForcedBeatingsForDames()
                && Rule.TheDameWasBeatingAccordingToTheRules(indexFrom, indexTo)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }
    }
}
