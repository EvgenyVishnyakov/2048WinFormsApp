﻿namespace _2048WinFormsApp
{
    partial class Rulles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rulles));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(988, 273);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Rulles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1227, 391);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "Rulles";
            Text = "Rulles";
            DockChanged += Rulles_DockChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}