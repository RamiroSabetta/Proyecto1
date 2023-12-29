namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private ControladorPersona cp;
        private Persona perso;
        private List<Persona> listadoPersona;


        public Form1()
        {
            InitializeComponent();
            cp = new ControladorPersona();
            perso = new Persona();
            listadoPersona = new List<Persona>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Dni = int.Parse(textBox3.Text);
            persona.Materia = Convert.ToString(comboBox1.Items[comboBox1.SelectedIndex]);
            persona.Mail = textBox4.Text;

            perso = persona;
            cp.adicionarPersona(persona);
            listadoPersona = cp.listadoPersonas();
            MessageBox.Show("DATOS CARGADOS");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            textBox4.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 pd = new Form2();
            pd.Pers = perso;
            pd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 pt = new Form3();
            pt.ListadoPersona = this.listadoPersona;
            pt.ShowDialog();
        }
    }
}