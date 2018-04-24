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
        Conexion_Bases_Datos conexion = new Conexion_Bases_Datos();
        string dbConsulta = string.Empty;
        string dbNombre = string.Empty;
        string[] Reservadas = new string[] { "SELECT","select","COUNT","count","ADD","EXTERNAL",
"PROCEDURE",
"ALL",
"FETCH",
"PUBLIC",
"ALTER",
"FILE",
"RAISERROR",
"AND",
"FILLFACTOR",
"READ",
"ANY",
"FOR",
"READTEXT",
"AS",
"FOREIGN",
"RECONFIGURE",
"ASC",
"FREETEXT",
"REFERENCES",
"AUTHORIZATION",
"FREETEXTTABLE",
"REPLICATION",
"BACKUP",
"FROM",
"RESTORE",
"BEGIN",
"FULL",
"RESTRICT",
"BETWEEN",
"FUNCTION",
"RETURN",
"BREAK",
"GRANT",
"REVOKE",
"GROUP",
"RIGHT",
"BY",
"HAVING",
"CASE",
"IF",
"SCHEMA",
"CLUSTERED",
"IN",
"INDEX",
"SELECT",
"INNER",
"COLUMN",
"INSERT",
"COMMIT",
"INTERSECT",
"CONSTRAINT",
"IS",
"SET",
"CONTAINS",
"JOIN",
"KEY",
"LEFT",
"CREATE",
"LIKE",
"CROSS",
"TABLE",
"CURRENT",
"CURRENT_DATE",
"MERGE",
"CURRENT_TIME",
"NATIONAL"
,"THEN",
"CURRENT_TIMESTAMP",
"TO",
"CURRENT_USER",
"NONCLUSTERED",
"TOP",
"CURSOR",
"DATABASE",
"NULL",
"TRANSACTION",
"TRIGGER",
"DEALLOCATE",
"OF",
"TRUNCATE",
"DECLARE",
"OFF"
,"DELETE",
"ON",
"UNION",
"DENY",
"OPEN",
"UNIQUE",
"DESC",
"UPDATE",
"DISTINCT",
"USE",
"DOUBLE",
"OPTION",
"USER",
"DROP"
,"OR",
"VALUES",
"DUMP",
"ORDER",
"VARYING"
,"ELSE"
,"OUTER",
"VIEW",
"END",
"WHERE",
"EXCEPT",
"WHILE",
"EXEC",
"PRECISION",
"WITH",
"EXECUTE",
"PRIMARY",
"EXISTS",
"PRINT",
"PROC","add","external",
"procedure",
"all",
"fetch",
"public",
"alter",
"file",
"raiserror",
"and",
"fillfactor",
"read",
"any",
"for",
"readtext",
"as",
"foreign",
"reconfigure",
"asc",
"freetext",
"references",
"authorization",
"freetexttable",
"replication",
"backup",
"from",
"restore",
"begin",
"full",
"restrict",
"between",
"function",
"return",
"break",
"grant",
"revoke",
"group",
"right",
"by",
"having",
"case",
"if",
"schema",
"clustered",
"in",
"index",
"select",
"inner",
"column",
"insert",
"commit",
"intersect",
"constraint",
"is",
"set",
"contains",
"join",
"key",
"left",
"create",
"like",
"cross",
"table",
"current",
"current_date",
"merge",
"current_time",
"national"
,"then",
"current_timestamp",
"to",
"current_user",
"nonclustered",
"top",
"cursor",
"database",
"null",
"transaction",
"trigger",
"deallocate",
"of",
"truncate",
"declare",
"off"
,"delete",
"on",
"union",
"deny",
"open",
"unique",
"desc",
"update",
"distinct",
"use",
"double",
"option",
"user",
"drop"
,"or",
"values",
"dump",
"order",
"varying"
,"else"
,"outer",
"view",
"end",
"where",
"except",
"while",
"exec",
"precision",
"with",
"execute",
"primary",
"exists",
"print",
"proc"
 };

        public Principal()
        {
            InitializeComponent();
            try
            {
                this.txtConsulta.TextChanged += (ob, ev) =>
                {
                    var palabras = this.txtConsulta.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var resultado = from b in Reservadas
                                    from c in palabras
                                    where c == b
                                    select b;

                    
                    foreach (var item in resultado)
                    {
                        int inicio = 0;
                        inicio = this.txtConsulta.Text.IndexOf(item, inicio);
                        this.txtConsulta.Select(inicio, item.Length);
                        this.txtConsulta.SelectionColor = Color.Red;
                        this.txtConsulta.SelectionStart = this.txtConsulta.Text.Length;
                        inicio++;
                    }

                    this.txtConsulta.SelectionColor = Color.Black;
                    this.txtConsulta.SelectionStart = this.txtConsulta.Text.Length;


                };
            }
            catch (Exception e) { MessageBox.Show("Error como \n"+e); }

            this.CenterToScreen();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControlConsultas.TabPages[0].Text = "Consulta " + dbConsulta;
            string[] arreglo = txtConsulta.Text.Split();
            if (comboDBConsulta.SelectedItem== null)
            {
                conexion.Consulta_Cualquiera("postgres", txtConsulta.Text);
            }
            else
            {
                conexion.Consulta_Cualquiera(comboDBConsulta.SelectedItem.ToString(), txtConsulta.Text);
                if (arreglo[0]=="SELECT"|| arreglo[0] == "select") {

                    //MessageBox.Show("Es una Consulta");
                    conexion.Consulta_Query(comboDBConsulta.SelectedItem.ToString(), txtConsulta.Text,dtgResultadoConsulta);
                    dtgResultadoConsulta.Visible = true;
                }
            }

            //Aqui se actualiza en arbol
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[2].Nodes.Clear();
            comboBasesDatosEliminar.Items.Clear();
            comboDBConsulta.Items.Clear();
            Llenar_Arbol();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Llenar_Arbol();
        }

        public void Llenar_Arbol()
        {
            ArrayList informacionDB = Conexion_Bases_Datos.ConsultarInformacionDBSistema();
            for (int i = 0; i < informacionDB.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(informacionDB[i].ToString());
                comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                comboDBConsulta.Items.Add(informacionDB[i]);
                //comboBasesDtosTablasNuevas.Items.Add(informacionDB[i]);
            }

            //Users
            ArrayList informacionUsers = Conexion_Bases_Datos.ConsultarInformacionUsersSistema();
            for (int i = 0; i < informacionUsers.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(informacionUsers[i].ToString());
            }

            //TableSpace
            ArrayList informacionTS = Conexion_Bases_Datos.ConsultarInformacionTableSpaceSistema();
            for (int i = 0; i < informacionTS.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[2].Nodes.Add(informacionTS[i].ToString());
            }

            //Schemas
            for (int i = 0; i < informacionDB.Count; i++)
            {
                treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes.Add("Schemas");
                ArrayList informacionSchemas = Conexion_Bases_Datos.ConsultarInformacionSchemas(informacionDB[i].ToString());
                for (int j = 0; j < informacionSchemas.Count; j++)
                {
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes.Add(informacionSchemas[j].ToString());
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Functions");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Sequences");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Tables");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Triggers");
                    treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes.Add("Views");

                    //Functions
                    ArrayList informacionFunciones = Conexion_Bases_Datos.ConsultarInformacionFuctions(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionFunciones.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[0].Nodes.Add(informacionFunciones[y].ToString());
                    }

                    //Sequences
                    ArrayList informacionSequences = Conexion_Bases_Datos.ConsultarInformacionSequences(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionSequences.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[1].Nodes.Add(informacionSequences[y].ToString());
                    }

                    //Tables
                    ArrayList informacionTables = Conexion_Bases_Datos.ConsultarInformacionTablasDB(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionTables.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes.Add(informacionTables[y].ToString());
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes.Add("Columns");
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes.Add("Indexes");
                        ArrayList informacionColumns = Conexion_Bases_Datos.ConsultarInformacionColumns(informacionDB[i].ToString(), informacionSchemas[j].ToString(), informacionTables[y].ToString());
                        for (int x = 0; x < informacionColumns.Count; x++)
                        {
                            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes[0].Nodes.Add(informacionColumns[x].ToString());
                        }
                        ArrayList informacionIndex = Conexion_Bases_Datos.ConsultarInformacionIndex(informacionDB[i].ToString(), informacionSchemas[j].ToString(), informacionTables[y].ToString());
                        for (int x = 0; x < informacionIndex.Count; x++)
                        {
                            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[2].Nodes[y].Nodes[1].Nodes.Add(informacionIndex[x].ToString());
                        }
                    }

                    //Triggers
                    ArrayList informacionTrigger = Conexion_Bases_Datos.ConsultarInformacionTrigger(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionTrigger.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[3].Nodes.Add(informacionTrigger[y].ToString());
                    }

                    //Views
                    ArrayList informacionViews = Conexion_Bases_Datos.ConsultarInformacionViews(informacionDB[i].ToString(), informacionSchemas[j].ToString());
                    for (int y = 0; y < informacionViews.Count; y++)
                    {
                        treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes[i].Nodes[0].Nodes[j].Nodes[4].Nodes.Add(informacionViews[y].ToString());
                    }
                }
            }
        }
        
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Debe de poder crearse las db");
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Crear una Base de Datos ?", "Confirmacion Creacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                string nombreBaseDatos = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el Nombre de la Base de Datos", "Nombre Base de Datos", "1", 500, 250);             
                conexion.Crear_Base_Datos(nombreBaseDatos);
                MessageBox.Show("Se Creo con exito la Base de Datos", "Confirmacion Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBasesDatosEliminar.Items.Clear();
                ArrayList informacionDB = Conexion_Bases_Datos.ConsultarInformacionDBSistema();
                for (int i = 0; i < informacionDB.Count; i++)
                {
                    comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                }
            }

            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[2].Nodes.Clear();
            comboBasesDatosEliminar.Items.Clear();
            comboDBConsulta.Items.Clear();
        }

        private void comboBasesDatosEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("Desea Eliminar la Base de Datos "+comboBasesDatosEliminar.SelectedItem.ToString()+" ?", "Confirmacion Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                string nombreBaseDatos = comboBasesDatosEliminar.SelectedItem.ToString();
                conexion.Eliminar_Base_Datos(nombreBaseDatos);
                //MessageBox.Show("Se Elimino con exito la Base de Datos", "Confirmacion Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBasesDatosEliminar.Items.Clear();
                ArrayList informacionDB = Conexion_Bases_Datos.ConsultarInformacionDBSistema();
                for (int i = 0; i < informacionDB.Count; i++)
                {
                    comboBasesDatosEliminar.Items.Add(informacionDB[i]);
                }
            }

            treeViewSGDB.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();
            treeViewSGDB.Nodes[0].Nodes[0].Nodes[2].Nodes.Clear();
            comboBasesDatosEliminar.Items.Clear();
            comboDBConsulta.Items.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void indecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Indeces v = new CRUD_Indeces();
            //v.Show();
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
            labelNombreDB2.Text = comboDBConsulta.SelectedItem.ToString() + " Conectada!!";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
        }

        private void contextMenuStripDBroger_Opening(object sender, CancelEventArgs e)
        {

        }

        private void actulizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void basesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Usuarios v = new CRUD_Usuarios();
            //v.Show();
        }

        private void columnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Esqeumas v = new CRUD_Esqeumas();
            //v.Show();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Funciones v = new CRUD_Funciones();
            //v.Show();
        }

        private void secuenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Secuencias  v = new CRUD_Secuencias();
            //v.Show();
        }

        private void tablasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CRUD_Tablas v = new CRUD_Tablas();
            //v.Show();
        }

        private void columnasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CRUD_Columnas v = new CRUD_Columnas();
            //v.Show();
        }

        private void restriccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Restricciones v = new CRUD_Restricciones();
            //v.Show();
        }

        private void disparadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Triggers v = new CRUD_Triggers();
            //v.Show();
        }

        private void vistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CRUD_Vistas v = new CRUD_Vistas();
            //v.Show();
        }

        private void comboBasesDatosEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Cerrar el Programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
            //el mae simpre se cierra, algo esta mal.... hay que analizarlo
        }
    }
}