namespace Snake_TaskPerformance
{
    partial class Highscore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_image = new MaterialSkin.Controls.MaterialLabel();
            this.myDGV = new System.Windows.Forms.DataGridView();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.myDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label_image
            // 
            this.label_image.Depth = 0;
            this.label_image.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_image.Image = global::Snake_TaskPerformance.Properties.Resources.scores_bg;
            this.label_image.Location = new System.Drawing.Point(0, 24);
            this.label_image.MinimumSize = new System.Drawing.Size(435, 468);
            this.label_image.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(435, 468);
            this.label_image.TabIndex = 4;
            // 
            // myDGV
            // 
            this.myDGV.AllowUserToAddRows = false;
            this.myDGV.AllowUserToDeleteRows = false;
            this.myDGV.AllowUserToResizeColumns = false;
            this.myDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Snake Chan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            this.myDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.myDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.myDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Snake Chan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.myDGV.ColumnHeadersHeight = 30;
            this.myDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.myDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.myDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myDGV.Location = new System.Drawing.Point(100, 190);
            this.myDGV.MultiSelect = false;
            this.myDGV.Name = "myDGV";
            this.myDGV.ReadOnly = true;
            this.myDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Snake Chan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.myDGV.RowHeadersWidth = 4;
            this.myDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Snake Chan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.myDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.myDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDGV.ShowEditingIcon = false;
            this.myDGV.Size = new System.Drawing.Size(228, 239);
            this.myDGV.TabIndex = 6;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = global::Snake_TaskPerformance.Properties.Resources.exit_icon;
            this.materialFlatButton1.Location = new System.Drawing.Point(127, 438);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(180, 36);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(180, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "BACK";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 490);
            this.Controls.Add(this.myDGV);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label_image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Highscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Highscore_FormClosing);
            this.Load += new System.EventHandler(this.Highscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_image;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView myDGV;
    }
}