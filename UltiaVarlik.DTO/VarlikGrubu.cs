﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class VarlikGrubu : AnaDTO
    {
        public int VarlikGrubuID { get; set; }
        public string VarlikGrubuAdi { get; set; }

        public override string ToString()
        {
            return VarlikGrubuAdi;
        }
    }
}
