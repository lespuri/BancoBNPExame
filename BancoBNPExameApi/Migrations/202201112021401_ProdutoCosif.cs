namespace BancoBNPExameApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProdutoCosif : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProdutoCosifs", "DES_PRODUTO");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProdutoCosifs", "DES_PRODUTO", c => c.String());
        }
    }
}
