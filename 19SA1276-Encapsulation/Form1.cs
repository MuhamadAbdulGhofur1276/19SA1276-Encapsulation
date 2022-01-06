using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19SA1276_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data datakendaraan = new data();
            datakendaraan.plat = "R 1234 G";
            datakendaraan.model = "SupraFit";
            datakendaraan.manufaktur = "HONDA";
            datakendaraan.speed = 100;
            datakendaraan.getbensin = 2;

            tbplat.Text = datakendaraan.plat;
            tbmodel.Text = datakendaraan.model;
            tbmanuf.Text = datakendaraan.manufaktur;
            tbspeed.Text = datakendaraan.speed.ToString();
            tbbensin.Text = datakendaraan.getbensin.ToString();

            tahun tahunproduksi = new tahun();
            tahunproduksi.tahunprod = 2000;
            tbtahunproduksi.Text = tahunproduksi.tahunprod.ToString();

        }

        private void btgas_Click(object sender, EventArgs e)
        {
            data datakendaraan = new data();
            string mobil;
            mobil = datakendaraan.gas(cbgasdanrem.SelectedItem.ToString());
            tbhasil.Text = "Motorku melaju dengan = " + mobil;
        }

        private void btrem_Click(object sender, EventArgs e)
        {
            data datakendaraan = new data();
            string mobil;
            mobil = datakendaraan.gas(cbgasdanrem.SelectedItem.ToString());
            tbhasil.Text = "Motorku berhenti secara = " + mobil;
        }
    }
}
