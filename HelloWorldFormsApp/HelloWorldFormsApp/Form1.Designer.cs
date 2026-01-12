namespace HelloWorldFormsApp
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
            lblHelloWorldLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblHelloWorldLabel
            // 
            lblHelloWorldLabel.AutoSize = true;
            lblHelloWorldLabel.BackColor = SystemColors.ActiveCaption;
            lblHelloWorldLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloWorldLabel.Location = new Point(167, 164);
            lblHelloWorldLabel.Name = "lblHelloWorldLabel";
            lblHelloWorldLabel.Size = new Size(276, 36);
            lblHelloWorldLabel.TabIndex = 0;
            lblHelloWorldLabel.Text = "lblHelloWorldLabel";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(69, 43);
            button1.Name = "button1";
            button1.Size = new Size(201, 47);
            button1.TabIndex = 1;
            button1.Text = "btnHelloButtonTest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonOnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 306);
            Controls.Add(button1);
            Controls.Add(lblHelloWorldLabel);
            Name = "Form1";
            Text = "HelloWorldWork";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloWorldLabel;
        private Button button1;
    }
}
