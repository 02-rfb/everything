using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace futok1
{
    public partial class Form2 : Form
    {
        public Form2(List<Versenyzo> lista)
        {
            InitializeComponent();

            // időeredmény szerint csökkenő sorrend
            foreach (Versenyzo v in lista.OrderByDescending(x => x.Masodperc))
            {
                lstEredmeny.Items.Add(v.Nev + ";" + v.IdoSzoveg);
            }
        }

        // jobb klikk a listán -> mentés
        private void lstEredmeny_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                File.WriteAllLines("EREDMENYEK.txt", lstEredmeny.Items.Cast<string>());
                MessageBox.Show("Mentve: EREDMENYEK.txt");
            }
        }
    }
}
