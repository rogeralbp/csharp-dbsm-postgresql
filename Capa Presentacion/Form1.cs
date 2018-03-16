using System;
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
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void treeViewSGDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void treeViewSGDB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "NodoBasesDeDatos")
            {
                foreach (string elem in conexion.ConsultarInformacionDBSistema())
                {
                    treeViewSGDB.SelectedNode.Nodes.Add(elem);               
                }
            }

            foreach (string elem in conexion.ConsultarInformacionDBSistema())
            {
                if (e.Node.Text == elem)
                {
                    string nombreDB = e.Node.Text;
                    //treeViewSGDB.SelectedNode.Nodes.Add("public");

                    //foreach (string elemEsch in conexion.ConsultarInformacionDBSistema())
                    //{
                        foreach (string elemT in conexion.ConsultarInformacionTablasDB(nombreDB))
                        {
                            treeViewSGDB.SelectedNode.Nodes.Add(elemT);
                        }
                    //}
                     
                    labelNombreDB.Text = "Base De Datos " + elem+", Conectada.";
                    dbConsulta = elem;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlConsultas.TabPages[0].Text = "Consulta "+dbConsulta;
        }
    }
}
