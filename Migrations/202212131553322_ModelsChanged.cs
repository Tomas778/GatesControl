namespace GatesControl.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ModelsChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Action", c => c.String());
            AddColumn("dbo.Gates", "Code", c => c.String());
            AddColumn("dbo.Workers", "Code", c => c.String());
            DropColumn("dbo.Events", "Name");
        }

        public override void Down()
        {
            AddColumn("dbo.Events", "Name", c => c.String());
            DropColumn("dbo.Workers", "Code");
            DropColumn("dbo.Gates", "Code");
            DropColumn("dbo.Events", "Action");
        }
    }
}
