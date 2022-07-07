﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class Modelos
    {
        public Modelos()
        {
            Unidades = new HashSet<Unidades>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdModelo { get; set; }
        [MaxLength(50)]
        public string Modelo { get; set; }
        public string Obs { get; set; }
        [ForeignKey("idMarca")]
        public int idMarca { get; set; }
        public virtual Marcas IdMarca { get; set; }
        [ForeignKey("IdGrupo")]
        public int IdGrupo { get; set; }
        public virtual Grupos idGrupo { get; set; }
        public virtual ICollection<Unidades> Unidades { get; set; }
    }
}
