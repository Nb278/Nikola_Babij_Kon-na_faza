using Hotelski_sistem;
using System;
using System.Windows.Forms;
namespace Hotelski_sistem
{
    public partial class Form1 : Form
    {
        private HotelskiSistem sistem = new HotelskiSistem();
        private int stevilka = 100;

        public Form1()
        {
            InitializeComponent();

            rbSoba.Checked = true;

            rbSoba.CheckedChanged += TipChanged;
            rbLuksuz.CheckedChanged += TipChanged;
            rbHiska.CheckedChanged += TipChanged;
            rbSotor.CheckedChanged += TipChanged;
            chkParkirisce.CheckedChanged += ParkirisceChanged;
            btnRezerviraj.Click += Rezerviraj;

            Rezervacija.RezervacijaUstvarjena += r =>
                MessageBox.Show("Rezervacija uspešno ustvarjena!");

            PosodobiKontrole();
        }

        private void TipChanged(object sender, EventArgs e)
        {
            PosodobiKontrole();
        }

        private void ParkirisceChanged(object sender, EventArgs e)
        {
            chkPokrito.Enabled = chkParkirisce.Checked;
            if (!chkParkirisce.Checked)
                chkPokrito.Checked = false;
        }

        private void PosodobiKontrole()
        {
            chkBazen.Enabled = rbLuksuz.Checked;
            if (!rbLuksuz.Checked) chkBazen.Checked = false;

            chkElektrika.Enabled = rbSotor.Checked;
            if (!rbSotor.Checked) chkElektrika.Checked = false;
        }

        private void Rezerviraj(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPriimek.Text))
            {
                MessageBox.Show("Vnesi ime in priimek!");
                return;
            }

            if (numDni.Value <= 0)
            {
                MessageBox.Show("Število dni mora biti veèje od 0!");
                return;
            }

            Gost gost = new Gost(
                txtIme.Text,
                txtPriimek.Text,
                (int)numStarost.Value);

            if (!gost.JePolnoleten())
            {
                MessageBox.Show("Gost mora biti star 18+!");
                return;
            }

            Nastanitev nastanitev;

            if (rbSoba.Checked)
                nastanitev = new Soba(stevilka++, 70);
            else if (rbLuksuz.Checked)
                nastanitev = new LuksuznaSoba(stevilka++, 120, chkBazen.Checked);
            else if (rbHiska.Checked)
                nastanitev = new Hiska(stevilka++, 150);
            else
                nastanitev = new Sotor(stevilka++, 30, chkElektrika.Checked);

            Parkirisce park = null;
            if (chkParkirisce.Checked)
                park = new Parkirisce(chkPokrito.Checked);

            Rezervacija r = new Rezervacija(
                gost, nastanitev, (int)numDni.Value, park);

            sistem.DodajRezervacijo(r);

            listBox1.Items.Add(r.Izpis());
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
