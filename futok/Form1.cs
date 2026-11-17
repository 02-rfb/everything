using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace futok1
{
    public class Versenyzo
    {
        public string Rajtszam = "";
        public string Nev = "";
        public DateTime Szuletes;
        public string Orszag = "";
        public string IdoSzoveg = "";   // pl. 40:05.18 (kiíráshoz)
        public double Masodperc;        // az idõ másodpercben (rendezéshez)

        public int Kor
        {
            get { return DateTime.Now.Year - Szuletes.Year; }
        }
    }

    public partial class Form1 : Form
    {
        List<Versenyzo> lista = new List<Versenyzo>();

        public Form1()
        {
            InitializeComponent();
        }

        // "40:05.18" vagy "1:40:05.18" -> másodperc
        double IdoMasodpercben(string ido)
        {
            double mp = 0;
            foreach (string resz in ido.Replace(',', '.').Split(':'))
            {
                mp = mp * 60 + double.Parse(resz, CultureInfo.InvariantCulture);
            }
            return mp;
        }

        void Betolt()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Szöveges fájl|*.txt";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            lista.Clear();
            lstVersenyzok.Items.Clear();

            foreach (string sor in File.ReadAllLines(ofd.FileName))
            {
                if (sor.Trim() == "") continue;
                string[] r = sor.Split(';');

                Versenyzo v = new Versenyzo();
                v.Rajtszam = r[0];
                v.Nev = r[1];
                v.Szuletes = DateTime.Parse(r[2]);
                v.Orszag = r[3];
                v.IdoSzoveg = r[4];
                v.Masodperc = IdoMasodpercben(r[4]);

                lista.Add(v);
                lstVersenyzok.Items.Add(v.Nev);
            }
        }

        private void megnyitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Betolt();
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            Betolt();
        }

        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstVersenyzok.SelectedIndex;
            if (i < 0) return;

            txtRajtszam.Text = lista[i].Rajtszam;
            txtOrszag.Text = lista[i].Orszag;
            txtIdo.Text = lista[i].IdoSzoveg;
            txtEletkor.Text = lista[i].Kor.ToString();
        }

        private void eredmenylistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(lista);
            f.Show();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
