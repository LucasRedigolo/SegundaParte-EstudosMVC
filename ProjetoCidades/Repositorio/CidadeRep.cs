using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ProjetoCidades.Models;

namespace ProjetoCidades.Repositorio {
    public class CidadeRep {
        string connectionString = @"Data Source=.\SqlExpress; Initial Catalog= ProjetoCidades; uid = sa; Password = senai@123";

        public List<Cidade> Listar () {
            List<Cidade> lstCidades = new List<Cidade> ();
            SqlConnection con = new SqlConnection (connectionString);

            string SqlQuery = "Select * from Cidades";
            SqlCommand cmd = new SqlCommand (SqlQuery, con);

            con.Open ();

            SqlDataReader rd = cmd.ExecuteReader ();

            while (rd.Read ()) {
                Cidade cidade = new Cidade ();
                cidade.ID = Convert.ToInt16 (rd["ID"]);
                cidade.Nome = Convert.ToString (rd["Nome"]);
                cidade.Estado = rd["Estado"].ToString ();
                cidade.Habitantes = Convert.ToInt16 (rd["Habitantes"]);

                lstCidades.Add (cidade);
            }
            con.Close ();

            return lstCidades;

        }

        public void Cadastrar (Cidade cidade) {
            SqlConnection con = new SqlConnection (connectionString);
            string SqlQuery = "insert into Cidades(Nome, Estado, Habitantes) values('" + cidade.Nome + "', '" + cidade.Estado + "', " + cidade.Habitantes + ")";

            SqlCommand cmd = new SqlCommand (SqlQuery, con);
            con.Open ();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}