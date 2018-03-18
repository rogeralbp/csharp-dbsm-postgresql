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
        public static NpgsqlConnection conexion;
        public static NpgsqlCommand cmd;

        public static void Conexion_General()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string claveAnthonny = "1414250816ma";
            string claveBryan = "bryan2748245"; 
            string claveRoger = "Saborio17";
            string baseDatos = "postgres";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveBryan + ";" + "Database=" + baseDatos;
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
            string claveBryan = "bryan2748245";
            string claveRoger = "Saborio17";
            //string baseDatos = "gesion_vuelos";
            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + claveBryan + ";" + "Database=" + db;
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

        //Bases de datos
        public static ArrayList ConsultarInformacionDBSistema()
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
                    if ((lectorConsulta.GetString(0).Equals("template0") == false) && (lectorConsulta.GetString(0).Equals("template1") == false))
                    {
                        informacionDB.Add(lectorConsulta.GetString(0));
                    }
                }
            }
            conexion.Close();
            return informacionDB;
        }

        //Users
        public static ArrayList ConsultarInformacionUsersSistema()
        {
            ArrayList informacionUsers = new ArrayList();
            Conexion_General();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT rolname FROM pg_roles", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionUsers.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionUsers;
        }

        //TableSpaces
        public static ArrayList ConsultarInformacionTableSpaceSistema()
        {
            ArrayList informacionTS = new ArrayList();
            Conexion_General();
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT spcname FROM pg_tablespace", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionTS.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionTS;
        }

        //Schemas
        public static ArrayList ConsultarInformacionSchemas(string daba)
        {
            ArrayList informacionSchemas = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT nspname FROM pg_catalog.pg_namespace WHERE nspname like 'pg_%' = false AND nspname != 'information_schema'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionSchemas.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionSchemas;
        }

        //Tables
        public static ArrayList ConsultarInformacionTablasDB(string daba, string schema)
        {
            ArrayList informacionDB = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = '"+ schema + "' AND table_type='BASE TABLE'", conexion);
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

        //Triggers
        public static ArrayList ConsultarInformacionTrigger(string daba, string schema)
        {
            ArrayList informacionTrigger = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT trigger_name FROM information_schema.triggers WHERE trigger_schema = '" + schema + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionTrigger.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionTrigger;
        }

        //Fuctions
        public static ArrayList ConsultarInformacionFuctions(string daba, string schema)
        {
            ArrayList informacionFuctions = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT proname FROM pg_catalog.pg_namespace n JOIN pg_catalog.pg_proc p ON pronamespace = n.oid WHERE nspname = '" + schema +"'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionFuctions.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionFuctions;
        }

        //Sequences
        public static ArrayList ConsultarInformacionSequences(string daba, string schema)
        {
            ArrayList informacionSequence = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT sequence_name FROM information_schema.sequences WHERE sequence_schema = '" + schema + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionSequence.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionSequence;
        }

        //Views
        public static ArrayList ConsultarInformacionViews(string daba, string schema)
        {
            ArrayList informacionViews = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT table_name FROM information_schema.views WHERE table_schema ='" + schema + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionViews.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionViews;
        }

        //Columns
        public static ArrayList ConsultarInformacionColumns(string daba, string schema, string table)
        {
            ArrayList informacionColumns = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT column_name FROM information_schema.columns WHERE table_schema ='" + schema + "' AND table_name = '" + table + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionColumns.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionColumns;
        }

        //Index
        public static ArrayList ConsultarInformacionIndex(string daba, string schema, string table)
        {
            ArrayList informacionIndex = new ArrayList();
            Conexion_Tablas(daba);
            conexion.Open();
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT indexname FROM pg_indexes WHERE schemaname = '" + schema + "' AND tablename = '" + table + "'", conexion);
            NpgsqlDataReader lectorConsulta = consulta.ExecuteReader();
            if (lectorConsulta.HasRows)
            {
                while (lectorConsulta.Read())
                {
                    informacionIndex.Add(lectorConsulta.GetString(0));
                }
            }
            conexion.Close();
            return informacionIndex;
        }
    }
}
