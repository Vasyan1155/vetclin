namespace vetClin
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.хозяинтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хозяинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id_onwer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_onwer,
            this.Name,
            this.Phone,
            this.adres});
            this.dataGridView1.Location = new System.Drawing.Point(340, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 125);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хозяинтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 554);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // хозяинтToolStripMenuItem
            // 
            this.хозяинтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хозяинToolStripMenuItem});
            this.хозяинтToolStripMenuItem.Name = "хозяинтToolStripMenuItem";
            this.хозяинтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.хозяинтToolStripMenuItem.Text = "Хозяин";
            this.хозяинтToolStripMenuItem.Click += new System.EventHandler(this.хозяинтToolStripMenuItem_Click);
            // 
            // хозяинToolStripMenuItem
            // 
            this.хозяинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.животноеToolStripMenuItem});
            this.хозяинToolStripMenuItem.Name = "хозяинToolStripMenuItem";
            this.хозяинToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.хозяинToolStripMenuItem.Text = "Животное";
            this.хозяинToolStripMenuItem.Click += new System.EventHandler(this.хозяинToolStripMenuItem_Click);
            // 
            // животноеToolStripMenuItem
            // 
            this.животноеToolStripMenuItem.Name = "животноеToolStripMenuItem";
            this.животноеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.животноеToolStripMenuItem.Text = "Карта животного";
            this.животноеToolStripMenuItem.Click += new System.EventHandler(this.животноеToolStripMenuItem_Click);
            // 
            // id_onwer
            // 
            this.id_onwer.HeaderText = "id_onwer";
            this.id_onwer.Name = "id_onwer";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // adres
            // 
            this.adres.HeaderText = "adres";
            this.adres.Name = "adres";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem хозяинтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хозяинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животноеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_onwer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
    }
}