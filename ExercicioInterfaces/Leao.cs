using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaces
{
    class Leao : IFelinos, IAnimal
    {
        public string Raca { get; set; }
        public double Altura { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void Atacar() { }
        public void Cacar() { }
        public void Correr() { }
        public void Dormir() { }
        public void Cuidar() { }
        public void Comer() { }

    }
}
