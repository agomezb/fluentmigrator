using System;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors;
using FluentMigrator.Runner.Processors.MySql;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var announcer = new ConsoleAnnouncer();
               var options = new ProcessorOptions();
               var processorFactory = new MySql5ProcessorFactory();
               using (var processor = processorFactory.Create(
                   "Server=localhost;Database=database;Uid=root;Pwd=root;Port=3306;charset=utf8;Pooling=False",
                   announcer,
                   options))
               {
                   var context = new RunnerContext(announcer);
                   var runner = new MigrationRunner(
                       typeof(AddLogTable).Assembly,
                       context,
                       processor);
                   runner.MigrateUp();
               }

               Console.ReadLine();
        }
    }

}
