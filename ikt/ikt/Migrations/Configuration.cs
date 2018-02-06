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
