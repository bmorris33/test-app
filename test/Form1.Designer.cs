namespace test
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.q1Lbl = new System.Windows.Forms.Label();
            this.q2Lbl = new System.Windows.Forms.Label();
            this.q3Lbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.pcPicBx = new System.Windows.Forms.PictureBox();
            this.tvPicBx = new System.Windows.Forms.PictureBox();
            this.ww2PicBx = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ww2PicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.q3Lbl);
            this.groupBox1.Controls.Add(this.q2Lbl);
            this.groupBox1.Controls.Add(this.q1Lbl);
            this.groupBox1.Controls.Add(this.answerBtn3);
            this.groupBox1.Controls.Add(this.answerBtn2);
            this.groupBox1.Controls.Add(this.answerBtn1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "questions";
            // 
            // answerBtn1
            // 
            this.answerBtn1.Location = new System.Drawing.Point(285, 19);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(75, 23);
            this.answerBtn1.TabIndex = 0;
            this.answerBtn1.Text = "answer";
            this.answerBtn1.UseVisualStyleBackColor = true;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn1_Click);
            // 
            // q1Lbl
            // 
            this.q1Lbl.AutoSize = true;
            this.q1Lbl.Location = new System.Drawing.Point(6, 24);
            this.q1Lbl.Name = "q1Lbl";
            this.q1Lbl.Size = new System.Drawing.Size(114, 13);
            this.q1Lbl.TabIndex = 1;
            this.q1Lbl.Text = "when did ww2 happon";
            // 
            // q2Lbl
            // 
            this.q2Lbl.AutoSize = true;
            this.q2Lbl.Location = new System.Drawing.Point(6, 58);
            this.q2Lbl.Name = "q2Lbl";
            this.q2Lbl.Size = new System.Drawing.Size(164, 13);
            this.q2Lbl.TabIndex = 1;
            this.q2Lbl.Text = "when was the computer invented";
            this.q2Lbl.Click += new System.EventHandler(this.q2Lbl_Click);
            // 
            // q3Lbl
            // 
            this.q3Lbl.AutoSize = true;
            this.q3Lbl.Location = new System.Drawing.Point(6, 87);
            this.q3Lbl.Name = "q3Lbl";
            this.q3Lbl.Size = new System.Drawing.Size(129, 13);
            this.q3Lbl.TabIndex = 1;
            this.q3Lbl.Text = "when was the tv invented";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.Location = new System.Drawing.Point(37, 238);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(45, 16);
            this.answerLbl.TabIndex = 1;
            this.answerLbl.Text = "label4";
            // 
            // answerBtn2
            // 
            this.answerBtn2.Location = new System.Drawing.Point(285, 48);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(75, 23);
            this.answerBtn2.TabIndex = 0;
            this.answerBtn2.Text = "answer";
            this.answerBtn2.UseVisualStyleBackColor = true;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn2_Click);
            // 
            // answerBtn3
            // 
            this.answerBtn3.Location = new System.Drawing.Point(285, 77);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(75, 23);
            this.answerBtn3.TabIndex = 0;
            this.answerBtn3.Text = "answer";
            this.answerBtn3.UseVisualStyleBackColor = true;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn3_Click);
            // 
            // pcPicBx
            // 
            this.pcPicBx.Image = global::test.Properties.Resources.header_computers_1280x720;
            this.pcPicBx.Location = new System.Drawing.Point(334, 128);
            this.pcPicBx.Name = "pcPicBx";
            this.pcPicBx.Size = new System.Drawing.Size(259, 155);
            this.pcPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPicBx.TabIndex = 4;
            this.pcPicBx.TabStop = false;
            // 
            // tvPicBx
            // 
            this.tvPicBx.Image = global::test.Properties.Resources._800px_RCA_630_TS_Television;
            this.tvPicBx.Location = new System.Drawing.Point(334, 128);
            this.tvPicBx.Name = "tvPicBx";
            this.tvPicBx.Size = new System.Drawing.Size(259, 155);
            this.tvPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tvPicBx.TabIndex = 3;
            this.tvPicBx.TabStop = false;
            // 
            // ww2PicBx
            // 
            this.ww2PicBx.Image = global::test.Properties.Resources._140828132531_01_world_war_ii_0828_horizontal_large_gallery;
            this.ww2PicBx.Location = new System.Drawing.Point(334, 128);
            this.ww2PicBx.Name = "ww2PicBx";
            this.ww2PicBx.Size = new System.Drawing.Size(259, 155);
            this.ww2PicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ww2PicBx.TabIndex = 2;
            this.ww2PicBx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 295);
            this.Controls.Add(this.pcPicBx);
            this.Controls.Add(this.tvPicBx);
            this.Controls.Add(this.ww2PicBx);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "testApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ww2PicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label q3Lbl;
        private System.Windows.Forms.Label q2Lbl;
        private System.Windows.Forms.Label q1Lbl;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.PictureBox ww2PicBx;
        private System.Windows.Forms.PictureBox tvPicBx;
        private System.Windows.Forms.PictureBox pcPicBx;
    }
}

