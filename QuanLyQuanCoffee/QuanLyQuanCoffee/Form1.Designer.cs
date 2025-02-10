namespace QuanLyQuanCoffee
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.txt_PassWord = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.DeepPink;
			this.label1.Location = new System.Drawing.Point(238, 361);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Đăng Nhập:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.DeepPink;
			this.label2.Location = new System.Drawing.Point(242, 447);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 42);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu:";
			// 
			// txt_User
			// 
			this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_User.ForeColor = System.Drawing.Color.DeepPink;
			this.txt_User.Location = new System.Drawing.Point(566, 352);
			this.txt_User.Multiline = true;
			this.txt_User.Name = "txt_User";
			this.txt_User.Size = new System.Drawing.Size(325, 49);
			this.txt_User.TabIndex = 1;
			this.txt_User.Text = "NV002";
			// 
			// txt_PassWord
			// 
			this.txt_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_PassWord.ForeColor = System.Drawing.Color.DeepPink;
			this.txt_PassWord.Location = new System.Drawing.Point(484, 442);
			this.txt_PassWord.Multiline = true;
			this.txt_PassWord.Name = "txt_PassWord";
			this.txt_PassWord.PasswordChar = '*';
			this.txt_PassWord.Size = new System.Drawing.Size(406, 49);
			this.txt_PassWord.TabIndex = 2;
			this.txt_PassWord.Text = "1234";
			// 
			// btn_Login
			// 
			this.btn_Login.BackColor = System.Drawing.Color.White;
			this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.ForeColor = System.Drawing.Color.DeepPink;
			this.btn_Login.Location = new System.Drawing.Point(318, 548);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(236, 67);
			this.btn_Login.TabIndex = 3;
			this.btn_Login.Text = "Đăng nhập";
			this.btn_Login.UseVisualStyleBackColor = false;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackColor = System.Drawing.Color.White;
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Exit.ForeColor = System.Drawing.Color.DeepPink;
			this.btn_Exit.Location = new System.Drawing.Point(650, 548);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(176, 67);
			this.btn_Exit.TabIndex = 3;
			this.btn_Exit.Text = "Thoát";
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.DeepPink;
			this.label4.Location = new System.Drawing.Point(478, 644);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(230, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Quên mật khẩu ?";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(352, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(457, 92);
			this.label3.TabIndex = 5;
			this.label3.Text = " Đăng Nhập";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1134, 770);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_PassWord);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

