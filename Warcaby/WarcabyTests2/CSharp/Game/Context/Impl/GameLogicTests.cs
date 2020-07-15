﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warcaby.Service.Context;
using Warcaby.Forms;

namespace Warcaby.CSharp.Game.Context.Tests
{
    [TestClass()]
    public class GameLogicTests
    {
        public void CompleteBoardTest()
        {
            GameService.gameBoard.Clear();
            for (int i = 2; i <= 63; i += 2)
            {
                GameService.gameBoard.Add(i, Constant.EMPTY_FIELD);
                if (i == 8) i--;
                if (i == 15) i++;
                if (i == 24) i--;
                if (i == 31) i++;
                if (i == 40) i--;
                if (i == 47) i++;
                if (i == 56) i--;
            }
            GameService.gameBoard[18] = Constant.PAWN_WHITE;
            GameService.gameBoard[20] = Constant.PAWN_WHITE;
            GameService.gameBoard[31] = Constant.PAWN_WHITE;
            GameService.gameBoard[24] = Constant.PAWN_WHITE;
            GameService.gameBoard[40] = Constant.PAWN_RED;
            GameService.gameBoard[43] = Constant.PAWN_RED;
            GameService.gameBoard[45] = Constant.PAWN_RED;
            GameService.gameBoard[47] = Constant.PAWN_RED;
            GameService.gameBoard[9] = Constant.PAWN_RED;
            GameService.gameBoard[34] = Constant.DAME_WHITE;
        }

        [TestMethod()]
        public void UpdateFieldFromTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_18, uCNewGame.field_25, 18, 25, "white");
            //then
            gameLogic.UpdateFieldFrom();
            Assert.AreEqual(Constant.EMPTY_FIELD, GameService.gameBoard[18]);
        }

        /*[TestMethod()]
        public void UpdateFieldThroughTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_36, uCNewGame.field_54, 36, 54, "white");
            //then
            gameLogic.UpdateFieldThrough();
            Assert.AreEqual(Constant.EMPTY_FIELD, GameService.gameBoard[45]);
        }*/

        [TestMethod()]
        public void UpdateFieldToTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_45, uCNewGame.field_36, 45, 36, "white");
            //then
            gameLogic.UpdateFieldTo();
            Assert.AreEqual(Constant.PAWN_RED, GameService.gameBoard[36]);
        }

        [TestMethod()]
        public void PromoteThePawnTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_9, uCNewGame.field_2, 9, 2, "red");
            //then
            gameLogic.PromoteThePawn();
            Assert.AreEqual(Constant.DAME_RED, GameService.gameBoard[2]);
        }

        [TestMethod()]
        public void FinishTheTurnTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_18, uCNewGame.field_25, 18, 25, "white");
            //then
            gameLogic.FinishTheTurn("white");
            Assert.AreEqual(false, GameService.whiteTurn);
        }

        [TestMethod()]
        public void RepeatTheTurnTest()
        {
            //given
            UCNewGame uCNewGame = new UCNewGame();
            CompleteBoardTest();
            //when
            GameLogic gameLogic = new GameLogic(uCNewGame.field_18, uCNewGame.field_25, 18, 25, "white");
            //then
            gameLogic.FinishTheTurn("white");
            Assert.AreEqual(false, GameService.whiteTurn);
        }
    }
}