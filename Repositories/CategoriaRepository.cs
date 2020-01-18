using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_FitCard.Models;
using Microsoft.Data.SqlClient;

namespace Teste_FitCard.Repositories
{
    public class CategoriaRepository
    {
        private SqlConnection conn;

        public CategoriaRepository()
        {
            conn = new SqlConnection(@"Data Source=WIN7-PC\SQLEXPRESS;Initial Catalog=FitCard;User ID=Admin;Password=admin; ");
        }
        public List<Categoria> Get()
        {
            string sql = @"SELECT * FROM Categoria";
            return conn.Query<Categoria>(sql).ToList();
        }
    }
}
