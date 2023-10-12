namespace vetClin
{
    partial class Form1
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
            this.Regist = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Regist
            // 
            this.Regist.Location = new System.Drawing.Point(331, 261);
            this.Regist.Name = "Regist";
            this.Regist.Size = new System.Drawing.Size(119, 59);
            this.Regist.TabIndex = 1;
            this.Regist.Text = "Регистрация";
            this.Regist.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(331, 176);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 63);
            this.login.TabIndex = 2;
            this.login.Text = "Вход";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Regist);
            this.Name = "Form1";
            this.Text = "Форма аунтефикации";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Regist;
        private System.Windows.Forms.Button login;
    }
}

