


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Computer
{

    internal class Program
    {


        static void Main(string[] args)
        {
            int op;
            for (;;)
            {


                op = Componentes.menu();
                if (op == 0)break;
                switch (op)
                {
                    case 1:
                        
                        Componentes pc1 = new Componentes(1, "Motherboard MSI MPG B550 Gaming Plus",
                            "Intel\u00ae Core\u2122 i5-12400F Hexa-Core, 2.50 GHz,18 MB Cache", "250GB", "16GB",
                            " 2.50 GHz, 4.40 GHz, 18 MB Cache", "500w");
                        pc1.See();
                        Componentes pc2 = new Componentes(1, "Motherboard MSI 900",
                            "Intel\u00ae Core\u2122 i5-12400F Hexa-Core, 2.50 GHz,18 MB Cache", "250GB", "16GB",
                            " 2.50 GHz, 4.40 GHz, 18 MB Cache", "500w");
                        pc2.See();
                        break;
                }




                Console.ReadLine();
            }
        }
    }
    
    
}

