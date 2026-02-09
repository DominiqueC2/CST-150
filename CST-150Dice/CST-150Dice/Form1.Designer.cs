namespace CST_150Dice
{
    partial class DiceSim
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
            diePic1 = new PictureBox();
            diePic2 = new PictureBox();
            btnDiceRoll = new Button();
            ((System.ComponentModel.ISupportInitialize)diePic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diePic2).BeginInit();
            SuspendLayout();
            // 
            // diePic1
            // 
            diePic1.Location = new Point(467, 101);
            diePic1.Margin = new Padding(4);
            diePic1.Name = "diePic1";
            diePic1.Size = new Size(143, 141);
            diePic1.SizeMode = PictureBoxSizeMode.StretchImage;
            diePic1.TabIndex = 0;
            diePic1.TabStop = false;
            // 
            // diePic2
            // 
            diePic2.Location = new Point(467, 273);
            diePic2.Margin = new Padding(4);
            diePic2.Name = "diePic2";
            diePic2.Size = new Size(143, 140);
            diePic2.SizeMode = PictureBoxSizeMode.StretchImage;
            diePic2.TabIndex = 1;
            diePic2.TabStop = false;
            // 
            // btnDiceRoll
            // 
            btnDiceRoll.Location = new Point(177, 242);
            btnDiceRoll.Margin = new Padding(4);
            btnDiceRoll.Name = "btnDiceRoll";
            btnDiceRoll.Size = new Size(131, 32);
            btnDiceRoll.TabIndex = 2;
            btnDiceRoll.Text = "Roll the Dice";
            btnDiceRoll.UseVisualStyleBackColor = true;
            btnDiceRoll.Click += btnDiceRoll_Click;
            // 
            // DiceSim
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 630);
            Controls.Add(btnDiceRoll);
            Controls.Add(diePic2);
            Controls.Add(diePic1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DiceSim";
            Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)diePic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diePic2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox diePic1;
        private PictureBox diePic2;
        private Button btnDiceRoll;
    }
}
