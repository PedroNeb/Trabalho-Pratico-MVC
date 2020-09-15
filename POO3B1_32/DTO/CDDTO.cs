using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B1_32.DTO
{
    public class CDDTO
    {
        private string nomeCD;
        private double precoVenda;
        private DateTime dtLancamento;
        private int idCD;

        public CDDTO (string nomeCD, double precoVenda)
        {
            this.NomeCD = nomeCD;
            this.PrecoVenda = precoVenda;
            this.idCD = Math.Sign(Guid.NewGuid().GetHashCode())<0? Guid.NewGuid().GetHashCode()*-1: Guid.NewGuid().GetHashCode();
        }

        public string NomeCD { get => nomeCD; set {
                if (!string.IsNullOrEmpty(value))
                {
                    nomeCD = value;
                }
                else
                {
                    throw new Exception("Algum campo esta vazio");
                }
            } }

        public double PrecoVenda { get => precoVenda; set{
                if (!double.IsNaN(value))
                {
                    precoVenda = value;
                }
                else
                {
                    throw new Exception("Algum campo esta vazio");
                }
            } }

        public DateTime DtLancamento { get => dtLancamento; set => dtLancamento = value; }
        public int IdCD { get => idCD; set => idCD = value; }

        public CDDTO(int id ,string nomeCD, double precoVenda)
        {
            this.NomeCD = nomeCD;
            this.PrecoVenda = precoVenda;
            this.idCD = id;
        }
    }
}