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

        private void EvidencijaPrisustva_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'iPS23_mstura21DataSet.Odsutstvo' table. You can move, or remove it, as needed.
            this.odsutstvoTableAdapter.Fill(this.iPS23_mstura21DataSet.Odsutstvo);

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
    }
}
