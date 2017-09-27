namespace ProvaDojo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosFaixas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixas VALUES('Branca', '6k')");
            Sql("INSERT INTO Faixas VALUES('Amarela','5k')");
            Sql("INSERT INTO Faixas VALUES('Roxa','4k')");
            Sql("INSERT INTO Faixas VALUES('Verde','3k')");
            Sql("INSERT INTO Faixas VALUES('Azul','2k')");
            Sql("INSERT INTO Faixas VALUES('Marrom','1k')");
            Sql("INSERT INTO Faixas VALUES('Preta','1d')");
        }
        
        public override void Down()
        {
        }
    }
}
