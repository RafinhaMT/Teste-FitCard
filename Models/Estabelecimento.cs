using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_FitCard.Models
{
    [Serializable]
    public class Estabelecimento
    {
        [DisplayName("Id")]
        public long id { get; set; }
        [Required(ErrorMessage = "Insira este campo")]
        [DisplayName("Razão Social")]
        public string razaoSocial { get; set; }
        [DisplayName("Nome Fantasia")]
        public string nomeFantasia { get; set; }
        [Required(ErrorMessage = "Insira este campo")]
        [DisplayName("CNPJ")]
        public string cnpj { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage = "Este e-mail é inválido")]
        [DisplayName("E-mail")]
        public string email { get; set; }
        [DisplayName("Endereço")]
        public string endereco { get; set; }
        [DisplayName("Cidade")]
        public string cidade { get; set; }  
        [DisplayName("Estado")]
        public string estado { get; set; }
        [DisplayName("Telefone")]
        public string telefone { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Esta data é inválida")]
        [DisplayName("Data de cadastro")]    
        public DateTime? dataDeCadastro { get; set; }
        [DisplayName("Categoria")]
        public int idCategoria   { get; set; }
        [DisplayName("Ativo")]
        public bool status { get; set; }
        [DisplayName("Agência")]
        public string agencia { get; set; }
        [DisplayName("Conta")]
        public string conta { get; set; }       
    }
}
