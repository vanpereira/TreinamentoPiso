using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoPisoComercial.Web.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(255)]
        [Required]
        public string NomeCompletoRazaoSocial { get; set; }

        [StringLength(255)]
        public string ApelidoNomeFantasia { get; set; }

        [StringLength(15)]
        [Required]
        public string CPFCNPJ { get; set; }
    }
}