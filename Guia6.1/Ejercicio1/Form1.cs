using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DepartamentoVehicular DepVeh = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombre.Text;
                string patente = tbPatente.Text;
                Persona propietario = new Persona(dni, nombre);
                RegistroVehiculo rv = DepVeh.RegistrarVehiculo(propietario, patente);
            }
            catch (RangoDniIncorrectoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            FormVer fVer = new FormVer();
            DepVeh.OrdenarRegistros();

            for (int n = 0; n < DepVeh.CantidadRegistros; n++)
            {
                fVer.lbxResultados.Text +=DepVeh.VerRegistro(n).ToString();
            }

            fVer.ShowDialog();
        }
    }
}
