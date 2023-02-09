using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySqlConnector;
using System.Windows.Controls;

namespace WPF_InsertarDatos
{
    internal class AdminDB
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

        public Boolean Conectar()
        {
            try
            {
                con.ConnectionString = CadenaDeConexion;
                con.Open();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                return false;
                throw;
            }
        }



        public void Desconectar()
        {
            con.Close();
        }


        public void llenarDatos()
        {
            //Todos los datos capturados en la tabla
            try
            {
                con.ConnectionString = CadenaDeConexion;
                con.Open();
                dsAnimales.Clear();
                string qry = "SELECT * FROM animales";
                cmd.CommandText = qry;
                cmd.Connection = con;
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(dsAnimales, "animales");          
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insertaDatos(String nombre, String especie, String raza, char sexo)
        {
            string strSQL = "INSERT INTO animales(nombre, especie, raza, sexo) VALUES ('" + nombre + "','" + especie + "', '" + raza + "', '" + sexo + "');";
            cmd.CommandText = strSQL;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

    }
}
