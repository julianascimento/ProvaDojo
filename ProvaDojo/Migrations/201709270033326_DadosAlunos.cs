namespace ProvaDojo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DadosAlunos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes VALUES('Martim Castro Ribeiro', 1, 3, '158.778.735-04')");
            Sql("INSERT INTO Alunoes VALUES('Lucas Alves Melo', 4, 5, '916.749.332-74')");
            Sql("INSERT INTO Alunoes VALUES('Breno Castro Carvalho', 2, 4, '454.019.800-94')");
            Sql("INSERT INTO Alunoes VALUES('Laura Cardoso Rocha', 6, 6, '361.089.665-56')");
        }
        
        public override void Down()
        {
        }
    }
}
