using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_FitCard.Models;
using Microsoft.Data.SqlClient;

namespace Teste_FitCard.Repositories
{
    public class EstabelecimentoRepository
    {
        private SqlConnection conn;

        public EstabelecimentoRepository()
        {
            conn = new SqlConnection(@"Data Source=WIN7-PC\SQLEXPRESS;Initial Catalog=FitCard;User ID=Admin;Password=admin; ");
        }
        public List<Estabelecimento> Get()
        {
            string sql = @"SELECT * FROM Estabelecimento";
            return conn.Query<Estabelecimento>(sql).ToList();
        }
        public Estabelecimento Get(long id)
        {
            string sql = @"SELECT * FROM Estabelecimento WHERE id = @id";
            return conn.Query<Estabelecimento>(sql, new { id }).FirstOrDefault();
        }
        public void Post(Estabelecimento estabelecimento)
        {
            string sql = @"INSERT INTO Estabelecimento
                         (razaoSocial, nomeFantasia, cnpj, email, endereco, cidade, estado, telefone, dataDeCadastro, idCategoria, status, agencia, conta)
                         VALUES (@razaoSocial, @nomeFantasia, @cnpj, @email, @endereco, @cidade, @estado, @telefone, @dataDeCadastro, @idCategoria, @status, @agencia, @conta)";
            conn.Execute(sql, estabelecimento);
        }
        public void Delete(long id)
        {
            string sql = @"DELETE FROM Estabelecimento WHERE id = @id";
            conn.Execute(sql, new { id });
        }
        public void Update(Estabelecimento estabelecimento)
        {
            string sql = @"UPDATE Estabelecimento
                         SET razaoSocial = @razaoSocial
                         ,nomeFantasia = @nomeFantasia
                         ,cnpj = @cnpj
                         ,email = @email
                         ,endereco = @endereco
                         ,cidade = @cidade
                         ,estado = @estado
                         ,telefone = @telefone
                         ,dataDeCadastro = @dataDeCadastro
                         ,idCategoria = @idCategoria
                         ,status = @status
                         ,agencia = @agencia
                         ,conta = @conta
                         WHERE id = @id";
            conn.Execute(sql, estabelecimento);
        }
    }
}
