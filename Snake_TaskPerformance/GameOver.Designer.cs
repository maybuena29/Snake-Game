namespace Snake_TaskPerformance
{
    partial class GameOver
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
            this.bg_gameover = new MaterialSkin.Controls.MaterialLabel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg_gameover
            // 
            this.bg_gameover.Depth = 0;
            this.bg_gameover.Font = new System.Drawing.Font("Roboto", 11F);
            this.bg_gameover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bg_gameover.Image = global::Snake_TaskPerformance.Properties.Resources.gameover_bg;
            this.bg_gameover.Location = new System.Drawing.Point(0, 21);
            this.bg_gameover.MouseState = MaterialSkin.MouseState.HOVER;
            this.bg_gameover.Name = "bg_gameover";
            this.bg_gameover.Size = new System.Drawing.Size(463, 346);
            this.bg_gameover.TabIndex = 0;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.DarkCyan;
            this.lblGameOver.Font = new System.Drawing.Font("Snake Chan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Coral;
            this.lblGameOver.Image = global::Snake_TaskPerformance.Properties.Resources.label_bg_gameover;
            this.lblGameOver.Location = new System.Drawing.Point(97, 180);
            this.lblGameOver.MinimumSize = new System.Drawing.Size(369, 38);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(369, 38);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "0";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(-2, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 84);
            this.panel1.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Depth = 0;
            this.txtName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtName.Hint = "       ENTER NAME";
            this.txtName.Location = new System.Drawing.Point(158, 12);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(149, 23);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 6;
            this.txtName.TabStop = false;
            this.toolTipName.SetToolTip(this.txtName, "ENTER NAME");
            this.txtName.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.materialFlatButton1.Icon = global::Snake_TaskPerformance.Properties.Resources.exit_icon;
            this.materialFlatButton1.Location = new System.Drawing.Point(158, 38);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(149, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(149, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "SUBMIT";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // toolTipName
            // 
            this.toolTipName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipName.ForeColor = System.Drawing.Color.Teal;
            this.toolTipName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(437, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 442);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bg_gameover);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel bg_gameover;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private System.Windows.Forms.ToolTip toolTipName;
        private System.Windows.Forms.Button button1;
    }
}