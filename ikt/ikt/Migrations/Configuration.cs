namespace ikt.Migrations
{
    using ikt.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ikt.DAL.iktContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ikt.DAL.iktContext";
        }

        protected override void Seed(ikt.DAL.iktContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var staff = new List<Staff>
            {
                new Staff
                {
                    Username = "9810pema",
                    FirstName = "Marcus",
                    LastName = "Perhamn"
                },
            };

            staff.ForEach(s => context.Staff.AddOrUpdate(st => st.Username, s));
            context.SaveChanges();

            var Class = new List<Class>
            {
                new Class
                {
                    Namn = "EK15A"
                },

                new Class
                {
                    Namn = "EK15B"
                },

                new Class
                {
                    Namn = "EK16A"
                },

                new Class
                {
                    Namn = "EK16B"
                },

                new Class
                {
                    Namn = "EK17A"
                },

                new Class
                {
                    Namn = "IMA"
                },

                new Class
                {
                    Namn = "IMS17:1"
                },

                new Class
                {
                    Namn = "IMS17:2A"
                },

                new Class
                {
                    Namn = "IMS17:2B1"
                },

                new Class
                {
                    Namn = "IMS17:2B2"
                },

                new Class
                {
                    Namn = "IMS17:3A"
                },

                new Class
                {
                    Namn = "IMS17:3B"
                },

                new Class
                {
                    Namn = "NA15A"
                },

                new Class
                {
                    Namn = "NA15B"
                },

                new Class
                {
                    Namn = "NA15C"
                },

                new Class
                {
                    Namn = "NA15C"
                },

                new Class
                {
                    Namn = "NA15D"
                },

                new Class
                {
                    Namn = "NA16A"
                },

                new Class
                {
                    Namn = "NA16B"
                },

                new Class
                {
                    Namn = "NA16C"
                },

                new Class
                {
                    Namn = "NA16D"
                },

                new Class
                {
                    Namn = "NA17A"
                },

                new Class
                {
                    Namn = "NA17B"
                },

                new Class
                {
                    Namn = "NA17C"
                },

                new Class
                {
                    Namn = "NA17D"
                },

                new Class
                {
                    Namn = "NA4"
                },

                new Class
                {
                    Namn = "SA15A"
                },

                new Class
                {
                    Namn = "SA15B"
                },

                new Class
                {
                    Namn = "SA16A"
                },

                new Class
                {
                    Namn = "SA16B"
                },

                new Class
                {
                    Namn = "SA17A"
                },

                new Class
                {
                    Namn = "SA17B"
                },

                new Class
                {
                    Namn = "SA4"
                },

                new Class
                {
                    Namn = "T4"
                },

                new Class
                {
                    Namn = "TE15A"
                },

                new Class
                {
                    Namn = "TE15B"
                },

                new Class
                {
                    Namn = "TE15C"
                },

                new Class
                {
                    Namn = "TE15D"
                },

                new Class
                {
                    Namn = "TE16A"
                },

                new Class
                {
                    Namn = "TE16B"
                },

                new Class
                {
                    Namn = "TE16C"
                },

                new Class
                {
                    Namn = "TE16D"
                },

                new Class
                {
                    Namn = "TE17A"
                },
                new Class
                {
                    Namn = "TE17B"
                },

                new Class
                {
                    Namn = "TE17C"
                },

                new Class
                {
                    Namn = "TE17D"
                },

                new Class
                {
                    Namn = "TE4"
                },

                new Class
                {
                    Namn = "VF15A"
                },

                new Class
                {
                    Namn = "VF15B"
                },

                new Class
                {
                    Namn = "VF16A"
                },

                new Class
                {
                    Namn = "VF16B"
                },

                new Class
                {
                    Namn = "VF17"
                },

                new Class
                {
                    Namn = "VF4"
                },

                new Class
                {
                    Namn = "VO15A"
                },

                new Class
                {
                    Namn = "VO15B"
                },

                new Class
                {
                    Namn = "VO15Y"
                },

                new Class
                {
                    Namn = "Vo16A"
                },

                new Class
                {
                    Namn = "Vo16B"
                },

                new Class
                {
                    Namn = "Vo16Y"
                },

                new Class
                {
                    Namn = "Vo17A"
                },

                new Class
                {
                    Namn = "Vo17B"
                },

                new Class
                {
                    Namn = "Vo17Y"
                },

                new Class
                {
                    Namn = "VO4"
                },
            };

            Class.ForEach(s => context.Class.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var Project = new List<Project>
            {
                new Project
                {
                    Name = "Barnkunskap/Svenska 3",
                    Description = "I Svenska 3 ska vi göra ett projekt där vi knyter ihop källkritik och stoffinsamling på nätet (Barnkonventionen etc) med kursen Barnhälsovård.",
                    Date = "HT17",
                    PDF = "...",
                    Grade = "VO15"
                },

                new Project
                {
                    Name = "Dokumentärfilm-sprojektet.",
                    Description = "Ett arbete inom svenska 1 där eleverna spelar in egna dokumentärfilmer kring ämnesområdet språksociologi.",
                    Date = "VT2017 , HT2017, VT2018",
                    PDF = "...",
                    Grade = "Alla åk 1"
                },

                new Project
                {
                    Name = "Sveriges 'mörka' historia",
                    Description = "Ett ämnesövergripande arbetsområde i samhällskunskap och historia med fokus på den del av Sveriges historia som vi sällar pratar om - utifrån",
                    Date = "Nasa 16 , Na15B , Na15C",
                    PDF = "",
                    Grade = "VT 2018"
                },
            };

            Project.ForEach(s => context.Project.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();
        }
    }
}
