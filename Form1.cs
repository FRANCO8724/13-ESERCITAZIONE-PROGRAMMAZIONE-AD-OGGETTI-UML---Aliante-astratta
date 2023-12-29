using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _13___Aliante_form_Interfaccia_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Aliante aliante = new Aliante(textBox1.Text, textBox2.Text, textBox3.Text);
            Ala ala = new Ala(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            Fusoliera fusoliera = new Fusoliera(textBox6.Text, Convert.ToInt32(textBox7.Text));
            Coda coda = new Coda(Convert.ToInt32(textBox8.Text));
            Ruota ruota = new Ruota(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));

            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
            textbox6.Text = "";
            textbox7.Text = "";
            textbox8.Text = "";
            textbox9.Text = "";
            textbox10.Text = "";
            textbox11.Text = "";
            textbox12.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            totale = ;
            descrizione = aliante.Descrizione();
            listView1.Items.Clear();
            listView1.Items.Add("Totale: " + Convert.ToString(totale));
            listView1.Items.Add("Descrizione: " + descrizione);

        }
    }
}
