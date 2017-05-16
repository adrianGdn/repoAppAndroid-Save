using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuiviAA.Model;
using System.Collections;

namespace SuiviAA.JsonModel
{
    public class VisiteJson : IEnumerable
    {
        public List<Visite> visite { get; set; }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)visite).GetEnumerator();
        }
    }
}

