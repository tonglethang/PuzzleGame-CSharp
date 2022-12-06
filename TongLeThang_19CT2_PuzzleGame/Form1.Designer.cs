namespace TongLeThang_19CT2_PuzzleGame
{
    partial class frmThang
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
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBXH = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Location = new System.Drawing.Point(483, 3);
            this.gbPuzzleBox.Margin = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Padding = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Size = new System.Drawing.Size(498, 533);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "Xếp hình";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(20, 28);
            this.pbx1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(151, 160);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(174, 28);
            this.pbx2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(151, 160);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(328, 28);
            this.pbx3.Margin = new System.Windows.Forms.Padding(4);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(151, 160);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(20, 191);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(151, 160);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(174, 191);
            this.pbx5.Margin = new System.Windows.Forms.Padding(4);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(151, 160);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(328, 191);
            this.pbx6.Margin = new System.Windows.Forms.Padding(4);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(151, 160);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(20, 353);
            this.pbx7.Margin = new System.Windows.Forms.Padding(4);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(151, 160);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(174, 353);
            this.pbx8.Margin = new System.Windows.Forms.Padding(4);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(151, 160);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(328, 353);
            this.pbx9.Margin = new System.Windows.Forms.Padding(4);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(151, 160);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::TongLeThang_19CT2_PuzzleGame.Properties.Resources.dadia;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbOriginal.Location = new System.Drawing.Point(57, 13);
            this.gbOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Padding = new System.Windows.Forms.Padding(4);
            this.gbOriginal.Size = new System.Drawing.Size(401, 356);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Hình mẫu";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShuffle.Location = new System.Drawing.Point(503, 544);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(101, 52);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Trộn";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuit.Location = new System.Drawing.Point(953, 544);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 52);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMovesMade.Location = new System.Drawing.Point(96, 556);
            this.lblMovesMade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(122, 24);
            this.lblMovesMade.TabIndex = 2;
            this.lblMovesMade.Text = "Số lần xếp: ";
            // 
            // tmrTimeElapse
            // 
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(657, 544);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(101, 52);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(61, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(111, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thời gian:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(247, 418);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 28);
            this.txtName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(35, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập tên của bạn:";
            // 
            // btnBXH
            // 
            this.btnBXH.BackColor = System.Drawing.Color.White;
            this.btnBXH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBXH.Location = new System.Drawing.Point(800, 544);
            this.btnBXH.Margin = new System.Windows.Forms.Padding(4);
            this.btnBXH.Name = "btnBXH";
            this.btnBXH.Size = new System.Drawing.Size(101, 52);
            this.btnBXH.TabIndex = 11;
            this.btnBXH.Text = "Bảng xếp hạng";
            this.btnBXH.UseVisualStyleBackColor = false;
            this.btnBXH.Click += new System.EventHandler(this.btnBXH_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(249, 480);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 45);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "300";
            // 
            // frmThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 652);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBXH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbPuzzleBox);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuite);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBXH;
        private System.Windows.Forms.Label lblTime;
    }
}

