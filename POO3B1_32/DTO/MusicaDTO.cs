using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B1_32.DTO
{
    public class MusicaDTO
    {
        private string nome;
        private string nomeAutor;
        private string idMusica;

        public MusicaDTO (string nome, string nomeAutor)
        {
            this.Nome = nome;
            this.NomeAutor = nomeAutor;
        }

        public string Nome { get => nome; set {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Algum campo esta vazio");
                }
            }
        }

        public string NomeAutor { get => nomeAutor; set {
                if (!string.IsNullOrEmpty(value))
                {
                    nomeAutor = value;
                }
                else
                {
                    throw new Exception("Algum campo esta vazio");
                }
            }
        }

        public string IdMusica { get => idMusica; set => idMusica = value; }
    }
}