namespace IntersysExercise.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IntersysExercise.DAL.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IntersysExercise.DAL.AppDBContext context)
        {
            GenerateClientsRecords(context);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }

        private static void GenerateClientsRecords(DAL.AppDBContext context)
        {
            if(context.Clients.Count() == 0)
            {
                for(int i = 1; i <= 100; i++)
                {
                    var client = new Models.Client();
                    client.FirstName = $"First Name {i}";
                    client.LastName = $"Last Name {i}";

                    context.Clients.Add(client);
                }

                context.SaveChanges();
            }
        }
    }
}
