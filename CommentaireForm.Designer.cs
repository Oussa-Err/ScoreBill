﻿namespace scoreBill
{
    partial class CommentaireForm
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
            InformationGeneraleLabel = new Label();
            SuspendLayout();
            // 
            // InformationGeneraleLabel
            // 
            InformationGeneraleLabel.AutoSize = true;
            InformationGeneraleLabel.Location = new Point(70, 89);
            InformationGeneraleLabel.Name = "InformationGeneraleLabel";
            InformationGeneraleLabel.Size = new Size(185, 28);
            InformationGeneraleLabel.TabIndex = 1;
            InformationGeneraleLabel.Text = "Information général";
            // 
            // CommentaireForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 639);
            Controls.Add(InformationGeneraleLabel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(790, 686);
            Name = "CommentaireForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Commentaire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InformationGeneraleLabel;
    }
}