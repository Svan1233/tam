using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// jedinstveni identitet za nagradu
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// pozicija mjesta koju je ekipa osvojila
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// naziv mjesta koju je ekipa osvojila
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Kolicina nagrade koju ce ekipa dobiti
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// postotak nagrade koju ce ekipa dobiti(npr 50%)
        /// </summary>
        public double PostotakNagrade { get; set; }

    }
}
