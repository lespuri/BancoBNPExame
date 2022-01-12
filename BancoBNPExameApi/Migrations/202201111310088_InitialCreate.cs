namespace BancoBNPExameApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovimentoManuals",
                c => new
                    {
                        DAT_MES = c.Int(nullable: false),
                        DAT_ANO = c.Int(nullable: false),
                        NUM_LANCAMENTO = c.Int(nullable: false),
                        COD_PRODUTO = c.String(nullable: false, maxLength: 128),
                        COD_COSIF = c.String(nullable: false, maxLength: 128),
                        DES_DESCRICAO = c.String(),
                        DAT_MOVIMENTO = c.DateTime(nullable: false),
                        COD_USUARIO = c.String(),
                        VAL_VALOR = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.DAT_MES, t.DAT_ANO, t.NUM_LANCAMENTO, t.COD_PRODUTO, t.COD_COSIF });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovimentoManuals");
        }
    }
}
