namespace Snake_TaskPerformance
{
    partial class Settings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.head_colors = new System.Windows.Forms.ComboBox();
            this.body_colors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsPerF = new System.Windows.Forms.Label();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBodyColor = new System.Windows.Forms.PictureBox();
            this.pictureHeadColor = new System.Windows.Forms.PictureBox();
            this.label_image = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBodyColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeadColor)).BeginInit();
            this.SuspendLayout();
            // 
            // head_colors
            // 
            this.head_colors.BackColor = System.Drawing.SystemColors.ControlDark;
            this.head_colors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.head_colors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.head_colors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.head_colors.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_colors.ForeColor = System.Drawing.Color.Black;
            this.head_colors.Location = new System.Drawing.Point(79, 161);
            this.head_colors.MaxDropDownItems = 10;
            this.head_colors.Name = "head_colors";
            this.head_colors.Size = new System.Drawing.Size(124, 23);
            this.head_colors.Sorted = true;
            this.head_colors.TabIndex = 5;
            this.head_colors.SelectedIndexChanged += new System.EventHandler(this.head_colors_SelectedIndexChanged);
            // 
            // body_colors
            // 
            this.body_colors.AutoCompleteCustomSource.AddRange(new string[] {
            "asdadsd",
            "sadad",
            "asd",
            "asd",
            "dasd",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd"});
            this.body_colors.BackColor = System.Drawing.SystemColors.ControlDark;
            this.body_colors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.body_colors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.body_colors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.body_colors.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body_colors.ForeColor = System.Drawing.Color.Black;
            this.body_colors.Location = new System.Drawing.Point(79, 197);
            this.body_colors.MaxDropDownItems = 10;
            this.body_colors.Name = "body_colors";
            this.body_colors.Size = new System.Drawing.Size(124, 23);
            this.body_colors.Sorted = true;
            this.body_colors.TabIndex = 14;
            this.body_colors.SelectedIndexChanged += new System.EventHandler(this.body_colors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Snake Chan", 25F);
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Image = global::Snake_TaskPerformance.Properties.Resources.setting_score_minus;
            this.label2.Location = new System.Drawing.Point(86, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Snake Chan", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Image = global::Snake_TaskPerformance.Properties.Resources.setting_score_add;
            this.label1.Location = new System.Drawing.Point(170, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pointsPerF
            // 
            this.pointsPerF.BackColor = System.Drawing.Color.Transparent;
            this.pointsPerF.Font = new System.Drawing.Font("Snake Chan", 25F);
            this.pointsPerF.ForeColor = System.Drawing.Color.Yellow;
            this.pointsPerF.Image = global::Snake_TaskPerformance.Properties.Resources.setting_score;
            this.pointsPerF.Location = new System.Drawing.Point(128, 279);
            this.pointsPerF.Name = "pointsPerF";
            this.pointsPerF.Size = new System.Drawing.Size(35, 38);
            this.pointsPerF.TabIndex = 11;
            this.pointsPerF.Text = "2";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = global::Snake_TaskPerformance.Properties.Resources.exit_icon;
            this.materialFlatButton2.Location = new System.Drawing.Point(67, 429);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MinimumSize = new System.Drawing.Size(141, 36);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(141, 36);
            this.materialFlatButton2.TabIndex = 10;
            this.materialFlatButton2.Text = "BACK";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = global::Snake_TaskPerformance.Properties.Resources.save_icon;
            this.materialFlatButton1.Location = new System.Drawing.Point(67, 382);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(141, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(141, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "save";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // pictureBodyColor
            // 
            this.pictureBodyColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBodyColor.Enabled = false;
            this.pictureBodyColor.Location = new System.Drawing.Point(209, 197);
            this.pictureBodyColor.Name = "pictureBodyColor";
            this.pictureBodyColor.Size = new System.Drawing.Size(33, 21);
            this.pictureBodyColor.TabIndex = 8;
            this.pictureBodyColor.TabStop = false;
            // 
            // pictureHeadColor
            // 
            this.pictureHeadColor.BackColor = System.Drawing.Color.Cyan;
            this.pictureHeadColor.Enabled = false;
            this.pictureHeadColor.Location = new System.Drawing.Point(209, 161);
            this.pictureHeadColor.Name = "pictureHeadColor";
            this.pictureHeadColor.Size = new System.Drawing.Size(33, 21);
            this.pictureHeadColor.TabIndex = 6;
            this.pictureHeadColor.TabStop = false;
            // 
            // label_image
            // 
            this.label_image.Depth = 0;
            this.label_image.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_image.Image = ((System.Drawing.Image)(resources.GetObject("label_image.Image")));
            this.label_image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_image.Location = new System.Drawing.Point(-3, 22);
            this.label_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(439, 468);
            this.label_image.TabIndex = 4;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 490);
            this.Controls.Add(this.body_colors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointsPerF);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.pictureBodyColor);
            this.Controls.Add(this.pictureHeadColor);
            this.Controls.Add(this.head_colors);
            this.Controls.Add(this.label_image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings_Form";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Form_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBodyColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeadColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_image;
        private System.Windows.Forms.ComboBox head_colors;
        private System.Windows.Forms.PictureBox pictureHeadColor;
        private System.Windows.Forms.PictureBox pictureBodyColor;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label pointsPerF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox body_colors;
    }
}