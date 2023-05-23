using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K.Restrictions {
    public class Restrictions {
        public void InputCheck(string tip, string razlog) {
            if (String.IsNullOrEmpty(tip)) {
                MessageBox.Show("Niste unijeli tip", "Problem tipa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrEmpty(razlog))
                if (String.IsNullOrEmpty(razlog)) {
                    MessageBox.Show("Niste unijeli razlog", "Problem razloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
