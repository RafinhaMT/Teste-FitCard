using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_FitCard.Helper;
using Teste_FitCard.Models;
using Teste_FitCard.Repositories;

namespace Teste_FitCard.Services
{
    public class EstabelecimentoService
    {
        private EstabelecimentoRepository repository;
        public EstabelecimentoService()
        {
            repository = new EstabelecimentoRepository();
        }
        public List<Estabelecimento> Get()
        {
            return repository.Get();
        }
        public Estabelecimento Get(long id)
        {
            return repository.Get(id);
        }
        public void Post(Estabelecimento estabelecimento)
        {
            if (Validacoes.IsCNPJ(estabelecimento.cnpj))
            {
                if (Validacoes.ValidarCategoria(estabelecimento))
                {
                    repository.Post(estabelecimento);
                }
                else
                {
                    throw new Exception("Telefone é obrigatório para supermercados");
                }
            }
            else
            {
                throw new Exception("Insira um CNPJ válido");
            }
        }
        public void Delete(long id)
        {
            repository.Delete(id);
        }
        public void Update(Estabelecimento estabelecimento)
        {
            if (Validacoes.IsCNPJ(estabelecimento.cnpj))
            {
                if (Validacoes.ValidarCategoria(estabelecimento))
                {
                    repository.Update(estabelecimento);
                }
                else
                {
                    throw new Exception("Telefone é obrigatório para supermercados");
                }
            }
            else
            {
                throw new Exception("Insira um CNPJ válido");
            }
        }
    }
}
