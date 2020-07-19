﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Warcaby.CSharp.Config;
using Warcaby.CSharp.Dto;
using Warcaby.CSharp.Game.Computer;
using Warcaby.CSharp.Game.Context.Impl;
using Warcaby.Forms;


namespace Warcaby.Service.Context
{
    public class GameService
    {
        public static Dictionary<int, Field> gameBoard = new Dictionary<int, Field>();
        public static List<Tuple<int, int, int>> forcedBeatingForPawnsList;
        public static Dictionary<Tuple<int, int>, List<int>> forcedBeatingForDamesList;
        public static Boolean whiteTurn;
        public static int indexFrom;
        public static int indexTo;
        public static PictureBox fieldFrom;
        public static PictureBox fieldTo;
        Pawn pawn = new Pawn();
        Dame dame = new Dame();

        public GameService()
        {
            Initializer.SpaceThePawns();
            whiteTurn = true;
        }

        public void GameConstructor(PictureBox fieldFrom, PictureBox fieldTo)
        {
            GameService.indexFrom = Extend.GetIndexFromField(fieldFrom);
            GameService.indexTo = Extend.GetIndexFromField(fieldTo);
            GameService.fieldFrom = fieldFrom;
            GameService.fieldTo = fieldTo;
        }

        public void GameChooser(PictureBox fieldFrom, PictureBox fieldTo)
        {
            GameConstructor(fieldFrom, fieldTo);
            GameLogic playerWhite = new GameLogic(fieldFrom, fieldTo, indexFrom, indexTo, Constant.WHITE);
            GameLogic playerRed = new GameLogic(fieldFrom, fieldTo, indexFrom, indexTo, Constant.RED);

            //PlayerVsPlayer(playerWhite, playerRed);
            PlayerVsComputer(playerWhite);
        }

        public void Gameplay(GameLogic player, string color)
        {
            AI ai = new AI();
            List<Move> list = ai.GetPossibleMoves(gameBoard, color);



            

            //var lisc = computerLogic.MinMax(gameBoardCopy, color, true, 3); // 9 - 20 sekund czekania

            forcedBeatingForPawnsList = pawn.GetDataAboutBeatings(color);
            forcedBeatingForDamesList = dame.GetDataAboutBeatings(color);
            player.MovingAPawnThatHasNoBeating();
            player.MovingADameThatHasNoBeating();
            player.MovingAPawnThatHasABeating();
            player.MovingADameThatHasABeating();
        }

        public void PlayerVsPlayer(GameLogic playerWhite, GameLogic playerRed)
        {
            if (whiteTurn)
                Gameplay(playerWhite, Constant.WHITE);
            else
                Gameplay(playerRed, Constant.RED);
        }

        public void PlayerVsComputer(GameLogic playerWhite)
        {
            AI ai = new AI();
            if (whiteTurn)
            {
                Gameplay(playerWhite, Constant.WHITE);
            }
            else
            {
                Dictionary<int, Field> gameBoardCopy = Extend.CloneGameBoard(gameBoard);
                MoveAndPoints moveAndPoints = ai.MinMax(gameBoardCopy, Constant.RED, true, 3);


                gameBoard[moveAndPoints.move.indexTo] = gameBoard[moveAndPoints.move.indexFrom];
                Extend.GetFieldByIndex(moveAndPoints.move.indexTo).Image = Extend.GetFieldByIndex(moveAndPoints.move.indexFrom).Image;

                if (moveAndPoints.move.indexThrough != 0)
                {
                    gameBoard[moveAndPoints.move.indexThrough] = Constant.EMPTY_FIELD;
                    Extend.GetFieldByIndex(moveAndPoints.move.indexThrough).Image = new Bitmap(Properties.Resources.empty_field);
                }

                gameBoard[moveAndPoints.move.indexFrom] = Constant.EMPTY_FIELD;
                Extend.GetFieldByIndex(moveAndPoints.move.indexFrom).Image = new Bitmap(Properties.Resources.empty_field);
                whiteTurn = true;
                Extend.ChangeImageOfTurn(Constant.WHITE);
            }


                
        }
    }
}
