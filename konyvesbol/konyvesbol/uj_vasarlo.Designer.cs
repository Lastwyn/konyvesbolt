
namespace konyvesbol
{
    partial class uj_vasarlo
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
            this.ujvasarlo = new System.Windows.Forms.Button();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.textBox_felhasznalonev = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Jelszó:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email Cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Születési dátum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Név:";
            // 
            // ujvasarlo
            // 
            this.ujvasarlo.Location = new System.Drawing.Point(326, 347);
            this.ujvasarlo.Name = "ujvasarlo";
            this.ujvasarlo.Size = new System.Drawing.Size(180, 64);
            this.ujvasarlo.TabIndex = 31;
            this.ujvasarlo.Text = "Hozzáadás";
            this.ujvasarlo.UseVisualStyleBackColor = true;
            this.ujvasarlo.Click += new System.EventHandler(this.ujvasarlo_Click);
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(350, 299);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(134, 20);
            this.textBox_jelszo.TabIndex = 25;
            // 
            // textBox_felhasznalonev
            // 
            this.textBox_felhasznalonev.Location = new System.Drawing.Point(350, 243);
            this.textBox_felhasznalonev.Name = "textBox_felhasznalonev";
            this.textBox_felhasznalonev.Size = new System.Drawing.Size(134, 20);
            this.textBox_felhasznalonev.TabIndex = 24;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(350, 182);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(134, 20);
            this.textBox_email.TabIndex = 23;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(350, 63);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(134, 20);
            this.textBox_nev.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // uj_vasarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ujvasarlo);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_felhasznalonev);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_nev);
            this.Name = "uj_vasarlo";
            this.Text = "uj_vasarlo";
            this.Load += new System.EventHandler(this.uj_vasarlo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ujvasarlo;
        public System.Windows.Forms.TextBox textBox_jelszo;
        public System.Windows.Forms.TextBox textBox_felhasznalonev;
        public System.Windows.Forms.TextBox textBox_email;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}