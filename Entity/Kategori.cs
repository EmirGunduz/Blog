using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Required]
        public string KategoriAdi { get; set; }
        [ForeignKey("UstKategorisi")]
        public int? UstKategoriID { get; set; }
        public virtual Kategori UstKategorisi { get; set; }
        public virtual List<Kategori> AltKategorileri { get; set; }
        public virtual List<Blog> Bloglar { get; set; }
    }
}
