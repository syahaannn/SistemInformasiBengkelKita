using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar
{
    public class Akun
    {
        protected String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String username { set; get; }
        public String password { set; get; }
        public int role { set; get; }
        public int id_pegawai { set; get; }
        public String usernamebaru { set; get; }
        public int id_user { set; get; }

        public Akun()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public String Login()
        {
            String error = null;
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT username, password, role, id_pegawai FROM akun " +
                "WHERE username = @username", conn);
            cmd.Parameters.AddWithValue("@username", this.username);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    username = rdr.GetString(0);
                    password = rdr.GetString(1);
                    role = rdr.GetInt32(2);
                    id_pegawai = rdr.GetInt32(3);
                }
            }
            catch
            {

            }
            return error;
        }

        public String Update()
        {
            string result = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE akun set password = @password WHERE id_user = @id_user";
            cmd.Parameters.AddWithValue("@id_user", this.id_user);
            cmd.Parameters.AddWithValue("@password", this.password);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return result;
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO akun (username, password, role, id_pegawai) VALUES " +
                "(@username, @password, @role, @id_pegawai)";
            cmd.Parameters.AddWithValue("@username", this.username);
            cmd.Parameters.AddWithValue("@password", this.password);
            cmd.Parameters.AddWithValue("@role", this.role);
            cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
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

        public String UbahUsername()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE akun set username = @usernamebaru WHERE id_user = @id_user";
            cmd.Parameters.AddWithValue("@id_user", this.id_user);
            cmd.Parameters.AddWithValue("@usernamebaru", this.usernamebaru);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return error;
        }

        public String Delete()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM akun WHERE id_pegawai = @id_pegawai";
            cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return error;
        }
    }
}
