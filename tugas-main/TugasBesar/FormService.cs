using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    public partial class FormService : Form
    {
        int tot = 0;
        int biaya;
        public FormService()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxBiaya.ReadOnly = false;
            textBoxNama.ReadOnly = false;
            buttonTambah.Enabled = true;
            textBoxIDService.Text = null;
            textBoxTotal.Text = null;
            dataGridViewDaftar.DataSource = null;

            var isi = "1234567890";
            var random = new char[8];
            var acak = new Random();

            for (int i = 0; i < random.Length; i++)
            {
                random[i] = isi[acak.Next(isi.Length)];
            }

            textBoxIDService.Text = new string(random);
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            biaya = Convert.ToInt32(textBoxBiaya.Text);
            tot = tot + biaya;
            textBoxTotal.Text = tot.ToString();

            string response;
            Service inputService = new Service();
            inputService.id_service = textBoxIDService.Text;
            inputService.nama_service = textBoxNama.Text;
            inputService.biaya = Convert.ToInt32(textBoxBiaya.Text);
            response = inputService.InsertStruk();
            if (response == null)
            {
                buttonSubmit.Enabled = true;
                textBoxNama.Text = null;
                textBoxBiaya.Text = null;
                ReadData();
            }
            else MessageBox.Show(response);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string response;
            Service inputService = new Service();
            inputService.id_service = textBoxIDService.Text;
            inputService.tgl_service = dateTimePickerTanggal.Value.ToString("yyyyMMdd");
            inputService.total_biaya = Convert.ToInt32(textBoxTotal.Text);
            response = inputService.Insert();
            if (response == null)
            {
                textBoxNama.Text = null;
                textBoxBiaya.Text = null;

                textBoxNama.ReadOnly = true;
                textBoxBiaya.ReadOnly = true;
                buttonTambah.Enabled = false;
                buttonSubmit.Enabled = false;
                buttonCetak.Enabled = true;

                MessageBox.Show("Input data sukses");
            }
            else MessageBox.Show(response);
        }

        private void textBoxNama_Click(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = false;
        }

        private void ReadData()
        {
            Service tabelStruk = new Service();
            DataTable dt = new DataTable();
            tabelStruk.struk = textBoxIDService.Text;
            dt = tabelStruk.ReadStruk();
            dataGridViewDaftar.DataSource = dt;
            dataGridViewDaftar.Show();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            FormCetakBuktiService form = new FormCetakBuktiService(textBoxIDService.Text);
            form.Show();
        }
    }
}
