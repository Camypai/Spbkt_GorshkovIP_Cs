using System;
using System.Collections.Generic;


namespace Spbkt_GorshkovIP_Cs.Models
{
    public class MenuItem
    {
        public byte Id          { get; set; }
        public string                  Title       { get; set; }
        public string                  Description { get; set; }
        public Method                  ItemMethod  { get; set; }

        public delegate void Method();
    }
}