using DBLayer;
using EV_K.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV_K.Repositories {
    public class ZahtjevRepository {
        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["IdOdsutstvo"].ToString());
            string tip = reader["Tip"].ToString();
            string date = reader["Datum"].ToString();
            string razlog = reader["Razlog"].ToString();
            var zahtjev = new Zahtjev {

                Id = id,
                Tip = tip,
                Date = date,
                Razlog = razlog,

            };
            return zahtjev;
        }
        public static List<Zahtjev> GetZahtjev() {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM dbo.Odsutstvo";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add( zahtjev );
            }
            DB.CloseConnection();
            return zahtjevi;
        }


    }
}
