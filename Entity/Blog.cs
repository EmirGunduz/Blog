using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        public string Baslik { get; set; }
        [Required]
        public string Yazi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        [ForeignKey("Kategorisi")]
        public int KategoriID { get; set; }
        public string KullaniciID { get; set; }
        public virtual Kategori Kategorisi { get; set; }
        public Blog()
        {
            EklenmeTarihi = DateTime.Now;
        }
    }
}
