namespace futok1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenylistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCim = new System.Windows.Forms.Label();
            this.lblResztvevok = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.lblRajtszam = new System.Windows.Forms.Label();
            this.lblOrszag = new System.Windows.Forms.Label();
            this.lblIdo = new System.Windows.Forms.Label();
            this.lblEletkor = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdo = new System.Windows.Forms.TextBox();
            this.txtEletkor = new System.Windows.Forms.TextBox();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fajlToolStripMenuItem,
                this.eredmenylistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);

            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.megnyitToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Text = "Fájl";

            this.megnyitToolStripMenuItem.Name = "megnyitToolStripMenuItem";
            this.megnyitToolStripMenuItem.Text = "Megnyit";
            this.megnyitToolStripMenuItem.Click += new System.EventHandler(this.megnyitToolStripMenuItem_Click);

            this.eredmenylistaToolStripMenuItem.Name = "eredmenylistaToolStripMenuItem";
            this.eredmenylistaToolStripMenuItem.Text = "Eredménylista";
            this.eredmenylistaToolStripMenuItem.Click += new System.EventHandler(this.eredmenylistaToolStripMenuItem_Click);

            // címkék
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCim.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCim.Location = new System.Drawing.Point(120, 35);
            this.lblCim.Name = "lblCim";
            this.lblCim.Text = "Maratoni futóverseny";

            this.lblResztvevok.AutoSize = true;
            this.lblResztvevok.Location = new System.Drawing.Point(20, 75);
            this.lblResztvevok.Name = "lblResztvevok";
            this.lblResztvevok.Text = "RÉSZTVEVŐK";

            // lista
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(20, 95);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(150, 225);
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);

            this.lblRajtszam.AutoSize = true;
            this.lblRajtszam.Location = new System.Drawing.Point(190, 100);
            this.lblRajtszam.Name = "lblRajtszam";
            this.lblRajtszam.Text = "Rajtszám";

            this.lblOrszag.AutoSize = true;
            this.lblOrszag.Location = new System.Drawing.Point(190, 160);
            this.lblOrszag.Name = "lblOrszag";
            this.lblOrszag.Text = "ország";

            this.lblIdo.AutoSize = true;
            this.lblIdo.Location = new System.Drawing.Point(190, 220);
            this.lblIdo.Name = "lblIdo";
            this.lblIdo.Text = "időeredmény";

            this.lblEletkor.AutoSize = true;
            this.lblEletkor.Location = new System.Drawing.Point(190, 280);
            this.lblEletkor.Name = "lblEletkor";
            this.lblEletkor.Text = "életkor";

            // szövegdobozok
            this.txtRajtszam.Location = new System.Drawing.Point(280, 97);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.ReadOnly = true;
            this.txtRajtszam.Size = new System.Drawing.Size(140, 20);

            this.txtOrszag.Location = new System.Drawing.Point(280, 157);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.ReadOnly = true;
            this.txtOrszag.Size = new System.Drawing.Size(140, 20);

            this.txtIdo.Location = new System.Drawing.Point(280, 217);
            this.txtIdo.Name = "txtIdo";
            this.txtIdo.ReadOnly = true;
            this.txtIdo.Size = new System.Drawing.Size(140, 20);

            this.txtEletkor.Location = new System.Drawing.Point(280, 277);
            this.txtEletkor.Name = "txtEletkor";
            this.txtEletkor.ReadOnly = true;
            this.txtEletkor.Size = new System.Drawing.Size(140, 20);

            // gombok
            this.btnAdatBe.Location = new System.Drawing.Point(20, 335);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(120, 25);
            this.btnAdatBe.Text = "adatBe";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);

            this.btnBezar.Location = new System.Drawing.Point(280, 335);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(120, 25);
            this.btnBezar.Text = "bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.lblResztvevok);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.lblRajtszam);
            this.Controls.Add(this.lblOrszag);
            this.Controls.Add(this.lblIdo);
            this.Controls.Add(this.lblEletkor);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtIdo);
            this.Controls.Add(this.txtEletkor);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnBezar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "futóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredmenylistaToolStripMenuItem;
        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label lblResztvevok;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label lblRajtszam;
        private System.Windows.Forms.Label lblOrszag;
        private System.Windows.Forms.Label lblIdo;
        private System.Windows.Forms.Label lblEletkor;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdo;
        private System.Windows.Forms.TextBox txtEletkor;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
    }
}