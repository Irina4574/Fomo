namespace TicTacToeGameArchitecture
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            restart = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            playerWin = new Label();
            pcWin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "PC Wins:";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(70, 59);
            button1.Name = "button1";
            button1.Size = new Size(111, 106);
            button1.TabIndex = 2;
            button1.Tag = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnClick;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(187, 59);
            button2.Name = "button2";
            button2.Size = new Size(111, 106);
            button2.TabIndex = 3;
            button2.Tag = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnClick;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(304, 59);
            button3.Name = "button3";
            button3.Size = new Size(111, 106);
            button3.TabIndex = 4;
            button3.Tag = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnClick;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(70, 171);
            button4.Name = "button4";
            button4.Size = new Size(111, 106);
            button4.TabIndex = 7;
            button4.Tag = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnClick;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(187, 171);
            button5.Name = "button5";
            button5.Size = new Size(111, 106);
            button5.TabIndex = 6;
            button5.Tag = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OnClick;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(304, 171);
            button6.Name = "button6";
            button6.Size = new Size(111, 106);
            button6.TabIndex = 5;
            button6.Tag = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OnClick;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(70, 283);
            button7.Name = "button7";
            button7.Size = new Size(111, 106);
            button7.TabIndex = 10;
            button7.Tag = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += OnClick;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(187, 283);
            button8.Name = "button8";
            button8.Size = new Size(111, 106);
            button8.TabIndex = 9;
            button8.Tag = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += OnClick;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(304, 283);
            button9.Name = "button9";
            button9.Size = new Size(111, 106);
            button9.TabIndex = 8;
            button9.Tag = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += OnClick;
            // 
            // restart
            // 
            restart.BackColor = Color.FromArgb(192, 192, 255);
            restart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            restart.Location = new Point(156, 395);
            restart.Name = "restart";
            restart.Size = new Size(167, 46);
            restart.TabIndex = 11;
            restart.Text = "Restart Game";
            restart.UseVisualStyleBackColor = false;
            restart.Click += OnRestart;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            // 
            // playerWin
            // 
            playerWin.AutoSize = true;
            playerWin.Location = new Point(157, 16);
            playerWin.Name = "playerWin";
            playerWin.Size = new Size(17, 20);
            playerWin.TabIndex = 12;
            playerWin.Text = "0";
            // 
            // pcWin
            // 
            pcWin.AutoSize = true;
            pcWin.Location = new Point(421, 16);
            pcWin.Name = "pcWin";
            pcWin.Size = new Size(17, 20);
            pcWin.TabIndex = 13;
            pcWin.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(pcWin);
            Controls.Add(playerWin);
            Controls.Add(restart);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button restart;
        private System.Windows.Forms.Timer CPUTimer;
        private Label playerWin;
        private Label pcWin;
    }
}
