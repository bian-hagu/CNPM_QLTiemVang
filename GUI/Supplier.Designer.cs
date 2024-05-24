namespace QLTiemVang.GUI
{
    partial class fSupplier
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
            panel2 = new Panel();
            b_Add = new Button();
            tb_Search = new TextBox();
            b_ChoseCust = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            tb_Phone = new TextBox();
            tb_id = new TextBox();
            tb_name = new TextBox();
            tb_Address = new TextBox();
            dgv_Sup = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sup).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(b_Add);
            panel2.Controls.Add(tb_Search);
            panel2.Controls.Add(b_ChoseCust);
            panel2.Location = new Point(12, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 49);
            panel2.TabIndex = 4;
            // 
            // b_Add
            // 
            b_Add.BackColor = Color.White;
            b_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_Add.Location = new Point(467, 3);
            b_Add.Name = "b_Add";
            b_Add.Size = new Size(96, 43);
            b_Add.TabIndex = 2;
            b_Add.Text = "Thêm";
            b_Add.UseVisualStyleBackColor = false;
            b_Add.Click += b_Add_Click;
            // 
            // tb_Search
            // 
            tb_Search.ForeColor = SystemColors.WindowFrame;
            tb_Search.Location = new Point(15, 14);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(446, 23);
            tb_Search.TabIndex = 1;
            tb_Search.Text = "Tìm nhà cung cấp";
            tb_Search.MouseClick += tb_Search_MouseClick;
            tb_Search.KeyPress += tb_Search_KeyPress;
            // 
            // b_ChoseCust
            // 
            b_ChoseCust.BackColor = Color.Lime;
            b_ChoseCust.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_ChoseCust.Location = new Point(569, 3);
            b_ChoseCust.Name = "b_ChoseCust";
            b_ChoseCust.Size = new Size(96, 43);
            b_ChoseCust.TabIndex = 0;
            b_ChoseCust.Text = "Chọn";
            b_ChoseCust.UseVisualStyleBackColor = false;
            b_ChoseCust.Click += b_ChoseSup_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgv_Sup);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 362);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_Phone);
            panel3.Controls.Add(tb_id);
            panel3.Controls.Add(tb_name);
            panel3.Controls.Add(tb_Address);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 78);
            panel3.TabIndex = 3;
            // 
            // tb_Phone
            // 
            tb_Phone.ForeColor = SystemColors.WindowFrame;
            tb_Phone.Location = new Point(15, 41);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(223, 23);
            tb_Phone.TabIndex = 4;
            tb_Phone.Text = "Số điện thoại";
            // 
            // tb_id
            // 
            tb_id.ForeColor = SystemColors.WindowFrame;
            tb_id.Location = new Point(15, 12);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(223, 23);
            tb_id.TabIndex = 3;
            tb_id.Text = "Mã khách hàng";
            // 
            // tb_name
            // 
            tb_name.ForeColor = SystemColors.WindowFrame;
            tb_name.Location = new Point(260, 12);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(405, 23);
            tb_name.TabIndex = 2;
            tb_name.Text = "Tên khách hàng";
            // 
            // tb_Address
            // 
            tb_Address.ForeColor = SystemColors.WindowFrame;
            tb_Address.Location = new Point(260, 41);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(405, 23);
            tb_Address.TabIndex = 1;
            tb_Address.Text = "Địa chỉ";
            // 
            // dgv_Sup
            // 
            dgv_Sup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sup.Location = new Point(0, 87);
            dgv_Sup.Name = "dgv_Sup";
            dgv_Sup.Size = new Size(677, 284);
            dgv_Sup.TabIndex = 0;
            dgv_Sup.CellClick += dgv_Sup_CellClick;
            // 
            // fSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fSupplier";
            Text = "Supplier";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Sup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button b_Add;
        private TextBox tb_Search;
        private Button b_ChoseCust;
        private Panel panel1;
        private Panel panel3;
        private TextBox tb_id;
        private TextBox tb_name;
        private TextBox tb_Address;
        private DataGridView dgv_Sup;
        private TextBox tb_Phone;
    }
}