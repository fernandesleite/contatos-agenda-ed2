using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA05_09_2019
{
    class Contatos
    {
        private List<Contato> meusContatos;

        public List<Contato> MeusContatos
        {
            get { return meusContatos; }
        }

        public Contatos()
        {
            meusContatos = new List<Contato>();
        }

        public void adicionar(Contato c)
        {
            Console.WriteLine(c.Fones.Count);
            this.meusContatos.Add(c);
        }

        public Contato pesquisar(Contato c)
        {
            Contato contatoAchado;
            foreach (Contato contato in this.meusContatos)
            {
                Console.WriteLine(contato.Fones.Count);
                if (contato.Email.Equals(c.Email))
                {
                    contatoAchado = contato;
                    return contatoAchado;
                }
            }    
            return null;
        }
        public bool alterar(Contato c)
        {
            int posicao = -1;
            foreach(Contato contato in this.meusContatos)
            {
                if (contato.Email.Equals(c.Email))
                {
                    posicao = this.meusContatos.IndexOf(contato);

                }
            }

            this.meusContatos.RemoveAt(posicao);
            this.meusContatos.Insert(posicao, c);

            return (posicao > -1);
        }

        public bool remover(Contato c)
        {
            foreach (Contato contato in this.meusContatos)
            {
                if (contato.Email.Equals(c.Email))
                {
                    this.meusContatos.RemoveAt(this.meusContatos.IndexOf(contato));
                    return true;
                }
            }
            return false;
        }
    }
}
