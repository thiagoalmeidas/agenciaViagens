using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenciaViagens.Models
{
    [Table("destino")]
    public class destin
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "pais_destino")]
        [Column("pais_destino")]
        public string pais_destino { get; set; }

        [Display(Name = "cidade_destino")]
        [Column("cidade_destino")]
        public string cidade_destino { get; set; }

        [Display(Name = "preco_destino")]
        [Column("preco_destino")]
        public float preco_destino { get; set; }
    }
}

