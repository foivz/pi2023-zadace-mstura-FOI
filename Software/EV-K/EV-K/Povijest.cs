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

        private void button1_Click(object sender, EventArgs e) {
            EvidencijaPrisustva ep = new EvidencijaPrisustva();

            Hide();
            ep.ShowDialog();
            Close();
        }
    }
}
