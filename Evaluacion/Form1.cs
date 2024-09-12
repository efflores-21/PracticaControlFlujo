using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            EvaluacionData data = new EvaluacionData();
            // Esto es por si se deja un espacio en blanco en el formulario
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbAge.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                //el mensaje que da cuanto los campos del cuestionario no estan completos
                lblMessage.Text = "Por favor, complete todos los campos.";
                return;
            }
            //aqui si el usuario no pone la edad bien 
            if (!int.TryParse(tbAge.Text, out int edad))
            {
                lblMessage.Text = "La edad debe ser un número válido.";
                return;
            }

            data.Nombre = tbName.Text;
            data.Edad = edad;
            data.Email = tbEmail.Text;
            // aqui se muestra el mensaje que se va a mostrar si el usuario es menor de edad o si el correo esta malo y el mensaje que se va a mostrar si todos los datos estan bien
            if (!data.ValidarEdad())
            {
                lblMessage.Text = "Debes ser mayor de edad para continuar.";
            }
            else if (!data.ValidarEmail())
            {
                lblMessage.Text = "El correo electrónico no tiene un formato válido.";
            }
            else
            {
                lblMessage.Text = $"Datos válidos. Rango de edad: {data.CalcularRangoEdad()}.";
            }
        }
    }
}

