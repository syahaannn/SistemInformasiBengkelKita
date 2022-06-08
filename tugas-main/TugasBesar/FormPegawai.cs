using MySql.Data.MySqlClient;
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
    public partial class FormPegawai : Form
    {
        String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;

        int id_pegawai;
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            panelTambah.Visible = true;
            comboBoxSearch.Enabled = false;
            NewLine();
            NewInput();
            OffButton();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            comboBoxSearch.Enabled = false;
            OffButton();
            NewInput();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            comboBoxSearch.Enabled = false;
            OffButton();
        }

        private void buttonTambahCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonTambahOK_Click(object sender, EventArgs e)
        {
            Pegawai dataPegawai = new Pegawai();
            dataPegawai.nama_pegawai = textBoxNama.Text;
            dataPegawai.tempat_lahir = textBoxTmptLahir.Text;
            dataPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            dataPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            dataPegawai.alamat = textBoxAlamat.Text;

            String response;
            response = dataPegawai.Insert();
            if (response == null) MessageBox.Show("Input data sukses");
            else MessageBox.Show("Input data gagal " + response);

            DataLoad();
        }

        private void buttonUpdateCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonUpdateOK_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai editPegawai = new Pegawai();
            editPegawai.nama_pegawai = textBoxNama.Text;
            editPegawai.tempat_lahir = textBoxTmptLahir.Text;
            editPegawai.tanggal_lahir = dateTimePickerTglLahir.Value.ToString("yyyyMMdd");
            editPegawai.agama = comboBoxAgama.SelectedItem.ToString();
            editPegawai.alamat = textBoxAlamat.Text;
            editPegawai.id_pegawai = id_pegawai;
            response = editPegawai.Update();
            if (response == null) MessageBox.Show("Update data sukses");
            else MessageBox.Show(response);

            DataLoad();
        }

        private void buttonDeleteCancel_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonDeleteOK_Click(object sender, EventArgs e)
        {
            string response;
            Pegawai deletePegawai = new Pegawai();
            deletePegawai.id_pegawai = id_pegawai;
            response = deletePegawai.Delete();
            if (response == null) MessageBox.Show("Hapus data sukses");
            else MessageBox.Show(response);

            DataLoad();
        }

        public void Combobox()
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string id = rdr.GetInt32(1).ToString();
                    comboBoxSearch.Items.Add(nama);
                }
            }
            catch
            {

            }
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            Combobox();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT id_pegawai " +
                "FROM data_pegawai WHERE nama_pegawai = '" + comboBoxSearch.Text + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_pegawai = rdr.GetInt32(0);
                    SelectID(id_pegawai);
                }
            }
            catch
            {

            }
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void NewLine()
        {
            comboBoxSearch.Text = null;
            textBoxNama.Text = null;
            textBoxTmptLahir.Text = null;
            dateTimePickerTglLahir.Text = null;
            comboBoxAgama.Text = "Islam";
            textBoxAlamat.Text = null;
        }

        private void NewInput()
        {
            textBoxNama.ReadOnly = false;
            textBoxTmptLahir.ReadOnly = false;
            dateTimePickerTglLahir.Enabled = true;
            comboBoxAgama.Enabled = true;
            textBoxAlamat.ReadOnly = false;
        }

        private void OffButton()
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void DataLoad()
        {
            FormPegawai form2b = new FormPegawai();
            form2b.TopLevel = false;
            form2b.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form2b);
            form2b.Show();
        }

        private void SelectID(int id)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT nama_pegawai, tempat_lahir, tanggal_lahir, agama, alamat " +
                "FROM data_pegawai WHERE id_pegawai = '" + id + "';", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    string tempat = rdr.GetString(1);
                    DateTime tanggal = rdr.GetDateTime(2);
                    string agama = rdr.GetString(3);
                    string alamat = rdr.GetString(4);
                    textBoxNama.Text = nama;
                    textBoxTmptLahir.Text = tempat;
                    dateTimePickerTglLahir.Value = tanggal;
                    comboBoxAgama.Text = agama;
                    textBoxAlamat.Text = alamat;
                }
            }
            catch
            {

            }
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
        }
    }
}
