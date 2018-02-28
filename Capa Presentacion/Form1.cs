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
    public partial class Form1 : Form
    {
        ConexionBasesDatos conexion = new ConexionBasesDatos();

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void treeViewSGDB_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name=="NodoBasesDeDatos")
            {
                foreach (string elem in conexion.ConsultarInformacionDBSistema())
                {

                    treeViewSGDB.SelectedNode.Nodes.Add(elem);
                }
            }
        }
    }
}
