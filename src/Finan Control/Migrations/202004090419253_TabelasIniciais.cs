namespace Finan_Control.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movimentacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        TipoMovimentracao = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Usuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id, cascadeDelete: true)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentacaos", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.Movimentacaos", new[] { "Usuario_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Movimentacaos");
        }
    }
}
