
namespace konyvesbol
{
    partial class modosit_vasarlo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vasarlomodositas = new System.Windows.Forms.Button();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_vasarloid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Jelszó:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Email Cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Születési dátum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Név:";
            // 
            // vasarlomodositas
            // 
            this.vasarlomodositas.Location = new System.Drawing.Point(310, 343);
            this.vasarlomodositas.Name = "vasarlomodositas";
            this.vasarlomodositas.Size = new System.Drawing.Size(180, 64);
            this.vasarlomodositas.TabIndex = 42;
            this.vasarlomodositas.Text = "Módosítás";
            this.vasarlomodositas.UseVisualStyleBackColor = true;
            this.vasarlomodositas.Click += new System.EventHandler(this.vasarlomodositas_Click);
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(334, 295);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(134, 20);
            this.textBox_jelszo.TabIndex = 41;
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(334, 239);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(134, 20);
            this.textBox_felhasznalonev.TabIndex = 40;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(334, 178);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(134, 20);
            this.textBox_email.TabIndex = 39;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(334, 59);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(134, 20);
            this.textBox_nev.TabIndex = 37;
            // 
            // textBox_vasarloid
            // 
            this.textBox_vasarloid.Location = new System.Drawing.Point(553, 178);
            this.textBox_vasarloid.Name = "textBox_vasarloid";
            this.textBox_vasarloid.ReadOnly = true;
            this.textBox_vasarloid.Size = new System.Drawing.Size(134, 20);
            this.textBox_vasarloid.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Vásárló Id:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // modosit_vasarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_vasarloid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vasarlomodositas);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_nev);
            this.Name = "modosit_vasarlo";
            this.Text = "modosit_vasarlo";
            this.Load += new System.EventHandler(this.modosit_vasarlo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vasarlomodositas;
        public System.Windows.Forms.TextBox textBox_jelszo;
        public System.Windows.Forms.TextBox textBox_felhasznalonev;
        public System.Windows.Forms.TextBox textBox_email;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.TextBox textBox_vasarloid;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}