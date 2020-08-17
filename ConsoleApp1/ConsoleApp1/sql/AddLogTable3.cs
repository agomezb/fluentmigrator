using ConsoleApp1.Properties;
using FluentMigrator;

namespace ConsoleApp1
{
    [Migration(20180430121804)]
    public class AddLogTable3 : Migration
    {
        public override void Up()
        {
            Execute.Sql(Properties.Resources.test);
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
