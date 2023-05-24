using DBLayer;
using EV_K.Models;
using EV_K.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K {
    public partial class Povijest : Form {
        public Povijest() {
            
            InitializeComponent();
        }
        private void Povijest_Load(object sender, EventArgs e) {
            ShowZahtjevi();
        }
        
        private void ShowZahtjevi() {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjev();
            dgvZahtjevi.DataSource = zahtjevi;
            
        }
        private void button1_Click(object sender, EventArgs e) {
            EvidencijaPrisustva ep = new EvidencijaPrisustva();

            Hide();
            ep.ShowDialog();
            Close();
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Povijest_Load_1(object sender, EventArgs e) {
            timer1.Start();
            ShowZahtjevi();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            Zahtjev selectedZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            if(selectedZahtjev != null ) {
                PromjenaEvidencije promjenaEvidencije = new PromjenaEvidencije(selectedZahtjev);
                promjenaEvidencije.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Refresh();
            Povijest ep = new Povijest();

            Hide();
            ep.ShowDialog();
            Close();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
