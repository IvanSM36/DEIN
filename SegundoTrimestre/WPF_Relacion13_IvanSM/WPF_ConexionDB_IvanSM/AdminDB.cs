using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ConexionDB_IvanSM
{
    internal class AdminDB
    {
        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "server=212.227.147.133;";
        static string db = "database=ZooTerra;";
        static string usuario = "id=root;";
        static string pwd = "password=root;";
        string CadenaDeConexion = serv + db + usuario + pwd;
        static MySqlCommand Comando = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();

        public void Conectar()
        {
            try
            {
                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
                MessageBox.Show("La BD esta ahora conectada");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }
        }

        public static void Desconectar()
        {
            Conex.Close();
        }
    }
}
