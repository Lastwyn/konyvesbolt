
namespace konyvesbol
{
    partial class megtekint
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
            this.listBox_megtekint = new System.Windows.Forms.ListBox();
            this.button_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_megtekint
            // 
            this.listBox_megtekint.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_megtekint.FormattingEnabled = true;
            this.listBox_megtekint.Location = new System.Drawing.Point(0, 0);
            this.listBox_megtekint.Name = "listBox_megtekint";
            this.listBox_megtekint.Size = new System.Drawing.Size(800, 355);
            this.listBox_megtekint.TabIndex = 0;
            // 
            // button_vissza
            // 
            this.button_vissza.Location = new System.Drawing.Point(344, 386);
            this.button_vissza.Name = "button_vissza";
            this.button_vissza.Size = new System.Drawing.Size(113, 52);
            this.button_vissza.TabIndex = 1;
            this.button_vissza.Text = "Vissza";
            this.button_vissza.UseVisualStyleBackColor = true;
            this.button_vissza.Click += new System.EventHandler(this.button_vissza_Click);
            // 
            // megtekint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_vissza);
            this.Controls.Add(this.listBox_megtekint);
            this.Name = "megtekint";
            this.Text = "megtekint";
            this.Load += new System.EventHandler(this.megtekint_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_vissza;
        public System.Windows.Forms.ListBox listBox_megtekint;
    }
}