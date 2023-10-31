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
        /// Metod för granskning av användarnamn och lösenord vid inlogg till systemet
        /// </summary>
        /// <param name="anställningsNr">Den anställdas nummer för att logga in</param>
        /// <param name="lösenord">Den anställdas lösenord för att logga in</param>
        /// <returns>false om inloggning inte gick igenom, och true om det gick att logga in</returns>
        public bool LoggaIn(int anställningsNr, string lösenord)
        {
            unitOfWork = new UnitOfWork();
            Anställd a = (from anst in unitOfWork.anställda where anst.AnställningsNr == anställningsNr select anst).FirstOrDefault();
            if (a != null && a.VerifieraLösenord(lösenord))
            {
                LoggedIn = a;
                return true;
            }
            else
                LoggedIn = null;
            return false;
        }

        /// <summary>
        /// Metoden beräknar och returnerar priset för en uthyrning baserat på antalet dagar och typ av utrustning.
        /// </summary>
        /// <param name="från">Datumet som uthyrningen börjar på</param>
        /// <param name="till">Datumet som uthyrningen slutar på</param>
        /// <param name="uthyrningsTyp">Det är typen av utrustning man hyr ut</param>
        /// <returns>Priset för uthyrningen</returns>
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
        /// Beräknar och returnerar priset för ett logi baserat på typen av logi och antalet dagar.
        /// </summary>
        /// <param name="från">Datumet som bokningen börjar på</param>
        /// <param name="till">Datumet som bokningen slutar på</param>
        /// <param name="logiTyp">Det är typen av logi man bokar</param>
        /// <returns>Priset för valt logi</returns>
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

        public float prisInkMomsOchRabatt(decimal pris, Faktura valdFaktura)
        {
            return (float)pris - ((float)pris * ((float)valdFaktura.Rabattsats / 100));
        }

        public float prisInkRabattExkMoms(float prisInkRabatt, decimal totalpris, Faktura valdFaktura)
        {
            return prisInkRabatt - ((float)totalpris * ((float)valdFaktura.Momsats / 100));
        }


        #region Skapa metoder
        /// <summary>
        /// Metoden skapar en ny bokning kopplad till en given kund i databasen.
        /// </summary>
        /// <param name="k">Är kunden bokningen ska kopplas till</param>
        /// <returns>Den skapade bokningen</returns>
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
        /// Metoden skapar en ny uthyrning kopplad till en given bokning i databasen.
        /// </summary>
        /// <param name="b">Bokningen man vill skapa uthyrning på</param>
        /// <returns>Den nyskapade uthyrningen returneras</returns>
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

        /// <summary>
        /// Metoden skapar en ny faktura kopplad till en bokning
        /// </summary>
        /// <param name="bokningsID">Bokningen fakturan ska tillhöra</param>
        /// <param name="moms">Momsen som ska tillhöra fakturan</param>
        /// <param name="rabattsats">rabattsats som ska tillhöra fakturan</param>
        /// <param name="totalpris">totalpris för fakturan</param>
        /// <returns>Den nya fakturan</returns>
        public Faktura SkapaFaktura(int bokningsID, int moms, int rabattsats, float totalpris)
        {
            Faktura nyFaktura = new Faktura(bokningsID, moms, rabattsats, totalpris);
            unitOfWork.fakturor.Add(nyFaktura);
            unitOfWork.SaveChanges();
            return nyFaktura;
        }

        /// <summary>
        /// Metoden skapar en ny uthyrningsrad kopplad till en given utrustning och uthyrning i databasen.
        /// </summary>
        /// <param name="från">Datumet som uthyrningen börjar på</param>
        /// <param name="till">Datumet som uthyrningen slutar på</param>
        /// <param name="u">Utrustningen som ska bokar</param>
        /// <param name="uthyrningsID">Uthyrningen som utrustningen ska tillhöra</param>
        /// <returns>Den nyskapade uthyrningsraden returneras.</returns>
        public Uthyrningsrad SkapaUthyrningsRad(DateTime från, DateTime till, Utrustning u, int uthyrningsID)
        {
            Uthyrningsrad nyUthyrningsRad = new Uthyrningsrad(u.UtrustningsID, från, till, uthyrningsID);
            unitOfWork.uthyrningsRader.Add(nyUthyrningsRad);
            unitOfWork.SaveChanges();
            return nyUthyrningsRad;
        }
        /// <summary>
        /// Metoden skapar och lägger till en bokningsrad i databasen
        /// </summary>
        /// <param name="från">Datumet som bokning av logi börjar på</param>
        /// <param name="till">Datumet som bokning av logi slutar på</param>
        /// <param name="l">Det valda logit som ska bokas</param>
        /// <param name="bokningsID">Bokningen som det valda logi ska tillhöra</param>
        /// <returns>Den nya bokningsraden returneras</returns>
        public Bokningsrad SkapaBokningsRad(DateTime från, DateTime till, Logi l, int bokningsID)
        {
            Bokningsrad nyRad = new Bokningsrad(l.LogiID, från, till, bokningsID);
            unitOfWork.bokningsRader.Add(nyRad);
            unitOfWork.SaveChanges();
            return nyRad;
        }

        /// <summary>
        /// Metoden skapar och lägger till en ny kund i databasen.
        /// </summary>
        /// <param name="personnummer">Personnumret för den nya kunden</param>
        /// <param name="namn">Namnet på den nya kunden</param>
        /// <param name="telefonnummer">Telefonnumret för den nya kunden</param>
        /// <param name="email">E-postadressen för den nya kunden</param>
        /// <param name="adress">Adressen för den nya kunden</param>
        /// <param name="postNr">Postnumret för den nya kunden</param>
        /// <param name="postOrt">Orten för den nya kunden</param>
        /// <param name="typ">Typen av kund (ex. privat eller företag)</param>
        /// <param name="maxbeloppskreditgräns">Maximal kreditgräns för den nya kunden</param>
        /// <returns>Den nya kunden som har skapats och lagts till i databasen</returns>
        public Kund SkapaNyKund(string personnummer, string namn, string telefonnummer, string email, string adress, string postNr, string postOrt, string typ, int maxbeloppskreditgräns)
        {
            Kund kund = new Kund(personnummer, namn, telefonnummer, email, adress, postNr, postOrt, typ, maxbeloppskreditgräns);
            unitOfWork.kunder.Add(kund);
            unitOfWork.SaveChanges();
            return kund;

        }

        /// <summary>
        /// Metoden skapar och lägger till en ny anställd i databasen.
        /// </summary>
        /// <param name="förnamn">Förnamnet på den nya anställda</param>
        /// <param name="efternamn">Efternamnet på den nya anställda</param>
        /// <param name="lösenord">Lösenordet för den nya anställda</param>
        /// <param name="behörighet">Behörighetsnivån för den nya anställda (ex. admin, bokare)</param>
        /// <returns>Den nya anställda som har skapats och lagts till i databasen</returns>
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
        /// Metoden tar bort en befintlig kund från databasen.
        /// </summary>
        /// <param name="k">Kunden som ska tas bort</param>
        public void TaBortKund(Kund k)
        {
            unitOfWork.kunder.Remove(k);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig anställd från databasen.
        /// </summary>
        /// <param name="a">Den anställda som ska tas bort</param>
        public void TaBortAnställd(Anställd a)
        {
            unitOfWork.anställda.Remove(a);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig bokning från databasen.
        /// </summary>
        /// <param name="b">Bokningen som ska tas bort</param>
        public void TaBortBokning(Bokning b)
        {
            unitOfWork.bokningar.Remove(b);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig uthyrning från databasen.
        /// </summary>
        /// <param name="u">Uthyrningen som ska tas bort</param>
        public void TaBortUthyrning(Uthyrning u)
        {
            unitOfWork.uthyrningar.Remove(u);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig bokningsrad från databasen.
        /// </summary>
        /// <param name="rad">Bokningsraden som ska tas bort</param>
        public void TaBortBokningsRad(Bokningsrad rad)
        {
            unitOfWork.bokningsRader.Remove(rad);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig uthyrningsrad från databasen.
        /// </summary>
        /// <param name="uRad">Uthyrningsraden som ska tas bort</param>
        public void TaBortUthyrningsRad(Uthyrningsrad uRad)
        {
            unitOfWork.uthyrningsRader.Remove(uRad);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort ett befintlig bokningsrad (Bokat logi) från databasen.
        /// </summary>
        /// <param name="valRad">Login (bokningsraden) som ska tas bort</param>
        public void TaBortLogi(Bokningsrad valRad)
        {
            unitOfWork.bokningsRader.Remove(valRad);
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Metoden tar bort en befintlig faktura från databasen.
        /// </summary>
        /// <param name="valdFaktura">Fakturan som ska tas bort</param>
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
        public IList<Kund> HittaKunderPåNamn(string namn)
        {
            return unitOfWork.kunder.Where(k => k.Namn == namn).ToList();
        }
        public IList<Kund> HittaKunderPåPersonNr(string personNr)
        {
            return unitOfWork.kunder.Where(k => k.Personnummer == personNr).ToList();
        }
        public Anställd HittaAnställd(int anställningsNr)
        {
            return unitOfWork.anställda.FirstOrDefault(a => a.AnställningsNr == anställningsNr);
        }
        public IList<Anställd> HittaFlerSpecifikaAnställda (int anställningsNr)
        {
            return unitOfWork.anställda.Where(a => a.AnställningsNr == anställningsNr).ToList();
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
        public IList<Bokning> HämtaKundensBokningar(int kundID)
        {
            return unitOfWork.bokningar.Where(b => b.KundID == kundID).ToList();
        }
        public IList<Bokning> HämtaBokningPåPersonNr(string personNr)
        {
            return unitOfWork.bokningar.Where(b => b.Kund.Personnummer == personNr).ToList();
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
        /// Hämtar en lista med tillgängliga storlekar för en given utrustningstyp.
        /// </summary>
        /// <param name="typ">Typen av utrustning för vilken storlekarna ska hämtas</param>
        /// <returns>En lista med tillgängliga storlekar som är kopplade till den angivna utrustningstypen</returns>
        /// <exception cref="ArgumentNullException">Kastas om 'typ' är null</exception>
        /// <exception cref="InvalidOperationException">Kastas om 'allUtrustning' är null eller tom</exception>
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
        /// Ändrar start- och slutdatum för alla bokningsrader kopplade till en specifik bokning.
        /// </summary>
        /// <param name="från">Det nya startdatumet för bokningsraderna</param>
        /// <param name="till">Det nya slutdatumet för bokningsraderna</param>
        /// <param name="bokningrad">Den ursprungliga bokningsraden</param>
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
        /// Ändrar informationen för en befintlig anställd och sparar ändringarna i databasen.
        /// </summary>
        /// <param name="förnamn">Det nya förnamnet</param>
        /// <param name="efternamn">Det nya efternamnet</param>
        /// <param name="lösenord">Det nya lösenordet</param>
        /// <param name="behörighet">Den nya behörigheten</param>
        /// <param name="anställd">Den anställda som ska ändras</param>
        public void ÄndraAnställd(string förnamn, string efternamn, string lösenord, string behörighet, Anställd anställd)
        {
            anställd.Förnamn = förnamn;
            anställd.Efternamn = efternamn;
            anställd.Lösenord = lösenord;
            anställd.Behörighet = behörighet;
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Ändrar informationen för en befintlig kund och sparar ändringarna i databasen.
        /// </summary>
        /// <param name="personnummer">Det nya personnumret</param>
        /// <param name="namn">Det nya namnet</param>
        /// <param name="telefonnummer">Det nya telefonnumret</param>
        /// <param name="postNr">Det nya postnumret</param>
        /// <param name="postOrt">Den nya orten</param>
        /// <param name="typ">Den nya kundtypen (ex. privat eller företag)</param>
        /// <param name="adress">Den nya adressen</param>
        /// <param name="email">Den nya e-postadressen</param>
        /// <param name="kredit">Den nya maxbeloppskreditgränsen</param>
        /// <param name="kund">Kunden som ska ändras</param>
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

        /// <summary>
        /// Ändrar start- och slutdatum för en specifik bokningsrad och sparar ändringarna i databasen.
        /// </summary>
        /// <param name="från">Det nya startdatumet</param>
        /// <param name="till">Det nya slutdatumet</param>
        /// <param name="bokningrad">Bokningsraden som ska ändras</param>
        public void ÄndraEnBokningsRad(DateTime från, DateTime till, Bokningsrad bokningrad)
        {
            bokningrad.Från = från;
            bokningrad.Till = till;
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Ändrar rabattsatsen för en faktura och uppdaterar totalpriset i databasen.
        /// </summary>
        /// <param name="valdFaktura">Fakturan vars rabattsats ska ändras</param>
        /// <param name="nyRabatt">Den nya rabattsatsen (procent) för fakturan</param>
        public void ÄndraFakturaRabatt(Faktura valdFaktura, int nyRabatt)
        {
            valdFaktura.Rabattsats = nyRabatt;
            valdFaktura.TotalPris = valdFaktura.TotalPris - (valdFaktura.TotalPris * (nyRabatt / 100));
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Ändrar momssatsen för en faktura och uppdaterar totalpriset i databasen.
        /// </summary>
        /// <param name="valdFaktura">Fakturan vars momssats ska ändras</param>
        /// <param name="nyMoms">Den nya momssatsen (procent) för fakturan</param>
        public void ÄndraFakturaMoms(Faktura valdFaktura, int nyMoms)
        {
            valdFaktura.Momsats = nyMoms;
            valdFaktura.TotalPris = valdFaktura.TotalPris - (valdFaktura.TotalPris * (nyMoms / 100));
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Ändrar det totala priset för en faktura och uppdaterar det i databasen.
        /// </summary>
        /// <param name="valdFaktura">Fakturan vars totalpris ska ändras</param>
        /// <param name="nyttPris">Det nya totalpriset för fakturan</param>
        public void ÄndraFakturaTotalPris(Faktura valdFaktura, float nyttPris)
        {
            valdFaktura.TotalPris = valdFaktura.TotalPris + nyttPris;
            unitOfWork.SaveChanges();
        }

        /// <summary>
        /// Ändrar maxbeloppskreditgränsen för alla angivna privatkunder och sparar ändringarna i databasen.
        /// </summary>
        /// <param name="kunder">Kunder där maxbeloppskreditgränsen ska ändras för privatkunder</param>
        /// <param name="nyttMaxbelopp">Det nya maxbeloppet för kreditgränsen som ska tillämpas på privatkunder</param>
        public void ÄndraMaxbeloppFörAllaPrivatKunder(IList<Kund> kunder, int nyttMaxbelopp)
        {
            foreach (var kund in kunder)
            {
                if (kund.Typ == "Privat")
                {
                    kund.Maxbeloppskreditgräns = nyttMaxbelopp;
                }
            }
            unitOfWork.SaveChanges();
        }

        #endregion
        #region Format-validering

        /// <summary>
        /// Kontrollerar om en given sträng enbart innehåller siffror (0-9).
        /// </summary>
        /// <param name="str">Strängen som ska kontrolleras</param>
        /// <returns>
        /// <c>true</c> om strängen enbart innehåller siffror; annars <c>false</c>.
        /// </returns>
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
        /// Kontrollerar om en given e-postadress är giltig med stöd för svenska bokstäver (Å, Ä, och Ö).
        /// </summary>
        /// <param name="email">E-postadressen som ska kontrolleras</param>
        /// <returns>
        /// <c>true</c> om e-postadressen är giltig; annars <c>false</c>.
        /// </returns>
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
        /// Kontrollerar om en given sträng representerar ett giltigt svenskt personnummer.
        /// </summary>
        /// <param name="ssn">Strängen som ska kontrolleras som ett personnummer</param>
        /// <returns>
        /// <c>true</c> om strängen representerar ett giltigt personnummer; annars <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Kontrollerar om en given sträng representerar ett giltigt namn med stöd för svenska bokstäver (Å, Ä, och Ö).
        /// </summary>
        /// <param name="name">Strängen som ska kontrolleras som ett namn</param>
        /// <returns>
        /// <c>true</c> om strängen representerar ett giltigt namn; annars <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Kontrollerar om en given sträng representerar en giltig adress med stöd för svenska bokstäver, specialtecken och ett slutet nummer.
        /// </summary>
        /// <param name="address">Strängen som ska kontrolleras som en adress</param>
        /// <returns>
        /// <c>true</c> om strängen representerar en giltig adress; annars <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Kontrollerar om en given sträng representerar ett giltigt telefonnummer med stöd för olika tecken.
        /// </summary>
        /// <param name="phoneNumber">Strängen som ska kontrolleras som ett telefonnummer</param>
        /// <returns>
        /// <c>true</c> om strängen representerar ett giltigt telefonnummer; annars <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Kontrollerar om en given sträng representerar ett giltig postnummer enligt det svenska postnumret.
        /// </summary>
        /// <param name="postalCode">Strängen som ska kontrolleras som ett postnummer</param>
        /// <returns>
        /// <c>true</c> om strängen representerar ett giltigt postnummer; annars <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Kontrollerar om en given heltalsvärde är ett giltigt procentvärde inom intervallet 0-100.
        /// </summary>
        /// <param name="value">Heltalsvärdet som ska kontrolleras som ett procentvärde</param>
        /// <returns>
        /// <c>true</c> om heltalsvärdet är ett giltigt procentvärde inom intervallet 0-100; annars <c>false</c>.
        /// </returns>
        public bool IsValidIntegerForPrecent(int value)
        {
            return (value >= 0 && value <= 100);
        }

        #endregion
    }
}