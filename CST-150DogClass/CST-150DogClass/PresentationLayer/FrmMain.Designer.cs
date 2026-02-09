namespace CST_150DogClass.PresentationLayer
{
    partial class FrmMain
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
            btnAddDog = new Button();
            txtName = new TextBox();
            txtNeck = new TextBox();
            txtColor = new TextBox();
            cmbSit = new ComboBox();
            dog = new Label();
            Neck = new Label();
            sit = new Label();
            label4 = new Label();
            color = new Label();
            grbAttributes = new GroupBox();
            txtWeight = new TextBox();
            pound = new Label();
            weight = new Label();
            gvShowDogs = new DataGridView();
            lblErrorMessage = new Label();
            grbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).BeginInit();
            SuspendLayout();
            // 
            // btnAddDog
            // 
            btnAddDog.AutoSize = true;
            btnAddDog.Location = new Point(75, 76);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(116, 28);
            btnAddDog.TabIndex = 0;
            btnAddDog.Text = "Add New Dog";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += BtnAddNewDog_ClickEvent;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 1;
            // 
            // txtNeck
            // 
            txtNeck.Location = new Point(140, 121);
            txtNeck.Name = "txtNeck";
            txtNeck.Size = new Size(100, 26);
            txtNeck.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(140, 242);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 26);
            txtColor.TabIndex = 4;
            // 
            // cmbSit
            // 
            cmbSit.FormattingEnabled = true;
            cmbSit.Items.AddRange(new object[] { "Yes", "No" });
            cmbSit.Location = new Point(140, 183);
            cmbSit.Name = "cmbSit";
            cmbSit.Size = new Size(121, 26);
            cmbSit.TabIndex = 5;
            // 
            // dog
            // 
            dog.AutoSize = true;
            dog.Location = new Point(47, 64);
            dog.Name = "dog";
            dog.Size = new Size(84, 18);
            dog.TabIndex = 6;
            dog.Text = "Dog Name";
            // 
            // Neck
            // 
            Neck.AutoSize = true;
            Neck.Location = new Point(34, 129);
            Neck.Name = "Neck";
            Neck.Size = new Size(97, 18);
            Neck.TabIndex = 7;
            Neck.Text = "Neck Radius";
            // 
            // sit
            // 
            sit.AutoSize = true;
            sit.Location = new Point(66, 191);
            sit.Name = "sit";
            sit.Size = new Size(52, 18);
            sit.TabIndex = 8;
            sit.Text = "Sitting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 124);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 9;
            label4.Text = "inches";
            // 
            // color
            // 
            color.AutoSize = true;
            color.Location = new Point(72, 250);
            color.Name = "color";
            color.Size = new Size(46, 18);
            color.TabIndex = 10;
            color.Text = "Color";
            // 
            // grbAttributes
            // 
            grbAttributes.Controls.Add(txtWeight);
            grbAttributes.Controls.Add(pound);
            grbAttributes.Controls.Add(weight);
            grbAttributes.Controls.Add(cmbSit);
            grbAttributes.Controls.Add(color);
            grbAttributes.Controls.Add(txtName);
            grbAttributes.Controls.Add(label4);
            grbAttributes.Controls.Add(txtNeck);
            grbAttributes.Controls.Add(sit);
            grbAttributes.Controls.Add(txtColor);
            grbAttributes.Controls.Add(Neck);
            grbAttributes.Controls.Add(dog);
            grbAttributes.Location = new Point(75, 129);
            grbAttributes.Name = "grbAttributes";
            grbAttributes.Size = new Size(320, 360);
            grbAttributes.TabIndex = 11;
            grbAttributes.TabStop = false;
            grbAttributes.Text = "Dog Attributes";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(140, 299);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 26);
            txtWeight.TabIndex = 13;
            // 
            // pound
            // 
            pound.AutoSize = true;
            pound.Location = new Point(246, 307);
            pound.Name = "pound";
            pound.Size = new Size(61, 18);
            pound.TabIndex = 12;
            pound.Text = "Pounds";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(66, 307);
            weight.Name = "weight";
            weight.Size = new Size(57, 18);
            weight.TabIndex = 11;
            weight.Text = "Weight";
            // 
            // gvShowDogs
            // 
            gvShowDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowDogs.Location = new Point(419, 129);
            gvShowDogs.Name = "gvShowDogs";
            gvShowDogs.Size = new Size(574, 325);
            gvShowDogs.TabIndex = 12;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(75, 492);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(361, 18);
            lblErrorMessage.TabIndex = 13;
            lblErrorMessage.Text = "Please fix the incorrect data entry...Then try again... ";
            lblErrorMessage.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(lblErrorMessage);
            Controls.Add(gvShowDogs);
            Controls.Add(grbAttributes);
            Controls.Add(btnAddDog);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMainLoadEventHandler;
            grbAttributes.ResumeLayout(false);
            grbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDog;
        private TextBox txtName;
        private TextBox txtNeck;
        private TextBox txtColor;
        private ComboBox cmbSit;
        private Label dog;
        private Label Neck;
        private Label sit;
        private Label label4;
        private Label color;
        private GroupBox grbAttributes;
        private DataGridView gvShowDogs;
        private TextBox txtWeight;
        private Label pound;
        private Label weight;
        private Label lblErrorMessage;
    }
}