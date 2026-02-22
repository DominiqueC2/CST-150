namespace MilestoneProject
{
    partial class AdventureShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcome = new System.Windows.Forms.Label();
            this.BtnDisplayInt = new System.Windows.Forms.Button();
            this.gvInventory = new System.Windows.Forms.DataGridView();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.sort = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edRarity = new System.Windows.Forms.TextBox();
            this.edType = new System.Windows.Forms.TextBox();
            this.edCost = new System.Windows.Forms.TextBox();
            this.edQty = new System.Windows.Forms.TextBox();
            this.edDesc = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Yellow;
            this.welcome.Location = new System.Drawing.Point(724, 70);
            this.welcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(476, 46);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome To The Store";
            // 
            // BtnDisplayInt
            // 
            this.BtnDisplayInt.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnDisplayInt.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BtnDisplayInt.FlatAppearance.BorderSize = 3;
            this.BtnDisplayInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisplayInt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayInt.Location = new System.Drawing.Point(801, 146);
            this.BtnDisplayInt.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDisplayInt.Name = "BtnDisplayInt";
            this.BtnDisplayInt.Size = new System.Drawing.Size(333, 74);
            this.BtnDisplayInt.TabIndex = 1;
            this.BtnDisplayInt.Text = "Display Inventory";
            this.BtnDisplayInt.UseVisualStyleBackColor = false;
            this.BtnDisplayInt.Click += new System.EventHandler(this.BtnDisplayInt_Click);
            // 
            // gvInventory
            // 
            this.gvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvInventory.BackgroundColor = System.Drawing.Color.Maroon;
            this.gvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesc,
            this.colQty,
            this.colCost,
            this.colType,
            this.colRarity});
            this.gvInventory.GridColor = System.Drawing.Color.Maroon;
            this.gvInventory.Location = new System.Drawing.Point(569, 360);
            this.gvInventory.Margin = new System.Windows.Forms.Padding(5);
            this.gvInventory.Name = "gvInventory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvInventory.Size = new System.Drawing.Size(808, 590);
            this.gvInventory.TabIndex = 2;
            this.gvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvInventory_CellClick);
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "Description";
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Quantity";
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            // 
            // colCost
            // 
            this.colCost.DataPropertyName = "Cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // colRarity
            // 
            this.colRarity.DataPropertyName = "Rarity";
            this.colRarity.HeaderText = "Rarity";
            this.colRarity.Name = "colRarity";
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnUp.FlatAppearance.BorderSize = 3;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(569, 1043);
            this.btnUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(333, 74);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Increase Item";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSub.FlatAppearance.BorderSize = 3;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(569, 1184);
            this.btnSub.Margin = new System.Windows.Forms.Padding(5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(333, 74);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Decrease Item";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1044, 1043);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(333, 74);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1413, 360);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 55);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(1519, 465);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(148, 29);
            this.txtDesc.TabIndex = 7;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1575, 580);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(148, 29);
            this.txtQty.TabIndex = 8;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(1517, 686);
            this.txtCost.Margin = new System.Windows.Forms.Padding(5);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(148, 29);
            this.txtCost.TabIndex = 9;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(1519, 805);
            this.txtType.Margin = new System.Windows.Forms.Padding(5);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(148, 29);
            this.txtType.TabIndex = 10;
            // 
            // txtRarity
            // 
            this.txtRarity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarity.Location = new System.Drawing.Point(1519, 914);
            this.txtRarity.Margin = new System.Windows.Forms.Padding(5);
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.Size = new System.Drawing.Size(148, 29);
            this.txtRarity.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(1419, 457);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(1419, 572);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(1419, 679);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(1419, 796);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(1419, 906);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rarity:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1085, 1218);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 25);
            this.txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1239, 1199);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 70);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // cmbSort
            // 
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(927, 262);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(205, 29);
            this.cmbSort.TabIndex = 20;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.AutoSize = true;
            this.sort.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.ForeColor = System.Drawing.Color.Gold;
            this.sort.Location = new System.Drawing.Point(805, 262);
            this.sort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(95, 32);
            this.sort.TabIndex = 21;
            this.sort.Text = "Sort By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(196, 906);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rarity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(196, 796);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(196, 679);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(196, 572);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 30);
            this.label9.TabIndex = 28;
            this.label9.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(196, 457);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 30);
            this.label10.TabIndex = 27;
            this.label10.Text = "Name:";
            // 
            // edRarity
            // 
            this.edRarity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edRarity.Location = new System.Drawing.Point(312, 914);
            this.edRarity.Margin = new System.Windows.Forms.Padding(5);
            this.edRarity.Name = "edRarity";
            this.edRarity.Size = new System.Drawing.Size(148, 29);
            this.edRarity.TabIndex = 26;
            // 
            // edType
            // 
            this.edType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edType.Location = new System.Drawing.Point(312, 805);
            this.edType.Margin = new System.Windows.Forms.Padding(5);
            this.edType.Name = "edType";
            this.edType.Size = new System.Drawing.Size(148, 29);
            this.edType.TabIndex = 25;
            // 
            // edCost
            // 
            this.edCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edCost.Location = new System.Drawing.Point(312, 686);
            this.edCost.Margin = new System.Windows.Forms.Padding(5);
            this.edCost.Name = "edCost";
            this.edCost.Size = new System.Drawing.Size(148, 29);
            this.edCost.TabIndex = 24;
            // 
            // edQty
            // 
            this.edQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edQty.Location = new System.Drawing.Point(353, 580);
            this.edQty.Margin = new System.Windows.Forms.Padding(5);
            this.edQty.Name = "edQty";
            this.edQty.Size = new System.Drawing.Size(148, 29);
            this.edQty.TabIndex = 23;
            // 
            // edDesc
            // 
            this.edDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edDesc.Location = new System.Drawing.Point(312, 465);
            this.edDesc.Margin = new System.Windows.Forms.Padding(5);
            this.edDesc.Name = "edDesc";
            this.edDesc.Size = new System.Drawing.Size(148, 29);
            this.edDesc.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(270, 360);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 55);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AdventureShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1921, 1301);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.edRarity);
            this.Controls.Add(this.edType);
            this.Controls.Add(this.edCost);
            this.Controls.Add(this.edQty);
            this.Controls.Add(this.edDesc);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRarity);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.gvInventory);
            this.Controls.Add(this.BtnDisplayInt);
            this.Controls.Add(this.welcome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdventureShop";
            this.Text = "AdventureShop";
            this.Load += new System.EventHandler(this.AdventureShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button BtnDisplayInt;
        private System.Windows.Forms.DataGridView gvInventory;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtRarity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label sort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edRarity;
        private System.Windows.Forms.TextBox edType;
        private System.Windows.Forms.TextBox edCost;
        private System.Windows.Forms.TextBox edQty;
        private System.Windows.Forms.TextBox edDesc;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRarity;
    }
}

