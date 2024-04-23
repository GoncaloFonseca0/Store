
namespace Computer
{
  
    internal struct Componentes
    {
        
        internal static int menu()
        {
            int op;
            Console.Clear();
            Console.WriteLine("\n---------( MENU )-----------");
            Console.WriteLine("\t1:Showcase all of the Computers we have avaible!");
            Console.WriteLine("---------------------------\n");
            Console.Write("\t\t\t ... Choose an Option:");
            if (!int.TryParse(Console.ReadLine(), out op)) op = -1;
            return op;

        }
        
        public static  int Total;
        private int _id;
        private String _motherboard;
        private string _cpu;
        private string _ssd;
        private string _ram;
        private string _gpu
            ;
        private string _powersp;

        #region
        internal int Id
        {
            
            get { return _id;}
            set
            {
                if (value >= 0) _id = value;
            }
        }
        internal String Motherboard
        {
            get { return _motherboard;}
            set
            {
                if (value == null) _motherboard = value; 
             
            }
        }

        internal String Cpu
        {
            get { return _cpu;}
            set
            {
            
                if (value == null) _cpu = value;
            }
        }

        internal String Ssd
        {
            get { return _ssd;}
            set
            {
                if (value == null) _ssd = value;
            }
        }

        internal string Ram
        {
            get { return _ram; }
            set
            {
                if (value == null) _ram = value;
            }
        }


        internal String gru
        {

            get { return _gpu; }
            set
            {
                if (value == null) _gpu = value;
            }

        }

        internal string PowerSupply
        {
            get { return _powersp; }
            set
            {
                if (value == null) _powersp = value;
            }
        }
        
        #endregion

        internal Componentes(int id, string motherboard, string cpu, string ssd,string ram, string gpu, string powersupply)
        {

            Componentes.Total++;
            this._id = id;
            this._motherboard = motherboard;
            this._cpu = cpu;
            this._ssd = ssd;
            this._ram = ram;
            this._gpu = gpu;
            this._powersp = PowerSupply;
        }
        

        public override string ToString()
        {
            return $"ID:{_id}\nMotherBoard:{_motherboard}\nCPU:{_cpu}\nSSD:{_ssd}\nRam:{_ram}\nGrafic Card:{_gpu}\nPower Supply:{PowerSupply}";
        }

        internal void See()
        {

            Console.WriteLine($"--------------{Componentes.Total}----------------------");
            Console.WriteLine(this.ToString());
            Console.WriteLine("---------------------------------------");
        }
        
        
        
    }

    

}