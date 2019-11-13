using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmArea_Triangulo : Form
    {
        public frmArea_Triangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtA.Text.Length == 0)
            {
                MessageBox.Show(" Debe ingresar el valor de A ");
                this.txtA.Focus();
                return;
            }
            if (this.txtB.Text.Length == 0)
            {
                MessageBox.Show(" Debe ingresar el valor de B ");
                this.txtB.Focus();
                return;
            }
            if (this.txtC.Text.Length == 0)
            {
                MessageBox.Show(" Debe ingresar el valor de C ");
                this.txtC.Focus();
               return;
            
            }
            //double A = Double.Parse( this,txtA. Text)
            double a, b, c, result;
           /* if (Double.TryParse(this.txtA.Text.ToString(), out result)
            {
                a = result;
            }*/
        }
      

        private double fnAreaTriangulo(double a, double b, double c)
        {
            double area = 0, sp = 0;
            sp = (a + b + c) / 2;

            area = Math.Sqrt(sp * (sp - a) * (sp - b) * (sp - c));
            return area;
        }

    }
}
