﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Actividad_1___Resta
{
    internal class Resta
    {
        private int num1;
        private int num2;

        public Resta(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int restar()
        {
            return (num1 - num2);

        }
    }
}
