using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoi_proekt
{
    public interface View
    {
        void UpdateState(Tour tour, int gen);
    }
}
