using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULA05_09_2019
{
    public partial class Form1 : Form
    {

        List<Fone> listaFone = new List<Fone>();
        private List<string> listaNum = new List<string>();
        private List<string> listaTipo = new List<string>();
        private Contatos contatos = new Contatos();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            // Remove todos os textos da form
            emailText.Text = "";
            nomeText.Text = "";
            numeroText.Text = "";
            tipoText2.Text = "";
            this.listaNum.Clear();
            this.listaTipo.Clear();
            listNumero.Items.Clear();
            listTipo.Items.Clear();
        }

        private void exibicaoLista()
        {
            listNumero.Items.Clear();
            listTipo.Items.Clear();

            for (int i = 0; i < this.listaNum.Count; i++)
            {
                listNumero.Items.Add(this.listaNum[i]);
                listTipo.Items.Add(this.listaTipo[i]);
            }
        }
        public void limparListBox()
        {
            listNumero.Items.Clear();
            listTipo.Items.Clear();
            this.listaNum.Clear();
            this.listaTipo.Clear();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Contato test = contatos.pesquisar(new Contato(emailText.Text, "", new List<Fone>()));
            List<Fone> listaFoneTemp = new List<Fone>();
            for (int i = 0; i < listNumero.Items.Count; i++)
            {
                listaFoneTemp.Add(new Fone(listNumero.Items[i].ToString(), listTipo.Items[i].ToString()));

            }
            Contato c = new Contato(emailText.Text, nomeText.Text, listaFoneTemp);
            if (test == null)
            {
                contatos.adicionar(c);
                MessageBox.Show("Usuario Adicionado");
            }
            else
            {
                contatos.alterar(c);
                MessageBox.Show("Usuario Alterado");
            }
        }

        private void BtnAddFone_Click(object sender, EventArgs e)
        {
            // Adiciona numero/tipo em listas separadas para exibição/manipulação
            this.listaNum.Add(numeroText.Text);
            this.listaTipo.Add(tipoText2.Text);

            // Exibicao
            this.exibicaoLista();
        }

        
        private void BtnRemFone_Click(object sender, EventArgs e)
        {
            // Caso não tenha nenhum numero selecionado
            if(!(listNumero.SelectedIndex == -1))
            {
                this.listaNum.RemoveAt(listNumero.SelectedIndex);
                this.listaTipo.RemoveAt(listNumero.SelectedIndex);
            }
            // Exibição
            this.exibicaoLista();
        }
               
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (contatos.remover(new Contato(emailText.Text, "", null)))
            {
                MessageBox.Show("Contato Removido");
                this.limparListBox();
            }
            else
            {
                MessageBox.Show("Contato não existente");
            }
        }

        private void BtnPesq_Click(object sender, EventArgs e)
        {
            Contato test = contatos.pesquisar(new Contato(emailText.Text, "", new List<Fone>()));
            if(test == null)
            {
                MessageBox.Show("Nao há nenhum contato com este email");
            }
            else
            {
                this.limparListBox();

                emailText.Text = test.Email;
                nomeText.Text = test.Nome;
                for (int k = 0; k < test.Fones.Count; k++)
                {
                    this.listaNum.Add(test.Fones[k].Numero);
                    this.listaTipo.Add(test.Fones[k].Tipo);
                    listNumero.Items.Add(test.Fones[k].Numero);
                    listTipo.Items.Add(test.Fones[k].Tipo);                
                    
                }
            }
            
        }
    }
}