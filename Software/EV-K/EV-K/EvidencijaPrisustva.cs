using EV_K.Repositories;
using EV_K.Restrictions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EV_K {
    public partial class EvidencijaPrisustva : Form {
        public EvidencijaPrisustva() {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

       

        private void button2_Click(object sender, EventArgs e) {
            Povijest povijest = new Povijest();
            Hide();
            povijest.ShowDialog();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }
        static int RandomNumber(int min, int max) {
            Random random = new Random(); return random.Next(min, max);

        }
        public void button1_Click(object sender, EventArgs e) {
            var restriction = new Restrictions.Restrictions();
            string tip = comboBox1.Text;
            string razlog = textBox1.Text;
            
            string datumod = dateTimePicker1.Value.ToString("dd-M-yyyy");
            string datumdo = dateTimePicker2.Value.ToString("dd-M-yyyy");
            int random = RandomNumber(1, 1000000000);
            if (restriction.InputCheck(comboBox1.Text, textBox1.Text) == false) {
            DodavanjeZahtjeva.DodajZahtjev(random, datumod, datumdo, tip, razlog);
            } else {
                MessageBox.Show("Niste unijeli nešto", "Problem nečega", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EvidencijaPrisustva_Load(object sender, EventArgs e) {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void testbox_TextChanged(object sender, EventArgs e) {

        }

        private void label8_Tick(object sender, EventArgs e) {
            label8.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
