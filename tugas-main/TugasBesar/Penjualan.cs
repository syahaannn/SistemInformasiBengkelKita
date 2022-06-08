using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar
{
    class Penjualan
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String id_transaksi { set; get; }
        public String tgl_jual { set; get; }
        public int total { set; get; }
        public String kode_barang { set; get; }
        public String nama_barang { set; get; }
        public int harga_satuan { set; get; }
        public int kuantitas_beli { set; get; }
        public int harga_total { set; get; }
        public String struk { set; get; }
        public int kuantitas_jual { set; get; }
        public int kurang { set; get; }
        public String tgl_awal { set; get; }
        public String tgl_akhir { set; get; }

        public Penjualan()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public String InsertStruk()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO daftar_transaksi VALUES (@id_transaksi, @kode_barang, @nama_barang, " +
                "@kuantitas_beli, @harga_satuan, @harga_total)";
            cmd.Parameters.AddWithValue("@id_transaksi", this.id_transaksi);
            cmd.Parameters.AddWithValue("@kode_barang", this.kode_barang);
            cmd.Parameters.AddWithValue("@nama_barang", this.nama_barang);
            cmd.Parameters.AddWithValue("@kuantitas_beli", this.kuantitas_beli);
            cmd.Parameters.AddWithValue("@harga_satuan", this.harga_satuan);
            cmd.Parameters.AddWithValue("@harga_total", this.harga_total);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO penjualan (id_transaksi, tgl_jual, total) VALUES (@id_transaksi, @tgl_jual, @total)";
            cmd.Parameters.AddWithValue("@id_transaksi", this.id_transaksi);
            cmd.Parameters.AddWithValue("@tgl_jual", this.tgl_jual);
            cmd.Parameters.AddWithValue("@total", this.total);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public DataTable ReadStruk()
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT kode_barang as 'Kode Barang', nama_barang as 'Nama Barang', kuantitas_beli as 'Kuantitas', " +
                "harga_satuan as 'Harga/Barang', harga_total as 'Harga Total' FROM daftar_transaksi " +
                "WHERE id_transaksi = '"+struk+"'";
            cmd.Parameters.AddWithValue(struk, this.struk);
            {
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e) { }
            }
            return dt;
        }

        public String KuantitasTerjual()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE data_barang set kuantitas_jual = @kuantitas_jual WHERE kode_barang = '"+struk+"';";
            cmd.Parameters.AddWithValue("@kuantitas_jual", this.kuantitas_jual);
            cmd.Parameters.AddWithValue(struk, this.struk);
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e) { }
            }
            return error;
        }

        public String KuantitasKurang()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE data_barang set kuantitas_barang = @kurang WHERE kode_barang = '" + struk + "';";
            cmd.Parameters.AddWithValue("@kurang", this.kurang);
            cmd.Parameters.AddWithValue(struk, this.struk);
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e) { }
            }
            return error;
        }

        public DataTable ReadSUM()
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_transaksi as 'ID Transaksi', total as 'Total Harga' FROM penjualan " +
                "WHERE (tgl_jual BETWEEN @tgl_awal AND @tgl_akhir)";
            cmd.Parameters.AddWithValue("@tgl_awal", this.tgl_awal);
            cmd.Parameters.AddWithValue("@tgl_akhir", this.tgl_akhir);
            {
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e) { }
            }
            return dt;
        }
    }
}
