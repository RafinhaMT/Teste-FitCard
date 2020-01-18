using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_FitCard.Models;
using Teste_FitCard.Repositories;

namespace Teste_FitCard.Services
{
    public class CategoriaService
    {
        private CategoriaRepository repository;
        public CategoriaService()
        {
            repository = new CategoriaRepository();
        }
        public List<Categoria> Get()
        {
            return repository.Get();
        }
    }
}
