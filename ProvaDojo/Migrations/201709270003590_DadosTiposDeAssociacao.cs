namespace ProvaDojo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosTiposDeAssociacao : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipoDeAssociacaos VALUES ('Mensal', 1, 140)");
            Sql("INSERT INTO TipoDeAssociacaos VALUES ('Trimestral', 3, 400)");
            Sql("INSERT INTO TipoDeAssociacaos VALUES ('Semestral', 6, 600)");
            Sql("INSERT INTO TipoDeAssociacaos VALUES ('Anual', 12, 1400)");
        }
        
        public override void Down()
        {
        }
    }
}
