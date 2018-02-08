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
                    ProjectID = projects.Single(p => p.Name == "Sveriges mörka historia").ID,
                    ClassID = classes.Single(c => c.Name == "NA15B").ID
                },

                new ProjectClass
                {
                    ProjectID = projects.Single(p => p.Name == "Sveriges mörka historia").ID,
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
                    Description = "Som digital anslagstavla där både elever och lärare kan skriva samtidigt. Används ibland för exit tickets men främst som ett verktyg då man vill ge elever möjlighet att skriva frågor eller träna olika aspekter som i realtid läggs upp på skärmen i klassrummet. Alla kan skriva samtidigt. Och man kan sedan plocka guldkornen.",
                    Comment = "Funkar bra för att skapa delaktighet i klassrummet. Alla ser det de själva skriver. Vill man kontrollera vem som skriver vad behöver eleverna skapa varsitt konto.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Delade Dokument Office 365",
                    Description = "Delar två dokument med varje elev. Ett som fungerar som logg där eleverna får skriva övningar, frågor, skrivuppgifter. I dessa kan jag följa elevernas process samt ge respons om jag vill. I det andra dokumentet, som eleverna bara kan se, samlar jag elevernas examinationsuppgifter så att de alltid kan gå tillbaka till dessa för att se vad de behöver förbättra.",
                    Comment = "Ger en bra överblick över elevernas kunskap. Eleverna blir även mer på hugget då de vet att det kan läsas. Resultatdokumentet är smidigt att återkomma till i omdömessamtal och för att peka på elevens utvecklingsmöjligheter.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Visma SPCS",
                    Description = "Bokföringsprogram där eleverna får kontera affärshändelser samt skapa och utläsa ekonomiska rapporter.",
                    Comment = "Ämnesspecifikt program. Används för att verklighetsanpassa undervisningen.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Google Expeditions",
                    Description = "App som låter läraren styra en VR-upplevelse i ett klassrum. Elever använder sina telefoner i VR-glasögon. ",
                    Comment = "Tar en lektion i anspråk. Ger en engagerande upplevelse, passar som utgångspunkt till samtal och diskussioner. Finns färdigt material riktat till historia, religion, kemi, biologi, mm. 32 VR-glasögon finns att låna",
                    Link = ""
                },

                new Ikt
                {
                    Name = "OneNote för klassrum",
                    Description = "Ett anteckningsverktyg med delnings- och återkopplingsfunktioner",
                    Comment = "Flexibel arbetsyta, bra överblick för elevåterkopplingar.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Moodle",
                    Description = "Digitalt provverktyg.",
                    Comment = "Kräver administration av elevuppgifter",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Safe Exam Browser",
                    Description = "Webbläsare för digitala prov som låter lärare styra vilka program och webbsidor som skall vara tillgängliga vid examinationstillfällen.",
                    Comment = "Kräver viss administration.",
                    Link = ""
                },

                new Ikt
                {
                    Name = "GitHub",
                    Description = "Samarbetsyta och versionshanterings-system för mjukvaruutveckling.",
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
                    Description = "Digital ”arbetsbok” för programmering- och webbutvecklings-uppgifter.",
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
                    Description = "Presentationer och informationssidor direkt i webbläsare.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Microsoft Forms",
                    Description = "Formulär och utvärderingar.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "reMarkable Live View",
                    Description = "Livesynkning mellan läs/skrivplatta och datorskärm.",
                    Comment = "",
                    Link = ""
                },

                new Ikt
                {
                    Name = "Smartprojektor med aktiva elever",
                    Description = "Smartprojektorn används aktivt och är integrerad i undervisningen, till exempel vid grammatikövningar där elever får möjlighet att fylla i svar med smartpennan, eller när texter omarbetas",
                    Comment = "Fungerar bra då eleverna blir aktiva och uppmärksamma. Är gruppen stor kan det vara bra att dela den i två grupper",
                    Link = ""
                }
            };
            IKT.ForEach(s => context.Ikts.AddOrUpdate(st => st.Name, s));
            context.SaveChanges();
        }
    }
}
