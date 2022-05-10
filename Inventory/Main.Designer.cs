
namespace Inventory
{
    partial class form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Home));
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_home = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.pnl_searchButtons = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_searchPartNumber = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.tb_searchLocation = new System.Windows.Forms.TextBox();
            this.tb_searchManufacturer = new System.Windows.Forms.TextBox();
            this.lv_products = new System.Windows.Forms.ListView();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_topBar.SuspendLayout();
            this.pnl_home.SuspendLayout();
            this.pnl_searchButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1004, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(138, 45);
            this.btn_add.TabIndex = 0;
            this.btn_add.TabStop = false;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseEnter += new System.EventHandler(this.btn_add_MouseEnter);
            this.btn_add.MouseLeave += new System.EventHandler(this.Btn_add_MouseLeave);
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.pnl_topBar.Controls.Add(this.label1);
            this.pnl_topBar.Controls.Add(this.btn_home);
            this.pnl_topBar.Controls.Add(this.btn_add);
            this.pnl_topBar.Location = new System.Drawing.Point(-1, 0);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(1279, 71);
            this.pnl_topBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "W.D. Dump Truck Service Inventory";
            // 
            // btn_home
            // 
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(859, 13);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(138, 45);
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            this.btn_home.MouseEnter += new System.EventHandler(this.btn_home_MouseEnter);
            this.btn_home.MouseLeave += new System.EventHandler(this.btn_home_MouseLeave);
            // 
            // pnl_home
            // 
            this.pnl_home.Controls.Add(this.btn_search);
            this.pnl_home.Controls.Add(this.tb_searchName);
            this.pnl_home.Controls.Add(this.pnl_searchButtons);
            this.pnl_home.Controls.Add(this.tb_searchPartNumber);
            this.pnl_home.Controls.Add(this.btn_refresh);
            this.pnl_home.Controls.Add(this.lbl_error);
            this.pnl_home.Controls.Add(this.tb_searchLocation);
            this.pnl_home.Controls.Add(this.tb_searchManufacturer);
            this.pnl_home.Controls.Add(this.lv_products);
            this.pnl_home.Location = new System.Drawing.Point(-1, 71);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(1276, 618);
            this.pnl_home.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.btn_search.Location = new System.Drawing.Point(189, 182);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 31);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_search_KeyDown);
            this.btn_search.MouseEnter += new System.EventHandler(this.btn_search_MouseEnter);
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_search_MouseLeave);
            // 
            // tb_searchName
            // 
            this.tb_searchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_searchName.Location = new System.Drawing.Point(150, 75);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.Size = new System.Drawing.Size(194, 20);
            this.tb_searchName.TabIndex = 2;
            // 
            // pnl_searchButtons
            // 
            this.pnl_searchButtons.BackColor = System.Drawing.Color.Gray;
            this.pnl_searchButtons.Controls.Add(this.btn_save);
            this.pnl_searchButtons.Controls.Add(this.label5);
            this.pnl_searchButtons.Controls.Add(this.label4);
            this.pnl_searchButtons.Controls.Add(this.label3);
            this.pnl_searchButtons.Controls.Add(this.label2);
            this.pnl_searchButtons.Location = new System.Drawing.Point(0, -1);
            this.pnl_searchButtons.Name = "pnl_searchButtons";
            this.pnl_searchButtons.Size = new System.Drawing.Size(144, 689);
            this.pnl_searchButtons.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Number:";
            // 
            // tb_searchPartNumber
            // 
            this.tb_searchPartNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_searchPartNumber.Location = new System.Drawing.Point(150, 41);
            this.tb_searchPartNumber.Name = "tb_searchPartNumber";
            this.tb_searchPartNumber.Size = new System.Drawing.Size(194, 20);
            this.tb_searchPartNumber.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.btn_refresh.Location = new System.Drawing.Point(1004, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(138, 25);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            this.btn_refresh.MouseEnter += new System.EventHandler(this.btn_refresh_MouseEnter);
            this.btn_refresh.MouseLeave += new System.EventHandler(this.btn_refresh_MouseLeave);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(231, 226);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 26;
            // 
            // tb_searchLocation
            // 
            this.tb_searchLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_searchLocation.Location = new System.Drawing.Point(150, 143);
            this.tb_searchLocation.Name = "tb_searchLocation";
            this.tb_searchLocation.Size = new System.Drawing.Size(194, 20);
            this.tb_searchLocation.TabIndex = 4;
            // 
            // tb_searchManufacturer
            // 
            this.tb_searchManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_searchManufacturer.Location = new System.Drawing.Point(150, 109);
            this.tb_searchManufacturer.Name = "tb_searchManufacturer";
            this.tb_searchManufacturer.Size = new System.Drawing.Size(194, 20);
            this.tb_searchManufacturer.TabIndex = 3;
            // 
            // lv_products
            // 
            this.lv_products.BackColor = System.Drawing.Color.Silver;
            this.lv_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_products.HideSelection = false;
            this.lv_products.Location = new System.Drawing.Point(359, 41);
            this.lv_products.Name = "lv_products";
            this.lv_products.Size = new System.Drawing.Size(783, 548);
            this.lv_products.TabIndex = 25;
            this.lv_products.TabStop = false;
            this.lv_products.UseCompatibleStateImageBehavior = false;
            this.lv_products.View = System.Windows.Forms.View.Details;
            this.lv_products.DoubleClick += new System.EventHandler(this.lv_products_DoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.DimGray;
            this.btn_save.Location = new System.Drawing.Point(13, 540);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 35);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1154, 669);
            this.Controls.Add(this.pnl_home);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_Home";
            this.Text = "WD Inventory Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_Home_FormClosed);
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            this.pnl_home.ResumeLayout(false);
            this.pnl_home.PerformLayout();
            this.pnl_searchButtons.ResumeLayout(false);
            this.pnl_searchButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_home;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Panel pnl_searchButtons;
        private System.Windows.Forms.TextBox tb_searchPartNumber;
        private System.Windows.Forms.TextBox tb_searchLocation;
        private System.Windows.Forms.TextBox tb_searchManufacturer;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ListView lv_products;
        internal System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
    }
}

