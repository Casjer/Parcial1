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

            if(string.IsNullOrEmpty(RentencionnumericUpDown.ToString()))
            {
                ErrorProvider.Equals(RentencionnumericUpDown, " llenar Rentacion");
                return false;
            }
            return true;
               
        }
            private Vendedores LLenaClase()
            {
                Vendedores vendedor = new Vendedores()
                vendedore.
            }




        
    }
}
