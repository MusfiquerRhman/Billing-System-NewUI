namespace BillingSystemNewUI
{
    partial class ProductDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonSellsPersons = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewProductDetail = new System.Windows.Forms.DataGridView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 705);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.buttonProducts);
            this.panel2.Controls.Add(this.buttonHistory);
            this.panel2.Controls.Add(this.buttonCustomers);
            this.panel2.Controls.Add(this.buttonSellsPersons);
            this.panel2.Controls.Add(this.buttonSell);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 705);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 85);
            this.label11.TabIndex = 7;
            this.label11.Text = "System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 85);
            this.label10.TabIndex = 6;
            this.label10.Text = "Billing";
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Location = new System.Drawing.Point(3, 518);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(197, 70);
            this.buttonProducts.TabIndex = 4;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Location = new System.Drawing.Point(7, 442);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(193, 70);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.FlatAppearance.BorderSize = 0;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonCustomers.Location = new System.Drawing.Point(7, 363);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(193, 70);
            this.buttonCustomers.TabIndex = 2;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.ButtonCustomers_Click);
            // 
            // buttonSellsPersons
            // 
            this.buttonSellsPersons.FlatAppearance.BorderSize = 0;
            this.buttonSellsPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellsPersons.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellsPersons.ForeColor = System.Drawing.Color.White;
            this.buttonSellsPersons.Location = new System.Drawing.Point(7, 287);
            this.buttonSellsPersons.Name = "buttonSellsPersons";
            this.buttonSellsPersons.Size = new System.Drawing.Size(193, 70);
            this.buttonSellsPersons.TabIndex = 1;
            this.buttonSellsPersons.Text = "Sells Persons";
            this.buttonSellsPersons.UseVisualStyleBackColor = true;
            this.buttonSellsPersons.Click += new System.EventHandler(this.ButtonSellsPersons_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.FlatAppearance.BorderSize = 0;
            this.buttonSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSell.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.ForeColor = System.Drawing.Color.White;
            this.buttonSell.Location = new System.Drawing.Point(7, 211);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(193, 70);
            this.buttonSell.TabIndex = 0;
            this.buttonSell.Text = "Sells Page";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.ButtonSell_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1443, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 32);
            this.label8.TabIndex = 76;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductID.Location = new System.Drawing.Point(383, 101);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(231, 29);
            this.textBoxProductID.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(233, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 92;
            this.label9.Text = "Product ID :";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(237, 623);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(377, 44);
            this.buttonDelete.TabIndex = 91;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 3;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(237, 561);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(377, 44);
            this.buttonUpdate.TabIndex = 90;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonAdd.FlatAppearance.BorderSize = 3;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(237, 496);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(377, 44);
            this.buttonAdd.TabIndex = 89;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(739, 101);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(551, 29);
            this.textBoxSearch.TabIndex = 88;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(647, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 87;
            this.label7.Text = "Search :";
            // 
            // dataGridViewProductDetail
            // 
            this.dataGridViewProductDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(23)))), ((int)(((byte)(37)))));
            this.dataGridViewProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductDetail.GridColor = System.Drawing.Color.White;
            this.dataGridViewProductDetail.Location = new System.Drawing.Point(651, 153);
            this.dataGridViewProductDetail.Name = "dataGridViewProductDetail";
            this.dataGridViewProductDetail.Size = new System.Drawing.Size(639, 514);
            this.dataGridViewProductDetail.TabIndex = 86;
            this.dataGridViewProductDetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewProductDetail_RowHeaderMouseClick);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(383, 286);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(231, 126);
            this.textBoxDescription.TabIndex = 85;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(383, 238);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(231, 29);
            this.textBoxManufacturer.TabIndex = 84;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(383, 193);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(231, 29);
            this.textBoxPrice.TabIndex = 83;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(383, 148);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(231, 29);
            this.textBoxProductName.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(233, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(233, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "Manufacturer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Price :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(233, 151);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(117, 21);
            this.labelUserName.TabIndex = 78;
            this.labelUserName.Text = "Pruduct Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 77;
            this.label1.Text = "Products Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1292, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 96;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1334, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProductDetail);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonSellsPersons;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewProductDetail;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

