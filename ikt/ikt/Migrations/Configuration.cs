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
            AutomaticMigrationsEnabled = true;
            ContextKey = "ikt.DAL.iktContext";
        }

        protected override void Seed(ikt.DAL.iktContext context)
        {
            /*
            var staff = new List<Staff>
            {
                new Staff
                {
                    Username = "9810pema",
                    FirstName = "Marcus",
                    LastName = "Perhamn"
                }
            };

            staff.ForEach(s => context.Staff.AddOrUpdate(st => st.Username, s));
            context.SaveChanges();
            */

            var classes = new List<Class>
            {
                new Class { Name = "EK15A" },
                new Class { Name = "EK15B" },
                new Class { Name = "EK16A" },
                new Class { Name = "EK16B" },
                new Class { Name = "EK17A" },
                new Class { Name = "IMA17" },
                new Class { Name = "IMS17:1" },
                new Class { Name = "IMS17:2A" },
                new Class { Name = "IMS17:2B1" },
                new Class { Name = "IMS17:2B2" },
                new Class { Name = "IMS17:3A" },
                new Class { Name = "IMS17:3B" },
                new Class { Name = "NA15A" },
                new Class { Name = "NA15B" },
                new Class { Name = "NA15C"},
                new Class { Name = "NA15D" },
                new Class { Name = "NA16A" },
                new Class { Name = "NA16B" },
                new Class { Name = "NA16C" },
                new Class { Name = "NA16D"},
                new Class { Name = "NA17A" },
                new Class { Name = "NA17B"},
                new Class { Name = "NA17C" },
                new Class { Name = "NA17D" },
                new Class { Name = "SA15A" },
                new Class { Name = "SA15B" },
                new Class { Name = "SA16A" },
                new Class { Name = "SA16B" },
                new Class { Name = "SA17A" },
                new Class { Name = "SA17B" },
                new Class { Name = "T4" },
                new Class { Name = "TE15A" },
                new Class { Name = "TE15B" },
                new Class { Name = "TE15C" },
                new Class { Name = "TE15D" },
                new Class { Name = "TE16A" },
                new Class { Name = "TE16B" },
                new Class { Name = "TE16C" },
                new Class { Name = "TE16D" },
                new Class { Name = "TE17A" },
                new Class { Name = "TE17B" },
                new Class { Name = "TE17C" },
                new Class { Name = "TE17D" },
                new Class { Name = "VF15A" },
                new Class { Name = "VF15B" },
                new Class { Name = "VF16A" },
                new Class { Name = "VF16B" },
                new Class { Name = "VF17" },
                new Class { Name = "VO15A" },
                new Class { Name = "VO15B" },
                new Class { Name = "VO16A" },
                new Class { Name = "VO16B" },
                new Class { Name = "VO17A" },
                new Class { Name = "VO17B" }

            };

            classes.ForEach(s => context.Classes.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject { Name =  "Datalagring"},
                new Subject { Name =  "Gymnasieingenjören i praktiken"},
                new Subject { Name =  "Mjukvarudesign"},
                new Subject { Name =  "Programmering"},
                new Subject { Name =  "Webbserverprogrammering"},
                new Subject { Name =  "Webbutveckling"},
                new Subject { Name =  "Affärsjuridik"},
                new Subject { Name =  "Engelska"},
                new Subject { Name =  "Svenska"},
                new Subject { Name =  "Matematik"},
                new Subject { Name =  "Psykologi"},
                new Subject { Name =  "Massage"},
                new Subject { Name =  "Entreprenörskap och företagande"},
                new Subject { Name =  "Tyska"},
                new Subject { Name =  "Spanska"},
                new Subject { Name =  "Franska"},
                new Subject { Name =  "Marknadsföring"},
                new Subject { Name =  "Företagsekonomi"},
                new Subject { Name =  "Idrott och hälsa"},
                new Subject { Name =  "Samhällskunskap"},
                new Subject { Name =  "Naturkunskap"},
                new Subject { Name =  "Historia"},
                new Subject { Name =  "Religionskunskap"},
                new Subject { Name =  "Specialpedagogik"},
                new Subject { Name =  "Kemi"},
                new Subject { Name =  "Bioteknik"},
                new Subject { Name =  "Fysik"},
                new Subject { Name =  "Politik och hållbar utveckling"},
                new Subject { Name =  "Geografi"},
                new Subject { Name =  "Filosofi"},
                new Subject { Name =  "Biologi"},
                new Subject { Name =  "Sociologi"},
                new Subject { Name =  "Internationella relationer"},
                new Subject { Name =  "Ledarskap och organisation"},
                new Subject { Name =  "Människor miljöer"},
                new Subject { Name =  "Kommunikation"},
                new Subject { Name =  "Tillämpad programmering"},
                new Subject { Name =  "Hållbart samhällsbyggande"},
                new Subject { Name =  "Design"},
                new Subject { Name =  "Teknik"},
                new Subject { Name =  "Cad"},
                new Subject { Name =  "Gränssnittsdesign"},
                new Subject { Name =  "Dator- och nätverksteknik"},
                new Subject { Name =  "Byggnadsverk"},
                new Subject { Name =  "Arkitektur"},
                new Subject { Name =  "Luftbehandling"},
                new Subject { Name =  "Värmelära"},
                new Subject { Name =  "Kyl- och värmepumpsteknik"},
                new Subject { Name =  "Mät- och reglerteknik"},
                new Subject { Name =  "Elkraftteknik"},
                new Subject { Name =  "Sanitetsteknik"},
                new Subject { Name =  "VVS Gassvetsning rör"},
                new Subject { Name =  "Bild och form"},
                new Subject { Name =  "Svets grund"},
                new Subject { Name =  "Matlagning"},
                new Subject { Name =  "Verktygs- och materialhantering"},
                new Subject { Name =  "Systemuppbyggnad"},
                new Subject { Name =  "VVS Svets och lödning rör"},
                new Subject { Name =  "Praktisk ellära"},
                new Subject { Name =  "Vård och omsorg vid demenssjukdom"},
                new Subject { Name =  "Psykiatri"},
                new Subject { Name =  "Barnhälsovård"},
                new Subject { Name =  "Akutsjukvård"},
                new Subject { Name =  "Hemsjukvård"},
                new Subject { Name =  "Etik och människans livsvillkor"},
                new Subject { Name =  "Medicin"},
                new Subject { Name =  "Vård- och omsorgsarbete"},
                new Subject { Name =  "Hälsopedagogik"}
            };
            subjects.ForEach(s => context.Subjects.AddOrUpdate(su => su.Name, s));
            context.SaveChanges();
            
            var projects = new List<Project>
            {
                new Project
                {
                    Name = "Barnkunskap",
                    Description = "I Svenska 3 ska vi göra ett projekt där vi knyter ihop källkritik och stoffinsamling på nätet (Barnkonventionen etc) med kursen Barnhälsovård.",
                    Date = "2017",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 3
                },

                new Project
                {
                    Name = "Dokumentärfilmsprojektet",
                    Description = "Ett arbete inom svenska 1 där eleverna spelar in egna dokumentärfilmer kring ämnesområdet språksociologi.",
                    Date = "2017",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 1
                },

                new Project
                {
                    Name = "Sveriges mörka historia",
                    Description = "Ett ämnesövergripande arbetsområde i samhällskunskap och historia med fokus på den del av Sveriges historia som vi sällar pratar om - utifrån",
                    Date = "2018",
                    SubjectID = subjects.Single(s => s.Name == "Samhällskunskap").ID,
                    PDF = "",
                    Grade = 2
                },
            };
            projects.ForEach(s => context.Projects.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();

            var projectClasses = new List<ProjectClass>
            {
                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Barnkunskap").ID,
                    ClassID = classes.Single(c => c.Name == "VO15A").ID
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Barnkunskap").ID,
                    ClassID = classes.Single(c => c.Name == "VO15B").ID
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges mörka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15B").ID
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges mörka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15C").ID
                },
            };
        }
    }
}
