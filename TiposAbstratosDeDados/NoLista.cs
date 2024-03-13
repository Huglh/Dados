using System;
using System.Collections.Generic;
using System.Text;

namespace TiposAbstratosDeDados
{
    class NoLista
    {
        public int chave;
        public string nome;
        public NoLista prox;

        public NoLista(int chave, string nome)
        {
            this.chave = chave;
            this.nome = nome;
            this.prox = null;
        }
    }

    class Lista
    {
        private NoLista prim;
        private NoLista ult;

        public Lista()
        {
            prim = ult = null;
        }

        public void Inserir(NoLista item)
        {
            if (prim == null)
                prim = item;
            else
                ult.prox = item;
            ult = item;
        }

        public void Imprimir()
        {
            NoLista aux = prim;
            while (aux != null)
            {
                Console.WriteLine(aux.chave + ", " + aux.nome);
                aux = aux.prox;
            }
        }

        public NoLista Pesquisar(int chave)
        {
            NoLista aux = prim;
            while (aux != null && aux.chave != chave)
            {
                aux = aux.prox;
            }
            return aux;
        }

        public bool Remover(int chave)
        {
            NoLista aux = prim, ant = null;
            while (aux != null && aux.chave != chave)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux != null)
            {
                if (ant != null) // não é o primeiro 
                    ant.prox = aux.prox;
                else // é o primeiro
                    prim = aux.prox;
                if (aux == ult) // é o último
                    ult = ant;
                aux.prox = null; // desconecta o nó da lista
                return true;
            }
            return false;
        }
    }
}
