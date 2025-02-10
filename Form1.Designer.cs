namespace GameCaroDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChessBoard = new Panel();
            pnlAvatar = new Panel();
            ptbAvatar = new PictureBox();
            pnlControl = new Panel();
            btnOK2 = new Button();
            label4 = new Label();
            lbTime = new Label();
            lbIP = new Label();
            lbName = new Label();
            pictureBox1 = new PictureBox();
            btnOK = new Button();
            pcsTime = new ProgressBar();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            tbxIP = new TextBox();
            txbName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.ActiveCaption;
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(691, 720);
            pnlChessBoard.TabIndex = 0;
            // 
            // pnlAvatar
            // 
            pnlAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatar.Location = new Point(723, 12);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(330, 330);
            pnlAvatar.TabIndex = 1;
            // 
            // ptbAvatar
            // 
            ptbAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAvatar.Image = Properties.Resources.caroback;
            ptbAvatar.Location = new Point(726, 12);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(323, 327);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 0;
            ptbAvatar.TabStop = false;
            // 
            // pnlControl
            // 
            pnlControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlControl.Controls.Add(btnOK2);
            pnlControl.Controls.Add(label4);
            pnlControl.Controls.Add(lbTime);
            pnlControl.Controls.Add(lbIP);
            pnlControl.Controls.Add(lbName);
            pnlControl.Controls.Add(pictureBox1);
            pnlControl.Controls.Add(btnOK);
            pnlControl.Controls.Add(pcsTime);
            pnlControl.Controls.Add(textBox4);
            pnlControl.Controls.Add(textBox3);
            pnlControl.Controls.Add(tbxIP);
            pnlControl.Controls.Add(txbName);
            pnlControl.Location = new Point(723, 357);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(340, 380);
            pnlControl.TabIndex = 2;
            // 
            // btnOK2
            // 
            btnOK2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK2.Location = new Point(255, 348);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(59, 27);
            btnOK2.TabIndex = 11;
            btnOK2.Text = "OK";
            btnOK2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 160);
            label4.Name = "label4";
            label4.Size = new Size(127, 29);
            label4.TabIndex = 10;
            label4.Text = "CHAT BOX";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTime.Location = new Point(0, 69);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(60, 26);
            lbTime.TabIndex = 9;
            lbTime.Text = "TIME";
            // 
            // lbIP
            // 
            lbIP.AutoSize = true;
            lbIP.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIP.Location = new Point(0, 36);
            lbIP.Name = "lbIP";
            lbIP.Size = new Size(48, 26);
            lbIP.TabIndex = 8;
            lbIP.Text = "LAN";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(0, 3);
            lbName.Name = "lbName";
            lbName.Size = new Size(65, 26);
            lbName.TabIndex = 7;
            lbName.Text = "NAME";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(242, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 62);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(72, 105);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(164, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // pcsTime
            // 
            pcsTime.Location = new Point(72, 69);
            pcsTime.Name = "pcsTime";
            pcsTime.Size = new Size(164, 29);
            pcsTime.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 348);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 192);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 150);
            textBox3.TabIndex = 2;
            // 
            // tbxIP
            // 
            tbxIP.Location = new Point(72, 36);
            tbxIP.Name = "tbxIP";
            tbxIP.Size = new Size(164, 27);
            tbxIP.TabIndex = 1;
            // 
            // txbName
            // 
            txbName.Location = new Point(72, 3);
            txbName.Name = "txbName";
            txbName.Size = new Size(164, 27);
            txbName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 741);
            Controls.Add(ptbAvatar);
            Controls.Add(pnlControl);
            Controls.Add(pnlAvatar);
            Controls.Add(pnlChessBoard);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel pnlAvatar;
        private Panel pnlControl;
        private Label label4;
        private Label lbTime;
        private Label lbIP;
        private Label lbName;
        private PictureBox pictureBox1;
        private Button btnOK;
        private ProgressBar pcsTime;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox tbxIP;
        private TextBox txbName;
        private Button btnOK2;
        private PictureBox ptbAvatar;
    }
}
