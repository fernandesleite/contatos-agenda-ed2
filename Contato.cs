using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA05_09_2019
{
    class Contato
    {
        #region Atributos
        private string email;
        private string nome;
        private List<Fone> fones;
        #endregion

        #region Propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Fone> Fones
        {
            get { return fones; }
            set { fones = value; }
        }
        #endregion

        #region Construtores
        public Contato(string email, string nome, List<Fone> fones)
        {
            this.email = email;
            this.nome = nome;
            this.fones = fones;
        }
        #endregion

        #region Sobrecargas
        //public override string ToString()
        //{
        //    return string.Format("e-mail: {0}\nNome: {1}\nFone: {2}",
        //        this.email, this.nome, this.fone);
        //}


        public void adicionarFone(Fone f)
        {
            this.fones.Add(f);
        }

        public bool removerFone(Fone f)
        {
            return false;
        }
        //public override bool Equals(object obj)
        //{
        //    return (this.email == ((Contato)obj).email);
        //}
        #endregion
    }
}
