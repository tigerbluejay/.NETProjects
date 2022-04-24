using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoPolimorfismo.EntidadesAjedrez
{
    public class PiezaAjedrez
    {
        public virtual string Mover()
        {
           return "Pieza se mueve";
            
        }
    }
}
