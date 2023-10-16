
namespace vetClin
{
    partial class Admin
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
            this.Klinika = new System.Windows.Forms.Button();
            this.Sotrudniki = new System.Windows.Forms.Button();
            this.Polsovateli = new System.Windows.Forms.Button();
            this.Diagramma = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saveButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Klinika
            // 
            this.Klinika.Location = new System.Drawing.Point(1, 45);
            this.Klinika.Name = "Klinika";
            this.Klinika.Size = new System.Drawing.Size(129, 23);
            this.Klinika.TabIndex = 0;
            this.Klinika.Text = "Клиника";
            this.Klinika.UseVisualStyleBackColor = true;
            this.Klinika.Click += new System.EventHandler(this.Klinika_Click);
            // 
            // Sotrudniki
            // 
            this.Sotrudniki.Location = new System.Drawing.Point(1, 95);
            this.Sotrudniki.Name = "Sotrudniki";
            this.Sotrudniki.Size = new System.Drawing.Size(129, 23);
            this.Sotrudniki.TabIndex = 1;
            this.Sotrudniki.Text = "Сотрудники";
            this.Sotrudniki.UseVisualStyleBackColor = true;
            this.Sotrudniki.Click += new System.EventHandler(this.Sotrudniki_Click);
            // 
            // Polsovateli
            // 
            this.Polsovateli.Location = new System.Drawing.Point(1, 145);
            this.Polsovateli.Name = "Polsovateli";
            this.Polsovateli.Size = new System.Drawing.Size(129, 23);
            this.Polsovateli.TabIndex = 2;
            this.Polsovateli.Text = "Пользователи";
            this.Polsovateli.UseVisualStyleBackColor = true;
            // 
            // Diagramma
            // 
            this.Diagramma.Location = new System.Drawing.Point(1, 195);
            this.Diagramma.Name = "Diagramma";
            this.Diagramma.Size = new System.Drawing.Size(129, 23);
            this.Diagramma.TabIndex = 3;
            this.Diagramma.Text = "Диаграмма";
            this.Diagramma.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 226);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(85, 372);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(818, 126);
            this.dataGridView2.TabIndex = 5;
            // 
            // saveButt
            // 
            this.saveButt.Location = new System.Drawing.Point(400, 257);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 23);
            this.saveButt.TabIndex = 6;
            this.saveButt.Text = "Сохранить";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 510);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Diagramma);
            this.Controls.Add(this.Polsovateli);
            this.Controls.Add(this.Sotrudniki);
            this.Controls.Add(this.Klinika);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Klinika;
        private System.Windows.Forms.Button Sotrudniki;
        private System.Windows.Forms.Button Polsovateli;
        private System.Windows.Forms.Button Diagramma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button saveButt;
    }
}