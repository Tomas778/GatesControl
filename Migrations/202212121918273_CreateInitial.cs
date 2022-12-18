namespace GatesControl.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TriggerTime = c.DateTime(nullable: false),
                    Name = c.String(),
                    SuccessEvent = c.Boolean(nullable: false),
                    WorkerId = c.Int(nullable: false),
                    GateId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Gates", t => t.GateId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.WorkerId)
                .Index(t => t.GateId);

            CreateTable(
                "dbo.Gates",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Workers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.WorkerGates",
                c => new
                {
                    Worker_Id = c.Int(nullable: false),
                    Gate_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Worker_Id, t.Gate_Id })
                .ForeignKey("dbo.Workers", t => t.Worker_Id, cascadeDelete: true)
                .ForeignKey("dbo.Gates", t => t.Gate_Id, cascadeDelete: true)
                .Index(t => t.Worker_Id)
                .Index(t => t.Gate_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Events", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.Events", "GateId", "dbo.Gates");
            DropForeignKey("dbo.WorkerGates", "Gate_Id", "dbo.Gates");
            DropForeignKey("dbo.WorkerGates", "Worker_Id", "dbo.Workers");
            DropIndex("dbo.WorkerGates", new[] { "Gate_Id" });
            DropIndex("dbo.WorkerGates", new[] { "Worker_Id" });
            DropIndex("dbo.Events", new[] { "GateId" });
            DropIndex("dbo.Events", new[] { "WorkerId" });
            DropTable("dbo.WorkerGates");
            DropTable("dbo.Workers");
            DropTable("dbo.Gates");
            DropTable("dbo.Events");
        }
    }
}
