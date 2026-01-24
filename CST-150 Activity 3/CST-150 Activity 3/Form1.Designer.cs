namespace CST_150_Activity_3
{
    partial class FrmMain
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
            BtnReadFile = new Button();
            lblSelectedFile = new Label();
            lblResults = new Label();
            selectFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // BtnReadFile
            // 
            BtnReadFile.BackColor = Color.ForestGreen;
            BtnReadFile.Cursor = Cursors.Hand;
            BtnReadFile.FlatAppearance.BorderColor = Color.Black;
            BtnReadFile.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            BtnReadFile.FlatStyle = FlatStyle.Flat;
            BtnReadFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReadFile.ForeColor = Color.WhiteSmoke;
            BtnReadFile.Location = new Point(286, 68);
            BtnReadFile.Name = "BtnReadFile";
            BtnReadFile.Size = new Size(137, 48);
            BtnReadFile.TabIndex = 0;
            BtnReadFile.Text = "ReadFile";
            BtnReadFile.UseVisualStyleBackColor = false;
            BtnReadFile.Click += BtnReadFile_Click;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedFile.ForeColor = Color.Firebrick;
            lblSelectedFile.Location = new Point(2, 394);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(800, 58);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "label1";
            lblSelectedFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(79, 122);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(723, 272);
            lblResults.TabIndex = 2;
            lblResults.Text = "label2";
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(lblSelectedFile);
            Controls.Add(BtnReadFile);
            Name = "FrmMain";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnReadFile;
        private Label lblSelectedFile;
        private Label lblResults;
        private OpenFileDialog selectFileDialog;
    }
}
