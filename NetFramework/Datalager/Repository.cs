using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalager
{
    public class Repository<T>
        where T : class
    {
        /// <summary>
        /// Lägger till en entitet i den underliggande datatabellen.
        /// </summary>
        /// <param name="entity">Entiteten som ska läggas till i datatabellen</param>
        public void Add(T entity)
        {
            table.Add(entity);
        }

        /// <summary>
        ///  Ta bort en entitet från Table.
        /// </summary>
        /// <param name="entity">Entiteten som ska tas bort</param>
        /// <returns>true om borttagen och false annars.</returns>
        public bool Remove(T entity)
        {
            return table.Remove(entity);
        }

        /// <summary>
        /// Hittar och returnerar en samling av entiteter som matchar det specificerade predikatet.
        /// </summary>
        /// <param name="predicate">Ett villkor som används för att filtrera entiteter i datatabellen</param>
        /// <returns>En samling av entiteter som uppfyller predikatet</returns>
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return table.Where(predicate);
        }

        /// <summary>
        /// Hittar det första elementet som matchar det specificerade villkoret och returnerar det.
        /// Om inget matchande element hittas, returneras standardvärdet för typen T.
        /// </summary>
        /// <param name="predicate">Ett villkor som används för att filtrera elementen i sekvensen</param>
        /// <returns>Det första matchande elementet eller standardvärdet för typen T om ingen matchning hittas</returns>
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return table.FirstOrDefault(predicate);
        }

        /// <summary>
        /// Kontrollerar om datatabellen är tom, dvs. om den inte innehåller några entiteter.
        /// </summary>
        /// <returns><c>true</c> om datatabellen är tom; annars <c>false</c>.</returns>
        public bool IsEmpty()
        {
            return table.Count == 0;
        }

        /// <summary>
        ///  Räkna antal entiteter i Table.
        /// </summary>
        /// <returns>Antalet entiteter.</returns>
        public int Count()
        {
            return table.Count();
        }

        // Skapar en ny instans av Repository-klassen och initierar den interna datatabellen om den inte redan finns.
        internal Repository()
        {
            if (table == null)
            {
                table = new List<T>();
            }
        }

        private IList<T> table;
    }
}
