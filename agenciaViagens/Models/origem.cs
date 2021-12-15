using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenciaViagens.Models
{
    [Table("origem")]
    public class origem
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "pais_origem")]
        [Column("pais_origem")]
        public string pais_origem { get; set; }

        [Display(Name = "cidade_origem")]
        [Column("cidade_origem")]
        public string cidade_origem { get; set; }

        [Display(Name = "preco_origem")]
        [Column("preco_origem")]
        public float preco_origem { get; set; }
    }
}

