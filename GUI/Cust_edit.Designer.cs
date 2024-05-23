namespace QLTiemVang.GUI
{
    partial class fCust_edit
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
            l_ID = new Label();
            tb_ID = new TextBox();
            tb_Name = new TextBox();
            l_Name = new Label();
            tb_Phone = new TextBox();
            l_Phone = new Label();
            label1 = new Label();
            b_Cencel = new Button();
            b_OK = new Button();
            SuspendLayout();
            // 
            // l_ID
            // 
            l_ID.AutoSize = true;
            l_ID.Location = new Point(23, 22);
            l_ID.Name = "l_ID";
            l_ID.Size = new Size(89, 15);
            l_ID.TabIndex = 0;
            l_ID.Text = "Mã khách hàng";
            // 
            // tb_ID
            // 
            tb_ID.BackColor = Color.LightGray;
            tb_ID.Location = new Point(118, 19);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(295, 23);
            tb_ID.TabIndex = 1;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(118, 59);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(295, 23);
            tb_Name.TabIndex = 3;
            // 
            // l_Name
            // 
            l_Name.AutoSize = true;
            l_Name.Location = new Point(22, 62);
            l_Name.Name = "l_Name";
            l_Name.Size = new Size(90, 15);
            l_Name.TabIndex = 2;
            l_Name.Text = "Tên khách hàng";
            // 
            // tb_Phone
            // 
            tb_Phone.Location = new Point(118, 102);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(295, 23);
            tb_Phone.TabIndex = 5;
            // 
            // l_Phone
            // 
            l_Phone.AutoSize = true;
            l_Phone.Location = new Point(36, 105);
            l_Phone.Name = "l_Phone";
            l_Phone.Size = new Size(76, 15);
            l_Phone.TabIndex = 4;
            l_Phone.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = " (không sửa)";
            // 
            // b_Cencel
            // 
            b_Cencel.Location = new Point(118, 147);
            b_Cencel.Name = "b_Cencel";
            b_Cencel.Size = new Size(92, 27);
            b_Cencel.TabIndex = 7;
            b_Cencel.Text = "Thoát";
            b_Cencel.UseVisualStyleBackColor = true;
            b_Cencel.Click += b_Cencel_Click;
            // 
            // b_OK
            // 
            b_OK.AccessibleRole = AccessibleRole.None;
            b_OK.BackColor = Color.Lime;
            b_OK.Location = new Point(249, 147);
            b_OK.Name = "b_OK";
            b_OK.Size = new Size(92, 27);
            b_OK.TabIndex = 8;
            b_OK.Text = "Đồng ý";
            b_OK.UseVisualStyleBackColor = false;
            b_OK.Click += b_OK_Click;
            // 
            // fCust_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 185);
            Controls.Add(b_OK);
            Controls.Add(b_Cencel);
            Controls.Add(label1);
            Controls.Add(tb_Phone);
            Controls.Add(l_Phone);
            Controls.Add(tb_Name);
            Controls.Add(l_Name);
            Controls.Add(tb_ID);
            Controls.Add(l_ID);
            Name = "fCust_edit";
            Text = "Chỉnh sủa thông tin khách hàng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_ID;
        private TextBox tb_ID;
        private TextBox tb_Name;
        private Label l_Name;
        private TextBox tb_Phone;
        private Label l_Phone;
        private Label label1;
        private Button b_Cencel;
        private Button b_OK;
    }
}