using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form3 : Form
    {
        private List<Persona> listadoPersona;
        public Form3()
        {
            InitializeComponent();
            listadoPersona = new List<Persona>();
        }

        public List<Persona> ListadoPersona
        {
            get
            {
                return listadoPersona;
            }
            set
            {
                listadoPersona = value;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Persona persona in listadoPersona)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = persona.Nombre;
                dataGridView1.Rows[n].Cells[1].Value = persona.Apellido;
                dataGridView1.Rows[n].Cells[2].Value = persona.Dni;
                dataGridView1.Rows[n].Cells[3].Value = persona.Materia;
                dataGridView1.Rows[n].Cells[4].Value = persona.Mail;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
