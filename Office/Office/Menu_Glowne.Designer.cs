namespace Office
{
    partial class Menu_Glowne
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Glowne));
            this.tP_ustawienia = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ustawienia_szukaj = new System.Windows.Forms.Button();
            this.txtB_Ustawienia_szukaj = new System.Windows.Forms.TextBox();
            this.dGV_Ustawienia = new System.Windows.Forms.DataGridView();
            this.gB_Ustawienia_Dane = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_Nazwisko = new System.Windows.Forms.TextBox();
            this.txtB_Imie = new System.Windows.Forms.TextBox();
            this.txtB_Haslo = new System.Windows.Forms.TextBox();
            this.txtB_Login = new System.Windows.Forms.TextBox();
            this.btn_Ustawienia_Usun = new System.Windows.Forms.Button();
            this.btn_Ustawienia_Dodaj = new System.Windows.Forms.Button();
            this.btn_Ustawienia_Modyfikuj = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tP_ustawienia.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ustawienia)).BeginInit();
            this.gB_Ustawienia_Dane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tP_ustawienia
            // 
            this.tP_ustawienia.Controls.Add(this.tabPage2);
            this.tP_ustawienia.Controls.Add(this.tabPage1);
            this.tP_ustawienia.Location = new System.Drawing.Point(5, 3);
            this.tP_ustawienia.Name = "tP_ustawienia";
            this.tP_ustawienia.SelectedIndex = 0;
            this.tP_ustawienia.Size = new System.Drawing.Size(675, 464);
            this.tP_ustawienia.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Ustawienia_szukaj);
            this.tabPage1.Controls.Add(this.txtB_Ustawienia_szukaj);
            this.tabPage1.Controls.Add(this.dGV_Ustawienia);
            this.tabPage1.Controls.Add(this.gB_Ustawienia_Dane);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ustawienia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szukaj";
            // 
            // btn_Ustawienia_szukaj
            // 
            this.btn_Ustawienia_szukaj.Location = new System.Drawing.Point(241, 19);
            this.btn_Ustawienia_szukaj.Name = "btn_Ustawienia_szukaj";
            this.btn_Ustawienia_szukaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Ustawienia_szukaj.TabIndex = 3;
            this.btn_Ustawienia_szukaj.Text = "Szukaj";
            this.btn_Ustawienia_szukaj.UseVisualStyleBackColor = true;
            this.btn_Ustawienia_szukaj.Click += new System.EventHandler(this.btn_Ustawienia_szukaj_Click);
            // 
            // txtB_Ustawienia_szukaj
            // 
            this.txtB_Ustawienia_szukaj.Location = new System.Drawing.Point(16, 20);
            this.txtB_Ustawienia_szukaj.Name = "txtB_Ustawienia_szukaj";
            this.txtB_Ustawienia_szukaj.Size = new System.Drawing.Size(219, 20);
            this.txtB_Ustawienia_szukaj.TabIndex = 2;
            // 
            // dGV_Ustawienia
            // 
            this.dGV_Ustawienia.AllowUserToAddRows = false;
            this.dGV_Ustawienia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Ustawienia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Ustawienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Ustawienia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Ustawienia.Location = new System.Drawing.Point(346, 20);
            this.dGV_Ustawienia.Name = "dGV_Ustawienia";
            this.dGV_Ustawienia.ReadOnly = true;
            this.dGV_Ustawienia.Size = new System.Drawing.Size(290, 390);
            this.dGV_Ustawienia.TabIndex = 1;
            this.dGV_Ustawienia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Ustawienia_CellClick);
            // 
            // gB_Ustawienia_Dane
            // 
            this.gB_Ustawienia_Dane.Controls.Add(this.label5);
            this.gB_Ustawienia_Dane.Controls.Add(this.label4);
            this.gB_Ustawienia_Dane.Controls.Add(this.label3);
            this.gB_Ustawienia_Dane.Controls.Add(this.label2);
            this.gB_Ustawienia_Dane.Controls.Add(this.txtB_Nazwisko);
            this.gB_Ustawienia_Dane.Controls.Add(this.txtB_Imie);
            this.gB_Ustawienia_Dane.Controls.Add(this.txtB_Haslo);
            this.gB_Ustawienia_Dane.Controls.Add(this.txtB_Login);
            this.gB_Ustawienia_Dane.Controls.Add(this.btn_Ustawienia_Usun);
            this.gB_Ustawienia_Dane.Controls.Add(this.btn_Ustawienia_Dodaj);
            this.gB_Ustawienia_Dane.Controls.Add(this.btn_Ustawienia_Modyfikuj);
            this.gB_Ustawienia_Dane.Location = new System.Drawing.Point(16, 48);
            this.gB_Ustawienia_Dane.Name = "gB_Ustawienia_Dane";
            this.gB_Ustawienia_Dane.Size = new System.Drawing.Size(300, 362);
            this.gB_Ustawienia_Dane.TabIndex = 0;
            this.gB_Ustawienia_Dane.TabStop = false;
            this.gB_Ustawienia_Dane.Text = "Dane:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(31, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(31, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasło:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login:";
            // 
            // txtB_Nazwisko
            // 
            this.txtB_Nazwisko.Location = new System.Drawing.Point(34, 238);
            this.txtB_Nazwisko.Name = "txtB_Nazwisko";
            this.txtB_Nazwisko.Size = new System.Drawing.Size(227, 20);
            this.txtB_Nazwisko.TabIndex = 3;
            // 
            // txtB_Imie
            // 
            this.txtB_Imie.Location = new System.Drawing.Point(34, 184);
            this.txtB_Imie.Name = "txtB_Imie";
            this.txtB_Imie.Size = new System.Drawing.Size(227, 20);
            this.txtB_Imie.TabIndex = 3;
            // 
            // txtB_Haslo
            // 
            this.txtB_Haslo.Location = new System.Drawing.Point(34, 130);
            this.txtB_Haslo.Name = "txtB_Haslo";
            this.txtB_Haslo.PasswordChar = '*';
            this.txtB_Haslo.Size = new System.Drawing.Size(227, 20);
            this.txtB_Haslo.TabIndex = 3;
            // 
            // txtB_Login
            // 
            this.txtB_Login.Location = new System.Drawing.Point(34, 76);
            this.txtB_Login.Name = "txtB_Login";
            this.txtB_Login.Size = new System.Drawing.Size(227, 20);
            this.txtB_Login.TabIndex = 3;
            // 
            // btn_Ustawienia_Usun
            // 
            this.btn_Ustawienia_Usun.Location = new System.Drawing.Point(212, 333);
            this.btn_Ustawienia_Usun.Name = "btn_Ustawienia_Usun";
            this.btn_Ustawienia_Usun.Size = new System.Drawing.Size(75, 23);
            this.btn_Ustawienia_Usun.TabIndex = 2;
            this.btn_Ustawienia_Usun.Text = "Usuń";
            this.btn_Ustawienia_Usun.UseVisualStyleBackColor = true;
            // 
            // btn_Ustawienia_Dodaj
            // 
            this.btn_Ustawienia_Dodaj.Location = new System.Drawing.Point(17, 333);
            this.btn_Ustawienia_Dodaj.Name = "btn_Ustawienia_Dodaj";
            this.btn_Ustawienia_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_Ustawienia_Dodaj.TabIndex = 2;
            this.btn_Ustawienia_Dodaj.Text = "Dodaj";
            this.btn_Ustawienia_Dodaj.UseVisualStyleBackColor = true;
            this.btn_Ustawienia_Dodaj.Click += new System.EventHandler(this.btn_Ustawienia_Dodaj_Click);
            // 
            // btn_Ustawienia_Modyfikuj
            // 
            this.btn_Ustawienia_Modyfikuj.Location = new System.Drawing.Point(113, 333);
            this.btn_Ustawienia_Modyfikuj.Name = "btn_Ustawienia_Modyfikuj";
            this.btn_Ustawienia_Modyfikuj.Size = new System.Drawing.Size(75, 23);
            this.btn_Ustawienia_Modyfikuj.TabIndex = 2;
            this.btn_Ustawienia_Modyfikuj.Text = "Modyfikuj";
            this.btn_Ustawienia_Modyfikuj.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usługi";
            // 
            // Menu_Glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(690, 479);
            this.Controls.Add(this.tP_ustawienia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Glowne";
            this.Text = "Menu Główne";
            this.tP_ustawienia.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Ustawienia)).EndInit();
            this.gB_Ustawienia_Dane.ResumeLayout(false);
            this.gB_Ustawienia_Dane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tP_ustawienia;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ustawienia_szukaj;
        private System.Windows.Forms.TextBox txtB_Ustawienia_szukaj;
        private System.Windows.Forms.DataGridView dGV_Ustawienia;
        private System.Windows.Forms.GroupBox gB_Ustawienia_Dane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_Nazwisko;
        private System.Windows.Forms.TextBox txtB_Imie;
        private System.Windows.Forms.TextBox txtB_Haslo;
        private System.Windows.Forms.TextBox txtB_Login;
        private System.Windows.Forms.Button btn_Ustawienia_Usun;
        private System.Windows.Forms.Button btn_Ustawienia_Dodaj;
        private System.Windows.Forms.Button btn_Ustawienia_Modyfikuj;
    }
}