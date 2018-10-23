using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }

            this.cboColor.SelectedItem = ConsoleColor.DarkBlue;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoTinta tinta in Enum.GetValues(typeof(ETipoTinta)))
            {
                this.cboTinta.Items.Add(tinta);
            }


            this.cboTinta.SelectedItem = ETipoTinta.Comun;
            this.cboTinta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmTinta_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
