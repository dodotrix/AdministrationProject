using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Administration.Domena.Models
{
    public class PacijentZahvat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int PacijentID { get; set; }
        public Pacijent Pacijent { get; set; }

        public int ZahvatID { get; set; }
        public Zahvat Zahvat { get; set; }
    }
}
