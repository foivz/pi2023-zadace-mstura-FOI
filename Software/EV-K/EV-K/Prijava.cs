using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EV_K {
    public partial class Prijava : Form {
        public Prijava() {
            InitializeComponent();
        }
        string username = "Juro";
        string password = "hjkl123";
        private void button1_Click(object sender, EventArgs e) {
            EvidencijaPrisustva ep = new EvidencijaPrisustva();
            if (textBox1.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (textBox2.Text == "") {
                MessageBox.Show("Pristupni kod nije unesen!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                if (textBox1.Text == username && textBox2.Text == password) {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    ep.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

            
        }
    }
}
