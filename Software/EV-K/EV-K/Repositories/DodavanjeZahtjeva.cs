using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K.Repositories {
    public class DodavanjeZahtjeva {
        public static void DodajZahtjev(int Id, string DatumOd, string DatumDo, string tip,string razlog) {

            string sql = $"INSERT INTO [dbo].[Zahtjev] ([Id], [Tip], [DatumOd], [DatumDo], [Razlog], [Status], [FK_Oib]) VALUES ( '{Id}', '{tip}', '{DatumOd}', '{DatumDo}', '{razlog}', 'U tijeku',1)";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            MessageBox.Show("Uspješno kreirano","Uspješnost", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
