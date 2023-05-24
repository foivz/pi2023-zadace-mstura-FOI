using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EV_K.Repositories {
    public class Brisanje {
        public static void DeleteZahtjev(int Id) {

            string sql = $"DELETE FROM [dbo].[Zahtjev] WHERE [Id] = {Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            MessageBox.Show("Uspješno obrisano", "Uspješnost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
