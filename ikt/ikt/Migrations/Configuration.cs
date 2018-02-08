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
                new Subject { Name =  "Tyska"},
                new Subject { Name =  "Spanska"},
                new Subject { Name =  "Franska"},
                new Subject { Name =  "Marknadsf�ring"},
                new Subject { Name =  "F�retagsekonomi"},
                new Subject { Name =  "Idrott och h�lsa"},
                new Subject { Name =  "Samh�llskunskap"},
                new Subject { Name =  "Naturkunskap"},
                new Subject { Name =  "Historia"},
                new Subject { Name =  "Religionskunskap"},
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
            subjects.ForEach(s => context.Subjects.AddOrUpdate(su => su.Name, s));
            context.SaveChanges();
            
            var projects = new List<Project>
            {
                new Project
                {
                    Name = "Barnkunskap",
                    Description = "I Svenska 3 ska vi g�ra ett projekt d�r vi knyter ihop k�llkritik och stoffinsamling p� n�tet (Barnkonventionen etc) med kursen Barnh�lsov�rd.",
                    Date = "2017",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 3
                },

                new Project
                {
                    Name = "Dokument�rfilmsprojektet",
                    Description = "Ett arbete inom svenska 1 d�r eleverna spelar in egna dokument�rfilmer kring �mnesomr�det spr�ksociologi.",
                    Date = "2017",
                    SubjectID = subjects.Single(s => s.Name == "Svenska").ID,
                    PDF = "",
                    Grade = 1
                },

                new Project
                {
                    Name = "Sveriges m�rka historia",
                    Description = "Ett �mnes�vergripande arbetsomr�de i samh�llskunskap och historia med fokus p� den del av Sveriges historia som vi s�llar pratar om - utifr�n",
                    Date = "2018",
                    SubjectID = subjects.Single(s => s.Name == "Samh�llskunskap").ID,
                    PDF = "",
                    Grade = 2
                },
            };
            projects.ForEach(s => context.Projects.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();
            /*
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
                    ProjectID = projects.Single(p => p.Name == "Sveriges m�rka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15B").ID
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges m�rka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15C").ID
                },
            };
            projectClasses.ForEach(s => context.ProjectClasses.AddOrUpdate(st => st.ProjectID, s));
            context.SaveChanges();
            */
            var IKT = new List<Ikt>
            {
                new Ikt
                {
                    Name = "Padlet",
                    Description = "Som digital anslagstavla d�r b�de elever och l�rare kan skriva samtidigt. Anv�nds ibland f�r exit tickets men fr�mst som ett verktyg d� man vill ge elever m�jlighet att skriva fr�gor eller tr�na olika aspekter som i realtid l�ggs upp p� sk�rmen i klassrummet. Alla kan skriva samtidigt. Och man kan sedan plocka guldkornen.",
                    Comment = "Funkar bra f�r att skapa delaktighet i klassrummet. Alla ser det de sj�lva skriver. Vill man kontrollera vem som skriver vad beh�ver eleverna skapa varsitt konto.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Delade Dokument Office 365",
                    Description = "Delar tv� dokument med varje elev. Ett som fungerar som logg d�r eleverna f�r skriva �vningar, fr�gor, skrivuppgifter. I dessa kan jag f�lja elevernas process samt ge respons om jag vill. I det andra dokumentet, som eleverna bara kan se, samlar jag elevernas examinationsuppgifter s� att de alltid kan g� tillbaka till dessa f�r att se vad de beh�ver f�rb�ttra.",
                    Comment = "Ger en bra �verblick �ver elevernas kunskap. Eleverna blir �ven mer p� hugget d� de vet att det kan l�sas. Resultatdokumentet �r smidigt att �terkomma till i omd�messamtal och f�r att peka p� elevens utvecklingsm�jligheter.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Visma SPCS",
                    Description = "Bokf�ringsprogram d�r eleverna f�r kontera aff�rsh�ndelser samt skapa och utl�sa ekonomiska rapporter.",
                    Comment = "�mnesspecifikt program. Anv�nds f�r att verklighetsanpassa undervisningen.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Google Expeditions",
                    Description = "App som l�ter l�raren styra en VR-upplevelse i ett klassrum. Elever anv�nder sina telefoner i VR-glas�gon. ",
                    Comment = "Tar en lektion i anspr�k. Ger en engagerande upplevelse, passar som utg�ngspunkt till samtal och diskussioner. Finns f�rdigt material riktat till historia, religion, kemi, biologi, mm. 32 VR-glas�gon finns att l�na",
                    Link = ""
                },

                new Ikt
                {
                    Name = "OneNote f�r klassrum",
                    Description = "Ett anteckningsverktyg med delnings- och �terkopplingsfunktioner",
                    Comment = "Flexibel arbetsyta, bra �verblick f�r elev�terkopplingar.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Moodle",
                    Description = "Digitalt provverktyg.",
                    Comment = "Kr�ver administration av elevuppgifter",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Safe Exam Browser",
                    Description = "Webbl�sare f�r digitala prov som l�ter l�rare styra vilka program och webbsidor som skall vara tillg�ngliga vid examinationstillf�llen.",
                    Comment = "Kr�ver viss administration.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "GitHub",
                    Description = "Samarbetsyta och versionshanterings-system f�r mjukvaruutveckling.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Socrative",
                    Description = "Digitalt responssystem.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Codecademy",
                    Description = "Digital �arbetsbok� f�r programmering- och webbutvecklings-uppgifter.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Microsoft Teams",
                    Description = "Synkron kommunikation, fildelning och uppgiftshantering mm.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Microsoft Sway",
                    Description = "Presentationer och informationssidor direkt i webbl�sare.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Microsoft Forms",
                    Description = "Formul�r och utv�rderingar.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "reMarkable Live View",
                    Description = "Livesynkning mellan l�s/skrivplatta och datorsk�rm.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Smartprojektor med aktiva elever",
                    Description = "Smartprojektorn anv�nds aktivt och �r integrerad i undervisningen, till exempel vid grammatik�vningar d�r elever f�r m�jlighet att fylla i svar med smartpennan, eller n�r texter omarbetas",
                    Comment = "Fungerar bra d� eleverna blir aktiva och uppm�rksamma. �r gruppen stor kan det vara bra att dela den i tv� grupper",
                    Link = ""
                }
            };
            IKT.ForEach(s => context.Ikts.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();
        }
    }
}
