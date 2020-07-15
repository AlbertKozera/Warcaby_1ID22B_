﻿using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Warcaby.Service.Context;

namespace Warcaby.Forms
{
    public static class Extend
    {
        public static bool IsNullOrEmpty(this IList List)
        {
            return (List == null || List.Count < 1);
        }
        public static bool IsNullOrEmpty(this IDictionary Dictionary)
        {
            return (Dictionary == null || Dictionary.Count < 1);
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static PictureBox GetFieldByIndex(int index)
        {
            return (PictureBox)Application.OpenForms["MainStage"].Controls.Find("field_" + index, true)[0];
        }

        public static Control GetControlByName(string name)
        {
            return Application.OpenForms["MainStage"].Controls.Find(name, true)[0];
        }

        public static int GetIndexFromField(PictureBox field)
        {
            return Int16.Parse(field.Tag.ToString());
        }

        public static string GetEnemyPlayerColor(string color)
        {
            return color.Equals(Constant.WHITE)
                ? Constant.RED
                : Constant.WHITE;
        }

        public static Field GetDameField(string color)
        {
            return color.Equals(Constant.WHITE)
                ? Constant.DAME_WHITE
                : Constant.DAME_RED;
        }

        public static Image GetDameImage(string color)
        {
            return color.Equals(Constant.WHITE)
                ? new Bitmap(Properties.Resources.dame_white)
                : new Bitmap(Properties.Resources.dame_red);
        }


        public static void ChangeImageOfTurn(string color)
        {
            PictureBox pictureBox = (PictureBox)GetControlByName("turn");
            if (color.Equals(Constant.WHITE))
                pictureBox.Image = new Bitmap(Properties.Resources.pawn_red);
            else
                pictureBox.Image = new Bitmap(Properties.Resources.pawn_white);
        }

        public static int GetNumberOfPawns(string color)
        {
            int i = 0;
            foreach (Field field in GameService.gameBoard.Values)
            {
                if (field.isPawn && field.color.Equals(color))
                    i++;
            }
            return i;
        }

        public static int GetNumberOfDames(string color)
        {
            int i = 0;
            foreach (Field field in GameService.gameBoard.Values)
            {
                if (field.isDame && field.color.Equals(color))
                    i++;
            }
            return i;
        }

        public static void UpdateGuiCounters()
        {
            Label label;
            label = (Label)GetControlByName("numberOfPawnsForWhite");
            label.Text = GetNumberOfPawns(Constant.WHITE).ToString();
            label = (Label)GetControlByName("numberOfPawnsForRed");
            label.Text = GetNumberOfPawns(Constant.RED).ToString();
            label = (Label)GetControlByName("numberOfDamesForWhite");
            label.Text = GetNumberOfDames(Constant.WHITE).ToString();
            label = (Label)GetControlByName("numberOfDamesForRed");
            label.Text = GetNumberOfDames(Constant.RED).ToString();
        }
    }
}
