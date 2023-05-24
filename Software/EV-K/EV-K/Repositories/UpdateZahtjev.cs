using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K.Repositories {
    public class UpdateZahtjev {
        public static void PromjeniZahtjev(int Id, string DatumOd, string DatumDo, string tip, string razlog) {

            string sql = $"UPDATE [dbo].[Zahtjev] SET [Tip] = '{tip}', [DatumOd] = '{DatumOd}', [DatumDo] = '{DatumDo}', [Razlog] = '{razlog}' WHERE [Id]= {Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            MessageBox.Show("Uspješno promjenjeno", "Uspješnost", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
