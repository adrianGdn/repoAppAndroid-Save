using SuiviAA.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.JsonModel
{
    public class MedecinJson:IEnumerable
    {
        public List<Medecin> medecins { get; set; }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)medecins).GetEnumerator();
        }
    }
}
