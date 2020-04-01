using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMasini2
{
    interface IStocareData
    {
        void AddMasina(Masina masina);
        Masina[] GetMasina(out int nrMasini);
    }
}
