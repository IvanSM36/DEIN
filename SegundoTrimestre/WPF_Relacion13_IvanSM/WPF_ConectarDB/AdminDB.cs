using System;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;
namespace InsertaDatos
{
    class AdminDB
    {
        static MySqlConnection con = new MySqlConnection();
        static string serv = "server=212.227.147.133;";
        static string db = "database=ZooTerra;";
        static string usuario = "user=root;";
        static string pwd = "password=root;";
        MySqlCommand cmd = new MySqlCommand();
        string CadenaDeConexion = serv + db + usuario + pwd;
        static MySqlCommand Comando = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        public DataSet dsAnimales = new DataSet();
        public void llenarDatosUsuarios()
        {
            //Todos los datos capturados en la tabla alumnos
            try
            {
                con.ConnectionString = CadenaDeConexion;
                con.Open();
                dsAnimales.Clear();
                string qry = "SELECT * FROM usuarios";
                cmd.CommandText = qry;
                cmd.Connection = con;
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(dsAnimales, "Animales");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}