﻿using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Warcaby.Forms
{
    partial class UCNewGame
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.fieldsContainer = new System.Windows.Forms.Panel();
            this.field_40 = new System.Windows.Forms.PictureBox();
            this.field_36 = new System.Windows.Forms.PictureBox();
            this.field_38 = new System.Windows.Forms.PictureBox();
            this.field_47 = new System.Windows.Forms.PictureBox();
            this.field_50 = new System.Windows.Forms.PictureBox();
            this.field_57 = new System.Windows.Forms.PictureBox();
            this.field_59 = new System.Windows.Forms.PictureBox();
            this.field_61 = new System.Windows.Forms.PictureBox();
            this.field_63 = new System.Windows.Forms.PictureBox();
            this.field_2 = new System.Windows.Forms.PictureBox();
            this.field_4 = new System.Windows.Forms.PictureBox();
            this.field_6 = new System.Windows.Forms.PictureBox();
            this.field_8 = new System.Windows.Forms.PictureBox();
            this.field_9 = new System.Windows.Forms.PictureBox();
            this.field_11 = new System.Windows.Forms.PictureBox();
            this.field_13 = new System.Windows.Forms.PictureBox();
            this.field_15 = new System.Windows.Forms.PictureBox();
            this.field_18 = new System.Windows.Forms.PictureBox();
            this.field_20 = new System.Windows.Forms.PictureBox();
            this.field_22 = new System.Windows.Forms.PictureBox();
            this.field_24 = new System.Windows.Forms.PictureBox();
            this.field_25 = new System.Windows.Forms.PictureBox();
            this.field_27 = new System.Windows.Forms.PictureBox();
            this.field_29 = new System.Windows.Forms.PictureBox();
            this.field_31 = new System.Windows.Forms.PictureBox();
            this.field_34 = new System.Windows.Forms.PictureBox();
            this.field_41 = new System.Windows.Forms.PictureBox();
            this.field_43 = new System.Windows.Forms.PictureBox();
            this.field_45 = new System.Windows.Forms.PictureBox();
            this.field_52 = new System.Windows.Forms.PictureBox();
            this.field_54 = new System.Windows.Forms.PictureBox();
            this.field_56 = new System.Windows.Forms.PictureBox();
            this.winner = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Czas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberOfDamesForWhite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfPawnsForWhite = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberOfDamesForRed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numberOfPawnsForRed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fieldsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field_40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(687, 307);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToMenu.TabIndex = 1;
            this.buttonBackToMenu.Text = "Zakończ grę";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.backToMenu);
            // 
            // fieldsContainer
            // 
            this.fieldsContainer.AllowDrop = true;
            this.fieldsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fieldsContainer.Controls.Add(this.field_40);
            this.fieldsContainer.Controls.Add(this.field_36);
            this.fieldsContainer.Controls.Add(this.field_38);
            this.fieldsContainer.Controls.Add(this.field_47);
            this.fieldsContainer.Controls.Add(this.field_50);
            this.fieldsContainer.Controls.Add(this.field_57);
            this.fieldsContainer.Controls.Add(this.field_59);
            this.fieldsContainer.Controls.Add(this.field_61);
            this.fieldsContainer.Controls.Add(this.field_63);
            this.fieldsContainer.Controls.Add(this.field_2);
            this.fieldsContainer.Controls.Add(this.field_4);
            this.fieldsContainer.Controls.Add(this.field_6);
            this.fieldsContainer.Controls.Add(this.field_8);
            this.fieldsContainer.Controls.Add(this.field_9);
            this.fieldsContainer.Controls.Add(this.field_11);
            this.fieldsContainer.Controls.Add(this.field_13);
            this.fieldsContainer.Controls.Add(this.field_15);
            this.fieldsContainer.Controls.Add(this.field_18);
            this.fieldsContainer.Controls.Add(this.field_20);
            this.fieldsContainer.Controls.Add(this.field_22);
            this.fieldsContainer.Controls.Add(this.field_24);
            this.fieldsContainer.Controls.Add(this.field_25);
            this.fieldsContainer.Controls.Add(this.field_27);
            this.fieldsContainer.Controls.Add(this.field_29);
            this.fieldsContainer.Controls.Add(this.field_31);
            this.fieldsContainer.Controls.Add(this.field_34);
            this.fieldsContainer.Controls.Add(this.field_41);
            this.fieldsContainer.Controls.Add(this.field_43);
            this.fieldsContainer.Controls.Add(this.field_45);
            this.fieldsContainer.Controls.Add(this.field_52);
            this.fieldsContainer.Controls.Add(this.field_54);
            this.fieldsContainer.Controls.Add(this.field_56);
            this.fieldsContainer.Controls.Add(this.winner);
            this.fieldsContainer.Location = new System.Drawing.Point(0, 0);
            this.fieldsContainer.Name = "fieldsContainer";
            this.fieldsContainer.Size = new System.Drawing.Size(601, 601);
            this.fieldsContainer.TabIndex = 7;
            // 
            // field_40
            // 
            this.field_40.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_40.Location = new System.Drawing.Point(525, 300);
            this.field_40.Name = "field_40";
            this.field_40.Size = new System.Drawing.Size(75, 75);
            this.field_40.TabIndex = 46;
            this.field_40.TabStop = false;
            this.field_40.Tag = "40";
            this.field_40.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_40.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_40.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_36
            // 
            this.field_36.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_36.Location = new System.Drawing.Point(225, 300);
            this.field_36.Name = "field_36";
            this.field_36.Size = new System.Drawing.Size(75, 75);
            this.field_36.TabIndex = 45;
            this.field_36.TabStop = false;
            this.field_36.Tag = "36";
            this.field_36.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_36.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_36.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_38
            // 
            this.field_38.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_38.Location = new System.Drawing.Point(375, 300);
            this.field_38.Name = "field_38";
            this.field_38.Size = new System.Drawing.Size(75, 75);
            this.field_38.TabIndex = 47;
            this.field_38.TabStop = false;
            this.field_38.Tag = "38";
            this.field_38.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_38.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_38.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_47
            // 
            this.field_47.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_47.Location = new System.Drawing.Point(450, 375);
            this.field_47.Name = "field_47";
            this.field_47.Size = new System.Drawing.Size(75, 75);
            this.field_47.TabIndex = 38;
            this.field_47.TabStop = false;
            this.field_47.Tag = "47";
            this.field_47.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_47.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_47.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_50
            // 
            this.field_50.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_50.Location = new System.Drawing.Point(75, 450);
            this.field_50.Name = "field_50";
            this.field_50.Size = new System.Drawing.Size(75, 75);
            this.field_50.TabIndex = 44;
            this.field_50.TabStop = false;
            this.field_50.Tag = "50";
            this.field_50.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_50.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_50.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_57
            // 
            this.field_57.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_57.Location = new System.Drawing.Point(0, 525);
            this.field_57.Name = "field_57";
            this.field_57.Size = new System.Drawing.Size(75, 75);
            this.field_57.TabIndex = 36;
            this.field_57.TabStop = false;
            this.field_57.Tag = "57";
            this.field_57.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_57.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_57.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_59
            // 
            this.field_59.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_59.Location = new System.Drawing.Point(150, 525);
            this.field_59.Name = "field_59";
            this.field_59.Size = new System.Drawing.Size(75, 75);
            this.field_59.TabIndex = 33;
            this.field_59.TabStop = false;
            this.field_59.Tag = "59";
            this.field_59.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_59.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_59.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_61
            // 
            this.field_61.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_61.Location = new System.Drawing.Point(300, 525);
            this.field_61.Name = "field_61";
            this.field_61.Size = new System.Drawing.Size(75, 75);
            this.field_61.TabIndex = 35;
            this.field_61.TabStop = false;
            this.field_61.Tag = "61";
            this.field_61.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_61.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_61.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_63
            // 
            this.field_63.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_63.Location = new System.Drawing.Point(450, 525);
            this.field_63.Name = "field_63";
            this.field_63.Size = new System.Drawing.Size(75, 75);
            this.field_63.TabIndex = 34;
            this.field_63.TabStop = false;
            this.field_63.Tag = "63";
            this.field_63.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_63.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_63.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_2
            // 
            this.field_2.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_2.Location = new System.Drawing.Point(75, 0);
            this.field_2.Name = "field_2";
            this.field_2.Size = new System.Drawing.Size(75, 75);
            this.field_2.TabIndex = 24;
            this.field_2.TabStop = false;
            this.field_2.Tag = "2";
            this.field_2.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_2.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_4
            // 
            this.field_4.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_4.Location = new System.Drawing.Point(225, 0);
            this.field_4.Name = "field_4";
            this.field_4.Size = new System.Drawing.Size(75, 75);
            this.field_4.TabIndex = 21;
            this.field_4.TabStop = false;
            this.field_4.Tag = "4";
            this.field_4.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_4.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_6
            // 
            this.field_6.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_6.Location = new System.Drawing.Point(375, 0);
            this.field_6.Name = "field_6";
            this.field_6.Size = new System.Drawing.Size(75, 75);
            this.field_6.TabIndex = 23;
            this.field_6.TabStop = false;
            this.field_6.Tag = "6";
            this.field_6.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_6.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_8
            // 
            this.field_8.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_8.Location = new System.Drawing.Point(525, 0);
            this.field_8.Name = "field_8";
            this.field_8.Size = new System.Drawing.Size(75, 75);
            this.field_8.TabIndex = 22;
            this.field_8.TabStop = false;
            this.field_8.Tag = "8";
            this.field_8.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_8.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_9
            // 
            this.field_9.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_9.Location = new System.Drawing.Point(0, 75);
            this.field_9.Name = "field_9";
            this.field_9.Size = new System.Drawing.Size(75, 75);
            this.field_9.TabIndex = 28;
            this.field_9.TabStop = false;
            this.field_9.Tag = "9";
            this.field_9.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_9.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_11
            // 
            this.field_11.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_11.Location = new System.Drawing.Point(150, 75);
            this.field_11.Name = "field_11";
            this.field_11.Size = new System.Drawing.Size(75, 75);
            this.field_11.TabIndex = 25;
            this.field_11.TabStop = false;
            this.field_11.Tag = "11";
            this.field_11.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_11.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_13
            // 
            this.field_13.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_13.Location = new System.Drawing.Point(300, 75);
            this.field_13.Name = "field_13";
            this.field_13.Size = new System.Drawing.Size(75, 75);
            this.field_13.TabIndex = 27;
            this.field_13.TabStop = false;
            this.field_13.Tag = "13";
            this.field_13.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_13.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_15
            // 
            this.field_15.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_15.Location = new System.Drawing.Point(450, 75);
            this.field_15.Name = "field_15";
            this.field_15.Size = new System.Drawing.Size(75, 75);
            this.field_15.TabIndex = 26;
            this.field_15.TabStop = false;
            this.field_15.Tag = "15";
            this.field_15.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_15.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_18
            // 
            this.field_18.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_18.Location = new System.Drawing.Point(75, 150);
            this.field_18.Name = "field_18";
            this.field_18.Size = new System.Drawing.Size(75, 75);
            this.field_18.TabIndex = 32;
            this.field_18.TabStop = false;
            this.field_18.Tag = "18";
            this.field_18.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_18.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_20
            // 
            this.field_20.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_20.Location = new System.Drawing.Point(225, 150);
            this.field_20.Name = "field_20";
            this.field_20.Size = new System.Drawing.Size(75, 75);
            this.field_20.TabIndex = 29;
            this.field_20.TabStop = false;
            this.field_20.Tag = "20";
            this.field_20.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_20.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_22
            // 
            this.field_22.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_22.Location = new System.Drawing.Point(375, 150);
            this.field_22.Name = "field_22";
            this.field_22.Size = new System.Drawing.Size(75, 75);
            this.field_22.TabIndex = 31;
            this.field_22.TabStop = false;
            this.field_22.Tag = "22";
            this.field_22.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_22.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_24
            // 
            this.field_24.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.field_24.Location = new System.Drawing.Point(525, 150);
            this.field_24.Name = "field_24";
            this.field_24.Size = new System.Drawing.Size(75, 75);
            this.field_24.TabIndex = 30;
            this.field_24.TabStop = false;
            this.field_24.Tag = "24";
            this.field_24.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_24.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_25
            // 
            this.field_25.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_25.Location = new System.Drawing.Point(0, 225);
            this.field_25.Name = "field_25";
            this.field_25.Size = new System.Drawing.Size(75, 75);
            this.field_25.TabIndex = 52;
            this.field_25.TabStop = false;
            this.field_25.Tag = "25";
            this.field_25.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_25.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_27
            // 
            this.field_27.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_27.Location = new System.Drawing.Point(150, 225);
            this.field_27.Name = "field_27";
            this.field_27.Size = new System.Drawing.Size(75, 75);
            this.field_27.TabIndex = 49;
            this.field_27.TabStop = false;
            this.field_27.Tag = "27";
            this.field_27.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_27.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_29
            // 
            this.field_29.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_29.Location = new System.Drawing.Point(300, 225);
            this.field_29.Name = "field_29";
            this.field_29.Size = new System.Drawing.Size(75, 75);
            this.field_29.TabIndex = 51;
            this.field_29.TabStop = false;
            this.field_29.Tag = "29";
            this.field_29.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_29.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_29.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_31
            // 
            this.field_31.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_31.Location = new System.Drawing.Point(450, 225);
            this.field_31.Name = "field_31";
            this.field_31.Size = new System.Drawing.Size(75, 75);
            this.field_31.TabIndex = 50;
            this.field_31.TabStop = false;
            this.field_31.Tag = "31";
            this.field_31.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_31.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_34
            // 
            this.field_34.Image = global::Warcaby.Properties.Resources.empty_field;
            this.field_34.Location = new System.Drawing.Point(75, 300);
            this.field_34.Name = "field_34";
            this.field_34.Size = new System.Drawing.Size(75, 75);
            this.field_34.TabIndex = 48;
            this.field_34.TabStop = false;
            this.field_34.Tag = "34";
            this.field_34.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_34.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_34.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_41
            // 
            this.field_41.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_41.Location = new System.Drawing.Point(0, 375);
            this.field_41.Name = "field_41";
            this.field_41.Size = new System.Drawing.Size(75, 75);
            this.field_41.TabIndex = 40;
            this.field_41.TabStop = false;
            this.field_41.Tag = "41";
            this.field_41.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_41.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_41.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_43
            // 
            this.field_43.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_43.Location = new System.Drawing.Point(150, 375);
            this.field_43.Name = "field_43";
            this.field_43.Size = new System.Drawing.Size(75, 75);
            this.field_43.TabIndex = 37;
            this.field_43.TabStop = false;
            this.field_43.Tag = "43";
            this.field_43.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_43.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_43.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_45
            // 
            this.field_45.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_45.Location = new System.Drawing.Point(300, 375);
            this.field_45.Name = "field_45";
            this.field_45.Size = new System.Drawing.Size(75, 75);
            this.field_45.TabIndex = 39;
            this.field_45.TabStop = false;
            this.field_45.Tag = "45";
            this.field_45.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_45.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_52
            // 
            this.field_52.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_52.Location = new System.Drawing.Point(225, 450);
            this.field_52.Name = "field_52";
            this.field_52.Size = new System.Drawing.Size(75, 75);
            this.field_52.TabIndex = 41;
            this.field_52.TabStop = false;
            this.field_52.Tag = "52";
            this.field_52.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_52.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_52.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_54
            // 
            this.field_54.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_54.Location = new System.Drawing.Point(375, 450);
            this.field_54.Name = "field_54";
            this.field_54.Size = new System.Drawing.Size(75, 75);
            this.field_54.TabIndex = 43;
            this.field_54.TabStop = false;
            this.field_54.Tag = "54";
            this.field_54.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_54.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_54.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // field_56
            // 
            this.field_56.Image = global::Warcaby.Properties.Resources.pawn_red;
            this.field_56.Location = new System.Drawing.Point(525, 450);
            this.field_56.Name = "field_56";
            this.field_56.Size = new System.Drawing.Size(75, 75);
            this.field_56.TabIndex = 42;
            this.field_56.TabStop = false;
            this.field_56.Tag = "56";
            this.field_56.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.field_56.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnteEvent);
            this.field_56.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.Color.Black;
            this.winner.Font = new System.Drawing.Font("Book Antiqua", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winner.ForeColor = System.Drawing.Color.White;
            this.winner.Location = new System.Drawing.Point(175, 272);
            this.winner.Name = "winner";
            this.winner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.winner.Size = new System.Drawing.Size(0, 58);
            this.winner.TabIndex = 53;
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turn
            // 
            this.turn.Image = global::Warcaby.Properties.Resources.pawn_white;
            this.turn.Location = new System.Drawing.Point(607, 288);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(75, 77);
            this.turn.TabIndex = 53;
            this.turn.TabStop = false;
            this.turn.Tag = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Czas
            // 
            this.Czas.AutoSize = true;
            this.Czas.Location = new System.Drawing.Point(903, 162);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(0, 13);
            this.Czas.TabIndex = 57;
            this.Czas.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberOfDamesForWhite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numberOfPawnsForWhite);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(606, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 77);
            this.panel1.TabIndex = 58;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numberOfDamesForWhite
            // 
            this.numberOfDamesForWhite.AutoSize = true;
            this.numberOfDamesForWhite.Location = new System.Drawing.Point(82, 56);
            this.numberOfDamesForWhite.Name = "numberOfDamesForWhite";
            this.numberOfDamesForWhite.Size = new System.Drawing.Size(13, 13);
            this.numberOfDamesForWhite.TabIndex = 4;
            this.numberOfDamesForWhite.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "liczba damek -";
            // 
            // numberOfPawnsForWhite
            // 
            this.numberOfPawnsForWhite.AutoSize = true;
            this.numberOfPawnsForWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfPawnsForWhite.Location = new System.Drawing.Point(88, 36);
            this.numberOfPawnsForWhite.Name = "numberOfPawnsForWhite";
            this.numberOfPawnsForWhite.Size = new System.Drawing.Size(19, 13);
            this.numberOfPawnsForWhite.TabIndex = 3;
            this.numberOfPawnsForWhite.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "liczba pionków -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gracz biały";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numberOfDamesForRed);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numberOfPawnsForRed);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(606, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 77);
            this.panel2.TabIndex = 59;
            // 
            // numberOfDamesForRed
            // 
            this.numberOfDamesForRed.AutoSize = true;
            this.numberOfDamesForRed.Location = new System.Drawing.Point(82, 56);
            this.numberOfDamesForRed.Name = "numberOfDamesForRed";
            this.numberOfDamesForRed.Size = new System.Drawing.Size(13, 13);
            this.numberOfDamesForRed.TabIndex = 4;
            this.numberOfDamesForRed.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "liczba damek -";
            // 
            // numberOfPawnsForRed
            // 
            this.numberOfPawnsForRed.AutoSize = true;
            this.numberOfPawnsForRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfPawnsForRed.Location = new System.Drawing.Point(88, 36);
            this.numberOfPawnsForRed.Name = "numberOfPawnsForRed";
            this.numberOfPawnsForRed.Size = new System.Drawing.Size(19, 13);
            this.numberOfPawnsForRed.TabIndex = 3;
            this.numberOfPawnsForRed.Text = "12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "liczba pionków -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gracz czerwony";
            // 
            // UCNewGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.fieldsContainer);
            this.Controls.Add(this.buttonBackToMenu);
            this.Name = "UCNewGame";
            this.Size = new System.Drawing.Size(762, 600);
            this.Load += new System.EventHandler(this.UCNewGame_Load);
            this.fieldsContainer.ResumeLayout(false);
            this.fieldsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.field_40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Panel fieldsContainer;
        public System.Windows.Forms.PictureBox field_2;
        public System.Windows.Forms.PictureBox field_4;
        public System.Windows.Forms.PictureBox field_6;
        public System.Windows.Forms.PictureBox field_8;
        public System.Windows.Forms.PictureBox field_9;
        public System.Windows.Forms.PictureBox field_11;
        public System.Windows.Forms.PictureBox field_13;
        public System.Windows.Forms.PictureBox field_15;
        public System.Windows.Forms.PictureBox field_18;
        public System.Windows.Forms.PictureBox field_20;
        public System.Windows.Forms.PictureBox field_22;
        public System.Windows.Forms.PictureBox field_24;
        public System.Windows.Forms.PictureBox field_25;
        public System.Windows.Forms.PictureBox field_27;
        public System.Windows.Forms.PictureBox field_29;
        public System.Windows.Forms.PictureBox field_31;
        public System.Windows.Forms.PictureBox field_34;
        public System.Windows.Forms.PictureBox field_36;
        public System.Windows.Forms.PictureBox field_38;
        public System.Windows.Forms.PictureBox field_40;
        public System.Windows.Forms.PictureBox field_41;
        public System.Windows.Forms.PictureBox field_43;
        public System.Windows.Forms.PictureBox field_45;
        public System.Windows.Forms.PictureBox field_47;
        public System.Windows.Forms.PictureBox field_50;
        public System.Windows.Forms.PictureBox field_52;
        public System.Windows.Forms.PictureBox field_54;
        public System.Windows.Forms.PictureBox field_56;
        public System.Windows.Forms.PictureBox field_57;
        public System.Windows.Forms.PictureBox field_59;
        public System.Windows.Forms.PictureBox field_61;
        public System.Windows.Forms.PictureBox field_63;
        public PictureBox turn;
        private Label label1;
        private Label Czas;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label numberOfDamesForWhite;
        private Label numberOfPawnsForWhite;
        private Panel panel2;
        private Label numberOfDamesForRed;
        private Label label9;
        private Label numberOfPawnsForRed;
        private Label label11;
        private Label label12;
        private Label winner;
    }
}
