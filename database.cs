using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryControl
{
    class database
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection ConnectionDatabase()
        {
            connection = new SQLiteConnection("Data Source=" + Global.localdb + Global.dbname);
            connection.Open();
            return connection;
        }

        public static DataTable DataBaseCommand(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectionDatabase().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDatabase());
                    da.Fill(dt);
                    ConnectionDatabase().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectionDatabase().Close();
                throw ex;
            }
        }
    
        /////// Functions of signUp ///////////

        public static void newUser(user u)
        {
            if (existUsername(u))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {
                var cmd = ConnectionDatabase().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_users (USER_NAME, USER_PASSWORD, USER_LEVEL) VALUES (@name, @password, @level)";
                cmd.Parameters.AddWithValue("@name", u.user_name);
                cmd.Parameters.AddWithValue("@password", u.user_password);
                cmd.Parameters.AddWithValue("@level", u.user_level);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário criado com sucesso");
                ConnectionDatabase().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
                ConnectionDatabase().Close();
            }
        }

        /////// End of Functions    ///////////
    

        /////// General routines //////////////
    
        public static bool existUsername(user u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConnectionDatabase().CreateCommand();
            cmd.CommandText = "SELECT USER_NAME FROM tb_users WHERE USER_NAME='" + u.user_name + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDatabase());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }    
            return res;
        }
    }
}
