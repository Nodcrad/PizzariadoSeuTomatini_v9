using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariadoSeuTomatini.modelo
{
    class Pizza
    {
        private String Tipo;
        private String Sabor;
        private String Composicao;
        private bool permiteBorda;
        private String bordas;
        private Double valorpequena;
        private Double valorfamilia;

        public Pizza()
        {

        }

        public Pizza(String Tipo, String Sabor, String Composicao, bool permiteBorda, String bordas, Double valorpequena, Double valorfamilia)
        {
            this.Tipo = Tipo;
            this.Sabor = Sabor;
            this.Composicao = Composicao;
            this.permiteBorda = permiteBorda;
            this.bordas = bordas;
            this.valorpequena = valorpequena;
            this.valorfamilia = valorfamilia;

        }

        public void setTipo(String Tipo)
        {
            this.Tipo = Tipo;
        }

        public String getTipo()
        {
            return this.Tipo;
        }

        public void setSabor(String Sabor)
        {
            this.Sabor = Sabor;
        }

        public String getSabor()
        {
            return this.Sabor;
        }

        public void setComposicao(string Composicao)
        {
            this.Composicao = Composicao;
        }

        public String getComposicao()
        {
            return this.Composicao;
        }

        public void setPermiteBorda(bool PermiteBorda)
        {
            this.permiteBorda = PermiteBorda;
        }

        public bool getPermiteBorda()
        {
            return this.permiteBorda;
        }
            
        public void setBordas(String Bordas)
        {
            this.bordas = Bordas;
        }

        public String getBordas()
        {
            return this.bordas;
        }

        public void setValorPequena(double ValorPequena)
        {
            this.valorpequena = ValorPequena;
        }

        public double getValorPequena()
        {
            return this.valorpequena;
        }

        public void setValorFamilia(double ValorFamilia)
        {
            this.valorfamilia = ValorFamilia;
        }

        public double getValorFamilia()
        {
            return this.valorfamilia;
        }

    }
}
//bool == Boolean
// tradução de get é pegar