namespace H4M_Assurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Circonstances", "IdDocument", "dbo.Documents");
            DropForeignKey("dbo.Contrats", "Vehicule_IdVehicule", "dbo.Vehicules");
            DropIndex("dbo.Circonstances", new[] { "IdDocument" });
            DropIndex("dbo.Contrats", new[] { "Vehicule_IdVehicule" });
            RenameColumn(table: "dbo.Documents", name: "ContratAssure_IdContrat", newName: "IdContrat");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Contrats", name: "Vehicule_IdVehicule", newName: "IdVehicule");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur1", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur2", newName: "Validateur_IdUtilisateur1");
            RenameColumn(table: "dbo.Documents", name: "__mig_tmp__0", newName: "Validateur_IdUtilisateur2");
            RenameColumn(table: "dbo.Documents", name: "__mig_tmp__1", newName: "Validateur_IdUtilisateur");
            RenameIndex(table: "dbo.Documents", name: "IX_ContratAssure_IdContrat", newName: "IX_IdContrat");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur1", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur2", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur", newName: "IX_Validateur_IdUtilisateur2");
            RenameIndex(table: "dbo.Documents", name: "__mig_tmp__0", newName: "IX_Validateur_IdUtilisateur");
            RenameIndex(table: "dbo.Documents", name: "__mig_tmp__1", newName: "IX_Validateur_IdUtilisateur1");
            AddColumn("dbo.Circonstances", "Constat_IdDocument", c => c.Int());
            AddColumn("dbo.Circonstances", "Constat_IdDocument1", c => c.Int());
            AddColumn("dbo.Circonstances", "Constat_IdDocument2", c => c.Int());
            AddColumn("dbo.Documents", "CirconstanceConstat_CirconstanceConstatId", c => c.Int());
            AddColumn("dbo.Documents", "Assure_IdUtilisateur", c => c.Int());
            AddColumn("dbo.Contrats", "IdUserCreat", c => c.Int(nullable: false));
            AddColumn("dbo.Contrats", "IdUserModif", c => c.Int(nullable: false));
            AddColumn("dbo.Contrats", "AssureId", c => c.Int(nullable: false));
            AddColumn("dbo.Contrats", "AgentAssureur_IdUtilisateur", c => c.Int());
            AddColumn("dbo.Options", "Contrat_IdContrat", c => c.String(maxLength: 128, storeType: "nvarchar"));
            AlterColumn("dbo.Contrats", "IdVehicule", c => c.Int(nullable: false));
            CreateIndex("dbo.Contrats", "IdVehicule");
            CreateIndex("dbo.Contrats", "AgentAssureur_IdUtilisateur");
            CreateIndex("dbo.Documents", "CirconstanceConstat_CirconstanceConstatId");
            CreateIndex("dbo.Documents", "Assure_IdUtilisateur");
            CreateIndex("dbo.Circonstances", "Constat_IdDocument");
            CreateIndex("dbo.Circonstances", "Constat_IdDocument1");
            CreateIndex("dbo.Circonstances", "Constat_IdDocument2");
            CreateIndex("dbo.Options", "Contrat_IdContrat");
            AddForeignKey("dbo.Documents", "CirconstanceConstat_CirconstanceConstatId", "dbo.CirconstanceConstats", "CirconstanceConstatId");
            AddForeignKey("dbo.Circonstances", "Constat_IdDocument1", "dbo.Documents", "IdDocument");
            AddForeignKey("dbo.Circonstances", "Constat_IdDocument2", "dbo.Documents", "IdDocument");
            AddForeignKey("dbo.Documents", "Assure_IdUtilisateur", "dbo.Utilisateurs", "IdUtilisateur");
            AddForeignKey("dbo.Options", "Contrat_IdContrat", "dbo.Contrats", "IdContrat");
            AddForeignKey("dbo.Contrats", "AgentAssureur_IdUtilisateur", "dbo.Utilisateurs", "IdUtilisateur");
            AddForeignKey("dbo.Circonstances", "Constat_IdDocument", "dbo.Documents", "IdDocument");
            AddForeignKey("dbo.Contrats", "IdVehicule", "dbo.Vehicules", "IdVehicule", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrats", "IdVehicule", "dbo.Vehicules");
            DropForeignKey("dbo.Circonstances", "Constat_IdDocument", "dbo.Documents");
            DropForeignKey("dbo.Contrats", "AgentAssureur_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Options", "Contrat_IdContrat", "dbo.Contrats");
            DropForeignKey("dbo.Documents", "Assure_IdUtilisateur", "dbo.Utilisateurs");
            DropForeignKey("dbo.Circonstances", "Constat_IdDocument2", "dbo.Documents");
            DropForeignKey("dbo.Circonstances", "Constat_IdDocument1", "dbo.Documents");
            DropForeignKey("dbo.Documents", "CirconstanceConstat_CirconstanceConstatId", "dbo.CirconstanceConstats");
            DropIndex("dbo.Options", new[] { "Contrat_IdContrat" });
            DropIndex("dbo.Circonstances", new[] { "Constat_IdDocument2" });
            DropIndex("dbo.Circonstances", new[] { "Constat_IdDocument1" });
            DropIndex("dbo.Circonstances", new[] { "Constat_IdDocument" });
            DropIndex("dbo.Documents", new[] { "Assure_IdUtilisateur" });
            DropIndex("dbo.Documents", new[] { "CirconstanceConstat_CirconstanceConstatId" });
            DropIndex("dbo.Contrats", new[] { "AgentAssureur_IdUtilisateur" });
            DropIndex("dbo.Contrats", new[] { "IdVehicule" });
            AlterColumn("dbo.Contrats", "IdVehicule", c => c.Int());
            DropColumn("dbo.Options", "Contrat_IdContrat");
            DropColumn("dbo.Contrats", "AgentAssureur_IdUtilisateur");
            DropColumn("dbo.Contrats", "AssureId");
            DropColumn("dbo.Contrats", "IdUserModif");
            DropColumn("dbo.Contrats", "IdUserCreat");
            DropColumn("dbo.Documents", "Assure_IdUtilisateur");
            DropColumn("dbo.Documents", "CirconstanceConstat_CirconstanceConstatId");
            DropColumn("dbo.Circonstances", "Constat_IdDocument2");
            DropColumn("dbo.Circonstances", "Constat_IdDocument1");
            DropColumn("dbo.Circonstances", "Constat_IdDocument");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur1", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.Documents", name: "IX_Validateur_IdUtilisateur2", newName: "IX_Validateur_IdUtilisateur");
            RenameIndex(table: "dbo.Documents", name: "__mig_tmp__1", newName: "IX_Validateur_IdUtilisateur2");
            RenameIndex(table: "dbo.Documents", name: "__mig_tmp__0", newName: "IX_Validateur_IdUtilisateur1");
            RenameIndex(table: "dbo.Documents", name: "IX_IdContrat", newName: "IX_ContratAssure_IdContrat");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur2", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Documents", name: "Validateur_IdUtilisateur1", newName: "Validateur_IdUtilisateur2");
            RenameColumn(table: "dbo.Documents", name: "__mig_tmp__1", newName: "Validateur_IdUtilisateur1");
            RenameColumn(table: "dbo.Contrats", name: "IdVehicule", newName: "Vehicule_IdVehicule");
            RenameColumn(table: "dbo.Documents", name: "__mig_tmp__0", newName: "Validateur_IdUtilisateur");
            RenameColumn(table: "dbo.Documents", name: "IdContrat", newName: "ContratAssure_IdContrat");
            CreateIndex("dbo.Contrats", "Vehicule_IdVehicule");
            CreateIndex("dbo.Circonstances", "IdDocument");
            AddForeignKey("dbo.Contrats", "Vehicule_IdVehicule", "dbo.Vehicules", "IdVehicule");
            AddForeignKey("dbo.Circonstances", "IdDocument", "dbo.Documents", "IdDocument", cascadeDelete: true);
        }
    }
}
