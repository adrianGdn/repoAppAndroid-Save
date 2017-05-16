using SuiviAA.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviAA.JsonModel
{
    public class CabinetJson:IEnumerable
    {
        #region properties
        public List<Cabinet> cabinets { get; set; }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)cabinets).GetEnumerator();
        }
        #endregion
    }
}
