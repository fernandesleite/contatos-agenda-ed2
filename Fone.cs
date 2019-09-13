using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA05_09_2019
{
    class Fone
    {
        #region Atributos
        private string numero;
        private string tipo;
        #endregion


        #region Propriedades
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Fone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        #endregion
    }
}
