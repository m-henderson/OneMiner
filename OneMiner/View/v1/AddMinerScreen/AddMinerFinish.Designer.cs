﻿namespace OneMiner.View.v1
{
    partial class AddMinerFinish
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
            this.rchFinish = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchFinish
            // 
            this.rchFinish.Location = new System.Drawing.Point(25, 26);
            this.rchFinish.Name = "rchFinish";
            this.rchFinish.Size = new System.Drawing.Size(676, 332);
            this.rchFinish.TabIndex = 1;
            this.rchFinish.Text = "";
            // 
            // AddMinerFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 423);
            this.Controls.Add(this.rchFinish);
            this.Name = "AddMinerFinish";
            this.Text = "AddMinerFinish";
            this.Load += new System.EventHandler(this.AddMinerFinish_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchFinish;
    }
}