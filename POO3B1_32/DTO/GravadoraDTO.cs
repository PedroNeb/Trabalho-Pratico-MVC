using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B1_32.DTO
{
    public class GravadoraDTO
    {
        private string nome;
        private int idGravadora;
        public GravadoraDTO(string nome){
            this.Nome = nome;
        }

        public string Nome { get => nome; set {
           if(!string.IsNullOrEmpty(value)){
                    nome = value;
           }
           else
           {
             throw new Exception("Algum campo esta vazio");
           }
        }}

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
    }
}