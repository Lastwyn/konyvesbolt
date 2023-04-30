
namespace konyvesbol
{
    partial class Könyvesbolt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.könyvekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlásokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megtekintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_konyvek = new System.Windows.Forms.ListBox();
            this.listBox_vasarlok = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.könyvekToolStripMenuItem,
            this.vásárlókToolStripMenuItem,
            this.vásárlásokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // könyvekToolStripMenuItem
            // 
            this.könyvekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.könyvekToolStripMenuItem.Name = "könyvekToolStripMenuItem";
            this.könyvekToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.könyvekToolStripMenuItem.Text = "Könyvek";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // vásárlókToolStripMenuItem
            // 
            this.vásárlókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.módosításToolStripMenuItem1,
            this.törlésToolStripMenuItem1});
            this.vásárlókToolStripMenuItem.Name = "vásárlókToolStripMenuItem";
            this.vásárlókToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vásárlókToolStripMenuItem.Text = "Vásárlók";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem1.Text = "Új";
            this.újToolStripMenuItem1.Click += new System.EventHandler(this.újToolStripMenuItem1_Click);
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            this.módosításToolStripMenuItem1.Click += new System.EventHandler(this.módosításToolStripMenuItem1_Click);
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            this.törlésToolStripMenuItem1.Click += new System.EventHandler(this.törlésToolStripMenuItem1_Click);
            // 
            // vásárlásokToolStripMenuItem
            // 
            this.vásárlásokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megtekintToolStripMenuItem});
            this.vásárlásokToolStripMenuItem.Name = "vásárlásokToolStripMenuItem";
            this.vásárlásokToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.vásárlásokToolStripMenuItem.Text = "Vásárlások";
            this.vásárlásokToolStripMenuItem.Click += new System.EventHandler(this.vásárlásokToolStripMenuItem_Click);
            // 
            // megtekintToolStripMenuItem
            // 
            this.megtekintToolStripMenuItem.Name = "megtekintToolStripMenuItem";
            this.megtekintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megtekintToolStripMenuItem.Text = "Megtekint";
            this.megtekintToolStripMenuItem.Click += new System.EventHandler(this.megtekintToolStripMenuItem_Click);
            // 
            // listBox_konyvek
            // 
            this.listBox_konyvek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_konyvek.FormattingEnabled = true;
            this.listBox_konyvek.Location = new System.Drawing.Point(0, 24);
            this.listBox_konyvek.Name = "listBox_konyvek";
            this.listBox_konyvek.Size = new System.Drawing.Size(338, 426);
            this.listBox_konyvek.TabIndex = 1;
            // 
            // listBox_vasarlok
            // 
            this.listBox_vasarlok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_vasarlok.FormattingEnabled = true;
            this.listBox_vasarlok.Location = new System.Drawing.Point(445, 24);
            this.listBox_vasarlok.Name = "listBox_vasarlok";
            this.listBox_vasarlok.Size = new System.Drawing.Size(355, 426);
            this.listBox_vasarlok.TabIndex = 2;
            // 
            // Könyvesbolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_vasarlok);
            this.Controls.Add(this.listBox_konyvek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Könyvesbolt";
            this.Text = "Könyvesbolt";
            this.Load += new System.EventHandler(this.Könyvesbolt_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem könyvekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlókToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_konyvek;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vásárlásokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megtekintToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_vasarlok;
    }
}

