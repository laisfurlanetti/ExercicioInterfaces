﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaces
{
    class Carro : IMotorizado
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public bool Completo { get; set; }
        public int Ano { get; set; }
        
        public void Acelerar() { }
        public void Frear() { }
        public void TrocarMarcha() { }
        public void DestrarvarPorta() { }

    }
}
