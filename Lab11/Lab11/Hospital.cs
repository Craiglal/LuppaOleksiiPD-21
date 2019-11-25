using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    
    class Hospital
    {
        public void MRT (Patien patien)
        {
            patien.MRT = true;
        }

        public void KT(Patien patien)
        {
            patien.KT = true;
        }

        public void XRAY(Patien patien)
        {
            patien.XRAY = true;
        }

        public void LOR(Patien patien)
        {
            patien.LOR = true;
        }

        public void UZI(Patien patien)
        {
            patien.UZI = true;
        }

        public void RH_Tests(Patien patien)
        {
            patien.RH_Tests = true;
        }
    }
}
