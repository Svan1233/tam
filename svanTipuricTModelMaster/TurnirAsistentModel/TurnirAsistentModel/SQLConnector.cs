using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Izradi NapraviNagradu metodu koju sacuva u bazu
        /// <summary>
        /// spremi novu nagradu u bazu podataka
        /// </summary>
        /// <param name="model">info o nagradama</param>
        /// <returns>info o nagradama, ukljucujuci posebni indetifikator</returns>
        public NagradaModel NapraviNagradu(NagradaModel model)
        {
            model.ID = 1;
            return model;
        }

        
    }
}
