
namespace FoodStoreManagement
{
    partial class SplashFormcs
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.myProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "SHOP N\' GO";
            // 
            // myProgressBar
            // 
            this.myProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.myProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myProgressBar.ForeColor = System.Drawing.Color.White;
            this.myProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.myProgressBar.Location = new System.Drawing.Point(244, 186);
            this.myProgressBar.Minimum = 0;
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myProgressBar.ShadowDecoration.Parent = this.myProgressBar;
            this.myProgressBar.Size = new System.Drawing.Size(159, 159);
            this.myProgressBar.TabIndex = 3;
            this.myProgressBar.Text = "guna2CircleProgressBar1";
            this.myProgressBar.UseTransparentBackground = true;
            this.myProgressBar.ValueChanged += new System.EventHandler(this.myProgressBar_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashFormcs";
            this.Load += new System.EventHandler(this.SplashFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}