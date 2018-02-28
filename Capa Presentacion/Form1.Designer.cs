namespace Capa_Presentacion
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nombre del Servidor", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Servidores", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodoBasesDeDatos";
            treeNode1.Text = "Bases de Datos";
            treeNode2.Name = "NodoLogin";
            treeNode2.Text = "Login/Group Roles";
            treeNode3.Name = "NodoTableSpaces";
            treeNode3.Text = "TableSpaces";
            treeNode4.Name = "NodoNombreServidor";
            treeNode4.Text = "Nombre del Servidor";
            treeNode5.Name = "NodoServidor";
            treeNode5.Text = "Servidores";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(213, 500);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 507);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

