namespace CST_150_Activity_1
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
            btnConvert = new Button();
            lblEarth = new Label();
            lblMars = new Label();
            IB = new Label();
            txtEarthWeight = new TextBox();
            lblMarsWeight = new TextBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(267, 312);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // lblEarth
            // 
            lblEarth.AutoSize = true;
            lblEarth.Location = new Point(142, 131);
            lblEarth.Name = "lblEarth";
            lblEarth.Size = new Size(147, 15);
            lblEarth.TabIndex = 1;
            lblEarth.Text = "Enter your weight on Earth";
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.Location = new Point(173, 180);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(116, 15);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your weight on Mars";
            // 
            // IB
            // 
            IB.AutoSize = true;
            IB.Location = new Point(401, 131);
            IB.Name = "IB";
            IB.Size = new Size(22, 15);
            IB.TabIndex = 3;
            IB.Text = "lbs";
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Location = new Point(295, 128);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.Size = new Size(100, 23);
            txtEarthWeight.TabIndex = 4;
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.Location = new Point(295, 177);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(100, 23);
            lblMarsWeight.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMarsWeight);
            Controls.Add(txtEarthWeight);
            Controls.Add(IB);
            Controls.Add(lblMars);
            Controls.Add(lblEarth);
            Controls.Add(btnConvert);
            Name = "Form1";
            Text = "Your Weight on Mars";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Label lblEarth;
        private Label lblMars;
        private Label IB;
        private TextBox txtEarthWeight;
        private TextBox lblMarsWeight;
    }
}
