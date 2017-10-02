using Microsoft.AspNet.Identity.EntityFramework;

namespace Entity
{
    public class Kullanici:IdentityUser
    {
        public string AdSoyad { get; set; }
    }
}
