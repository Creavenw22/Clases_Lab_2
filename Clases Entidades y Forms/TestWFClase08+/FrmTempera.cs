using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades07_08;

namespace TestWFClase08_
{
    public partial class FrmTempera : Form
    {
        private Tempera t_miTempera;

        public Tempera MiTempera
        {
            get
            {
                return t_miTempera;
            }
        }

        public FrmTempera()
        {
            
            InitializeComponent();
            this.label1.Text = "Color";
            this.label2.Text = "Marca";
            this.label3.Text = "Cantidad";

            this.button1.Text = "Aceptar";
            this.button2.Text = "Cancelar";

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(color);
            }

            this.comboBox1.SelectedItem = ConsoleColor.DarkYellow;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.t_miTempera = new Tempera(sbyte.Parse(this.textBox2.Text), (ConsoleColor)this.comboBox1.SelectedItem, this.textBox1.Text);
        }
    }
}
