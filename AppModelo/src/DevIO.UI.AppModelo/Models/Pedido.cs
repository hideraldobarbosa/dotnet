﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Pedido()
        {
            Id = Guid.NewGuid();
        }
    }
}
