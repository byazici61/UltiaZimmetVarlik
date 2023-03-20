﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltiaVarlik.DTO
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelSifresi { get; set; }
        public string EMail { get; set; }
        public Personel YoneticiID { get; set; }
        public Rol Rol { get; set; }
        public SirketEkip SirketEkip { get; set; }
    }
}