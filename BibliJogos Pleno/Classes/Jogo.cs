using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliJogos.Classes
{
    internal class Jogo
    {

        //Atributos
        private String titulo; 
        private int data; 
        private String genero; 
        private int qtjogadores; 
        private int metacritic; 

        //Construtores
        public Jogo (String titulo, int data, String genero, int qtjogadores, int metacritic )
        {
            this.titulo = titulo;
            this.data = data;
            this.genero = genero;
            this.qtjogadores = qtjogadores;
            this.metacritic = metacritic;
        }
        public Jogo(String titulo, int data, String genero, int qtjogadores)
        {
            this.titulo = titulo;
            this.data = data;
            this.genero = genero;
            this.qtjogadores = qtjogadores;
        }

        // Metodos de Acesso
        public String getTitulo ()
        {
            return this.titulo;
        }
        public void setTitulo(String titulo)
        {
            if(titulo != "")
            {
                this.titulo = titulo;
            }
        }
        public String getGenero()
        {
            return this.genero;
        }
        public void setGenero(String genero)
        {
            if (genero != "")
            {
                this.genero = genero;
            }
        }
        public int getData()
        {
            return this.data;
        }
        public void setData(int data)
        {
            if (data > 1950)
            {
                this.data = data;
            }
        }
        public int getqtjogadores()
        {
            return this.qtjogadores;
        }
        public void setqtjogadores(int qtjogadores)
        {
            if (qtjogadores >= 1)
            {
                this.qtjogadores = qtjogadores;
            }
        }
        public int getMetacritic()
        {
            return this.metacritic;
        }
        public void setMetacritic(int metacritic)
        {
            if (metacritic >= 0 && metacritic <= 100 )
            {
                this.metacritic = metacritic;
            }
        }



    }
}
