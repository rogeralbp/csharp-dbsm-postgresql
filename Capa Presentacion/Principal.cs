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
        ConexionBasesDatos conexion = new ConexionBasesDatos();
        string dbConsulta = string.Empty;
        string[] Reservadas = new string[] { "DATABASE","TABLE","COLUMN","CREATE","DELETE", "DROP","SELECT","INSERT","UPDATE","DELETE","FROM","ON","AS" };

        public Principal()
        {
            InitializeComponent();
            this.txtConsulta.TextChanged += (ob, ev) =>
            {
                var palabras = this.txtConsulta.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var resultado = from b in Reservadas
                                from c in palabras
                                where c == b
                                select b;

                int inicio = 0;
                foreach (var item in resultado)
                {
                    inicio = this.txtConsulta.Text.IndexOf(item, inicio);
                    this.txtConsulta.Select(inicio, item.Length);
                    this.txtConsulta.SelectionColor = Color.Red;
                    this.txtConsulta.SelectionStart = this.txtConsulta.Text.Length;
                    inicio++;
                }

                this.txtConsulta.SelectionColor = Color.Black;
                this.txtConsulta.SelectionStart = this.txtConsulta.Text.Length;


            };

            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControlConsultas.TabPages[0].Text = "Consulta " + dbConsulta;
            if (comboDBConsulta.SelectedItem== null)
            {
                conexion.Consulta_Cualquiera("postgres", txtConsulta.Text);

            }
            else
            {
                conexion.Consulta_Cualquiera(comboDBConsulta.SelectedItem.ToString(), txtConsulta.Text);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            //Base de datos
            ArrayList informacionDB = ConexionBasesDatos.ConsultarInformacionDBSistema();
            for (int i = 0; i < informacionDB.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(informacionDB[i].ToString());
                comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                comboDBConsulta.Items.Add(informacionDB[i]);
                //comboBasesDtosTablasNuevas.Items.Add(informacionDB[i]);
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
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes.Add("Indexes");
                        ArrayList informacionColumns = ConexionBasesDatos.ConsultarInformacionColumns(informacionDB[i].ToString(), informacionSchemas[j].ToString(), informacionTables[y].ToString());
                        for (int x = 0; x < informacionColumns.Count; x++)
                        {
                            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes[0].Nodes.Add(informacionColumns[x].ToString());
                        }
                        ArrayList informacionIndex = ConexionBasesDatos.ConsultarInformacionIndex(informacionDB[i].ToString(), informacionSchemas[j].ToString(), informacionTables[y].ToString());
                        for (int x = 0; x < informacionIndex.Count; x++)
                        {
                            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes[1].Nodes.Add(informacionIndex[x].ToString());
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
        
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Debde de poder crearse las db");
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Crear una Base de Datos ?", "Confirmacion Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                string nombreBaseDatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el Nombre de la Base de Datos", "Nombre Base de Datos", "1", 500, 250);             
                conexion.Crear_Base_Datos(nombreBaseDatos);
                MessageBox.Show("Se Creo con exito la Base de Datos", "Confirmacion Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBasesDatosEliminar.Items.Clear();
                ArrayList informacionDB = ConexionBasesDatos.ConsultarInformacionDBSistema();
                for (int i = 0; i < informacionDB.Count; i++)
                {
                    comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                }
            }
        }

        private void comboBasesDatosEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Eliminar la Base de Datos "+comboBasesDatosEliminar.SelectedItem.ToString()+" ?", "Confirmacion Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                string nombreBaseDatos = comboBasesDatosEliminar.SelectedItem.ToString();
                conexion.Eliminar_Base_Datos(nombreBaseDatos);
                MessageBox.Show("Se Elimino con exito la Base de Datos", "Confirmacion Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBasesDatosEliminar.Items.Clear();
                ArrayList informacionDB = ConexionBasesDatos.ConsultarInformacionDBSistema();
                for (int i = 0; i < informacionDB.Count; i++)
                {
                    comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void indecesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txtConsulta.Visible = true;
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEjecutarConsulta.Visible = true;
        }

        private void comboDBConsulta_Click(object sender, EventArgs e)
        {

        }

        private void comboDBConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
        }

    }
}