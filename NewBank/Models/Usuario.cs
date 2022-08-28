using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBank.Interface;

namespace NewBank.Models
{
    internal class Usuario : IConta
    {
        #region Atributos
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Id {get;set;}
        public double Saldo { get; set; }
        public bool Logado { get; set; }


        #endregion

        #region Construtor
        
        #endregion

        #region Metodos
        public double ConsultaSaldo()
        {
            throw new NotImplementedException();
        }

        public double Deposita()
        {
            throw new NotImplementedException();
        }

        public bool Deslogar()
        {
            throw new NotImplementedException();
        }

        public bool Logar(int Id)
        {
            if(this.Id == Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Saca()
        {
            throw new NotImplementedException();
        }

        public double Transferencias()
        {
            throw new NotImplementedException();
        }
    }
        #endregion
}
