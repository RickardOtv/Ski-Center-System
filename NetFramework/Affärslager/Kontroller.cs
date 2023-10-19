using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Datalager;
using Entitetslager;
using static System.Data.Entity.Infrastructure.Design.Executor;


namespace Affärslager
{
    public class Kontroller
    {

        private UnitOfWork unitOfWork;
        private List<Utrustning> allUtrustning = new List<Utrustning>();
        public Kontroller() 
        {
            using (var unitOfWork = new UnitOfWork())
            {
                allUtrustning = unitOfWork.utrustningar.ToList();
            }


        }
        public Anställd LoggedIn
        {
            get; private set;
        }

        public bool LoggaIn(int anställningsNr, string lösenord)
        {
            unitOfWork = new UnitOfWork();
            Anställd a = (from anst in unitOfWork.anställda where anst.AnställningsNr == anställningsNr select anst).FirstOrDefault();
            if (a != null && a.VerifieraLösenord(lösenord))
            {
                LoggedIn = a;
                return true;
                unitOfWork.SaveChanges();
            }
            else
                LoggedIn = null;
            return false;
        }
        
        public Bokningsrad SkapaBokningsRad(DateTime från, DateTime till, Logi l, int bokningsID)
        {
            Bokningsrad nyRad = new Bokningsrad(l.LogiID, från, till, bokningsID);
            unitOfWork.bokningsRader.Add(nyRad);
            unitOfWork.SaveChanges();
            return nyRad;
        }
        public void TaBortBokningsRad(Bokningsrad rad)
        {
            unitOfWork.bokningsRader.Remove(rad);
            unitOfWork.SaveChanges();
        }
        
        public Bokning SkapaBokning(Kund k)
        {
            Bokning bokning = new Bokning
            {
                KundID = k.KundID,
            };

            unitOfWork.bokningar.Add(bokning);
            unitOfWork.SaveChanges();
            return bokning;
        }
        
        public Uthyrning SkapaUthyrning(Bokning b)
        {
            Uthyrning uthyrning = new Uthyrning
            {
                BokningsID = b.BokningsID,
            };

            unitOfWork.uthyrningar.Add(uthyrning);
            unitOfWork.SaveChanges();
            return uthyrning;
        }
        public Uthyrningsrad SkapaUthyrningsRad(DateTime från, DateTime till, Utrustning u, int uthyrningsID)
        {
            Uthyrningsrad nyUthyrningsRad = new Uthyrningsrad(u.UtrustningsID, från, till, uthyrningsID);
            unitOfWork.uthyrningsRader.Add(nyUthyrningsRad);
            unitOfWork.SaveChanges();
            return nyUthyrningsRad;
        }
        public void TaBortUthyrningsRad(Uthyrningsrad uRad)
        {
            unitOfWork.uthyrningsRader.Remove(uRad);
            unitOfWork.SaveChanges();
        }

        public Kund SkapaNyKund(string personnummer, string namn, string telefonnummer, string email, string adress, string postNr, string postOrt, string typ, int maxbeloppskreditgräns)
        {
            Kund kund = new Kund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, typ, maxbeloppskreditgräns);
            unitOfWork.kunder.Add(kund);
            unitOfWork.SaveChanges();
            return kund;

        }
        public Anställd SkapaNyAnställd(string förnamn, string efternamn, string lösenord, string behörighet)
        {
            Anställd anställd = new Anställd(förnamn, efternamn, lösenord, behörighet);
            unitOfWork.anställda.Add(anställd);
            unitOfWork.SaveChanges();
            return anställd;
        }
        public void TaBortKund(Kund k)
        {
            unitOfWork.kunder.Remove(k);
            unitOfWork.SaveChanges();
        }
        public void TaBortAnställd(Anställd a)
        {
            unitOfWork.anställda.Remove(a);
            unitOfWork.SaveChanges();
        }
        public void TaBortBokning(Bokning b)
        {
            unitOfWork.bokningar.Remove(b);
            unitOfWork.SaveChanges();
        }
        public Kund HittaKund(int kundID)
        {
            return unitOfWork.kunder.FirstOrDefault(k => k.KundID == kundID);
        }
        public Kund HittaKund(string personNummer)
        {
            return unitOfWork.kunder.FirstOrDefault(k => k.Personnummer == personNummer);
        }
        public Anställd HittaAnställd(int anställningsNr)
        {
            return unitOfWork.anställda.FirstOrDefault(a => a.AnställningsNr == anställningsNr);
        }
        public Logi HittaLogi(string logiID)
        {
            return unitOfWork.logier.FirstOrDefault(l => l.LogiID == logiID);
        }
        public IList<Bokningsrad> HämtaRader(int bokningsID)
        {
            return unitOfWork.bokningsRader.Where(b => b.BokningsID == bokningsID).ToList();
        }
        public string HämtaUthyrningsTyp(string utrustningsID)
        {
            var typ = unitOfWork.utrustningar.FirstOrDefault(u => u.UtrustningsID == utrustningsID)?.Typ;
            return typ;
        }
        public IList<Uthyrningsrad> HämtaUthyrningsRad(int uthyrningsID)
        {
            return unitOfWork.uthyrningsRader.Where(u => u.UthyrningsID == uthyrningsID).ToList();
        }
        public IList<Lektionsrad> HämtaLektionsRader(int bokningsID)
        {
            return unitOfWork.lektionsRader.Where(b => b.BokningsID == bokningsID).ToList();
        }
        public IList<Uthyrning> HämtaUthyrningar(int uthyrningsID)
        {
            return unitOfWork.uthyrningar.Where(u => u.UthyrningsID == uthyrningsID).ToList();
        }
        public IList<Skidlektion> HämtaLektioner(int lektionsID)
        {
            return unitOfWork.skidlektioner.Where(l => l.LektionsID == lektionsID).ToList();
        }
        public IList<Logi> HämtaTillgängligLogi()
        {
            return unitOfWork.logier.ToList<Logi>();
        }
        public IList<Kund> HämtaKunder()
        {
            return unitOfWork.kunder.ToList<Kund>();
        }
        public IList<Anställd> HämtaAnställda()
        {
            return unitOfWork.anställda.ToList<Anställd>();
        }
        
