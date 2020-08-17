using FluentMigrator;

namespace ConsoleApp1
{
    [Migration(20180430121801)]
    public class AddLogTable1 : Migration
    {
        public override void Up()
        {
            Create.Table("Log1")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
