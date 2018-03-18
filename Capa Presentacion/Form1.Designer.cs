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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bases de Datos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Login/Group Roles");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TableSpaces");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Servidor SGDB", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Servidores", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewSGDB = new System.Windows.Forms.TreeView();
            this.labelNombreDB = new System.Windows.Forms.Label();
            this.tabControlConsultas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.tabControlConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewSGDB
            // 
            this.treeViewSGDB.Location = new System.Drawing.Point(2, 4);
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
            this.treeViewSGDB.Size = new System.Drawing.Size(213, 512);
            this.treeViewSGDB.TabIndex = 0;
            // 
            // labelNombreDB
            // 
            this.labelNombreDB.AutoSize = true;
            this.labelNombreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDB.Location = new System.Drawing.Point(222, 491);
            this.labelNombreDB.Name = "labelNombreDB";
            this.labelNombreDB.Size = new System.Drawing.Size(0, 16);
            this.labelNombreDB.TabIndex = 1;
            // 
            // tabControlConsultas
            // 
            this.tabControlConsultas.Controls.Add(this.tabPage1);
            this.tabControlConsultas.Location = new System.Drawing.Point(216, 25);
            this.tabControlConsultas.Name = "tabControlConsultas";
            this.tabControlConsultas.SelectedIndex = 0;
            this.tabControlConsultas.Size = new System.Drawing.Size(764, 339);
            this.tabControlConsultas.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgResultadoConsulta
            // 
            this.dtgResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultadoConsulta.Location = new System.Drawing.Point(216, 366);
            this.dtgResultadoConsulta.Name = "dtgResultadoConsulta";
            this.dtgResultadoConsulta.ReadOnly = true;
            this.dtgResultadoConsulta.Size = new System.Drawing.Size(760, 150);
            this.dtgResultadoConsulta.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.dtgResultadoConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlConsultas);
            this.Controls.Add(this.labelNombreDB);
            this.Controls.Add(this.treeViewSGDB);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControlConsultas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSGDB;
        private System.Windows.Forms.Label labelNombreDB;
        private System.Windows.Forms.TabControl tabControlConsultas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgResultadoConsulta;
    }
}

