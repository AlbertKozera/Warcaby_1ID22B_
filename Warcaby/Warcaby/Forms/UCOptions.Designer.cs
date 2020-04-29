﻿namespace Warcaby.Forms
{
    partial class UCOptions
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
            this.labelOptions = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.optionsQuestion = new System.Windows.Forms.Label();
            this.checkBoxThread = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOptions.Location = new System.Drawing.Point(433, 3);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(129, 50);
            this.labelOptions.TabIndex = 0;
            this.labelOptions.Text = "Opcje";
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenu.Location = new System.Drawing.Point(451, 404);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(100, 50);
            this.buttonBackToMenu.TabIndex = 1;
            this.buttonBackToMenu.Text = "Powrót";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.backToMenu);
            // 
            // optionsQuestion
            // 
            this.optionsQuestion.AutoSize = true;
            this.optionsQuestion.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsQuestion.Location = new System.Drawing.Point(163, 196);
            this.optionsQuestion.Name = "optionsQuestion";
            this.optionsQuestion.Size = new System.Drawing.Size(593, 31);
            this.optionsQuestion.TabIndex = 2;
            this.optionsQuestion.Text = "Algorytm komputera będzie korzystał z wątków";
            // 
            // checkBoxThread
            // 
            this.checkBoxThread.AutoSize = true;
            this.checkBoxThread.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxThread.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxThread.Location = new System.Drawing.Point(782, 209);
            this.checkBoxThread.Name = "checkBoxThread";
            this.checkBoxThread.Size = new System.Drawing.Size(15, 14);
            this.checkBoxThread.TabIndex = 3;
            this.checkBoxThread.UseVisualStyleBackColor = true;
            this.checkBoxThread.CheckedChanged += new System.EventHandler(this.checkBoxThreadYes_CheckedChanged);
            // 
            // UCOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.checkBoxThread);
            this.Controls.Add(this.optionsQuestion);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.labelOptions);
            this.Name = "UCOptions";
            this.Size = new System.Drawing.Size(984, 661);
            this.Load += new System.EventHandler(this.UCOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label optionsQuestion;
        private System.Windows.Forms.CheckBox checkBoxThread;
    }
}
