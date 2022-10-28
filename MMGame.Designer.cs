
using System;

namespace MemoryMatchingGame
{
    partial class MMGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbNotice = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.lbLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.ForeColor = System.Drawing.Color.Red;
            this.lbTimeLeft.Location = new System.Drawing.Point(903, 218);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(236, 67);
            this.lbTimeLeft.TabIndex = 0;
            this.lbTimeLeft.Text = "Time Left: 60";
            this.lbTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lbNotice
            // 
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotice.Location = new System.Drawing.Point(897, 114);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(242, 57);
            this.lbNotice.TabIndex = 0;
            this.lbNotice.Text = "MisMatched:";
            this.lbNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Image = global::MemoryMatchingGame.Properties.Resources.refresh;
            this.btnRestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestar.Location = new System.Drawing.Point(947, 327);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(154, 54);
            this.btnRestar.TabIndex = 1;
            this.btnRestar.Text = "Restart";
            this.btnRestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.Location = new System.Drawing.Point(923, 568);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(216, 55);
            this.btnBackMenu.TabIndex = 2;
            this.btnBackMenu.Text = "Back to Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // lbLevel
            // 
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(903, 40);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(236, 54);
            this.lbLevel.TabIndex = 3;
            this.lbLevel.Text = "Level: ";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MMGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBackMenu;
            this.ClientSize = new System.Drawing.Size(1178, 649);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.lbTimeLeft);
            this.Controls.Add(this.btnRestar);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MMGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Matching Game";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Timer GameTimer;
		private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Label lbLevel;
    }
}

