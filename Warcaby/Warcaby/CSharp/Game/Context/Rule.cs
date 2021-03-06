﻿using System;
using System.Collections.Generic;
using Warcaby.CSharp.Config;
using Warcaby.CSharp.Dto;
using Warcaby.CSharp.Game.Context.Impl;
using Warcaby.Forms;
using Warcaby.Service.Context;

namespace Warcaby.CSharp.Game.Context
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

        public static Boolean ThereAreForcedBeatings()
        {
            return ThereAreForcedBeatingsForPawns() || ThereAreForcedBeatingsForDames();
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
            Pawn pawn = new Pawn();
            foreach (Tuple<int, int, int> tuple in GameService.forcedBeatingForPawnsList)
            {
                if (tuple.Item1.Equals(indexFrom) && tuple.Item2.Equals(pawn.GetIndexThrough(indexFrom, indexTo)) && tuple.Item3.Equals(indexTo))
                {
                    GameLogic.indexThrough = tuple.Item2;
                    return true;
                }
            }
            return false;
        }

        public static Boolean TheDameWasBeatingAccordingToTheRules(int indexFrom, int indexTo, string color)
        {
            Dame dame = new Dame();
            foreach (KeyValuePair<Tuple<int, int>, List<int>> entry in GameService.forcedBeatingForDamesList)
            {
                if (entry.Key.Item1.Equals(indexFrom) && entry.Key.Item2.Equals(dame.GetIndexThrough(color, indexFrom, indexTo)) && entry.Value.Contains(indexTo))
                {
                    GameLogic.indexThrough = entry.Key.Item2;
                    return true;
                }
            }
            return false;
        }

        public static Boolean CheckIfAnyPieceIsInTheProcessOfMultipleBeatings(int index)
        {
            return index.Equals(0) ? false : true;
        }

        public static Boolean ThePawnHasABeat(string myColor, int index)
        {
            return ThePawnHasABeatOnSpecificDiagonal(myColor, index, Constant.TOP_LEFT)
                || ThePawnHasABeatOnSpecificDiagonal(myColor, index, Constant.TOP_RIGHT)
                || ThePawnHasABeatOnSpecificDiagonal(myColor, index, Constant.DOWN_LEFT)
                || ThePawnHasABeatOnSpecificDiagonal(myColor, index, Constant.DOWN_RIGHT);
        }

        public static Boolean ThePawnHasABeatOnSpecificDiagonal(string myColor, int index, int diagonal)
        {
            Field fieldData;
            string enemyColor = Extend.GetEnemyPlayerColor(myColor);
            return (GameService.gameBoard.TryGetValue(index, out fieldData) && fieldData.color.Equals(myColor))
                && (GameService.gameBoard.TryGetValue(index + diagonal, out fieldData) && fieldData.color.Equals(enemyColor))
                && (GameService.gameBoard.TryGetValue(index + (2 * diagonal), out fieldData) && fieldData.isEmptyField);
        }

        public static Boolean TheDameHasABeat(string myColor, int index)
        {
            return TheDameHasABeatOnSpecificDiagonal(myColor, index, Constant.TOP_LEFT)
                || TheDameHasABeatOnSpecificDiagonal(myColor, index, Constant.TOP_RIGHT)
                || TheDameHasABeatOnSpecificDiagonal(myColor, index, Constant.DOWN_LEFT)
                || TheDameHasABeatOnSpecificDiagonal(myColor, index, Constant.DOWN_RIGHT);
        }

        public static Boolean TheDameHasABeatOnSpecificDiagonal(string myColor, int index, int diagonal)
        {
            Field field;
            Field fieldData;
            string enemyColor = Extend.GetEnemyPlayerColor(myColor);
            if (Rule.SelectedPieceIsDame(index) && Rule.SelectedPieceColorIs(index, myColor))
            {
                int currentIndex = index;
                while (GameService.gameBoard.TryGetValue(currentIndex += diagonal, out field))
                {
                    if (field.color.Equals(enemyColor) && (GameService.gameBoard.TryGetValue(currentIndex + diagonal, out Field fieldBehind)))
                    {
                        return fieldBehind.isEmptyField ? true : false;
                    }
                }
            }
            return false;
        }

        public static Boolean ThePieceHaveABeat(string color, int indexTo)
        {
            return GameService.gameBoard[indexTo].isPawn
            ? Rule.ThePawnHasABeat(color, indexTo)
            : Rule.TheDameHasABeat(color, indexTo);
        }

        public static Boolean ThePawnStoodInThePromotionField(int index, string color)
        {
            List<int> listOfPromotionalFieldsForWhite = new List<int>(new int[] { 57, 59, 61, 63 });
            List<int> listOfPromotionalFieldsForRed = new List<int>(new int[] { 2, 4, 6, 8 });
            return color.Equals(Constant.WHITE)
                ? listOfPromotionalFieldsForWhite.Contains(index)
                : listOfPromotionalFieldsForRed.Contains(index);
        }

        public static string WhoIsTheWinner()
        {
            int numberOfWhitePawns = Convert.ToInt16(Extend.GetControlByName("numberOfPawnsForWhite").Text);
            int numberOfRedPawns = Convert.ToInt16(Extend.GetControlByName("numberOfPawnsForRed").Text);
            int numberOfWhiteDames = Convert.ToInt16(Extend.GetControlByName("numberOfDamesForWhite").Text);
            int numberOfRedDames = Convert.ToInt16(Extend.GetControlByName("numberOfDamesForRed").Text);

            if (numberOfRedPawns == 0 && numberOfRedDames == 0)
                return Constant.WHITE;
            else if (numberOfWhitePawns == 0 && numberOfWhiteDames == 0)
                return Constant.RED;
            return Constant.EMPTY;
        }

        public static Boolean ThePawnWantsToMoveProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsPawn(indexFrom)
                && !Rule.ThereAreForcedBeatings()
                && Rule.ThePawnWasMovedAccordingToTheRules(indexFrom, indexTo, color)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }

        public static Boolean TheDameWantsToMoveProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsDame(indexFrom)
                && !Rule.ThereAreForcedBeatings()
                && Rule.TheDameWasMovedAccordingToTheRules(indexFrom, indexTo)
                && Rule.TheFieldWhereThePieceHasBeenDroppedIsEmpty(indexTo);
        }

        public static Boolean ThePawnWantToExecuteBeatProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsPawn(indexFrom)
                && Rule.ThereAreForcedBeatingsForPawns()
                && Rule.ThePawnWasBeatingAccordingToTheRules(indexFrom, indexTo);
        }

        public static Boolean TheDameWantToExecuteBeatProperly(int indexFrom, int indexTo, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsDame(indexFrom)
                && Rule.ThereAreForcedBeatingsForDames()
                && Rule.TheDameWasBeatingAccordingToTheRules(indexFrom, indexTo, color);
        }

        public static Boolean ThePawnWantToExecuteMultipleBeatProperly(int indexFrom, int indexTo, int indexWhichHaveMultipleBeats, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsPawn(indexFrom)
                && Rule.ThereAreForcedBeatingsForPawns()
                && indexFrom == indexWhichHaveMultipleBeats
                && Rule.ThePawnWasBeatingAccordingToTheRules(indexFrom, indexTo);
        }

        public static Boolean TheDameWantToExecuteMultipleBeatProperly(int indexFrom, int indexTo, int indexWhichHaveMultipleBeats, string color)
        {
            return Rule.SelectedPieceColorIs(indexFrom, color)
                && Rule.SelectedPieceIsDame(indexFrom)
                && Rule.ThereAreForcedBeatingsForDames()
                && indexFrom == indexWhichHaveMultipleBeats
                && Rule.TheDameWasBeatingAccordingToTheRules(indexFrom, indexTo, color);
        }
    }
}
