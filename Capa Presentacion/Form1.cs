using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class Principal : Form
    {
        string dbConsulta = string.Empty;
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlConsultas.TabPages[0].Text = "Consulta "+ dbConsulta;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            //Base de datos
            ArrayList informacionDB = ConexionBasesDatos.ConsultarInformacionDBSistema();
            for (int i = 0; i < informacionDB.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(informacionDB[i].ToString());
            }

            //Users
            ArrayList informacionUsers = ConexionBasesDatos.ConsultarInformacionUsersSistema();
            for (int i = 0; i < informacionUsers.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(informacionUsers[i].ToString());
            }

            //TableSpace
            ArrayList informacionTS = ConexionBasesDatos.ConsultarInformacionTableSpaceSistema();
            for (int i = 0; i < informacionTS.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[2].Nodes.Add(informacionTS[i].ToString());
            }

            //Schemas
            for (int i = 0; i < informacionDB.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Schemas");
                ArrayList informacionSchemas = ConexionBasesDatos.ConsultarInformacionSchemas(informacionDB[i].ToString());
                for (int j = 0; j < informacionSchemas.Count; j++)
                {
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes.Add(informacionSchemas[j].ToString());
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Functions");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Sequences");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Tables");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Triggers");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Views");

                    //Functions
                    ArrayList informacionFunciones = ConexionBasesDatos.ConsultarInformacionFuctions(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionFunciones.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[0].Nodes.Add(informacionFunciones[y].ToString());
                    }

                    //Sequences
                    ArrayList informacionSequences = ConexionBasesDatos.ConsultarInformacionSequences(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionSequences.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[1].Nodes.Add(informacionSequences[y].ToString());
                    }

                    //Tables
                    ArrayList informacionTables = ConexionBasesDatos.ConsultarInformacionTablasDB(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionTables.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes.Add(informacionTables[y].ToString());
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes.Add("Columns");
                        ArrayList informacionColumns = ConexionBasesDatos.ConsultarInformacionColumns(informacionDB[i].ToString(), informacionSchemas[j].ToString(), informacionTables[y].ToString());
                        for (int x = 0; x < informacionColumns.Count; x++)
                        {
                            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes[0].Nodes.Add(informacionColumns[x].ToString());
                        }
                    }

                    //Triggers
                    ArrayList informacionTrigger = ConexionBasesDatos.ConsultarInformacionTrigger(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionTrigger.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[3].Nodes.Add(informacionTrigger[y].ToString());
                    }

                    //Views
                    ArrayList informacionViews = ConexionBasesDatos.ConsultarInformacionViews(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionViews.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[4].Nodes.Add(informacionViews[y].ToString());
                    }
                }
            }
        }
    }
}
