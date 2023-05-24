using DBLayer;
using EV_K.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV_K.Repositories {
    public class MjenjanjeZahjeva {

        public static Zahtjev GetZahtjevs(int Id) {
            Zahtjev zahtjevi = null;
            string sql = $"SELECT * FROM [dbo].[Zahtjev] WHERE Id = {Id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows) {
                reader.Read();
                zahtjevi = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zahtjevi;
        }
        private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string tip = reader["Tip"].ToString();
            string datumOd = reader["DatumOd"].ToString();
            string datumDo = reader["DatumDo"].ToString();
            string razlog = reader["Razlog"].ToString();
            string status = reader["Status"].ToString();
            int zaposlenik = int.Parse(reader["FK_Oib"].ToString());
            var zahtjev = new Zahtjev {

                Id = id,
                Tip = tip,
                DatumOd = datumOd,
                DatumDo = datumDo,
                Razlog = razlog,
                Status = status,
                FK_Oib = zaposlenik
            };
            return zahtjev;
        }


    }
}
