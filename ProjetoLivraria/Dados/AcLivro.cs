using MySql.Data.MySqlClient;
using ProjetoLivraria.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Dados
{
    public class AcLivro
    {
        Conexao Con = new Conexao();
        
        public void inserirLivro(ModLivro cm)
        {
            MySqlCommand cmd = new MySqlCommand("Server=localhost; Database=bdlivraria8_3; User=root; pwd=12345678", Con.ConectarBD());
            cmd.Parameters.Add("@nomeLivro", MySqlDbType.VarChar).Value = cm.nomeLivro;
            cmd.Parameters.Add("@nomeLivro", MySqlDbType.VarChar).Value = cm.codAutor;
        }


        public List<ModLivro> mostrarLivro()
        {
            List<ModLivro> listalivros = new List<ModLivro>();
            MySqlCommand cmd = new MySqlCommand("select tbLivro.codLivro, tbLivro.nomeLivro,tbAutor.nomeAutor from tbLivro inner join tbAutor on tbLivro.codAutor = tbAutor.codAutor;", Con.ConectarBD());

        }
    }
}