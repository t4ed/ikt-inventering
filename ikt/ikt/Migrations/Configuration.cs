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
                    Name = "EK15A"
                },

                new Class
                {
                    Name = "EK15B"
                },

                new Class
                {
                    Name = "EK16A"
                },

                new Class
                {
                    Name = "EK16B"
                },

                new Class
                {
                    Name = "EK17A"
                },

                new Class
                {
                    Name = "IMA"
                },

                new Class
                {
                    Name = "IMS17:1"
                },

                new Class
                {
                    Name = "IMS17:2A"
                },

                new Class
                {
                    Name = "IMS17:2B1"
                },

                new Class
                {
                    Name = "IMS17:2B2"
                },

                new Class
                {
                    Name = "IMS17:3A"
                },

                new Class
                {
                    Name = "IMS17:3B"
                },

                new Class
                {
                    Name = "NA15A"
                },

                new Class
                {
                    Name = "NA15B"
                },

                new Class
                {
                    Name = "NA15C"
                },

                new Class
                {
                    Name = "NA15C"
                },

                new Class
                {
                    Name = "NA15D"
                },

                new Class
                {
                    Name = "NA16A"
                },

                new Class
                {
                    Name = "NA16B"
                },

                new Class
                {
                    Name = "NA16C"
                },

                new Class
                {
                    Name = "NA16D"
                },

                new Class
                {
                    Name = "NA17A"
                },

                new Class
                {
                    Name = "NA17B"
                },

                new Class
                {
                    Name = "NA17C"
                },

                new Class
                {
                    Name = "NA17D"
                },

                new Class
                {
                    Name = "NA4"
                },

                new Class
                {
                    Name = "SA15A"
                },

                new Class
                {
                    Name = "SA15B"
                },

                new Class
                {
                    Name = "SA16A"
                },

                new Class
                {
                    Name = "SA16B"
                },

                new Class
                {
                    Name = "SA17A"
                },

                new Class
                {
                    Name = "SA17B"
                },

                new Class
                {
                    Name = "SA4"
                },

                new Class
                {
                    Name = "T4"
                },

                new Class
                {
                    Name = "TE15A"
                },

                new Class
                {
                    Name = "TE15B"
                },

                new Class
                {
                    Name = "TE15C"
                },

                new Class
                {
                    Name = "TE15D"
                },

                new Class
                {
                    Name = "TE16A"
                },

                new Class
                {
                    Name = "TE16B"
                },

                new Class
                {
                    Name = "TE16C"
                },

                new Class
                {
                    Name = "TE16D"
                },

                new Class
                {
                    Name = "TE17A"
                },
                new Class
                {
                    Name = "TE17B"
                },

                new Class
                {
                    Name = "TE17C"
                },

                new Class
                {
                    Name = "TE17D"
                },

                new Class
                {
                    Name = "TE4"
                },

                new Class
                {
                    Name = "VF15A"
                },

                new Class
                {
                    Name = "VF15B"
                },

                new Class
                {
                    Name = "VF16A"
                },

                new Class
                {
                    Name = "VF16B"
                },

                new Class
                {
                    Name = "VF17"
                },

                new Class
                {
                    Name = "VF4"
                },

                new Class
                {
                    Name = "VO15A"
                },

                new Class
                {
                    Name = "VO15B"
                },

                new Class
                {
                    Name = "VO15Y"
                },

                new Class
                {
                    Name = "Vo16A"
                },

                new Class
                {
                    Name = "Vo16B"
                },

                new Class
                {
                    Name = "Vo16Y"
                },

                new Class
                {
                    Name = "Vo17A"
                },

                new Class
                {
                    Name = "Vo17B"
                },

                new Class
                {
                    Name = "Vo17Y"
                },

                new Class
                {
                    Name = "VO4"
                },
            };

            Class.ForEach(s => context.Classes.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var Project = new List<Project>
            {
                new Project
                {
                    Name = "Barnkunskap/Svenska 3",
                    Description = "I Svenska 3 ska vi g�ra ett projekt d�r vi knyter ihop k�llkritik och stoffinsamling p� n�tet (Barnkonventionen etc) med kursen Barnh�lsov�rd.",
                    Date = "HT17",
                    PDF = "...",
                    Grade = 3
                },

                new Project
                {
                    Name = "Dokument�rfilm-sprojektet.",
                    Description = "Ett arbete inom svenska 1 d�r eleverna spelar in egna dokument�rfilmer kring �mnesomr�det spr�ksociologi.",
                    Date = "VT2017 , HT2017, VT2018",
                    PDF = "...",
                    Grade = 1
                },

                new Project
                {
                    Name = "Sveriges 'm�rka' historia",
                    Description = "Ett �mnes�vergripande arbetsomr�de i samh�llskunskap och historia med fokus p� den del av Sveriges historia som vi s�llar pratar om - utifr�n",
                    Date = "VT 2018",
                    PDF = "",
                    Grade = 2
                },
            };

            Project.ForEach(s => context.Projects.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var subject = new List<Subject>
            {
                new Subject { Name =  "Datalagring"},
                new Subject { Name =  "Gymnasieingenj�ren i praktiken"},
                new Subject { Name =  "Mjukvarudesign"},
                new Subject { Name =  "Programmering"},
                new Subject { Name =  "Webbserverprogrammering"},
                new Subject { Name =  "Webbutveckling"},
                new Subject { Name =  "Aff�rsjuridik"},
                new Subject { Name =  "Engelska"},
                new Subject { Name =  "Svenska"},
                new Subject { Name =  "Matematik"},
                new Subject { Name =  "Psykologi"},
                new Subject { Name =  "Massage"},
                new Subject { Name =  "Entrepren�rskap och f�retagande"},
                new Subject { Name =  "Moderna spr�k - Tyska"},
                new Subject { Name =  "Moderna spr�k - Spanska"},
                new Subject { Name =  "Moderna spr�k - Franska"},
                new Subject { Name =  "Marknadsf�ring"},
                new Subject { Name =  "F�retagsekonomi"},
                new Subject { Name =  "Idrott och h�lsa"},
                new Subject { Name =  "Samh�llskunskap"},
                new Subject { Name =  "Naturkunskap"},
                new Subject { Name =  "Historia"},
                new Subject { Name =  "Religionskunskap"},
                new Subject { Name =  "Svenska som andraspr�k"},
                new Subject { Name =  "Specialpedagogik"},
                new Subject { Name =  "Kemi"},
                new Subject { Name =  "Bioteknik"},
                new Subject { Name =  "Fysik"},
                new Subject { Name =  "Politik och h�llbar utveckling"},
                new Subject { Name =  "Geografi"},
                new Subject { Name =  "Filosofi"},
                new Subject { Name =  "Biologi"},
                new Subject { Name =  "Sociologi"},
                new Subject { Name =  "Internationella relationer"},
                new Subject { Name =  "Ledarskap och organisation"},
                new Subject { Name =  "M�nniskor milj�er"},
                new Subject { Name =  "Kommunikation"},
                new Subject { Name =  "Till�mpad programmering"},
                new Subject { Name =  "H�llbart samh�llsbyggande"},
                new Subject { Name =  "Design"},
                new Subject { Name =  "Teknik"},
                new Subject { Name =  "Cad"},
                new Subject { Name =  "Gr�nssnittsdesign"},
                new Subject { Name =  "Dator- och n�tverksteknik"},
                new Subject { Name =  "Byggnadsverk"},
                new Subject { Name =  "Arkitektur"},
                new Subject { Name =  "Luftbehandling"},
                new Subject { Name =  "V�rmel�ra"},
                new Subject { Name =  "Kyl- och v�rmepumpsteknik"},
                new Subject { Name =  "M�t- och reglerteknik"},
                new Subject { Name =  "Elkraftteknik"},
                new Subject { Name =  "Sanitetsteknik"},
                new Subject { Name =  "VVS Gassvetsning r�r"},
                new Subject { Name =  "Bild och form"},
                new Subject { Name =  "Svets grund"},
                new Subject { Name =  "Matlagning"},
                new Subject { Name =  "Verktygs- och materialhantering"},
                new Subject { Name =  "Systemuppbyggnad"},
                new Subject { Name =  "VVS Svets och l�dning r�r"},
                new Subject { Name =  "Praktisk ell�ra"},
                new Subject { Name =  "V�rd och omsorg vid demenssjukdom"},
                new Subject { Name =  "Psykiatri"},
                new Subject { Name =  "Barnh�lsov�rd"},
                new Subject { Name =  "Akutsjukv�rd"},
                new Subject { Name =  "Hemsjukv�rd"},
                new Subject { Name =  "Etik och m�nniskans livsvillkor"},
                new Subject { Name =  "Medicin"},
                new Subject { Name =  "V�rd- och omsorgsarbete"},
                new Subject { Name =  "H�lsopedagogik"}
            };
            subject.ForEach(s => context.Subjects.AddOrUpdate(su => su.Name, s));
            context.SaveChanges();
        }
    }
}
