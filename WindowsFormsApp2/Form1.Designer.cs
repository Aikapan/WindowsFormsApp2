namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Import_Reisezeit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Listtest = new System.Windows.Forms.ListBox();
            this.TestFiles = new System.Windows.Forms.ListBox();
            this.Aktualisieren = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sync
            // 
            this.Sync.Location = new System.Drawing.Point(56, 105);
            this.Sync.Name = "Sync";
            this.Sync.Size = new System.Drawing.Size(147, 53);
            this.Sync.TabIndex = 0;
            this.Sync.Text = "Sync";
            this.Sync.UseVisualStyleBackColor = true;
            this.Sync.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(259, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administratorplattform ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Import_Reisezeit
            // 
            this.Import_Reisezeit.Location = new System.Drawing.Point(539, 277);
            this.Import_Reisezeit.Name = "Import_Reisezeit";
            this.Import_Reisezeit.Size = new System.Drawing.Size(147, 53);
            this.Import_Reisezeit.TabIndex = 2;
            this.Import_Reisezeit.Text = "Import Reisezeit";
            this.Import_Reisezeit.UseVisualStyleBackColor = true;
            this.Import_Reisezeit.Click += new System.EventHandler(this.Import_Reisezeit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Listtest
            // 
            this.Listtest.FormattingEnabled = true;
            this.Listtest.ItemHeight = 16;
            this.Listtest.Location = new System.Drawing.Point(34, 182);
            this.Listtest.Name = "Listtest";
            this.Listtest.Size = new System.Drawing.Size(169, 148);
            this.Listtest.TabIndex = 4;
            // 
            // TestFiles
            // 
            this.TestFiles.FormattingEnabled = true;
            this.TestFiles.ItemHeight = 16;
            this.TestFiles.Location = new System.Drawing.Point(209, 182);
            this.TestFiles.Name = "TestFiles";
            this.TestFiles.Size = new System.Drawing.Size(302, 148);
            this.TestFiles.TabIndex = 5;
            // 
            // Aktualisieren
            // 
            this.Aktualisieren.Location = new System.Drawing.Point(281, 109);
            this.Aktualisieren.Name = "Aktualisieren";
            this.Aktualisieren.Size = new System.Drawing.Size(133, 44);
            this.Aktualisieren.TabIndex = 6;
            this.Aktualisieren.Text = "Aktualisieren";
            this.Aktualisieren.UseVisualStyleBackColor = true;
            this.Aktualisieren.Click += new System.EventHandler(this.Aktualisieren_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(517, 194);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(106, 22);
            this.tb1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.Aktualisieren);
            this.Controls.Add(this.TestFiles);
            this.Controls.Add(this.Listtest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Import_Reisezeit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Import_Reisezeit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Listtest;
        private System.Windows.Forms.ListBox TestFiles;
        private System.Windows.Forms.Button Aktualisieren;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

