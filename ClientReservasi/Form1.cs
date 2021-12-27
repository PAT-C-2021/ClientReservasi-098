using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();

            TampilData();
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void TxtBoxIdReservasi_TextChanged(object sender, EventArgs e)
        {

        }

        public void TampilData()
        {
            var List = service.Pemesanan1();
            dataGridView1.DataSource = List;
        }

        public void Clear()
        {
            TxtBoxIdReservasi.Clear();
            TxtNama.Clear();
            TxtTelfon.Clear();
            TxtJml.Clear();
            TxtIdLokasi.Clear();

            TxtJml.Enabled = true;
            TxtIdLokasi.Enabled = true;

            Btnsimpan.Enabled = true;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;

            TxtBoxIdReservasi.Enabled = true;
        }


        private void Btnsimpan_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TxtBoxIdReservasi.Text;
            string NamaCustomer = TxtNama.Text;
            string NoTelpon = TxtTelfon.Text;
            int JumlahPemesanan = int.Parse(TxtJml.Text);
            string IdLokasi = TxtIdLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IdLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TxtBoxIdReservasi.Text;
            string NamaCustomer = TxtNama.Text;
            string NoTelpon = TxtTelfon.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TxtBoxIdReservasi.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtBoxIdReservasi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            TxtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            TxtTelfon.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            TxtJml.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            TxtIdLokasi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            TxtJml.Enabled = false;
            TxtBoxIdReservasi.Enabled = false;

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;

            Btnsimpan.Enabled = false;
            TxtBoxIdReservasi.Enabled = false;
        }
    }
}
