using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBank.Interface
{
    internal interface IConta
    {
        public bool Logar(int Id);
        public bool Deslogar();
        public double Transferencias();
        public double ConsultaSaldo();
        public double Saca();
        public double Deposita();
    }
}