        public decimal KollaUthyrningsPris(DateTime från, DateTime till, string uthyrningsTyp)
        {
            int totalDays = (int)(till - från).TotalDays + 1;
            var pris = unitOfWork.utrustningsPris.FirstOrDefault(ep => ep.Typ == uthyrningsTyp);
            decimal totalPrice = 0;

            switch (totalDays)
            {
                case 1:
                    totalPrice = pris.EnDagsPris;
                    break;
                case 2:
                    totalPrice = pris.TvåDagsPris;
                    break;
                case 3:
                    totalPrice = pris.TreDagsPris;
                    break;
                case 4:
                    totalPrice = pris.FyrDagsPris;
                    break;
                case 5:
                    totalPrice = pris.FemDagsPris;
                    break;
            }
            return totalPrice;
        }
        
        public decimal KollaPris(DateTime från, DateTime till, string logiTyp)
        {
            decimal totalPrice = 0;
            DateTime currentDate = från;
            int vecka = -1; // Initialt värde för att säkerställa att vi räknar första veckan.

            while (currentDate <= till)
            {
                // Hämta veckonummer för det aktuella datumet baserat på kalenderåret 2023
                int currentVecka = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

                if (vecka != currentVecka)
                {
                    // Om vi har gått in i en ny vecka (enligt kalenderåret 2023)
                    vecka = currentVecka;
                    if (logiTyp == "Camping")
                    {
                        var campPris = unitOfWork.campPris.FirstOrDefault(cp => cp.Vecka == vecka && cp.Typ == logiTyp);

                        if (campPris != null)
                        {
                            DateTime veckaStart = currentDate.Date;
                            DateTime veckaSlut = currentDate.Date.AddDays(6);
                            if (currentDate.DayOfWeek == DayOfWeek.Monday && veckaSlut <= till)
                            {
                                totalPrice += campPris.VeckoPris;
                                currentDate = veckaSlut.AddDays(1);
                                continue;
                            }
                            else
                            {
                                while (currentDate <= till)
                                {
                                    totalPrice += campPris.DygnsPris;
                                    currentDate = currentDate.AddDays(1);

                                    if (currentDate > till)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (logiTyp == "Konferens liten" || logiTyp == "Konferens stor")
                    {
                        var konferensPris = unitOfWork.konferensPris.FirstOrDefault(kp => kp.Vecka == vecka && kp.Typ == logiTyp);

                        if (konferensPris != null)
                        {
                            DateTime veckaStart = currentDate.Date;
                            DateTime veckaSlut = currentDate.Date.AddDays(6);
                            if (currentDate.DayOfWeek == DayOfWeek.Monday && veckaSlut <= till)
                            {
                                totalPrice += konferensPris.VeckoPris;
                                currentDate = veckaSlut.AddDays(1);
                                continue;
                            }
                            else
                            {
                                while (currentDate <= till)
                                {
                                    totalPrice += konferensPris.DygnsPris; // Exempel: du kan ändra detta för att använda TimPris vid behov.
                                    currentDate = currentDate.AddDays(1);

                                    if (currentDate > till)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    // Hämta prisinformation för den aktuella veckan och logitypen
                    var logiPris = unitOfWork.logiPris.FirstOrDefault(lp => lp.Vecka == vecka && lp.Typ == logiTyp);

                    if (logiPris != null)
                    {
                        // Kontrollera om det är en hel vecka (måndag till söndag)
                        DateTime veckaStart = currentDate.Date;
                        DateTime veckaSlut = currentDate.Date.AddDays(6);
                        if (currentDate.DayOfWeek == DayOfWeek.Monday && veckaSlut <= till)
                        {
                            totalPrice += logiPris.VeckoPris;
                            currentDate = veckaSlut.AddDays(1);
                            continue;
                        }
                        else
                        {
                            // Om det inte är en hel vecka, använd vardags- och helgpris
                            while (currentDate <= till)
                            {
                                if (currentDate.DayOfWeek >= DayOfWeek.Monday && currentDate.DayOfWeek <= DayOfWeek.Thursday)
                                {
                                    // Om det är en vardag (måndag till torsdag), använd vardagspriset
                                    totalPrice += logiPris.VardagsPris;
                                }
                                else
                                {
                                    // Annars är det en helgdag (fredag till söndag), använd helgpriset
                                    totalPrice += logiPris.HelgPris;
                                }

                                // Gå till nästa dag
                                currentDate = currentDate.AddDays(1);

                                if (currentDate > till)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Om prisinformation saknas för den aktuella veckan och logitypen, bryt loopen
                        break;
                    }
                }
                else
                {
                    // Om vi är fortfarande inom samma vecka, gå till nästa dag
                    currentDate = currentDate.AddDays(1);

                    if (currentDate > till)
                    {
                        break;
                    }
                }
            }

            return totalPrice;
        }
        public IList<Bokning> HämtaBokningar()
        {
            return unitOfWork.bokningar.ToList<Bokning>();
        }

        public IList<Bokningsrad> HämtaBokningsRader()
        {
            return unitOfWork.bokningsRader.ToList<Bokningsrad>();
        }
        public IList<Utrustning> HämtaUtrustning()
        {
            return unitOfWork.utrustningar.ToList<Utrustning>();
        }
        

        public void ÄndraAllaBokningsRader(DateTime från, DateTime till, Bokningsrad bokningrad)
        {
            var allaRader = HämtaRader(bokningrad.BokningsID);
            foreach (var r in allaRader)
            {
                r.Från = från;
                r.Till = till;
            }
            unitOfWork.SaveChanges();
        }

        public void ÄndraAnställd(string förnamn, string efternamn, string lösenord, string behörighet, Anställd anställd)
        {
            anställd.Förnamn = förnamn;
            anställd.Efternamn = efternamn;
            anställd.Lösenord = lösenord;
            anställd.Behörighet = behörighet;
            unitOfWork.SaveChanges();
        }
        
        public void ÄndraKund(string personnummer, string namn, string telefonnummer, string postNr, string postOrt, string typ, string adress, string email, int kredit, Kund kund)
        {
            kund.Personnummer = personnummer;
            kund.Namn = namn;
            kund.Telefonnummer = telefonnummer;
            kund.PostNr = postNr;
            kund.PostOrt = postOrt;
            kund.Typ = typ;
            kund.Adress = adress;
            kund.Email = email;
            kund.Maxbeloppskreditgräns = kredit;
            unitOfWork.SaveChanges();
        }

        public Bokning HittaBokning(string söktBokningsNummer)
        {
            int matadBokningsNr = Int32.Parse(söktBokningsNummer);
            Bokning matchadBokning = unitOfWork.bokningar.FirstOrDefault(b => b.BokningsID == matadBokningsNr);
            return matchadBokning;
        }
        public Bokning HittaBokning(int kundID)
        {
            return unitOfWork.bokningar.FirstOrDefault(b => b.KundID == kundID);
        }
        public Uthyrning HittaUthyrning(int bokningsID)
        {
            return unitOfWork.uthyrningar.FirstOrDefault(u => u.BokningsID == bokningsID);
        }

        public string HittaBehörighet(int anstllningsNr)
        {
            Anställd anställd = unitOfWork.anställda.FirstOrDefault(k => k.AnställningsNr == anstllningsNr);
            return anställd.Behörighet;
        }

        public List<int> HamtaStorlekarForTyp(string typ)
        {
            if (typ == null) throw new ArgumentNullException(nameof(typ));

            // Kontrollera om allUtrustning är null eller tom
            if (allUtrustning == null || !allUtrustning.Any())
            {
                throw new InvalidOperationException("allUtrustning är null eller tom.");
            }

            // Försök att identifiera var problemet ligger
            var nonNullUtrustning = allUtrustning.Where(u => u != null && u.Typ != null && u.Storlek != null).ToList();

            // Om nonNullUtrustning är tom, kasta ett undantag
            if (!nonNullUtrustning.Any())
            {
                throw new InvalidOperationException("Ingen utrustning med icke-null Typ och Storlek.");
            }

            var storlekar = nonNullUtrustning
                .Where(u => u.Typ == typ)
                .Select(u => u.Storlek)
                .Distinct()
                .ToList();

            // Om storlekar är tom, kasta ett undantag
            if (!storlekar.Any())
            {
                throw new InvalidOperationException($"Ingen utrustning av typ {typ} hittades.");
            }

            return storlekar;
        }



        public void TaBortLogi(Bokningsrad valRad)
        {
            unitOfWork.bokningsRader.Remove(valRad);
            unitOfWork.SaveChanges();
        }
        public void ÄndraEnBokningsRad(DateTime från, DateTime till, Bokningsrad bokningrad)
        {
            bokningrad.Från = från;
            bokningrad.Till = till;
            unitOfWork.SaveChanges();
        }
    }
}