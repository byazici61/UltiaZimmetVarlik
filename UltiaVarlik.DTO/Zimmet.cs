﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Zimmet
    {
        public int ZimmetID { get; set; }
        public Varlik Varlik { get; set; }
        public ZimmetNedeni ZimmetNedeni { get; set; }
        public ZimmetTuru ZimmetTuru { get; set; }
        public string  Aciklama { get; set; }
    }
}