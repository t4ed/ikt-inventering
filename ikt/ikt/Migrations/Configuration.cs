namespace ikt.Migrations
{
    using ikt.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ikt.DAL.iktContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ikt.DAL.iktContext";
        }

        protected override void Seed(ikt.DAL.iktContext context)
        {
            var staff = new List<Staff>
            {
                new Staff
                {
                    Username = "admin",
                    FirstName = "Admin",
                    LastName = "Adminsson",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
                new Staff
                {
                    Username = "larar",
                    FirstName = "Lars",
                    LastName = "Svensson",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
                new Staff
                {
                    Username = "9810pema",
                    FirstName = "Marcus",
                    LastName = "Perhamn",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };

            staff.ForEach(s => context.Staff.AddOrUpdate(st => st.Username, s));
            context.SaveChanges();

            var classes = new List<Class>
            {
                new Class
                {
                    Name = "EK15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "EK15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "EK16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "EK16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "EK17A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMA17",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:1",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:2A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:2B1",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:2B2",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:3A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "IMS17:3B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA15C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA15D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA16C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA16D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA17A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA17B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA17C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "NA17D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA17A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "SA17B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "T4",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE15C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE15D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE16C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                { Name = "TE16D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE17A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE17B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE17C",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "TE17D",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VF15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VF15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VF16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VF16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VF17",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO15A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO15B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO16A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO16B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO17A",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Class
                {
                    Name = "VO17B",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }

            };
            classes.ForEach(s => context.Classes.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject
                {
                    Name =  "Datalagring",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Gymnasieingenj�ren i praktiken",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Mjukvarudesign",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Programmering",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Webbserverprogrammering",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Webbutveckling",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Aff�rsjuridik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Engelska",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Svenska",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Matematik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Psykologi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Massage",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Entrepren�rskap och f�retagande",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Tyska",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Spanska",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Franska",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Marknadsf�ring",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "F�retagsekonomi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Idrott och h�lsa",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Samh�llskunskap",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Naturkunskap",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Historia",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Religionskunskap",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Specialpedagogik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Kemi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Bioteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Fysik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Politik och h�llbar utveckling",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Geografi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Filosofi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Biologi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Sociologi",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Internationella relationer",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Ledarskap och organisation",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "M�nniskor milj�er",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Kommunikation",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
                new Subject
                {
                    Name =  "Till�mpad programmering",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "H�llbart samh�llsbyggande",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Design",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Teknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Cad",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Gr�nssnittsdesign",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Dator- och n�tverksteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Byggnadsverk",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Arkitektur",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Luftbehandling",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "V�rmel�ra",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Kyl- och v�rmepumpsteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "M�t- och reglerteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Elkraftteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Sanitetsteknik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "VVS Gassvetsning r�r",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Bild och form",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Svets grund",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Matlagning",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Verktygs- och materialhantering",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Systemuppbyggnad",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "VVS Svets och l�dning r�r",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Praktisk ell�ra",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "V�rd och omsorg vid demenssjukdom",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Psykiatri",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Barnh�lsov�rd",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Akutsjukv�rd",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Hemsjukv�rd",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Etik och m�nniskans livsvillkor",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "Medicin",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "V�rd- och omsorgsarbete",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Subject
                {
                    Name =  "H�lsopedagogik",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };
            subjects.ForEach(s => context.Subjects.AddOrUpdate(su => su.Name, s));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project
                {
                    Name = "Barnkunskap",
                    Description = "I Svenska 3 ska vi g�ra ett projekt d�r vi knyter ihop k�llkritik och stoffinsamling p� n�tet (Barnkonventionen etc) med kursen Barnh�lsov�rd.",
                    Date = "2017-11-04",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 3,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Project
                {
                    Name = "Dokument�rfilmsprojektet",
                    Description = "Ett arbete inom svenska 1 d�r eleverna spelar in egna dokument�rfilmer kring �mnesomr�det spr�ksociologi.",
                    Date = "2017-12-08",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 1,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Project
                {
                    Name = "Sveriges m�rka historia",
                    Description = "Ett �mnes�vergripande arbetsomr�de i samh�llskunskap och historia med fokus p� den del av Sveriges historia som vi s�llar pratar om - utifr�n",
                    Date = "2018-01-25",
                    SubjectID = subjects.Single(s => s.Name == "Samh�llskunskap").ID,
                    PDF = "",
                    Grade = 2,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
            };
            projects.ForEach(s => context.Projects.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var projectClasses = new List<ProjectClass>
            {
                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Barnkunskap").ID,
                    ClassID = classes.Single(c => c.Name == "VO15A").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Barnkunskap").ID,
                    ClassID = classes.Single(c => c.Name == "VO15B").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges m�rka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15B").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges m�rka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15C").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
            };
            projectClasses.ForEach(s => context.ProjectClasses.AddOrUpdate(st => st.ID, s));
            context.SaveChanges();

            var IKT = new List<Ikt>
            {
                new Ikt
                {
                    Name = "Padlet",
                    Description = "Som digital anslagstavla d�r b�de elever och l�rare kan skriva samtidigt. Anv�nds ibland f�r exit tickets men fr�mst som ett verktyg d� man vill ge elever m�jlighet att skriva fr�gor eller tr�na olika aspekter som i realtid l�ggs upp p� sk�rmen i klassrummet. Alla kan skriva samtidigt. Och man kan sedan plocka guldkornen.",
                    Comment = "Funkar bra f�r att skapa delaktighet i klassrummet. Alla ser det de sj�lva skriver. Vill man kontrollera vem som skriver vad beh�ver eleverna skapa varsitt konto.",
                    Link = "",
                    CreatedDate = DateTime.Parse("12 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Delade Dokument Office 365",
                    Description = "Delar tv� dokument med varje elev. Ett som fungerar som logg d�r eleverna f�r skriva �vningar, fr�gor, skrivuppgifter. I dessa kan jag f�lja elevernas process samt ge respons om jag vill. I det andra dokumentet, som eleverna bara kan se, samlar jag elevernas examinationsuppgifter s� att de alltid kan g� tillbaka till dessa f�r att se vad de beh�ver f�rb�ttra.",
                    Comment = "Ger en bra �verblick �ver elevernas kunskap. Eleverna blir �ven mer p� hugget d� de vet att det kan l�sas. Resultatdokumentet �r smidigt att �terkomma till i omd�messamtal och f�r att peka p� elevens utvecklingsm�jligheter.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Visma SPCS",
                    Description = "Bokf�ringsprogram d�r eleverna f�r kontera aff�rsh�ndelser samt skapa och utl�sa ekonomiska rapporter.",
                    Comment = "�mnesspecifikt program. Anv�nds f�r att verklighetsanpassa undervisningen.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Google Expeditions",
                    Description = "App som l�ter l�raren styra en VR-upplevelse i ett klassrum. Elever anv�nder sina telefoner i VR-glas�gon. ",
                    Comment = "Tar en lektion i anspr�k. Ger en engagerande upplevelse, passar som utg�ngspunkt till samtal och diskussioner. Finns f�rdigt material riktat till historia, religion, kemi, biologi, mm. 32 VR-glas�gon finns att l�na",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "OneNote f�r klassrum",
                    Description = "Ett anteckningsverktyg med delnings- och �terkopplingsfunktioner",
                    Comment = "Flexibel arbetsyta, bra �verblick f�r elev�terkopplingar.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Moodle",
                    Description = "Digitalt provverktyg.",
                    Comment = "Kr�ver administration av elevuppgifter",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Safe Exam Browser",
                    Description = "Webbl�sare f�r digitala prov som l�ter l�rare styra vilka program och webbsidor som skall vara tillg�ngliga vid examinationstillf�llen.",
                    Comment = "Kr�ver viss administration.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "GitHub",
                    Description = "Samarbetsyta och versionshanteringssystem f�r mjukvaruutveckling.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Socrative",
                    Description = "Digitalt responssystem.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Codecademy",
                    Description = "Digital arbetsbok f�r programmering- och webbutvecklings-uppgifter.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Microsoft Teams",
                    Description = "Synkron kommunikation, fildelning och uppgiftshantering mm.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Microsoft Sway",
                    Description = "Presentationer och informationssidor direkt i webbl�sare.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Microsoft Forms",
                    Description = "Formul�r och utv�rderingar.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "reMarkable Live View",
                    Description = "Livesynkning mellan l�s/skrivplatta och datorsk�rm.",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Smartprojektor med aktiva elever",
                    Description = "Smartprojektorn anv�nds aktivt och �r integrerad i undervisningen, till exempel vid grammatik�vningar d�r elever f�r m�jlighet att fylla i svar med smartpennan, eller n�r texter omarbetas",
                    Comment = "Fungerar bra d� eleverna blir aktiva och uppm�rksamma. �r gruppen stor kan det vara bra att dela den i tv� grupper",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },

                new Ikt
                {
                    Name = "Svensson",
                    Description = "Sven testar saker",
                    Comment = "Hello",
                    Link = "",
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };
            IKT.ForEach(s => context.Ikts.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var iktStaff = new List<IktStaff>
            {
                new IktStaff
                {
                    ID = 1,
                    IktID = 1,
                    StaffID = staff.Single(s => s.Username == "larar").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
                new IktStaff
                {
                    ID = 2,
                    IktID = 1,
                    StaffID = staff.Single(s => s.Username == "admin").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };

            iktStaff.ForEach(i => context.IktStaffs.AddOrUpdate(st => st.ID, i));
            context.SaveChanges();

            var iktClass = new List<IktClass>
            {
                new IktClass
                {
                    ID =1,
                    IktID = 1,
                    ClassID = classes.Single(c => c.Name == "NA17A").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };

            iktClass.ForEach(i => context.IktClasses.AddOrUpdate(c => c.ID, i));
            context.SaveChanges();

            var projectClass = new List<ProjectClass>
            {
                new ProjectClass
                {
                    ID = 1,
                    ProjectID = 1,
                    ClassID = classes.Single(c => c.Name == "NA17A").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };

            projectClass.ForEach(p => context.ProjectClasses.AddOrUpdate(c => c.ID, p));
            context.SaveChanges();

            var projectStaff = new List<ProjectStaff>
            {
                new ProjectStaff
                {
                    ID = 1,
                    ProjectID = 2,
                    StaffID = staff.Single(s => s.Username == "larar").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                },
                new ProjectStaff
                {
                    ID = 2,
                    ProjectID = 2,
                    StaffID = staff.Single(s => s.Username == "9810pema").ID,
                    CreatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    CreatedBy = "admin",
                    UpdatedDate = DateTime.Parse("26 dec 2017", new CultureInfo("sv-SE")),
                    UpdatedBy = "admin"
                }
            };

            projectStaff.ForEach(p => context.ProjectStaffs.AddOrUpdate(s => s.ID, p));
            context.SaveChanges();
        }
    }
}
