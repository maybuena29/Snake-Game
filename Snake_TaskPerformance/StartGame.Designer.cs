namespace Snake_TaskPerformance
{
    partial class StartGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bg_image = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblScore.Font = new System.Drawing.Font("Snake Chan", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Coral;
            this.lblScore.Image = global::Snake_TaskPerformance.Properties.Resources.label_bg;
            this.lblScore.Location = new System.Drawing.Point(525, 88);
            this.lblScore.MinimumSize = new System.Drawing.Size(189, 45);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(189, 45);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bg_image
            // 
            this.bg_image.AutoSize = true;
            this.bg_image.Font = new System.Drawing.Font("Snake Chan", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bg_image.ForeColor = System.Drawing.Color.DarkCyan;
            this.bg_image.Image = global::Snake_TaskPerformance.Properties.Resources.gamestart_bg;
            this.bg_image.Location = new System.Drawing.Point(528, 25);
            this.bg_image.MinimumSize = new System.Drawing.Size(186, 432);
            this.bg_image.Name = "bg_image";
            this.bg_image.Size = new System.Drawing.Size(186, 432);
            this.bg_image.TabIndex = 1;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbCanvas.Location = new System.Drawing.Point(0, 25);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(528, 432);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 457);
            this.ControlBox = false;
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.bg_image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartGame";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNAKE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label bg_image;
    }
}