using EV_K.Models;
using EV_K.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EV_K {
    public partial class PromjenaEvidencije : Form {
        private Zahtjev zahtjev;
        public PromjenaEvidencije( Zahtjev selectedZahtjev) {
            InitializeComponent();
            zahtjev = selectedZahtjev;
        }

        private void PromjenaEvidencije_Load(object sender, EventArgs e) {
            this.ActiveControl = null;
            SetFormText();
            int id = zahtjev.Id;
            string datumOd = zahtjev.DatumOd.ToString().Trim();
            string datumDo = zahtjev.DatumDo.ToString().Trim();
            Zahtjev zahtjevi = MjenjanjeZahjeva.GetZahtjevs(id);
            var currenttip = comboBox2.SelectedItem as Zahtjev;
            comboBox2.Text = zahtjev.Tip;
            dateTimePicker1.Value = DateTime.ParseExact(datumOd, "dd-M-yyyy", CultureInfo.InvariantCulture);
            dateTimePicker2.Value = DateTime.ParseExact(datumDo, "dd-M-yyyy", CultureInfo.InvariantCulture);
            textBox1.Text = zahtjev.Razlog;
          
        }
        private void SetFormText() {
            Text = zahtjev.Tip;
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int id = zahtjev.Id;
            string tip = comboBox2.Text;
            string razlog = textBox1.Text;
            string datumod = dateTimePicker1.Value.ToString("dd-M-yyyy");
            string datumdo = dateTimePicker2.Value.ToString("dd-M-yyyy");
            UpdateZahtjev.PromjeniZahtjev(id,datumod,datumdo,tip,razlog);
            Close();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            int id = zahtjev.Id;
            Brisanje.DeleteZahtjev(id);
            Close();
        }
    }
}
