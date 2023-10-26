using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
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
        /// <summary>
        /// Metoden "LoggaIn" försöker verifiera användaruppgifter genom att söka efter en anställd med matchande anställningsnummer i databasen. Om användaren hittas och lösenordet verifieras, uppdateras den inloggade användaren och returnerar sant. Annars nollställs den inloggade användaren och metoden returnerar falskt. Spara ändringar görs om verifieringen är framgångsrik.
        /// </summary>
        /// <param name="anställningsNr"></param>
        /// <param name="lösenord"></param>
        /// <returns></returns>
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

        
        #region Skapa metoder
        /// <summary>
        /// Metoden "SkapaBokning" skapar en ny bokning kopplad till en given kund i databasen. Bokningen läggs till i databasen och ändringarna sparas. Den nyskapade bokningen returneras.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoden "SkapaUthyrning" skapar en ny uthyrning kopplad till en given bokning i databasen. Uthyrningen läggs till i databasen och ändringarna sparas. Den nyskapade uthyrningen returneras.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
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


        
        public Faktura SkapaFaktura(int bokningsID, int moms, int rabattsats, float totalpris)
        {
            Faktura nyFaktura = new Faktura(bokningsID, moms, rabattsats, totalpris);
            unitOfWork.fakturor.Add(nyFaktura); 
            unitOfWork.SaveChanges();
            return nyFaktura;
        }

        /// <summary>
        /// Metoden "SkapaUthyrningsRad" skapar en ny uthyrningsrad kopplad till en given utrustning och uthyrning i databasen. Uthyrningsraden läggs till i databasen och ändringarna sparas. Den nyskapade uthyrningsraden returneras.
        /// </summary>
        /// <param name="från"></param>
        /// <param name="till"></param>
        /// <param name="u"></param>
        /// <param name="uthyrningsID"></param>
        /// <returns></returns>
        public Uthyrningsrad SkapaUthyrningsRad(DateTime från, DateTime till, Utrustning u, int uthyrningsID)
        {
            Uthyrningsrad nyUthyrningsRad = new Uthyrningsrad(u.UtrustningsID, från, till, uthyrningsID);
            unitOfWork.uthyrningsRader.Add(nyUthyrningsRad);
            unitOfWork.SaveChanges();
            return nyUthyrningsRad;
        }
        /// <summary>
        /// Metoden "SkapaBokningsRad" skapar och lägger till en bokningsrad i databasen med angivna parametrar för start- och slutdatum, logi och boknings-ID. Efter att ha lagt till bokningsraden sparas ändringarna i databasen och den nya bokningsraden returneras.
        /// </summary>
        /// <param name="från"></param>
        /// <param name="till"></param>
        /// <param name="l"></param>
        /// <param name="bokningsID"></param>
        /// <returns></returns>
        public Bokningsrad SkapaBokningsRad(DateTime från, DateTime till, Logi l, int bokningsID)
        {
            Bokningsrad nyRad = new Bokningsrad(l.LogiID, från, till, bokningsID);
            unitOfWork.bokningsRader.Add(nyRad);
            unitOfWork.SaveChanges();
            return nyRad;
        }
        /// <summary>
        /// Metoden "SkapaNyKund" skapar en ny kund med de angivna attributen och lägger till kunden i databasen genom att använda den associerade UnitOfWork. Efter att ändringarna har sparats returneras den nyskapade kunden.
        /// </summary>
        /// <param name="personnummer"></param>
        /// <param name="namn"></param>
        /// <param name="telefonnummer"></param>
        /// <param name="email"></param>
        /// <param name="adress"></param>
        /// <param name="postNr"></param>
        /// <param name="postOrt"></param>
        /// <param name="typ"></param>
        /// <param name="maxbeloppskreditgräns"></param>
        /// <returns></returns>
        public Kund SkapaNyKund(string personnummer, string namn, string telefonnummer, string email, string adress, string postNr, string postOrt, string typ, int maxbeloppskreditgräns)
        {
            Kund kund = new Kund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, typ, maxbeloppskreditgräns);
            unitOfWork.kunder.Add(kund);
            unitOfWork.SaveChanges();
            return kund;

        }
        /// <summary>
        /// Metoden "SkapaNyAnställd" skapar en ny anställd med de angivna attributen och lägger till den anställde i databasen genom att använda den associerade UnitOfWork. Efter att ändringarna har sparats returneras den nyskapade anställda.
        /// </summary>
        /// <param name="förnamn"></param>
        /// <param name="efternamn"></param>
        /// <param name="lösenord"></param>
        /// <param name="behörighet"></param>
        /// <returns></returns>
        public Anställd SkapaNyAnställd(string förnamn, string efternamn, string lösenord, string behörighet)
        {
            Anställd anställd = new Anställd(förnamn, efternamn, lösenord, behörighet);
            unitOfWork.anställda.Add(anställd);
            unitOfWork.SaveChanges();
            return anställd;
        }
        #endregion
        #region Ta-bort metoder
        /// <summary>
        /// Tar bort kunden och sparar ner det i databasen
        /// </summary>
        /// <param name="k"></param>
        public void TaBortKund(Kund k)
        {
            unitOfWork.kunder.Remove(k);
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Tar bort den anställde och sparar ner detta i databasen
        /// </summary>
        /// <param name="a"></param>
        public void TaBortAnställd(Anställd a)
        {
            unitOfWork.anställda.Remove(a);
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Tar bort bokningen och sparar ner detta i databasen
        /// </summary>
        /// <param name="b"></param>
        public void TaBortBokning(Bokning b)
        {
            unitOfWork.bokningar.Remove(b);
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Tar bort uthyrningen och sparar ner detta i databasen
        /// </summary>
        /// <param name="u"></param>
        public void TaBortUthyrning(Uthyrning u)
        {
            unitOfWork.uthyrningar.Remove(u);
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Metoden "TaBortBokningsRad" tar bort en specifik bokningsrad från databasen med hjälp av den angivna bokningsraden som parameter. Efter borttagningen sparas ändringarna i databasen.
        /// </summary>
        /// <param name="rad"></param>
        public void TaBortBokningsRad(Bokningsrad rad)
        {
            unitOfWork.bokningsRader.Remove(rad);
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Metoden "TaBortUthyrningsRad" tar bort en given uthyrningsrad från databasen genom att använda den tillhörande UnitOfWork. Ändringarna sparas i databasen efter borttagningen.
        /// </summary>
        /// <param name="uRad"></param>
        public void TaBortUthyrningsRad(Uthyrningsrad uRad)
        {
            unitOfWork.uthyrningsRader.Remove(uRad);
            unitOfWork.SaveChanges();
        }
        public void TaBortLogi(Bokningsrad valRad)
        {
            unitOfWork.bokningsRader.Remove(valRad);
            unitOfWork.SaveChanges();
        }

        public void TaBortFaktura(Faktura valdFaktura)
        {
            unitOfWork.fakturor.Remove(valdFaktura);
            unitOfWork.SaveChanges();
        }


        #endregion
        #region Hitta/hämta-metoder
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
        public IList<Uthyrning> HämtaAllaUthyrningar()
        {
            return unitOfWork.uthyrningar.ToList<Uthyrning>();
        }
        public IList<Anställd> HämtaAnställda()
        {
            return unitOfWork.anställda.ToList<Anställd>();
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
        public IList<Faktura> HämtaFakturor()
        {
            return unitOfWork.fakturor.ToList<Faktura>();
        }

        public Kund HämtaFörstaPrivatKund()
        {
            Kund hittadKund = unitOfWork.kunder.FirstOrDefault(kund => kund.Typ == "Privat");
            return hittadKund;
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
        /// <summary>
        /// Denna metod, "HamtaStorlekarForTyp", hämtar storlekar för en specifik typ av utrustning. Metoden kontrollerar om parametern för typ är null och om listan med all utrustning är antingen null eller tom. Den identifierar sedan utrustning med en icke-null typ och storlek. Metoden returnerar en lista med unika storlekar för den angivna typen av utrustning och kastar undantag om några problem uppstår under processen.
        /// </summary>
        /// <param name="typ"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
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

        public Faktura HittaFaktura(int söktBokningsNummer)
        {
            Faktura matchadFaktura = unitOfWork.fakturor.FirstOrDefault(b => b.BokningsID == söktBokningsNummer);
            return matchadFaktura;
        }

        public Uthyrning HittaUthyrningFrånRad(int uthyrningsID)
        {
            Uthyrning uthyrning = unitOfWork.uthyrningar.FirstOrDefault(u => u.UthyrningsID == uthyrningsID);
            return uthyrning;
        }

        public Utrustning HämtaSpecifikUtrusning(string utrustningsID)
        {
            Utrustning utrustning = unitOfWork.utrustningar.FirstOrDefault(u => u.UtrustningsID == utrustningsID);
            return utrustning;
        }

        #endregion
        #region Ändra metoder
        /// <summary>
        /// Denna metod, "ÄndraAllaBokningsRader", uppdaterar alla bokningsrader associerade med en specifik bokning. Den tar in start- och slutdatum för bokningsraderna samt bokningsraden som ska ändras och uppdaterar varje bokningsrads datum. Efter att ha uppdaterat alla rader sparas ändringarna till databasen.
        /// </summary>
        /// <param name="från"></param>
        /// <param name="till"></param>
        /// <param name="bokningrad"></param>
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
        /// <summary>
        /// Denna metod, "ÄndraAnställd", uppdaterar en befintlig anställd med de angivna parametrarna för förnamn, efternamn, lösenord och behörighet. Metoden tilldelar de nya värdena till den angivna anställd-objektet och sparar ändringarna till databasen genom att anropa "SaveChanges" från UnitOfWork.
        /// </summary>
        /// <param name="förnamn"></param>
        /// <param name="efternamn"></param>
        /// <param name="lösenord"></param>
        /// <param name="behörighet"></param>
        /// <param name="anställd"></param>
        public void ÄndraAnställd(string förnamn, string efternamn, string lösenord, string behörighet, Anställd anställd)
        {
            anställd.Förnamn = förnamn;
            anställd.Efternamn = efternamn;
            anställd.Lösenord = lösenord;
            anställd.Behörighet = behörighet;
            unitOfWork.SaveChanges();
        }
        /// <summary>
        /// Denna metod, "ÄndraKund", uppdaterar en befintlig kund med de angivna parametrarna för personnummer, namn, telefonnummer, postnummer, postort, typ, adress, e-post och maxbeloppskreditgräns. Metoden tilldelar de nya värdena till den angivna kund-objektet och sparar ändringarna till databasen genom att anropa "SaveChanges" från UnitOfWork.
        /// </summary>
        /// <param name="personnummer"></param>
        /// <param name="namn"></param>
        /// <param name="telefonnummer"></param>
        /// <param name="postNr"></param>
        /// <param name="postOrt"></param>
        /// <param name="typ"></param>
        /// <param name="adress"></param>
        /// <param name="email"></param>
        /// <param name="kredit"></param>
        /// <param name="kund"></param>
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
        public void ÄndraEnBokningsRad(DateTime från, DateTime till, Bokningsrad bokningrad)
        {
            bokningrad.Från = från;
            bokningrad.Till = till;
            unitOfWork.SaveChanges();
        }

        public void ÄndraFakturaRabatt(Faktura valdFaktura, int nyRabatt)
        {
            valdFaktura.Rabattsats = nyRabatt;
            valdFaktura.TotalPris = valdFaktura.TotalPris - (valdFaktura.TotalPris * (nyRabatt / 100));
            unitOfWork.SaveChanges();
        }
        public void ÄndraFakturaMoms(Faktura valdFaktura, int nyMoms)
        {
            valdFaktura.Momsats = nyMoms;
            valdFaktura.TotalPris= valdFaktura.TotalPris - (valdFaktura.TotalPris * (nyMoms / 100));
            unitOfWork.SaveChanges();
        }

        public void ÄndraFakturaTotalPris(Faktura valdFaktura, float nyttPris)
        {
            valdFaktura.TotalPris = valdFaktura.TotalPris + nyttPris;
            unitOfWork.SaveChanges();
        }

        public void ÄndraMaxbeloppFörAllaPrivatKunder(IList<Kund> kunder, int nyttMaxbelopp)
        {
            foreach (var kund in kunder)
            {
                if(kund.Typ == "Privat")
                {
                    kund.Maxbeloppskreditgräns = nyttMaxbelopp;
                }
            }
            unitOfWork.SaveChanges();
        }


        #endregion
        /// <summary>
        /// Metoden "KollaUthyrningsPris" beräknar och returnerar priset för en uthyrning baserat på antalet dagar och typ av uthyrning. Den hämtar priser från databasen via UnitOfWork och använder en switch-sats för att välja priset baserat på antalet dagar. Ett decimalvärde som representerar det totala priset returneras till slut.
        /// </summary>
        /// <param name="från"></param>
        /// <param name="till"></param>
        /// <param name="uthyrningsTyp"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metoden "KollaPris" beräknar och returnerar priset för en logi-uthyrning baserat på typen av logi och antalet dagar mellan två datum. Metoden använder priser från databasen via UnitOfWork och hanterar olika prisstrukturer för olika logityper och veckor. Ett decimalvärde som representerar det totala priset för uthyrningen returneras till slut.
        /// </summary>
        /// <param name="från"></param>
        /// <param name="till"></param>
        /// <param name="logiTyp"></param>
        /// <returns></returns>
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
        
        
        #region Format-validering
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Denna metod, "IsValidEmail", försöker validera en sträng som en giltig e-postadress genom att använda en enkel reguljäruttryckskontroll. Metoden tar in en sträng som representerar e-postadressen och jämför den med det definierade mönstret för e-postvalidering. Om strängen matchar mönstret returnerar metoden sant, annars returneras falskt. Ifall det uppstår några undantag under processen returnerar metoden också falskt.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            try
            {
                // Define a regular expression for email validation with support for Swedish characters Å, Ä, and Ö
                string pattern = @"^[a-zA-Z0-9._%+-åäöÅÄÖ]+@[a-zA-Z0-9.-]+\.[a-zA-ZåäöÅÄÖ]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Denna metod, "IsValidSwedishSSN", försöker validera en sträng som en giltig svensk personnummer (personnummer) genom att använda ett reguljärt uttryck för att kontrollera det grundläggande formatet. Metoden extraherar sedan året, månaden och dagen från personnumret och försöker skapa en giltig födelsedatum med dessa värden. Om detta lyckas och personnumret passerar eventuella ytterligare kontroller, returnerar metoden sant; annars returneras falskt. Ifall det uppstår några undantag under processen returnerar metoden också falskt.
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool IsValidSwedishSSN(string ssn)
        {
            try
            {
                // Basic format check
                string pattern = @"^(\d{4})(0[1-9]|1[0-2])(0[1-9]|1\d|2\d|3[01])\d{4}$";
                if (!Regex.IsMatch(ssn, pattern))
                {
                    return false;
                }

                // Extract year, month, and day
                int year = int.Parse(ssn.Substring(0, 4));
                int month = int.Parse(ssn.Substring(4, 2));
                int day = int.Parse(ssn.Substring(6, 2));

                // Check if date is valid
                DateTime birthDate;
                if (!DateTime.TryParse($"{year}-{month}-{day}", out birthDate))
                {
                    return false;
                }

                // Additional checks on the individual number (e.g., checksum) can be added here if needed

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidName(string name)
        {
            try
            {
                // Regular expression pattern for name validation with Swedish characters
                string pattern = @"^[a-zA-ZåäöÅÄÖ\s'-]+$";
                return Regex.IsMatch(name, pattern);
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidAddress(string address)
        {
            try
            {
                // Regular expression pattern for address validation with Swedish characters and special characters
                string pattern = @"^[a-zA-ZåäöÅÄÖ\s'-,]+ \d+$";
                return Regex.IsMatch(address, pattern);
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            try
            {
                // Regular expression pattern for phone number validation
                string pattern = @"^\+?(\d[\d-. ]+)?\d$";
                return Regex.IsMatch(phoneNumber, pattern);
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPostalCode(string postalCode)
        {
            try
            {
                // Regular expression pattern for postal code validation with Swedish postal code format
                string pattern = @"^\d{5}$";
                return Regex.IsMatch(postalCode, pattern);
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidIntegerForPrecent(int value)
        {
            return (value >= 0 && value <= 100);
        }

        #endregion
    }
}