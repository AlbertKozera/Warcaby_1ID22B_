﻿using System.Collections.Generic;
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
            this.labelNewGame = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.fieldsContainer = new System.Windows.Forms.Panel();
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
            this.field_36 = new System.Windows.Forms.PictureBox();
            this.field_38 = new System.Windows.Forms.PictureBox();
            this.field_40 = new System.Windows.Forms.PictureBox();
            this.field_41 = new System.Windows.Forms.PictureBox();
            this.field_43 = new System.Windows.Forms.PictureBox();
            this.field_45 = new System.Windows.Forms.PictureBox();
            this.field_47 = new System.Windows.Forms.PictureBox();
            this.field_50 = new System.Windows.Forms.PictureBox();
            this.field_52 = new System.Windows.Forms.PictureBox();
            this.field_54 = new System.Windows.Forms.PictureBox();
            this.field_56 = new System.Windows.Forms.PictureBox();
            this.field_57 = new System.Windows.Forms.PictureBox();
            this.field_59 = new System.Windows.Forms.PictureBox();
            this.field_61 = new System.Windows.Forms.PictureBox();
            this.field_63 = new System.Windows.Forms.PictureBox();
            this.fieldsContainer.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.field_36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_63)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Location = new System.Drawing.Point(468, 8);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(53, 13);
            this.labelNewGame.TabIndex = 0;
            this.labelNewGame.Text = "Nowa gra";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(906, 3);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToMenu.TabIndex = 1;
            this.buttonBackToMenu.Text = "Powrót";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.backToMenu);
            // 
            // fieldsContainer
            // 
            this.fieldsContainer.AllowDrop = true;
            this.fieldsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.fieldsContainer.Controls.Add(this.field_36);
            this.fieldsContainer.Controls.Add(this.field_38);
            this.fieldsContainer.Controls.Add(this.field_40);
            this.fieldsContainer.Controls.Add(this.field_41);
            this.fieldsContainer.Controls.Add(this.field_43);
            this.fieldsContainer.Controls.Add(this.field_45);
            this.fieldsContainer.Controls.Add(this.field_47);
            this.fieldsContainer.Controls.Add(this.field_50);
            this.fieldsContainer.Controls.Add(this.field_52);
            this.fieldsContainer.Controls.Add(this.field_54);
            this.fieldsContainer.Controls.Add(this.field_56);
            this.fieldsContainer.Controls.Add(this.field_57);
            this.fieldsContainer.Controls.Add(this.field_59);
            this.fieldsContainer.Controls.Add(this.field_61);
            this.fieldsContainer.Controls.Add(this.field_63);
            this.fieldsContainer.Location = new System.Drawing.Point(181, 35);
            this.fieldsContainer.Name = "fieldsContainer";
            this.fieldsContainer.Size = new System.Drawing.Size(601, 601);
            this.fieldsContainer.TabIndex = 7;
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
            // UCNewGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldsContainer);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.labelNewGame);
            this.Name = "UCNewGame";
            this.Size = new System.Drawing.Size(984, 661);
            this.Load += new System.EventHandler(this.UCNewGame_Load);
            this.fieldsContainer.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.field_36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.field_63)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Panel fieldsContainer;
        private System.Windows.Forms.PictureBox field_2;
        private System.Windows.Forms.PictureBox field_4;
        private System.Windows.Forms.PictureBox field_6;
        private System.Windows.Forms.PictureBox field_8;
        private System.Windows.Forms.PictureBox field_9;
        private System.Windows.Forms.PictureBox field_11;
        private System.Windows.Forms.PictureBox field_13;
        private System.Windows.Forms.PictureBox field_15;
        private System.Windows.Forms.PictureBox field_18;
        private System.Windows.Forms.PictureBox field_20;
        private System.Windows.Forms.PictureBox field_22;
        private System.Windows.Forms.PictureBox field_24;
        private System.Windows.Forms.PictureBox field_25;
        private System.Windows.Forms.PictureBox field_27;
        private System.Windows.Forms.PictureBox field_29;
        private System.Windows.Forms.PictureBox field_31;
        private System.Windows.Forms.PictureBox field_34;
        private System.Windows.Forms.PictureBox field_36;
        private System.Windows.Forms.PictureBox field_38;
        private System.Windows.Forms.PictureBox field_40;
        private System.Windows.Forms.PictureBox field_41;
        private System.Windows.Forms.PictureBox field_43;
        private System.Windows.Forms.PictureBox field_45;
        private System.Windows.Forms.PictureBox field_47;
        private System.Windows.Forms.PictureBox field_50;
        private System.Windows.Forms.PictureBox field_52;
        private System.Windows.Forms.PictureBox field_54;
        private System.Windows.Forms.PictureBox field_56;
        private System.Windows.Forms.PictureBox field_57;
        private System.Windows.Forms.PictureBox field_59;
        private System.Windows.Forms.PictureBox field_61;
        private System.Windows.Forms.PictureBox field_63;
    }
}