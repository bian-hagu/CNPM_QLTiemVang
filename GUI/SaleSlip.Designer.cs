﻿namespace QLTiemVang.GUI
{
    partial class fSaleSlip
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
            ColumnHeader columnHeader1;
            panel2 = new Panel();
            lvSaleSlip = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            panel4 = new Panel();
            b_Completed = new Button();
            nm_ProductCount = new NumericUpDown();
            b_Add = new Button();
            cbProduct = new ComboBox();
            tb_TotalSlipPrice = new TextBox();
            l_TotalsalePrice = new Label();
            panel3 = new Panel();
            t_Home = new TabControl();
            tabPage1 = new TabPage();
            panel6 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            tb_Customer = new TextBox();
            tb_Date = new TextBox();
            tb_ID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            columnHeader1 = new ColumnHeader();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).BeginInit();
            panel3.SuspendLayout();
            t_Home.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvSaleSlip);
            panel2.Location = new Point(6, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 356);
            panel2.TabIndex = 1;
            // 
            // lvSaleSlip
            // 
            lvSaleSlip.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvSaleSlip.Dock = DockStyle.Fill;
            lvSaleSlip.FullRowSelect = true;
            lvSaleSlip.GridLines = true;
            lvSaleSlip.Location = new Point(0, 0);
            lvSaleSlip.MinimumSize = new Size(50, 0);
            lvSaleSlip.Name = "lvSaleSlip";
            lvSaleSlip.Size = new Size(1220, 356);
            lvSaleSlip.TabIndex = 0;
            lvSaleSlip.UseCompatibleStateImageBehavior = false;
            lvSaleSlip.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sản phẩm";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Loại sản phẩm";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số lượng";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Đơn vị tính";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Đơn giá";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            columnHeader6.Width = 240;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Thành tiền";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 250;
            // 
            // panel4
            // 
            panel4.Controls.Add(b_Completed);
            panel4.Controls.Add(nm_ProductCount);
            panel4.Controls.Add(b_Add);
            panel4.Controls.Add(cbProduct);
            panel4.Location = new Point(6, 560);
            panel4.Name = "panel4";
            panel4.Size = new Size(1220, 63);
            panel4.TabIndex = 3;
            // 
            // b_Completed
            // 
            b_Completed.BackColor = Color.FromArgb(128, 255, 128);
            b_Completed.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Completed.Location = new Point(1109, 6);
            b_Completed.Name = "b_Completed";
            b_Completed.Size = new Size(98, 51);
            b_Completed.TabIndex = 4;
            b_Completed.Text = "Lập";
            b_Completed.UseVisualStyleBackColor = false;
            b_Completed.Click += b_Completed_Click;
            // 
            // nm_ProductCount
            // 
            nm_ProductCount.Location = new Point(889, 22);
            nm_ProductCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nm_ProductCount.Name = "nm_ProductCount";
            nm_ProductCount.Size = new Size(83, 23);
            nm_ProductCount.TabIndex = 3;
            nm_ProductCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // b_Add
            // 
            b_Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Add.Location = new Point(991, 6);
            b_Add.Name = "b_Add";
            b_Add.Size = new Size(98, 51);
            b_Add.TabIndex = 2;
            b_Add.Text = "Thêm";
            b_Add.UseVisualStyleBackColor = true;
            b_Add.Click += b_Add_Click;
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(32, 22);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(836, 23);
            cbProduct.TabIndex = 0;
            // 
            // tb_TotalSlipPrice
            // 
            tb_TotalSlipPrice.Location = new Point(991, 13);
            tb_TotalSlipPrice.Name = "tb_TotalSlipPrice";
            tb_TotalSlipPrice.Size = new Size(216, 23);
            tb_TotalSlipPrice.TabIndex = 6;
            tb_TotalSlipPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // l_TotalsalePrice
            // 
            l_TotalsalePrice.AutoSize = true;
            l_TotalsalePrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_TotalsalePrice.Location = new Point(889, 15);
            l_TotalsalePrice.Name = "l_TotalsalePrice";
            l_TotalsalePrice.Size = new Size(83, 21);
            l_TotalsalePrice.TabIndex = 7;
            l_TotalsalePrice.Text = "Tổng tiền";
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_TotalSlipPrice);
            panel3.Controls.Add(l_TotalsalePrice);
            panel3.Location = new Point(6, 501);
            panel3.Name = "panel3";
            panel3.Size = new Size(1220, 53);
            panel3.TabIndex = 8;
            // 
            // t_Home
            // 
            t_Home.Controls.Add(tabPage1);
            t_Home.Controls.Add(tabPage2);
            t_Home.Location = new Point(12, 12);
            t_Home.Name = "t_Home";
            t_Home.SelectedIndex = 0;
            t_Home.Size = new Size(1240, 657);
            t_Home.TabIndex = 0;
            t_Home.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1232, 629);
            tabPage1.TabIndex = 0;
            tabPage1.Tag = "t_Sale";
            tabPage1.Text = "Phiếu bán hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Location = new Point(6, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(1220, 46);
            panel6.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(487, 6);
            label5.Name = "label5";
            label5.Size = new Size(287, 37);
            label5.TabIndex = 0;
            label5.Text = "PHIẾU BÁN HÀNG";
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_Customer);
            panel1.Controls.Add(tb_Date);
            panel1.Controls.Add(tb_ID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1220, 63);
            panel1.TabIndex = 5;
            // 
            // tb_Customer
            // 
            tb_Customer.Font = new Font("Segoe UI", 9F);
            tb_Customer.ForeColor = SystemColors.WindowText;
            tb_Customer.Location = new Point(104, 35);
            tb_Customer.Name = "tb_Customer";
            tb_Customer.Size = new Size(317, 23);
            tb_Customer.TabIndex = 9;
            tb_Customer.Text = "Chưa chọn khách hàng";
            tb_Customer.MouseClick += tb_Customer_MouseClick;
            // 
            // tb_Date
            // 
            tb_Date.Location = new Point(799, 8);
            tb_Date.Name = "tb_Date";
            tb_Date.Size = new Size(336, 23);
            tb_Date.TabIndex = 8;
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(104, 8);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(317, 23);
            tb_ID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(728, 11);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 38);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Số phiếu:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1232, 629);
            tabPage2.TabIndex = 1;
            tabPage2.Tag = "t_Buy";
            tabPage2.Text = "Phiếu mua hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fSaleSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(t_Home);
            Name = "fSaleSlip";
            Text = "Lusso Jewelry";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nm_ProductCount).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            t_Home.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListView lvSaleSlip;
        private Panel panel4;
        private ComboBox cbProduct;
        private Button b_Add;
        private NumericUpDown nm_ProductCount;
        private Label label1;
        private Panel panel5;
        private Button b_Completed;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox tb_TotalSlipPrice;
        private Label l_TotalsalePrice;
        private Panel panel3;
        private TabControl t_Home;
        private TabPage tabPage1;
        private Panel panel6;
        private Label label5;
        private Panel panel1;
        private TextBox tb_Customer;
        private TextBox tb_Date;
        private TextBox tb_ID;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
    }
}