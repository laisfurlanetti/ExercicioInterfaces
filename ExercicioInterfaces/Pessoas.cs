using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaces
{
    class Pessoas : IAnimal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public string Sexo { get; set; }

        public void Comer() { }
        public void Correr() { }
        public void Dormir() { }
        public void Pular() { }
        public void Dancar() { }
    }
}
