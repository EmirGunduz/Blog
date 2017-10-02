namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class degisiklik : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false),
                        Yazi = c.String(nullable: false),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        KategoriID = c.Int(nullable: false),
                        KullaniciID = c.String(),
                    })
                .PrimaryKey(t => t.BlogID)
                .ForeignKey("dbo.Kategoris", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Blogs", new[] { "KategoriID" });
            DropTable("dbo.Blogs");
        }
    }
}
