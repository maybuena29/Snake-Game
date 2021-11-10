namespace Snake_TaskPerformance
{
    partial class Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.btn_start = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_highscore = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_exit = new MaterialSkin.Controls.MaterialFlatButton();
            this.label_image = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.AutoSize = true;
            this.btn_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Depth = 0;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_start.FlatAppearance.BorderSize = 2;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_start.Icon = global::Snake_TaskPerformance.Properties.Resources.snake_icon;
            this.btn_start.Location = new System.Drawing.Point(125, 253);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_start.MinimumSize = new System.Drawing.Size(180, 36);
            this.btn_start.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_start.Name = "btn_start";
            this.btn_start.Primary = false;
            this.btn_start.Size = new System.Drawing.Size(180, 36);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_highscore
            // 
            this.btn_highscore.AutoSize = true;
            this.btn_highscore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_highscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_highscore.Depth = 0;
            this.btn_highscore.Icon = global::Snake_TaskPerformance.Properties.Resources.highscore_icon;
            this.btn_highscore.Location = new System.Drawing.Point(125, 304);
            this.btn_highscore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_highscore.MinimumSize = new System.Drawing.Size(180, 36);
            this.btn_highscore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_highscore.Name = "btn_highscore";
            this.btn_highscore.Primary = false;
            this.btn_highscore.Size = new System.Drawing.Size(180, 36);
            this.btn_highscore.TabIndex = 1;
            this.btn_highscore.Text = "HIGH SCORE";
            this.btn_highscore.UseVisualStyleBackColor = true;
            this.btn_highscore.Click += new System.EventHandler(this.btn_highscore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Depth = 0;
            this.btn_exit.Icon = global::Snake_TaskPerformance.Properties.Resources.exit_icon;
            this.btn_exit.Location = new System.Drawing.Point(125, 405);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_exit.MinimumSize = new System.Drawing.Size(180, 36);
            this.btn_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Primary = false;
            this.btn_exit.Size = new System.Drawing.Size(180, 36);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_image
            // 
            this.label_image.Depth = 0;
            this.label_image.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_image.Image = global::Snake_TaskPerformance.Properties.Resources.snake_background;
            this.label_image.Location = new System.Drawing.Point(0, 23);
            this.label_image.MinimumSize = new System.Drawing.Size(435, 468);
            this.label_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(435, 468);
            this.label_image.TabIndex = 3;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButton1.Icon")));
            this.materialFlatButton1.Location = new System.Drawing.Point(125, 354);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(180, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(180, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "SETTINGS";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(435, 490);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_highscore);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_image);
            this.Location = new System.Drawing.Point(400, 400);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Snake";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Snake_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btn_start;
        private MaterialSkin.Controls.MaterialFlatButton btn_highscore;
        private MaterialSkin.Controls.MaterialFlatButton btn_exit;
        private MaterialSkin.Controls.MaterialLabel label_image;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

