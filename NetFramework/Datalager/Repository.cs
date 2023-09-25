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
        ///  Lägg till en ny entitet till Table.
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            table.Add(entity);
        }

        /// <summary>
        ///  Ta bort en entitet från Table.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>true om borttagen och false annars.</returns>
        public bool Remove(T entity)
        {
            return table.Remove(entity);
        }

        /// <summary>
        ///  Hitta entiteter som matchar predikatet.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return table.Where(predicate);
        }

        /// <summary>
        ///  Hitta den första entiteten som matchar predikat.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return table.FirstOrDefault(predicate);
        }

        /// <summary>
        ///  Är repositoryn tom?
        /// </summary>
        /// <returns>true = tom, false = inte.</returns>
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
