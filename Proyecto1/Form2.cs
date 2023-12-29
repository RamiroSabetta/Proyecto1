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
    public partial class Form2 : Form
    {
        private Persona pers;
        public Form2()
        {
            InitializeComponent();
            pers = new Persona();

        }
        public Persona Pers
        {
            get
            {
                return pers;
            }
            set
            {
                pers = value;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = pers.Nombre;
            label8.Text = pers.Apellido;
            label9.Text = Convert.ToString(pers.Dni);
            label10.Text = pers.Materia;
            label11.Text = pers.Mail;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
