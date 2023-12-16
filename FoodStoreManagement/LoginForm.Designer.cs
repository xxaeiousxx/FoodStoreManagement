
namespace FoodStoreManagement
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.label_clear = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN TO SHOP N\' GO";
            // 
            // TextBox_username
            // 
            this.TextBox_username.BorderColor = System.Drawing.Color.Empty;
            this.TextBox_username.BorderThickness = 0;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = null;
            this.TextBox_username.FillColor = System.Drawing.Color.Empty;
            this.TextBox_username.ForeColor = System.Drawing.Color.Empty;
            this.TextBox_username.HideSelection = false;
            this.TextBox_username.IconLeftCursor = null;
            this.TextBox_username.IconLeftSize = new System.Drawing.Size(0, 0);
            this.TextBox_username.IconRightCursor = null;
            this.TextBox_username.IconRightSize = new System.Drawing.Size(0, 0);
            this.TextBox_username.Location = new System.Drawing.Point(282, 169);
            this.TextBox_username.MaxLength = 0;
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_username.PlaceholderText = null;
            this.TextBox_username.SelectedText = null;
            this.TextBox_username.ShortcutsEnabled = false;
            this.TextBox_username.Size = new System.Drawing.Size(154, 24);
            this.TextBox_username.TabIndex = 3;
            this.TextBox_username.WordWrap = false;
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderColor = System.Drawing.Color.Empty;
            this.TextBox_password.BorderThickness = 0;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = null;
            this.TextBox_password.FillColor = System.Drawing.Color.Empty;
            this.TextBox_password.ForeColor = System.Drawing.Color.Empty;
            this.TextBox_password.HideSelection = false;
            this.TextBox_password.IconLeftCursor = null;
            this.TextBox_password.IconLeftSize = new System.Drawing.Size(0, 0);
            this.TextBox_password.IconRightCursor = null;
            this.TextBox_password.IconRightSize = new System.Drawing.Size(0, 0);
            this.TextBox_password.Location = new System.Drawing.Point(282, 206);
            this.TextBox_password.MaxLength = 0;
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBox_password.PlaceholderText = null;
            this.TextBox_password.SelectedText = null;
            this.TextBox_password.ShortcutsEnabled = false;
            this.TextBox_password.Size = new System.Drawing.Size(154, 24);
            this.TextBox_password.TabIndex = 3;
            this.TextBox_password.WordWrap = false;
            this.TextBox_password.TextChanged += new System.EventHandler(this.TextBox_password_TextChanged);
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_login.BorderColor = System.Drawing.Color.Empty;
            this.Button_login.FillColor = System.Drawing.Color.Empty;
            this.Button_login.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.Black;
            this.Button_login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_login.ImageSize = new System.Drawing.Size(0, 0);
            this.Button_login.Location = new System.Drawing.Point(0, 0);
            this.Button_login.Name = "Button_login";
            this.Button_login.PressedColor = System.Drawing.Color.Empty;
            this.Button_login.PressedDepth = 0;
            this.Button_login.Size = new System.Drawing.Size(0, 0);
            this.Button_login.TabIndex = 4;
            this.Button_login.Text = null;
            this.Button_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_login.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.White;
            this.label_clear.Location = new System.Drawing.Point(377, 233);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(59, 25);
            this.label_clear.TabIndex = 5;
            this.label_clear.Text = "Clear";
            this.label_clear.Click += new System.EventHandler(this.label_clear_Click);
            this.label_clear.MouseEnter += new System.EventHandler(this.label_clear_MouseEnter);
            this.label_clear.MouseLeave += new System.EventHandler(this.label_clear_MouseLeave);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(611, 2);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 38);
            this.label_exit.TabIndex = 6;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.ForeColor = System.Drawing.Color.Black;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "ADMIN",
            "CUSTOMER"});
            this.comboBox_role.Location = new System.Drawing.Point(282, 135);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(154, 25);
            this.comboBox_role.TabIndex = 7;
            this.comboBox_role.Text = "Select User";
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.ComboBox comboBox_role;
    }
}

