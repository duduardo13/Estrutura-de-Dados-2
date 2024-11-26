using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Atendimento
{
    internal class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }

        public List<Guiche> getListaGuiches()
        {
            return this.listaGuiches;
        }
    }
}
