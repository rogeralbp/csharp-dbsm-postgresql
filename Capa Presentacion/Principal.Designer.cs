namespace Capa_Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bases de Datos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Login/Group Roles");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TableSpaces");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Servidor SGDB", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Servidores", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.treeViewSGDB = new System.Windows.Forms.TreeView();
            this.labelNombreDB = new System.Windows.Forms.Label();
            this.btnEjecutarConsulta = new System.Windows.Forms.Button();
            this.dtgResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboDBConsulta = new System.Windows.Forms.ToolStripComboBox();
            this.basesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBasesDatosEliminar = new System.Windows.Forms.ToolStripComboBox();
            this.columnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEsquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEsquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actuliazarEsquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionEsquemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSecuenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSecuenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarSecuenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesColumnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restriccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRestriccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRestriccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarRestriccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionRestriccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disparadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDisparadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDisparadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDisparadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDisparadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsulta = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actulizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSGDB
            // 
            this.treeViewSGDB.Location = new System.Drawing.Point(2, 27);
            this.treeViewSGDB.Name = "treeViewSGDB";
            treeNode1.Name = "NodoBasesDeDatos";
            treeNode1.Text = "Bases de Datos";
            treeNode2.Name = "NodoLogin";
            treeNode2.Text = "Login/Group Roles";
            treeNode3.Name = "NodoTableSpaces";
            treeNode3.Text = "TableSpaces";
            treeNode4.Name = "NodoNombreServidor";
            treeNode4.Text = "Servidor SGDB";
            treeNode5.Name = "NodoServidor";
            treeNode5.Text = "Servidores";
            this.treeViewSGDB.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewSGDB.Size = new System.Drawing.Size(248, 514);
            this.treeViewSGDB.TabIndex = 0;
            // 
            // labelNombreDB
            // 
            this.labelNombreDB.AutoSize = true;
            this.labelNombreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDB.Location = new System.Drawing.Point(259, 491);
            this.labelNombreDB.Name = "labelNombreDB";
            this.labelNombreDB.Size = new System.Drawing.Size(0, 16);
            this.labelNombreDB.TabIndex = 1;
            // 
            // btnEjecutarConsulta
            // 
            this.btnEjecutarConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutarConsulta.Image")));
            this.btnEjecutarConsulta.Location = new System.Drawing.Point(598, 0);
            this.btnEjecutarConsulta.Name = "btnEjecutarConsulta";
            this.btnEjecutarConsulta.Size = new System.Drawing.Size(84, 35);
            this.btnEjecutarConsulta.TabIndex = 3;
            this.btnEjecutarConsulta.UseVisualStyleBackColor = true;
            this.btnEjecutarConsulta.Visible = false;
            this.btnEjecutarConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgResultadoConsulta
            // 
            this.dtgResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultadoConsulta.Location = new System.Drawing.Point(252, 366);
            this.dtgResultadoConsulta.Name = "dtgResultadoConsulta";
            this.dtgResultadoConsulta.ReadOnly = true;
            this.dtgResultadoConsulta.Size = new System.Drawing.Size(988, 175);
            this.dtgResultadoConsulta.TabIndex = 4;
            this.dtgResultadoConsulta.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.basesDeDatosToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.columnasToolStripMenuItem,
            this.funcionesToolStripMenuItem,
            this.secuenciasToolStripMenuItem,
            this.tablasToolStripMenuItem1,
            this.columnasToolStripMenuItem1,
            this.restriccionesToolStripMenuItem,
            this.indecesToolStripMenuItem,
            this.disparadoresToolStripMenuItem,
            this.vistasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.comboDBConsulta});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "General";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // comboDBConsulta
            // 
            this.comboDBConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDBConsulta.Name = "comboDBConsulta";
            this.comboDBConsulta.Size = new System.Drawing.Size(121, 23);
            this.comboDBConsulta.SelectedIndexChanged += new System.EventHandler(this.comboDBConsulta_SelectedIndexChanged);
            this.comboDBConsulta.Click += new System.EventHandler(this.comboDBConsulta_Click);
            // 
            // basesDeDatosToolStripMenuItem
            // 
            this.basesDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacionUsuarioToolStripMenuItem,
            this.actualizacionUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.basesDeDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("basesDeDatosToolStripMenuItem.Image")));
            this.basesDeDatosToolStripMenuItem.Name = "basesDeDatosToolStripMenuItem";
            this.basesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.basesDeDatosToolStripMenuItem.Text = "Roles y Usuarios";
            this.basesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.basesDeDatosToolStripMenuItem_Click);
            // 
            // creacionUsuarioToolStripMenuItem
            // 
            this.creacionUsuarioToolStripMenuItem.Name = "creacionUsuarioToolStripMenuItem";
            this.creacionUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.creacionUsuarioToolStripMenuItem.Text = "Creacion Usuario";
            // 
            // actualizacionUsuarioToolStripMenuItem
            // 
            this.actualizacionUsuarioToolStripMenuItem.Name = "actualizacionUsuarioToolStripMenuItem";
            this.actualizacionUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.actualizacionUsuarioToolStripMenuItem.Text = "Actualizacion Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario ";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.eliminarBaseDeDatosToolStripMenuItem});
            this.tablasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tablasToolStripMenuItem.Image")));
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tablasToolStripMenuItem.Text = "Bases de Datos";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.crearToolStripMenuItem.Text = "Crear Base de Datos";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // eliminarBaseDeDatosToolStripMenuItem
            // 
            this.eliminarBaseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBasesDatosEliminar});
            this.eliminarBaseDeDatosToolStripMenuItem.Name = "eliminarBaseDeDatosToolStripMenuItem";
            this.eliminarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarBaseDeDatosToolStripMenuItem.Text = "Eliminar Base de Datos";
            // 
            // comboBasesDatosEliminar
            // 
            this.comboBasesDatosEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBasesDatosEliminar.Name = "comboBasesDatosEliminar";
            this.comboBasesDatosEliminar.Size = new System.Drawing.Size(121, 23);
            this.comboBasesDatosEliminar.SelectedIndexChanged += new System.EventHandler(this.comboBasesDatosEliminar_SelectedIndexChanged);
            this.comboBasesDatosEliminar.Click += new System.EventHandler(this.comboBasesDatosEliminar_Click);
            // 
            // columnasToolStripMenuItem
            // 
            this.columnasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEsquemaToolStripMenuItem,
            this.eliminarEsquemaToolStripMenuItem,
            this.actuliazarEsquemaToolStripMenuItem,
            this.informacionEsquemaToolStripMenuItem});
            this.columnasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("columnasToolStripMenuItem.Image")));
            this.columnasToolStripMenuItem.Name = "columnasToolStripMenuItem";
            this.columnasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.columnasToolStripMenuItem.Text = "Esquemas";
            this.columnasToolStripMenuItem.Click += new System.EventHandler(this.columnasToolStripMenuItem_Click);
            // 
            // crearEsquemaToolStripMenuItem
            // 
            this.crearEsquemaToolStripMenuItem.Name = "crearEsquemaToolStripMenuItem";
            this.crearEsquemaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.crearEsquemaToolStripMenuItem.Text = "Crear Esquema";
            // 
            // eliminarEsquemaToolStripMenuItem
            // 
            this.eliminarEsquemaToolStripMenuItem.Name = "eliminarEsquemaToolStripMenuItem";
            this.eliminarEsquemaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.eliminarEsquemaToolStripMenuItem.Text = "Eliminar Esquema";
            // 
            // actuliazarEsquemaToolStripMenuItem
            // 
            this.actuliazarEsquemaToolStripMenuItem.Name = "actuliazarEsquemaToolStripMenuItem";
            this.actuliazarEsquemaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.actuliazarEsquemaToolStripMenuItem.Text = "Actualizar Esquema ";
            // 
            // informacionEsquemaToolStripMenuItem
            // 
            this.informacionEsquemaToolStripMenuItem.Name = "informacionEsquemaToolStripMenuItem";
            this.informacionEsquemaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.informacionEsquemaToolStripMenuItem.Text = "Informacion Esquema";
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFuncionToolStripMenuItem,
            this.eliminarFuncionToolStripMenuItem,
            this.actualizarFuncionToolStripMenuItem,
            this.informacionFuncionToolStripMenuItem});
            this.funcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionesToolStripMenuItem.Image")));
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.funcionesToolStripMenuItem.Text = "Funciones";
            this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
            // 
            // crearFuncionToolStripMenuItem
            // 
            this.crearFuncionToolStripMenuItem.Name = "crearFuncionToolStripMenuItem";
            this.crearFuncionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.crearFuncionToolStripMenuItem.Text = "Crear Funcion";
            // 
            // eliminarFuncionToolStripMenuItem
            // 
            this.eliminarFuncionToolStripMenuItem.Name = "eliminarFuncionToolStripMenuItem";
            this.eliminarFuncionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminarFuncionToolStripMenuItem.Text = "Eliminar Funcion";
            // 
            // actualizarFuncionToolStripMenuItem
            // 
            this.actualizarFuncionToolStripMenuItem.Name = "actualizarFuncionToolStripMenuItem";
            this.actualizarFuncionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.actualizarFuncionToolStripMenuItem.Text = "Actualizar Funcion";
            // 
            // informacionFuncionToolStripMenuItem
            // 
            this.informacionFuncionToolStripMenuItem.Name = "informacionFuncionToolStripMenuItem";
            this.informacionFuncionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.informacionFuncionToolStripMenuItem.Text = "Informacion Funcion";
            // 
            // secuenciasToolStripMenuItem
            // 
            this.secuenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSecuenciasToolStripMenuItem,
            this.eliminarSecuenciasToolStripMenuItem,
            this.actualizarSecuenciasToolStripMenuItem});
            this.secuenciasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("secuenciasToolStripMenuItem.Image")));
            this.secuenciasToolStripMenuItem.Name = "secuenciasToolStripMenuItem";
            this.secuenciasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.secuenciasToolStripMenuItem.Text = "Secuencias";
            this.secuenciasToolStripMenuItem.Click += new System.EventHandler(this.secuenciasToolStripMenuItem_Click);
            // 
            // crearSecuenciasToolStripMenuItem
            // 
            this.crearSecuenciasToolStripMenuItem.Name = "crearSecuenciasToolStripMenuItem";
            this.crearSecuenciasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.crearSecuenciasToolStripMenuItem.Text = "Crear Secuencias";
            // 
            // eliminarSecuenciasToolStripMenuItem
            // 
            this.eliminarSecuenciasToolStripMenuItem.Name = "eliminarSecuenciasToolStripMenuItem";
            this.eliminarSecuenciasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.eliminarSecuenciasToolStripMenuItem.Text = "Eliminar Secuencias";
            // 
            // actualizarSecuenciasToolStripMenuItem
            // 
            this.actualizarSecuenciasToolStripMenuItem.Name = "actualizarSecuenciasToolStripMenuItem";
            this.actualizarSecuenciasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.actualizarSecuenciasToolStripMenuItem.Text = "Actualizar Secuencias";
            // 
            // tablasToolStripMenuItem1
            // 
            this.tablasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTablaToolStripMenuItem,
            this.eliminarTablaToolStripMenuItem,
            this.actualizarTablaToolStripMenuItem,
            this.informacionTablaToolStripMenuItem});
            this.tablasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("tablasToolStripMenuItem1.Image")));
            this.tablasToolStripMenuItem1.Name = "tablasToolStripMenuItem1";
            this.tablasToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.tablasToolStripMenuItem1.Text = "Tablas";
            this.tablasToolStripMenuItem1.Click += new System.EventHandler(this.tablasToolStripMenuItem1_Click);
            // 
            // crearTablaToolStripMenuItem
            // 
            this.crearTablaToolStripMenuItem.Name = "crearTablaToolStripMenuItem";
            this.crearTablaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.crearTablaToolStripMenuItem.Text = "Crear Tabla";
            // 
            // eliminarTablaToolStripMenuItem
            // 
            this.eliminarTablaToolStripMenuItem.Name = "eliminarTablaToolStripMenuItem";
            this.eliminarTablaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarTablaToolStripMenuItem.Text = "Eliminar Tabla";
            // 
            // actualizarTablaToolStripMenuItem
            // 
            this.actualizarTablaToolStripMenuItem.Name = "actualizarTablaToolStripMenuItem";
            this.actualizarTablaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.actualizarTablaToolStripMenuItem.Text = "Actualizar Tabla";
            // 
            // informacionTablaToolStripMenuItem
            // 
            this.informacionTablaToolStripMenuItem.Name = "informacionTablaToolStripMenuItem";
            this.informacionTablaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.informacionTablaToolStripMenuItem.Text = "Informacion Tabla";
            // 
            // columnasToolStripMenuItem1
            // 
            this.columnasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearColumnaToolStripMenuItem,
            this.eliminarColumnaToolStripMenuItem,
            this.actualizarColumnaToolStripMenuItem,
            this.detallesColumnaToolStripMenuItem});
            this.columnasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("columnasToolStripMenuItem1.Image")));
            this.columnasToolStripMenuItem1.Name = "columnasToolStripMenuItem1";
            this.columnasToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.columnasToolStripMenuItem1.Text = "Columnas";
            this.columnasToolStripMenuItem1.Click += new System.EventHandler(this.columnasToolStripMenuItem1_Click);
            // 
            // crearColumnaToolStripMenuItem
            // 
            this.crearColumnaToolStripMenuItem.Name = "crearColumnaToolStripMenuItem";
            this.crearColumnaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.crearColumnaToolStripMenuItem.Text = "Crear Columna";
            // 
            // eliminarColumnaToolStripMenuItem
            // 
            this.eliminarColumnaToolStripMenuItem.Name = "eliminarColumnaToolStripMenuItem";
            this.eliminarColumnaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarColumnaToolStripMenuItem.Text = "Eliminar Columna";
            // 
            // actualizarColumnaToolStripMenuItem
            // 
            this.actualizarColumnaToolStripMenuItem.Name = "actualizarColumnaToolStripMenuItem";
            this.actualizarColumnaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.actualizarColumnaToolStripMenuItem.Text = "Actualizar Columna";
            // 
            // detallesColumnaToolStripMenuItem
            // 
            this.detallesColumnaToolStripMenuItem.Name = "detallesColumnaToolStripMenuItem";
            this.detallesColumnaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.detallesColumnaToolStripMenuItem.Text = "Detalles Columna";
            // 
            // restriccionesToolStripMenuItem
            // 
            this.restriccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRestriccionToolStripMenuItem,
            this.eliminarRestriccionToolStripMenuItem,
            this.actualizarRestriccionToolStripMenuItem,
            this.informacionRestriccionToolStripMenuItem});
            this.restriccionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restriccionesToolStripMenuItem.Image")));
            this.restriccionesToolStripMenuItem.Name = "restriccionesToolStripMenuItem";
            this.restriccionesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.restriccionesToolStripMenuItem.Text = "Restricciones";
            this.restriccionesToolStripMenuItem.Click += new System.EventHandler(this.restriccionesToolStripMenuItem_Click);
            // 
            // crearRestriccionToolStripMenuItem
            // 
            this.crearRestriccionToolStripMenuItem.Name = "crearRestriccionToolStripMenuItem";
            this.crearRestriccionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.crearRestriccionToolStripMenuItem.Text = "Crear Restriccion";
            // 
            // eliminarRestriccionToolStripMenuItem
            // 
            this.eliminarRestriccionToolStripMenuItem.Name = "eliminarRestriccionToolStripMenuItem";
            this.eliminarRestriccionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.eliminarRestriccionToolStripMenuItem.Text = "Eliminar Restriccion";
            // 
            // actualizarRestriccionToolStripMenuItem
            // 
            this.actualizarRestriccionToolStripMenuItem.Name = "actualizarRestriccionToolStripMenuItem";
            this.actualizarRestriccionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.actualizarRestriccionToolStripMenuItem.Text = "Actualizar Restriccion";
            // 
            // informacionRestriccionToolStripMenuItem
            // 
            this.informacionRestriccionToolStripMenuItem.Name = "informacionRestriccionToolStripMenuItem";
            this.informacionRestriccionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.informacionRestriccionToolStripMenuItem.Text = "Informacion Restriccion";
            // 
            // indecesToolStripMenuItem
            // 
            this.indecesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearIndexToolStripMenuItem,
            this.actualizarIndexToolStripMenuItem,
            this.eliminarIndexToolStripMenuItem});
            this.indecesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indecesToolStripMenuItem.Image")));
            this.indecesToolStripMenuItem.Name = "indecesToolStripMenuItem";
            this.indecesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.indecesToolStripMenuItem.Text = "Indices";
            this.indecesToolStripMenuItem.Click += new System.EventHandler(this.indecesToolStripMenuItem_Click);
            // 
            // crearIndexToolStripMenuItem
            // 
            this.crearIndexToolStripMenuItem.Name = "crearIndexToolStripMenuItem";
            this.crearIndexToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.crearIndexToolStripMenuItem.Text = "Crear Index";
            // 
            // actualizarIndexToolStripMenuItem
            // 
            this.actualizarIndexToolStripMenuItem.Name = "actualizarIndexToolStripMenuItem";
            this.actualizarIndexToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.actualizarIndexToolStripMenuItem.Text = "Actualizar Index";
            // 
            // eliminarIndexToolStripMenuItem
            // 
            this.eliminarIndexToolStripMenuItem.Name = "eliminarIndexToolStripMenuItem";
            this.eliminarIndexToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eliminarIndexToolStripMenuItem.Text = "Eliminar Index";
            // 
            // disparadoresToolStripMenuItem
            // 
            this.disparadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDisparadorToolStripMenuItem,
            this.eliminarDisparadorToolStripMenuItem,
            this.actualizarDisparadorToolStripMenuItem,
            this.informacionDisparadorToolStripMenuItem});
            this.disparadoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disparadoresToolStripMenuItem.Image")));
            this.disparadoresToolStripMenuItem.Name = "disparadoresToolStripMenuItem";
            this.disparadoresToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.disparadoresToolStripMenuItem.Text = "Disparadores";
            this.disparadoresToolStripMenuItem.Click += new System.EventHandler(this.disparadoresToolStripMenuItem_Click);
            // 
            // crearDisparadorToolStripMenuItem
            // 
            this.crearDisparadorToolStripMenuItem.Name = "crearDisparadorToolStripMenuItem";
            this.crearDisparadorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.crearDisparadorToolStripMenuItem.Text = "Crear Disparador";
            // 
            // eliminarDisparadorToolStripMenuItem
            // 
            this.eliminarDisparadorToolStripMenuItem.Name = "eliminarDisparadorToolStripMenuItem";
            this.eliminarDisparadorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.eliminarDisparadorToolStripMenuItem.Text = "Eliminar Disparador";
            // 
            // actualizarDisparadorToolStripMenuItem
            // 
            this.actualizarDisparadorToolStripMenuItem.Name = "actualizarDisparadorToolStripMenuItem";
            this.actualizarDisparadorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.actualizarDisparadorToolStripMenuItem.Text = "Actualizar Disparador";
            // 
            // informacionDisparadorToolStripMenuItem
            // 
            this.informacionDisparadorToolStripMenuItem.Name = "informacionDisparadorToolStripMenuItem";
            this.informacionDisparadorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.informacionDisparadorToolStripMenuItem.Text = "Informacion Disparador";
            // 
            // vistasToolStripMenuItem
            // 
            this.vistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearVistaToolStripMenuItem,
            this.eliminarVistaToolStripMenuItem,
            this.actualizarVistaToolStripMenuItem,
            this.informacionVistaToolStripMenuItem});
            this.vistasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistasToolStripMenuItem.Image")));
            this.vistasToolStripMenuItem.Name = "vistasToolStripMenuItem";
            this.vistasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.vistasToolStripMenuItem.Text = "Vistas";
            this.vistasToolStripMenuItem.Click += new System.EventHandler(this.vistasToolStripMenuItem_Click);
            // 
            // crearVistaToolStripMenuItem
            // 
            this.crearVistaToolStripMenuItem.Name = "crearVistaToolStripMenuItem";
            this.crearVistaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.crearVistaToolStripMenuItem.Text = "Crear Vista";
            // 
            // eliminarVistaToolStripMenuItem
            // 
            this.eliminarVistaToolStripMenuItem.Name = "eliminarVistaToolStripMenuItem";
            this.eliminarVistaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eliminarVistaToolStripMenuItem.Text = "Eliminar Vista";
            // 
            // actualizarVistaToolStripMenuItem
            // 
            this.actualizarVistaToolStripMenuItem.Name = "actualizarVistaToolStripMenuItem";
            this.actualizarVistaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.actualizarVistaToolStripMenuItem.Text = "Actualizar Vista";
            // 
            // informacionVistaToolStripMenuItem
            // 
            this.informacionVistaToolStripMenuItem.Name = "informacionVistaToolStripMenuItem";
            this.informacionVistaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.informacionVistaToolStripMenuItem.Text = "Informacion Vista";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(252, 30);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(988, 330);
            this.txtConsulta.TabIndex = 0;
            this.txtConsulta.Text = "";
            this.txtConsulta.Visible = false;
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.actulizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.propiedadesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("crearToolStripMenuItem1.Image")));
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.crearToolStripMenuItem1.Text = "Crear";
            // 
            // actulizarToolStripMenuItem
            // 
            this.actulizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actulizarToolStripMenuItem.Image")));
            this.actulizarToolStripMenuItem.Name = "actulizarToolStripMenuItem";
            this.actulizarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.actulizarToolStripMenuItem.Text = "Actualizar";
            this.actulizarToolStripMenuItem.Click += new System.EventHandler(this.actulizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("propiedadesToolStripMenuItem.Image")));
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1252, 542);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.dtgResultadoConsulta);
            this.Controls.Add(this.btnEjecutarConsulta);
            this.Controls.Add(this.labelNombreDB);
            this.Controls.Add(this.treeViewSGDB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "pgAdmin";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSGDB;
        private System.Windows.Forms.Label labelNombreDB;
        private System.Windows.Forms.Button btnEjecutarConsulta;
        private System.Windows.Forms.DataGridView dtgResultadoConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem columnasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restriccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disparadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboBasesDatosEliminar;
        private System.Windows.Forms.ToolStripMenuItem crearTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesColumnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEsquemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEsquemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actuliazarEsquemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionEsquemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSecuenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSecuenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarSecuenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRestriccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRestriccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarRestriccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionRestriccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDisparadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDisparadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDisparadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDisparadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionVistaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtConsulta;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox comboDBConsulta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actulizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
    }
}

