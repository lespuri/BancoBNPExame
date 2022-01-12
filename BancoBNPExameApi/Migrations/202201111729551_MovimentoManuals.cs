namespace BancoBNPExameApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentoManuals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdutoCosifs",
                c => new
                    {
                        COD_PRODUTO = c.String(nullable: false, maxLength: 128),
                        COD_COSIF = c.String(nullable: false, maxLength: 128),
                        DES_PRODUTO = c.String(),
                        COD_CLASSIFICACAO = c.String(),
                        STA_STATUS = c.String(),
                    })
                .PrimaryKey(t => new { t.COD_PRODUTO, t.COD_COSIF })
                .ForeignKey("dbo.Produtoes", t => t.COD_PRODUTO, cascadeDelete: true)
                .Index(t => t.COD_PRODUTO);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        COD_PRODUTO = c.String(nullable: false, maxLength: 128),
                        DES_PRODUTO = c.String(),
                        STA_PRODUTO = c.String(),
                    })
                .PrimaryKey(t => t.COD_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutoCosifs", "COD_PRODUTO", "dbo.Produtoes");
            DropIndex("dbo.ProdutoCosifs", new[] { "COD_PRODUTO" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.ProdutoCosifs");
        }
    }
}
