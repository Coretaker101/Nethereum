﻿using System.Collections.Generic;
using System.Numerics;

namespace Nethereum.RPC.Chain
{
    public class ChainFeature
    {
        public BigInteger ChainId { get; set; }
        public bool SupportEIP1559 { get; set; } = true;
        public bool SupportEIP155 { get; set; } = true;
        public NativeCurrency NativeCurrency { get; set; } = new NativeCurrency();
        public string ChainName { get; set; }
        public List<string> HttpRpcs { get; set; } = new List<string>();
        public List<string> WsRpcs { get; set; } = new List<string>();
        public List<string> Explorers { get; set; } = new List<string>();
    }

    public class NativeCurrency
    {
        public string Name { get; set; }
        public string Symbol { get; set; } 
        public int Decimals { get; set; }
    }

}
