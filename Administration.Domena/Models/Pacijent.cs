using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Administration.Domena.Models
{
    public class Pacijent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prezime { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telefon { get; set; }

        [Required]
        public string Adresa { get; set; }

        [NotMapped]
        public string  PunoIme {
            get
            {
                return Ime + " " + Prezime;
            }
        }
    }
}
