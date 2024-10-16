using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_Parcial2.Controller;

namespace Examen_Parcial2
{
    public partial class Form1 : Form
    {
        PersonaController pcontrol = new PersonaController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void LimpiarTexTbox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblEliminar.Visible = false;
            txtEliminar.Visible = false;
            btnokEliminar.Visible = false;

            btnokActualizar.Visible = true;
            lblActualizr.Visible = true;
            txtActualizar.Visible = true;
        }
        private void btnokActualizar_Click(object sender, EventArgs e)
        {
            if (pcontrol.Actualizar(txtNombre.Text,Convert.ToInt32(txtEdad.Text),dateFechaNac.Value,txtCorreo.Text, Convert.ToInt32(txtActualizar.Text)))
            {
                MessageBox.Show($"Se actualizó a la persona {txtActualizar} con éxito");
                LimpiarTexTbox(this);
            }
            else
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnokActualizar.Visible = false;
            lblActualizr.Visible = false;
            txtActualizar.Visible = false;

            lblEliminar.Visible = true;
            txtEliminar.Visible = true;
            btnokEliminar.Visible = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgview.Visible = true;
            if (pcontrol.ObtenerInfo().Count>0)
            {
                dgview.DataSource = pcontrol.ObtenerInfo();
            }
            else
            {
                MessageBox.Show("No hay personas :c");
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pcontrol.Insertar(txtNombre.Text, Convert.ToInt32(txtEdad.Text), dateFechaNac.Value, txtCorreo.Text))
                {
                    MessageBox.Show("Persona se agregó con éxito");
                    LimpiarTexTbox(this);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
