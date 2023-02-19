using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp
{
    class Data
    {
        public float PricipleAmt { get; set; }
        public int totalMnth { get; set; }
        public float IoR { get; set; }

        public void ClearData()
        {
            
            PricipleAmt = 0;
            totalMnth = 0;
            IoR = 0; 
        }

    }
}
