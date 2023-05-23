using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K.Restrictions {
    public class Restrictions {
        public bool InputCheck(string tip, string razlog) {
            bool pro1 = false;
            bool pro2 = false;
            if (String.IsNullOrEmpty(tip)) {
                MessageBox.Show("Niste unijeli tip", "Problem tipa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pro1 = true;
            } else {
                pro1 = false;
            }
            if (String.IsNullOrEmpty(razlog))
                if (String.IsNullOrEmpty(razlog)) {
                    MessageBox.Show("Niste unijeli razlog", "Problem razloga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pro2 = true;
                } else {
                    pro2 = false;
                }
            return (pro1 && pro2);
        }
    }
}
