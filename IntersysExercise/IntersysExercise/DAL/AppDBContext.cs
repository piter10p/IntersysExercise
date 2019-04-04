using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IntersysExercise.Models;

namespace IntersysExercise.DAL
{
    public class AppDBContext: DbContext
    {

        public AppDBContext()
            :base("default")
        { }

        public DbSet<Client> Clients { get; set; }
    }
}