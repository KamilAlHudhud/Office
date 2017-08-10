namespace Office
{
    partial class Form_logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_logowanie));
            this.gB_Logowanie = new System.Windows.Forms.GroupBox();
            this.txtB_login = new System.Windows.Forms.TextBox();
            this.txtB_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_zaloguj = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.gB_Logowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_Logowanie
            // 
            this.gB_Logowanie.Controls.Add(this.btn_anuluj);
            this.gB_Logowanie.Controls.Add(this.btn_zaloguj);
            this.gB_Logowanie.Controls.Add(this.label2);
            this.gB_Logowanie.Controls.Add(this.label1);
            this.gB_Logowanie.Controls.Add(this.txtB_haslo);
            this.gB_Logowanie.Controls.Add(this.txtB_login);
            this.gB_Logowanie.Location = new System.Drawing.Point(12, 12);
            this.gB_Logowanie.Name = "gB_Logowanie";
            this.gB_Logowanie.Size = new System.Drawing.Size(260, 237);
            this.gB_Logowanie.TabIndex = 0;
            this.gB_Logowanie.TabStop = false;
            this.gB_Logowanie.Text = "Logowanie :";
            // 
            // txtB_login
            // 
            this.txtB_login.Location = new System.Drawing.Point(66, 54);
            this.txtB_login.Name = "txtB_login";
            this.txtB_login.Size = new System.Drawing.Size(140, 20);
            this.txtB_login.TabIndex = 0;
            // 
            // txtB_haslo
            // 
            this.txtB_haslo.Location = new System.Drawing.Point(66, 110);
            this.txtB_haslo.Name = "txtB_haslo";
            this.txtB_haslo.Size = new System.Drawing.Size(140, 20);
            this.txtB_haslo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // btn_zaloguj
            // 
            this.btn_zaloguj.Location = new System.Drawing.Point(41, 172);
            this.btn_zaloguj.Name = "btn_zaloguj";
            this.btn_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.btn_zaloguj.TabIndex = 2;
            this.btn_zaloguj.Text = "Zaloguj";
            this.btn_zaloguj.UseVisualStyleBackColor = true;
            this.btn_zaloguj.Click += new System.EventHandler(this.btn_zaloguj_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(152, 172);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(75, 23);
            this.btn_anuluj.TabIndex = 2;
            this.btn_anuluj.Text = "Anuluj";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            // 
            // Form_logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gB_Logowanie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form_logowanie_Load);
            this.gB_Logowanie.ResumeLayout(false);
            this.gB_Logowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_Logowanie;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.Button btn_zaloguj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_haslo;
        private System.Windows.Forms.TextBox txtB_login;
    }
}

