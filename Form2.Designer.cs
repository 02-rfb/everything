namespace futok1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCim = new System.Windows.Forms.Label();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblCim.AutoSize = true;
            this.lblCim.Location = new System.Drawing.Point(60, 20);
            this.lblCim.Name = "lblCim";
            this.lblCim.Text = "verseny eredmény lista";

            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(30, 50);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(210, 160);
            this.lstEredmeny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstEredmeny_MouseDown);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 240);
            this.Controls.Add(this.lblCim);
            this.Controls.Add(this.lstEredmeny);
            this.Name = "Form2";
            this.Text = "eredmények";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.ListBox lstEredmeny;
    }
}