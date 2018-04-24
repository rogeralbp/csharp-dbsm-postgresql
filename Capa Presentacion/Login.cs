using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        string claveAnthonny = "1414250816ma";
        string claveBryan = "bryan2748245";
        string claveRoger = "Saborio17";

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseñaPostgres.Text.Length!=0)
            {
                if (txtContraseñaPostgres.Text == claveAnthonny || txtContraseñaPostgres.Text == claveBryan || txtContraseñaPostgres.Text == claveRoger)
                {
                    this.Hide();
                    Principal v = new Principal();
                    v.Show();
                   
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta.");
                }
            }
            else {

                MessageBox.Show("Introduzca la Contraseña.");
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {          
        }

        private void txtContraseñaPostgres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtContraseñaPostgres.Text == claveAnthonny || txtContraseñaPostgres.Text == claveBryan || txtContraseñaPostgres.Text == claveRoger)
                {
                    this.Hide();
                    Principal v = new Principal();
                    v.Show();
                    
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta.");
                }

            }
        }
    }
}
