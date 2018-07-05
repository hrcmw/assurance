namespace H4M_Assurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validitecontrat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contrats", "ValableDu", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Contrats", "ValableAu", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contrats", "ValableAu");
            DropColumn("dbo.Contrats", "ValableDu");
        }
    }
}
