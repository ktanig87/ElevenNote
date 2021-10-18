namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Note", "CreatedUrc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "CreatedUrc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Note", "CreatedUtc");
        }
    }
}
