using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public interface IDataConnection
    {
        NagradaModel NapraviNagradu(NagradaModel model);
    }
    
}
