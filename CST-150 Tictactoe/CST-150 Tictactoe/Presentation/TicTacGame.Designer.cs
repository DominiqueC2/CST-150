namespace CST_150_Tictactoe
{
    partial class TicTacGame
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
            btnNewGame = new Button();
            lblmsg = new Label();
            title = new Label();
            lblBox1 = new Label();
            lblBox2 = new Label();
            lblBox3 = new Label();
            lblBox6 = new Label();
            lblBox9 = new Label();
            lblBox8 = new Label();
            lblBox7 = new Label();
            lblBox5 = new Label();
            lblBox4 = new Label();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(299, 835);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(248, 49);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "Start Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Location = new Point(381, 144);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(87, 21);
            lblmsg.TabIndex = 1;
            lblmsg.Text = "Show Info";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(302, 58);
            title.Name = "title";
            title.Size = new Size(245, 50);
            title.TabIndex = 2;
            title.Text = "TIC-TAC-TOE";
            // 
            // lblBox1
            // 
            lblBox1.BackColor = Color.LightGray;
            lblBox1.FlatStyle = FlatStyle.Popup;
            lblBox1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox1.ForeColor = Color.Black;
            lblBox1.ImageAlign = ContentAlignment.TopRight;
            lblBox1.Location = new Point(103, 197);
            lblBox1.Name = "lblBox1";
            lblBox1.Size = new Size(194, 173);
            lblBox1.TabIndex = 3;
            lblBox1.Text = "?";
            lblBox1.TextAlign = ContentAlignment.MiddleCenter;
            lblBox1.Click += lblBox1_Click;
            // 
            // lblBox2
            // 
            lblBox2.BackColor = Color.LightGray;
            lblBox2.FlatStyle = FlatStyle.Popup;
            lblBox2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox2.ForeColor = Color.Black;
            lblBox2.ImageAlign = ContentAlignment.TopRight;
            lblBox2.Location = new Point(331, 197);
            lblBox2.Name = "lblBox2";
            lblBox2.Size = new Size(194, 173);
            lblBox2.TabIndex = 12;
            lblBox2.Text = "?";
            lblBox2.TextAlign = ContentAlignment.MiddleCenter;
            lblBox2.Click += lblBox2_Click;
            // 
            // lblBox3
            // 
            lblBox3.BackColor = Color.LightGray;
            lblBox3.FlatStyle = FlatStyle.Popup;
            lblBox3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox3.ForeColor = Color.Black;
            lblBox3.ImageAlign = ContentAlignment.TopRight;
            lblBox3.Location = new Point(553, 197);
            lblBox3.Name = "lblBox3";
            lblBox3.Size = new Size(194, 173);
            lblBox3.TabIndex = 13;
            lblBox3.Text = "?";
            lblBox3.TextAlign = ContentAlignment.MiddleCenter;
            lblBox3.Click += lblBox3_Click;
            // 
            // lblBox6
            // 
            lblBox6.BackColor = Color.LightGray;
            lblBox6.FlatStyle = FlatStyle.Popup;
            lblBox6.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox6.ForeColor = Color.Black;
            lblBox6.ImageAlign = ContentAlignment.TopRight;
            lblBox6.Location = new Point(553, 392);
            lblBox6.Name = "lblBox6";
            lblBox6.Size = new Size(194, 173);
            lblBox6.TabIndex = 14;
            lblBox6.Text = "?";
            lblBox6.TextAlign = ContentAlignment.MiddleCenter;
            lblBox6.Click += lblBox6_Click;
            // 
            // lblBox9
            // 
            lblBox9.BackColor = Color.LightGray;
            lblBox9.FlatStyle = FlatStyle.Popup;
            lblBox9.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox9.ForeColor = Color.Black;
            lblBox9.ImageAlign = ContentAlignment.TopRight;
            lblBox9.Location = new Point(553, 588);
            lblBox9.Name = "lblBox9";
            lblBox9.Size = new Size(194, 173);
            lblBox9.TabIndex = 15;
            lblBox9.Text = "?";
            lblBox9.TextAlign = ContentAlignment.MiddleCenter;
            lblBox9.Click += lblBox9_Click;
            // 
            // lblBox8
            // 
            lblBox8.BackColor = Color.LightGray;
            lblBox8.FlatStyle = FlatStyle.Popup;
            lblBox8.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox8.ForeColor = Color.Black;
            lblBox8.ImageAlign = ContentAlignment.TopRight;
            lblBox8.Location = new Point(331, 588);
            lblBox8.Name = "lblBox8";
            lblBox8.Size = new Size(194, 173);
            lblBox8.TabIndex = 16;
            lblBox8.Text = "?";
            lblBox8.TextAlign = ContentAlignment.MiddleCenter;
            lblBox8.Click += lblBox8_Click;
            // 
            // lblBox7
            // 
            lblBox7.BackColor = Color.LightGray;
            lblBox7.FlatStyle = FlatStyle.Popup;
            lblBox7.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox7.ForeColor = Color.Black;
            lblBox7.ImageAlign = ContentAlignment.TopRight;
            lblBox7.Location = new Point(103, 588);
            lblBox7.Name = "lblBox7";
            lblBox7.Size = new Size(194, 173);
            lblBox7.TabIndex = 17;
            lblBox7.Text = "?";
            lblBox7.TextAlign = ContentAlignment.MiddleCenter;
            lblBox7.Click += lblBox7_Click;
            // 
            // lblBox5
            // 
            lblBox5.BackColor = Color.LightGray;
            lblBox5.FlatStyle = FlatStyle.Popup;
            lblBox5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox5.ForeColor = Color.Black;
            lblBox5.ImageAlign = ContentAlignment.TopRight;
            lblBox5.Location = new Point(331, 392);
            lblBox5.Name = "lblBox5";
            lblBox5.Size = new Size(194, 173);
            lblBox5.TabIndex = 18;
            lblBox5.Text = "?";
            lblBox5.TextAlign = ContentAlignment.MiddleCenter;
            lblBox5.Click += lblBox5_Click;
            // 
            // lblBox4
            // 
            lblBox4.BackColor = Color.LightGray;
            lblBox4.FlatStyle = FlatStyle.Popup;
            lblBox4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBox4.ForeColor = Color.Black;
            lblBox4.ImageAlign = ContentAlignment.TopRight;
            lblBox4.Location = new Point(103, 392);
            lblBox4.Name = "lblBox4";
            lblBox4.Size = new Size(194, 173);
            lblBox4.TabIndex = 19;
            lblBox4.Text = "?";
            lblBox4.TextAlign = ContentAlignment.MiddleCenter;
            lblBox4.Click += lblBox4_Click;
            // 
            // TicTacGame
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 954);
            Controls.Add(lblBox4);
            Controls.Add(lblBox5);
            Controls.Add(lblBox7);
            Controls.Add(lblBox8);
            Controls.Add(lblBox9);
            Controls.Add(lblBox6);
            Controls.Add(lblBox3);
            Controls.Add(lblBox2);
            Controls.Add(lblBox1);
            Controls.Add(title);
            Controls.Add(lblmsg);
            Controls.Add(btnNewGame);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "TicTacGame";
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnNewGame;
        private Label lblmsg;
        private Label title;
        private Label lblBox1;
        private Label lblBox2;
        private Label lblBox3;
        private Label lblBox6;
        private Label lblBox9;
        private Label lblBox8;
        private Label lblBox7;
        private Label lblBox5;
        private Label lblBox4;
    }
}
