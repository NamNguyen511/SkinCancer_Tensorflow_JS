namespace QuanLyQuanNet
{
    partial class ComputerManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpComputer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddAccountbtn = new System.Windows.Forms.Button();
            this.Accounttxt = new System.Windows.Forms.TextBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nmrFoodCount = new System.Windows.Forms.NumericUpDown();
            this.addfoodbtn = new System.Windows.Forms.Button();
            this.adduserbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckOutAccountbtn = new System.Windows.Forms.Button();
            this.Swapbtn = new System.Windows.Forms.Button();
            this.Discountbtn = new System.Windows.Forms.Button();
            this.cbSwap = new System.Windows.Forms.ComboBox();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.Totalpricetxt = new System.Windows.Forms.TextBox();
            this.CheckOutbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountProfileToolStripMenuItem,
            this.accountPlayerToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1761, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountProfileToolStripMenuItem
            // 
            this.accountProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountProfileToolStripMenuItem.Name = "accountProfileToolStripMenuItem";
            this.accountProfileToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.accountProfileToolStripMenuItem.Text = "Account Profile";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // accountPlayerToolStripMenuItem
            // 
            this.accountPlayerToolStripMenuItem.Name = "accountPlayerToolStripMenuItem";
            this.accountPlayerToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.accountPlayerToolStripMenuItem.Text = "Account Player";
            this.accountPlayerToolStripMenuItem.Click += new System.EventHandler(this.accountPlayerToolStripMenuItem_Click);
            // 
            // flpComputer
            // 
            this.flpComputer.Location = new System.Drawing.Point(17, 34);
            this.flpComputer.Margin = new System.Windows.Forms.Padding(4);
            this.flpComputer.Name = "flpComputer";
            this.flpComputer.Size = new System.Drawing.Size(957, 591);
            this.flpComputer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddAccountbtn);
            this.panel2.Controls.Add(this.Accounttxt);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.nmrFoodCount);
            this.panel2.Controls.Add(this.addfoodbtn);
            this.panel2.Controls.Add(this.adduserbtn);
            this.panel2.Location = new System.Drawing.Point(984, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 94);
            this.panel2.TabIndex = 3;
            // 
            // AddAccountbtn
            // 
            this.AddAccountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountbtn.Location = new System.Drawing.Point(643, 49);
            this.AddAccountbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddAccountbtn.Name = "AddAccountbtn";
            this.AddAccountbtn.Size = new System.Drawing.Size(121, 41);
            this.AddAccountbtn.TabIndex = 6;
            this.AddAccountbtn.Text = "Add Account";
            this.AddAccountbtn.UseVisualStyleBackColor = true;
            this.AddAccountbtn.Click += new System.EventHandler(this.AddAccountbtn_Click);
            // 
            // Accounttxt
            // 
            this.Accounttxt.Location = new System.Drawing.Point(645, 6);
            this.Accounttxt.Margin = new System.Windows.Forms.Padding(4);
            this.Accounttxt.Name = "Accounttxt";
            this.Accounttxt.Size = new System.Drawing.Size(115, 22);
            this.Accounttxt.TabIndex = 5;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(5, 49);
            this.cbFood.Margin = new System.Windows.Forms.Padding(4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(417, 24);
            this.cbFood.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(5, 5);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(343, 24);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // nmrFoodCount
            // 
            this.nmrFoodCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nmrFoodCount.Location = new System.Drawing.Point(357, 5);
            this.nmrFoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmrFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrFoodCount.Name = "nmrFoodCount";
            this.nmrFoodCount.Size = new System.Drawing.Size(67, 22);
            this.nmrFoodCount.TabIndex = 2;
            this.nmrFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addfoodbtn
            // 
            this.addfoodbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfoodbtn.Location = new System.Drawing.Point(432, 4);
            this.addfoodbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addfoodbtn.Name = "addfoodbtn";
            this.addfoodbtn.Size = new System.Drawing.Size(100, 86);
            this.addfoodbtn.TabIndex = 1;
            this.addfoodbtn.Text = "Add Food";
            this.addfoodbtn.UseVisualStyleBackColor = true;
            this.addfoodbtn.Click += new System.EventHandler(this.addfoodbtn_Click);
            // 
            // adduserbtn
            // 
            this.adduserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserbtn.Location = new System.Drawing.Point(540, 4);
            this.adduserbtn.Margin = new System.Windows.Forms.Padding(4);
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.Size = new System.Drawing.Size(100, 86);
            this.adduserbtn.TabIndex = 0;
            this.adduserbtn.Text = "Add User";
            this.adduserbtn.UseVisualStyleBackColor = true;
            this.adduserbtn.Click += new System.EventHandler(this.adduserbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CheckOutAccountbtn);
            this.panel3.Controls.Add(this.Swapbtn);
            this.panel3.Controls.Add(this.Discountbtn);
            this.panel3.Controls.Add(this.cbSwap);
            this.panel3.Controls.Add(this.nmrDiscount);
            this.panel3.Controls.Add(this.Totalpricetxt);
            this.panel3.Controls.Add(this.CheckOutbtn);
            this.panel3.Location = new System.Drawing.Point(983, 532);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 94);
            this.panel3.TabIndex = 4;
            // 
            // CheckOutAccountbtn
            // 
            this.CheckOutAccountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutAccountbtn.Location = new System.Drawing.Point(663, 4);
            this.CheckOutAccountbtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutAccountbtn.Name = "CheckOutAccountbtn";
            this.CheckOutAccountbtn.Size = new System.Drawing.Size(100, 86);
            this.CheckOutAccountbtn.TabIndex = 7;
            this.CheckOutAccountbtn.Text = "Check Out Account";
            this.CheckOutAccountbtn.UseVisualStyleBackColor = true;
            this.CheckOutAccountbtn.Click += new System.EventHandler(this.CheckOutAccountbtn_Click);
            // 
            // Swapbtn
            // 
            this.Swapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Swapbtn.Location = new System.Drawing.Point(7, 5);
            this.Swapbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Swapbtn.Name = "Swapbtn";
            this.Swapbtn.Size = new System.Drawing.Size(161, 38);
            this.Swapbtn.TabIndex = 6;
            this.Swapbtn.Text = "Swap";
            this.Swapbtn.UseVisualStyleBackColor = true;
            this.Swapbtn.Click += new System.EventHandler(this.Swapbtn_Click);
            // 
            // Discountbtn
            // 
            this.Discountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discountbtn.Location = new System.Drawing.Point(176, 5);
            this.Discountbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Discountbtn.Name = "Discountbtn";
            this.Discountbtn.Size = new System.Drawing.Size(131, 38);
            this.Discountbtn.TabIndex = 5;
            this.Discountbtn.Text = "Discount";
            this.Discountbtn.UseVisualStyleBackColor = true;
            // 
            // cbSwap
            // 
            this.cbSwap.FormattingEnabled = true;
            this.cbSwap.Location = new System.Drawing.Point(7, 50);
            this.cbSwap.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwap.Name = "cbSwap";
            this.cbSwap.Size = new System.Drawing.Size(160, 24);
            this.cbSwap.TabIndex = 4;
            this.cbSwap.SelectedIndexChanged += new System.EventHandler(this.cbSwap_SelectedIndexChanged);
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Location = new System.Drawing.Point(176, 50);
            this.nmrDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(131, 22);
            this.nmrDiscount.TabIndex = 3;
            // 
            // Totalpricetxt
            // 
            this.Totalpricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalpricetxt.Location = new System.Drawing.Point(315, 25);
            this.Totalpricetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Totalpricetxt.Name = "Totalpricetxt";
            this.Totalpricetxt.Size = new System.Drawing.Size(213, 55);
            this.Totalpricetxt.TabIndex = 2;
            this.Totalpricetxt.TextChanged += new System.EventHandler(this.Totalpricetxt_TextChanged);
            // 
            // CheckOutbtn
            // 
            this.CheckOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutbtn.Location = new System.Drawing.Point(537, 4);
            this.CheckOutbtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutbtn.Name = "CheckOutbtn";
            this.CheckOutbtn.Size = new System.Drawing.Size(100, 86);
            this.CheckOutbtn.TabIndex = 1;
            this.CheckOutbtn.Text = "Check Out";
            this.CheckOutbtn.UseVisualStyleBackColor = true;
            this.CheckOutbtn.Click += new System.EventHandler(this.CheckOutbtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lsvBill);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(984, 135);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 389);
            this.panel4.TabIndex = 5;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(757, 383);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Name";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Price";
            this.columnHeader5.Width = 102;
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.chatToolStripMenuItem.Text = "chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // ComputerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 626);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpComputer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComputerManager";
            this.Text = "ComputerManager";
            this.Load += new System.EventHandler(this.ComputerManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpComputer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nmrFoodCount;
        private System.Windows.Forms.Button addfoodbtn;
        private System.Windows.Forms.Button adduserbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Swapbtn;
        private System.Windows.Forms.Button Discountbtn;
        private System.Windows.Forms.ComboBox cbSwap;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.TextBox Totalpricetxt;
        private System.Windows.Forms.Button CheckOutbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem accountPlayerToolStripMenuItem;
        private System.Windows.Forms.Button AddAccountbtn;
        private System.Windows.Forms.TextBox Accounttxt;
        private System.Windows.Forms.Button CheckOutAccountbtn;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
    }
}