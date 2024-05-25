namespace QLTiemVang.GUI
{
    partial class fSup_edit
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
            b_OK = new Button();
            b_Cencel = new Button();
            label1 = new Label();
            tb_Address = new TextBox();
            l_Address = new Label();
            tb_Name = new TextBox();
            l_Name = new Label();
            tb_ID = new TextBox();
            l_ID = new Label();
            tb_Phone = new TextBox();
            l_Phone = new Label();
            SuspendLayout();
            // 
            // b_OK
            // 
            b_OK.AccessibleRole = AccessibleRole.None;
            b_OK.BackColor = Color.Lime;
            b_OK.Location = new Point(252, 183);
            b_OK.Name = "b_OK";
            b_OK.Size = new Size(92, 27);
            b_OK.TabIndex = 17;
            b_OK.Text = "Đồng ý";
            b_OK.UseVisualStyleBackColor = false;
            b_OK.Click += b_OK_Click;
            // 
            // b_Cencel
            // 
            b_Cencel.Location = new Point(121, 183);
            b_Cencel.Name = "b_Cencel";
            b_Cencel.Size = new Size(92, 27);
            b_Cencel.TabIndex = 16;
            b_Cencel.Text = "Thoát";
            b_Cencel.UseVisualStyleBackColor = true;
            b_Cencel.Click += b_Cencel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = " (không sửa)";
            // 
            // tb_Address
            // 
            tb_Address.Location = new Point(121, 98);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(295, 23);
            tb_Address.TabIndex = 14;
            // 
            // l_Address
            // 
            l_Address.AutoSize = true;
            l_Address.Location = new Point(72, 98);
            l_Address.Name = "l_Address";
            l_Address.Size = new Size(43, 15);
            l_Address.TabIndex = 13;
            l_Address.Text = "Địa chỉ";
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(121, 55);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(295, 23);
            tb_Name.TabIndex = 12;
            // 
            // l_Name
            // 
            l_Name.AutoSize = true;
            l_Name.Location = new Point(15, 58);
            l_Name.Name = "l_Name";
            l_Name.Size = new Size(100, 15);
            l_Name.TabIndex = 11;
            l_Name.Text = "Tên nhà cung cấp";
            // 
            // tb_ID
            // 
            tb_ID.BackColor = Color.LightGray;
            tb_ID.Location = new Point(121, 15);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(295, 23);
            tb_ID.TabIndex = 10;
            // 
            // l_ID
            // 
            l_ID.AutoSize = true;
            l_ID.Location = new Point(16, 18);
            l_ID.Name = "l_ID";
            l_ID.Size = new Size(99, 15);
            l_ID.TabIndex = 9;
            l_ID.Text = "Mã nhà cung cấp";
            // 
            // tb_Phone
            // 
            tb_Phone.Location = new Point(120, 143);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(295, 23);
            tb_Phone.TabIndex = 19;
            // 
            // l_Phone
            // 
            l_Phone.AutoSize = true;
            l_Phone.Location = new Point(39, 146);
            l_Phone.Name = "l_Phone";
            l_Phone.Size = new Size(76, 15);
            l_Phone.TabIndex = 18;
            l_Phone.Text = "Số điện thoại";
            // 
            // fSup_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 228);
            Controls.Add(tb_Phone);
            Controls.Add(l_Phone);
            Controls.Add(b_OK);
            Controls.Add(b_Cencel);
            Controls.Add(label1);
            Controls.Add(tb_Address);
            Controls.Add(l_Address);
            Controls.Add(tb_Name);
            Controls.Add(l_Name);
            Controls.Add(tb_ID);
            Controls.Add(l_ID);
            Name = "fSup_edit";
            Text = "Chỉnh sửa thông tin nhà cung cấp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_OK;
        private Button b_Cencel;
        private Label label1;
        private TextBox tb_Address;
        private Label l_Address;
        private TextBox tb_Name;
        private Label l_Name;
        private TextBox tb_ID;
        private Label l_ID;
        private TextBox tb_Phone;
        private Label l_Phone;
    }
}