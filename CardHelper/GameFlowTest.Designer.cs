﻿namespace CardHelper
{
    partial class GameFlowTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitGame
            // 
            this.btnInitGame.Location = new System.Drawing.Point(25, 39);
            this.btnInitGame.Name = "btnInitGame";
            this.btnInitGame.Size = new System.Drawing.Size(229, 23);
            this.btnInitGame.TabIndex = 1;
            this.btnInitGame.Text = "初始化游戏";
            this.btnInitGame.UseVisualStyleBackColor = true;
            this.btnInitGame.Click += new System.EventHandler(this.btnInitGame_Click);
            // 
            // GameFlowTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnInitGame);
            this.Name = "GameFlowTest";
            this.Text = "游戏流程测试";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitGame;
    }
}