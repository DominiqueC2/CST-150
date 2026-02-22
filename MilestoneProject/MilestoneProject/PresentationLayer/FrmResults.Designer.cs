namespace MilestoneProject.PresentationLayer
{
    partial class FrmResults
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
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.seecfrmtitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResult
            // 
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResult.BackgroundColor = System.Drawing.Color.DarkRed;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(291, 200);
            this.gvResult.Name = "gvResult";
            this.gvResult.RowHeadersVisible = false;
            this.gvResult.Size = new System.Drawing.Size(666, 365);
            this.gvResult.TabIndex = 0;
            // 
            // seecfrmtitle
            // 
            this.seecfrmtitle.AutoSize = true;
            this.seecfrmtitle.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seecfrmtitle.ForeColor = System.Drawing.Color.Yellow;
            this.seecfrmtitle.Location = new System.Drawing.Point(467, 83);
            this.seecfrmtitle.Name = "seecfrmtitle";
            this.seecfrmtitle.Size = new System.Drawing.Size(276, 45);
            this.seecfrmtitle.TabIndex = 1;
            this.seecfrmtitle.Text = "Searched Results";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(522, 669);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 46);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1239, 865);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.seecfrmtitle);
            this.Controls.Add(this.gvResult);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmResults";
            this.Text = "Search Results";
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Label seecfrmtitle;
        private System.Windows.Forms.Button btnClose;
    }
}