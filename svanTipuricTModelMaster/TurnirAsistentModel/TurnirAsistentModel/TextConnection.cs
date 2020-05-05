using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TextConnection : IDataConnection
    {
        public NagradaModel NapraviNagradu(NagradaModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}
