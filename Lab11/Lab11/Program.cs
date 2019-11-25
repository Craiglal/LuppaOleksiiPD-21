using System;

namespace Lab11
{
    class Program
    {
        public delegate void MyDelegate(Patien patien);
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            Patien patien = new Patien();

            MyDelegate allAnalis = null;
            MyDelegate mrt = new MyDelegate(hospital.MRT);
            allAnalis += mrt;
            MyDelegate kt = new MyDelegate(hospital.KT);
            allAnalis += kt;
            MyDelegate lor = new MyDelegate(hospital.LOR);
            allAnalis += lor;
            MyDelegate xray = new MyDelegate(hospital.XRAY);
            allAnalis += xray;
            MyDelegate uzi = new MyDelegate(hospital.UZI);
            allAnalis += uzi;
            MyDelegate rh_test = new MyDelegate(hospital.RH_Tests);
            allAnalis += rh_test;

            allAnalis.Invoke(patien);

            patien.info();
        }
    }
}
