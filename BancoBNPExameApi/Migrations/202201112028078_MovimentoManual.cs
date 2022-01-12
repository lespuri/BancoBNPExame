namespace BancoBNPExameApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentoManual : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.MovimentoManuals", "COD_PRODUTO");
            AddForeignKey("dbo.MovimentoManuals", "COD_PRODUTO", "dbo.Produtoes", "COD_PRODUTO", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovimentoManuals", "COD_PRODUTO", "dbo.Produtoes");
            DropIndex("dbo.MovimentoManuals", new[] { "COD_PRODUTO" });
        }
    }
}
