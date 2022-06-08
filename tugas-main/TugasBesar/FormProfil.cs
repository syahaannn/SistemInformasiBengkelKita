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
    public partial class FormProfil : Form
    {
        Akun akun;
        Pegawai pegawai;
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        String pw, pwBaru;
        int role, id, id_;
        public FormProfil(Akun akun)
        {
            InitializeComponent();
            this.akun = akun;
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
            label5.Visible = true;
            label6.Visible = true;
            labelAdmin.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label5.Enabled = false;
            panelUbahUsername.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
            panelUbahPassword.Visible = true;
            label6.Enabled = false;
        }

        private void buttonOKPWLama_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxKonfirmasiUbahPassword.Text)
            {
                textBoxUbahPasswordBaru.Visible = true;
                textBoxKonfirmasiUbahPasswordBaru.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                buttonOKUbahPassword.Visible = true;
                buttonCancelUbahPassword.Visible = true;
            }
            else
            {
                textBoxKonfirmasiUbahPassword.Text = null;
            }
        }

        private void buttonOKUbahPassword_Click(object sender, EventArgs e)
        {
            if(textBoxUbahPasswordBaru.Text == textBoxKonfirmasiUbahPasswordBaru.Text)
            {
                string response;
                Akun akun = new Akun();
                akun.id_user = pegawai.id_user;
                akun.password = textBoxKonfirmasiUbahPasswordBaru.Text;
                response = akun.Update();
                if (response == null)
                {
                    MessageBox.Show("Update password sukses");
                    DataLoad();
                }
                else
                {
                    MessageBox.Show(response);
                    textBoxKonfirmasiUbahPasswordBaru.Text = null;
                }
            }
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            ComboBox();
            ComboBoxUser();
            pegawai = new Pegawai();
            pegawai = Pegawai.Select(akun.id_pegawai);
            textBoxNama.Text = pegawai.nama_pegawai;
            textBoxUsername.Text = pegawai.username;
            textBoxPassword.Text = pegawai.password;
            if (pegawai.role == 1)
            {
                labelAdmin.Visible = true;
            }
            else
            {
                labelAdmin.Visible = false;
            }
        }

        private void buttonCancelUbahPassword_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void buttonOKUbahUsername_Click(object sender, EventArgs e)
        {
            string response;
            akun = new Akun();
            akun.id_user = pegawai.id_user;
            akun.usernamebaru = textBoxUbahUsername.Text;
            response = akun.UbahUsername();
            if (response == null)
            {
                MessageBox.Show("Update username sukses");
            }
            else
            {
                MessageBox.Show(response);
            }
            DataLoad();
        }

        private void buttonCancelUbahUsername_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            labelAdmin.ForeColor = Color.Red;
            labelTambahAKun.Visible = true;
            label4.Enabled = false;
            labelHapusAkun.Visible = true;
        }

        private void labelTambahAKun_Click(object sender, EventArgs e)
        {
            labelHapusAkun.Enabled = false;
            labelAdmin.ForeColor = Color.Red;
            panelTambahAkun.Visible = true;
        }

        private void buttonOKTambahAkun_Click(object sender, EventArgs e)
        {
            string response;
            pw = textBoxPasswordBaru.Text;
            pwBaru = textBoxKonfirmasiPasswordBaru.Text;
            if (pw == pwBaru) pw = textBoxKonfirmasiPasswordBaru.Text;
            else pw = null;
            if (comboBoxRole.Text == "Admin") role = 1;
            else if (comboBoxRole.Text == "Kasir") role = 2;
            Akun akun = new Akun();
            akun.username = textBoxUsernameBaru.Text;
            akun.password = pw;
            akun.role = role;
            akun.id_pegawai = id;
            response = akun.Insert();
            if (response == null)
            {
                MessageBox.Show("Insert data sukses");
                DataLoad();
            }
            else MessageBox.Show(response);
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai " +
                "WHERE nama_pegawai = '" + comboBoxNama.Text + "'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id = rdr.GetInt32(1);
                }
            }
            catch { }
        }

        private void buttonCancelTambahAkun_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void labelHapusAkun_Click(object sender, EventArgs e)
        {
            labelTambahAKun.Enabled = false;
            panelHapusAkun.Visible = true;
        }

        private void buttonOKHapus_Click(object sender, EventArgs e)
        {
            string response;
            Akun akun = new Akun();
            akun.id_pegawai = id_;
            response = akun.Delete();
            if (response == null)
            {
                MessageBox.Show("Hapus data berhasil");
                DataLoad();
            }
            else MessageBox.Show(response);
        }

        private void buttonCancelHapus_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void comboBoxNamaHapus_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT id_pegawai FROM akun " +
                "WHERE username = '" + comboBoxNamaHapus.Text + "'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_ = rdr.GetInt32(0);
                    Select();
                }
            }
            catch { }
        }

        private void ComboBox()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT nama_pegawai, id_pegawai FROM data_pegawai", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    comboBoxNama.Items.Add(nama);
                }
            }
            catch { }
        }

        private void ComboBoxUser()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT username, id_pegawai FROM akun", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    comboBoxNamaHapus.Items.Add(nama);
                }
            }
            catch { }
        }

        private void Select()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand("SELECT nama_pegawai FROM data_pegawai WHERE id_pegawai = '"+id_+"'", conn);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string nama = rdr.GetString(0);
                    textBoxUsernameHapus.Text = nama;
                }
            }
            catch { }
        }

        private void DataLoad()
        {
            FormProfil form1 = new FormProfil(akun);
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(form1);
            form1.Show();
        }
    }
}
