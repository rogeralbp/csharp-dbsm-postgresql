using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Capa_Datos
{
    public class ConexionBasesDatos
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion_General()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string claveAnthonny = "1414250816ma";
            string claveBryan = String.Empty; 
            string claveRoger = "Saborio17";
            string baseDatos = "gestion_vuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveRoger + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);

            if (conexion != null)
            {

                Console.WriteLine("Conexion con la DB nombre : " + baseDatos + " , Exitosa!!");
            }
            else
            {

                Console.WriteLine("Error en la conexion con la DB");
            }
        }

        public static void Conexion_Tablas(string db )
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string claveAnthonny = "1414250816ma";
            string claveBryan = String.Empty;
            string claveRoger = "Saborio17";
            //string baseDatos = "gesion_vuelos";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveRoger + ";" + "Database=" + db;
            conexion = new NpgsqlConnection(cadenaConexion);

            if (conexion != null)
            {

                Console.WriteLine("Conexion con la DB nombre : " + db+ " , Exitosa!!");
            }
            else
            {

                Console.WriteLine("Error en la conexion con la DB");
            }
        }


        public ArrayList ConsultarInformacionDBSistema()
        {

            ArrayList informacionDB = new ArrayList();

            Conexion_General();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT datname FROM pg_database", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionDB.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();

            return informacionDB;
        }

        public ArrayList ConsultarInformacionTablasDB(string daba)
        {

            ArrayList informacionDB = new ArrayList();

            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' AND table_type='BASE TABLE'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionDB.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();

            return informacionDB;
        }
        //SELECT table_name FROM information_schema.tables WHERE table_schema = 'public';
    }
}
