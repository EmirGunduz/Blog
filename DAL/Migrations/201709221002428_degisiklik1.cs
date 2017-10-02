namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class degisiklik1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Kategoris", new[] { "UstKategoriID" });
            AlterColumn("dbo.Kategoris", "UstKategoriID", c => c.Int());
            CreateIndex("dbo.Kategoris", "UstKategoriID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kategoris", new[] { "UstKategoriID" });
            AlterColumn("dbo.Kategoris", "UstKategoriID", c => c.Int(nullable: false));
            CreateIndex("dbo.Kategoris", "UstKategoriID");
        }
    }
}
