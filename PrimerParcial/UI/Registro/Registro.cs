using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if(string.IsNullOrEmpty(NombretextBox.Text))
            {
                ErrorProvider.Equals(NombretextBox, "llenar Nombre");
                    return false;
            }

            if (string.IsNullOrEmpty(SueldonumericUpDow.ToString()))
            {
                ErrorProvider.Equals(SueldonumericUpDow, "llenar Sueldo");
                    return false;
            }

            if(string.IsNullOrEmpty(RetencionnumericUpDown.ToString()))
            {
                ErrorProvider.Equals(RetencionnumericUpDown, " llenar Rentacion");
                return false;
            }
            return true;
               
        }
            private Vendedores LLenaClase()
            {
            Vendedores vendedor = new Vendedores();
                vendedor.VendedroresId = Convert.ToInt32(VendedorIdnumericUpDown.Value);
                vendedor.Nombre = NombretextBox.Text;
                vendedor.Sueldo = Convert.ToInt32(SueldonumericUpDow.Value);
                vendedor.Retencion = Convert.ToInt32(RetencionnumericUpDown.Value);
                return vendedor;

            }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            VendedorIdnumericUpDown.Value = 0;
           
            NombretextBox.Clear();
            SueldonumericUpDow.Value = 0;
            RetencionnumericUpDown.Value = 0;
           
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("llena", "y trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            {
                Vendedores vendedor = LLenaClase();
                bool paso = false;


                if (VendedorIdnumericUpDown.Value == 0)
                {
                    paso = BLL.VendedoresBll.Guardar(vendedor);
                }
                else
                {
                    paso = BLL.VendedoresBll.Modificar(vendedor);
                }

                if (paso)
                {
                    MessageBox.Show("guardado", "se guardo exitosamente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VendedorIdnumericUpDown.Value);
            if (BLL.VendedoresBll.Eliminar(id))
                MessageBox.Show("fue eliminado", "acceptado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VendedorIdnumericUpDown.Value);
            Vendedores vendedor = BLL.VendedoresBll.Buscar(id);


            if (vendedor != null)

            {
               
                NombretextBox.Text =vendedor.Nombre;
                SueldonumericUpDow.Value = vendedor.Sueldo;
               RetencionnumericUpDown.Value = vendedor.Retencion;
               
            }
            else
            {
                MessageBox.Show("no encontrado", "Buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SueldonumericUpDow_ValueChanged(object sender, EventArgs e)
        {
            if(RetencionnumericUpDown.Value != 0 && SueldonumericUpDow.Value !=0)
            {
                PorcientoRetenciontextBox = Convert.ToDecimal(RetencionnumericUpDown.Value / SueldonumericUpDow.Value *  100);
            }
        }
    }
    
}
