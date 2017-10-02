namespace DAL.Migrations
{
    using Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MyContext context)
        {
            if (context.Kategoriler.Count() == 0)
            {
                Kategori k1 = new Kategori()
                {
                    KategoriAdi = "Son Haberler",

                };
                Kategori k2 = new Kategori();
                k2.KategoriAdi = "Ürün Gelişmeleri";

                context.Kategoriler.Add(k1);
                context.Kategoriler.Add(k2);
                context.SaveChanges();

                Kategori ak1 = new Kategori();
                ak1.KategoriAdi = "Sağlık";
                ak1.UstKategoriID = k1.KategoriID;

                Kategori ak2 = new Kategori();
                ak2.KategoriAdi = "Teknoloji";
                ak2.UstKategoriID = k1.KategoriID;

                context.Kategoriler.Add(ak1);
                context.Kategoriler.Add(ak2);
                context.SaveChanges();
            }
        }
    }
}
