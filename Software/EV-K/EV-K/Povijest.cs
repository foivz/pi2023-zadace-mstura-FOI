using DBLayer;
using EV_K.Models;
using EV_K.Repositories;
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

       
    }
}
