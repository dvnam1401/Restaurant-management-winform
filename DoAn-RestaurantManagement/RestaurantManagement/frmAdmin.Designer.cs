using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagement
{
    partial class frmAdmin
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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel24 = new System.Windows.Forms.Panel();
            this.cbTableStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpTable.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.tpFoodCategory.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel8.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel1);
            this.tpAccount.Controls.Add(this.panel28);
            this.tpAccount.Controls.Add(this.dtgvAccount);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(850, 481);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetPassword);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.panel26);
            this.panel1.Location = new System.Drawing.Point(463, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 404);
            this.panel1.TabIndex = 9;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(215, 205);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(139, 52);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.nmAccountType);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Location = new System.Drawing.Point(0, 137);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(354, 62);
            this.panel17.TabIndex = 3;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(138, 18);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(97, 22);
            this.nmAccountType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại tài khoản:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txbDisplayName);
            this.panel20.Controls.Add(this.label12);
            this.panel20.Location = new System.Drawing.Point(0, 68);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(354, 62);
            this.panel20.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(138, 18);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(209, 22);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 35);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbUserName);
            this.panel26.Controls.Add(this.label13);
            this.panel26.Location = new System.Drawing.Point(0, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(354, 62);
            this.panel26.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(138, 18);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(209, 22);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label13.Location = new System.Drawing.Point(3, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 35);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnShowAccount);
            this.panel28.Controls.Add(this.btnEditAccount);
            this.panel28.Controls.Add(this.btnDeleteAccount);
            this.panel28.Controls.Add(this.btnAddAccount);
            this.panel28.Location = new System.Drawing.Point(7, 6);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(449, 52);
            this.panel28.TabIndex = 7;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(352, 0);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(97, 52);
            this.btnShowAccount.TabIndex = 0;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(233, 0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(97, 52);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(118, 0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(97, 52);
            this.btnDeleteAccount.TabIndex = 0;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 52);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(7, 63);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 25;
            this.dtgvAccount.Size = new System.Drawing.Size(449, 406);
            this.dtgvAccount.TabIndex = 10;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel24);
            this.tpTable.Controls.Add(this.panel16);
            this.tpTable.Controls.Add(this.panel25);
            this.tpTable.Controls.Add(this.dtgvTable);
            this.tpTable.Location = new System.Drawing.Point(4, 25);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(850, 481);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.cbTableStatus);
            this.panel24.Controls.Add(this.label11);
            this.panel24.Location = new System.Drawing.Point(487, 208);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(354, 62);
            this.panel24.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new System.Drawing.Point(112, 20);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new System.Drawing.Size(233, 24);
            this.cbTableStatus.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Trạng thái:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel22);
            this.panel16.Controls.Add(this.panel23);
            this.panel16.Location = new System.Drawing.Point(488, 71);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(357, 404);
            this.panel16.TabIndex = 9;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.textBox1);
            this.panel22.Controls.Add(this.label9);
            this.panel22.Location = new System.Drawing.Point(0, 68);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(354, 62);
            this.panel22.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên bàn:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.textBox2);
            this.panel23.Controls.Add(this.label10);
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(354, 62);
            this.panel23.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(236, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label10.Location = new System.Drawing.Point(3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btnShowTable);
            this.panel25.Controls.Add(this.btnEditTable);
            this.panel25.Controls.Add(this.btnDeleteTable);
            this.panel25.Controls.Add(this.btnAddTable);
            this.panel25.Location = new System.Drawing.Point(7, 13);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(474, 52);
            this.panel25.TabIndex = 7;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(377, 0);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(97, 52);
            this.btnShowTable.TabIndex = 0;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(250, 0);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(97, 52);
            this.btnEditTable.TabIndex = 0;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(123, 0);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(97, 52);
            this.btnDeleteTable.TabIndex = 0;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(0, 0);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(97, 52);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(10, 70);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 25;
            this.dtgvTable.Size = new System.Drawing.Size(471, 406);
            this.dtgvTable.TabIndex = 10;
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Controls.Add(this.panel15);
            this.tpFoodCategory.Controls.Add(this.panel21);
            this.tpFoodCategory.Controls.Add(this.dtgvCategory);
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 25);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoodCategory.Size = new System.Drawing.Size(850, 481);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục ";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Location = new System.Drawing.Point(489, 65);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(357, 404);
            this.panel15.TabIndex = 9;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txbCategoryName);
            this.panel18.Controls.Add(this.label7);
            this.panel18.Location = new System.Drawing.Point(0, 68);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(354, 62);
            this.panel18.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(141, 18);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(206, 22);
            this.txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên bàn";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txbCategoryID);
            this.panel19.Controls.Add(this.label8);
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(354, 62);
            this.panel19.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(141, 18);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(206, 22);
            this.txbCategoryID.TabIndex = 1;
            this.txbCategoryID.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnShowCategory);
            this.panel21.Controls.Add(this.btnEditCategory);
            this.panel21.Controls.Add(this.btnDeleteCategory);
            this.panel21.Controls.Add(this.btnAddCategory);
            this.panel21.Location = new System.Drawing.Point(3, 6);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(474, 52);
            this.panel21.TabIndex = 7;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(377, 0);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(97, 52);
            this.btnShowCategory.TabIndex = 0;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(250, 0);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(97, 52);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(123, 0);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(97, 52);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(0, 0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(97, 52);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 65);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 25;
            this.dtgvCategory.Size = new System.Drawing.Size(471, 406);
            this.dtgvCategory.TabIndex = 10;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel10);
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(850, 481);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(488, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(357, 404);
            this.panel10.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.nmFoodPrice);
            this.panel14.Controls.Add(this.label4);
            this.panel14.Location = new System.Drawing.Point(0, 205);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(354, 62);
            this.panel14.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(111, 18);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(237, 22);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.cbFoodCategory);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Location = new System.Drawing.Point(0, 137);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(354, 62);
            this.panel13.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(111, 18);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(236, 24);
            this.cbFoodCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục: ";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbFoodName);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Location = new System.Drawing.Point(0, 68);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(354, 62);
            this.panel12.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(111, 18);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(236, 22);
            this.txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txbFoodID);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(354, 62);
            this.panel11.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(111, 18);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(236, 22);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSearchFoodName);
            this.panel6.Controls.Add(this.btnSearchFood);
            this.panel6.Location = new System.Drawing.Point(488, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 52);
            this.panel6.TabIndex = 4;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(3, 15);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(246, 22);
            this.txbSearchFoodName.TabIndex = 1;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(257, 0);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(97, 52);
            this.btnSearchFood.TabIndex = 0;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowFood);
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(7, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 52);
            this.panel4.TabIndex = 3;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(377, 0);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(97, 52);
            this.btnShowFood.TabIndex = 0;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(250, 0);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(97, 52);
            this.btnEditFood.TabIndex = 0;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(123, 0);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(97, 52);
            this.btnDeleteFood.TabIndex = 0;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(0, 0);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(97, 52);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvFood);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(7, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 405);
            this.panel5.TabIndex = 2;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 0);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 25;
            this.dtgvFood.Size = new System.Drawing.Size(471, 406);
            this.dtgvFood.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(481, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 420);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(481, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(354, 420);
            this.panel9.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(481, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 420);
            this.panel7.TabIndex = 5;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel3);
            this.tpBill.Controls.Add(this.dtgvBill);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(850, 481);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewBill);
            this.panel3.Controls.Add(this.dtpkToDate);
            this.panel3.Controls.Add(this.dtpkFromDate);
            this.panel3.Location = new System.Drawing.Point(7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 34);
            this.panel3.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(371, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(96, 30);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(593, 3);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(238, 22);
            this.dtpkToDate.TabIndex = 0;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(238, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(7, 47);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 25;
            this.dtgvBill.Size = new System.Drawing.Size(835, 427);
            this.dtgvBill.TabIndex = 1;
            // 
            // tcAdmin
            // 
            this.tcAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(14, 13);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(858, 510);
            this.tcAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 530);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.tpAccount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.tpFoodCategory.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tpAccount;
        private TabPage tpTable;
        private TabPage tpFoodCategory;
        private TabPage tpFood;
        private TabPage tpBill;
        private TabControl tcAdmin;
        private Panel panel3;
        private DataGridView dtgvBill;
        private DateTimePicker dtpkFromDate;
        private DateTimePicker dtpkToDate;
        private Button btnViewBill;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Panel panel10;
        private Button btnAddFood;
        private DataGridView dtgvFood;
        private Button btnEditFood;
        private Button btnShowFood;
        private Button btnDeleteFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel11;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel13;
        private Label label3;
        private Panel panel12;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel14;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private ComboBox cbFoodCategory;
        private Panel panel15;
        private Panel panel18;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel19;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel21;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private DataGridView dtgvCategory;
        private Panel panel16;
        private Panel panel22;
        private TextBox textBox1;
        private Label label9;
        private Panel panel23;
        private TextBox textBox2;
        private Label label10;
        private Panel panel25;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dtgvTable;
        private Panel panel24;
        private ComboBox cbTableStatus;
        private Label label11;
        private Panel panel1;
        private Panel panel17;
        private Label label6;
        private Panel panel20;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel26;
        private TextBox txbUserName;
        private Label label13;
        private Panel panel28;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private NumericUpDown nmAccountType;
    }
}