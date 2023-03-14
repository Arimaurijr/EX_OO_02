using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_OO_02
{
    internal class Estudante : Pessoa
    {
        double _nota1;
        double _nota2;
        public Estudante(string nome, string telefone, string endereco, int matricula) : base(nome, telefone, endereco)
        {
            Matricula = matricula;
        }
        public int Matricula { get; set; }

        public double GetNota1()
        {
            return this._nota1;
        }
        public double GetNota2() 
        {
            return this._nota2;
        }

        public double CalcularMedia(double _nota1, double _nota2)
        {
            double media = 0.0;
            this._nota1 = _nota1;
            this._nota2 = _nota2;

            media = (_nota1 + _nota2) / 2.0;

            return media;
        }

        public double CalcularMedia(double _nota1, int peso1, double _nota2, int peso2)
        {
            double media = 0.0;

            this._nota1 = _nota1;
            this._nota2 = _nota2;
            
            media = (_nota1 * peso1 + _nota2 * peso2) / (peso1 + peso2);

            return media;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + Matricula;
        }
    }
}
