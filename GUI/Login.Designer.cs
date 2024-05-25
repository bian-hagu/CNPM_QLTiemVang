namespace QLTiemVang.GUI
{
    partial class fLogin
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
            panel1 = new Panel();
            b_Login = new Button();
            b_Exit = new Button();
            panel3 = new Panel();
            tb_Password = new TextBox();
            t_Password = new Label();
            panel2 = new Panel();
            tb_Username = new TextBox();
            t_Username = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(b_Login);
            panel1.Controls.Add(b_Exit);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 135);
            panel1.TabIndex = 0;
            // 
            // b_Login
            // 
            b_Login.BackColor = Color.Lime;
            b_Login.BackgroundImageLayout = ImageLayout.None;
            b_Login.Location = new Point(260, 98);
            b_Login.Name = "b_Login";
            b_Login.Size = new Size(75, 23);
            b_Login.TabIndex = 2;
            b_Login.Text = "Đăng nhập";
            b_Login.UseVisualStyleBackColor = false;
            b_Login.Click += b_Login_Click;
            // 
            // b_Exit
            // 
            b_Exit.BackColor = SystemColors.Window;
            b_Exit.Location = new Point(341, 98);
            b_Exit.Name = "b_Exit";
            b_Exit.Size = new Size(75, 23);
            b_Exit.TabIndex = 3;
            b_Exit.Text = "Thoát";
            b_Exit.UseVisualStyleBackColor = false;
            b_Exit.Click += b_Exit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_Password);
            panel3.Controls.Add(t_Password);
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(436, 47);
            panel3.TabIndex = 1;
            // 
            // tb_Password
            // 
            tb_Password.Cursor = Cursors.IBeam;
            tb_Password.Location = new Point(140, 11);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(276, 23);
            tb_Password.TabIndex = 1;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // t_Password
            // 
            t_Password.AutoSize = true;
            t_Password.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t_Password.Location = new Point(4, 11);
            t_Password.Name = "t_Password";
            t_Password.Size = new Size(84, 19);
            t_Password.TabIndex = 0;
            t_Password.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_Username);
            panel2.Controls.Add(t_Username);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 39);
            panel2.TabIndex = 0;
            // 
            // tb_Username
            // 
            tb_Username.Cursor = Cursors.IBeam;
            tb_Username.Location = new Point(140, 11);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(276, 23);
            tb_Username.TabIndex = 1;
            // 
            // t_Username
            // 
            t_Username.AutoSize = true;
            t_Username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t_Username.Location = new Point(4, 11);
            t_Username.Name = "t_Username";
            t_Username.Size = new Size(130, 19);
            t_Username.TabIndex = 0;
            t_Username.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 151);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label t_Username;
        private TextBox tb_Username;
        private Panel panel3;
        private TextBox tb_Password;
        private Label t_Password;
        private Button b_Exit;
        private Button b_Login;
    }
}