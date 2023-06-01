using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nobel
{
    
    class Nobel
    {
        int ev;
        string tipus;
        string keresztNev;
        string vezetekNev;

        public Nobel(string sor)
        {
            string[] mezok = sor.Split(';');
            ev = int.Parse(mezok[0]);
            tipus = mezok[1];
            keresztNev = mezok[2];
            vezetekNev = mezok[3];
        }

        public Nobel(int ev, string tipus, string keresztNev, string vezetekNev)
        {
            this.ev = ev;
            this.tipus = tipus;
            this.keresztNev = keresztNev;
            this.vezetekNev = vezetekNev;
        }

        public int Ev { get => ev;}
        public string Tipus { get => tipus;}
        public string KeresztNev { get => keresztNev;}
        public string VezetekNev { get => vezetekNev;}
        public string TeljesNev { get => keresztNev + " " + vezetekNev; }
        public string Fajlba { get => $"{Ev}:{TeljesNev}"; }
    }
}
