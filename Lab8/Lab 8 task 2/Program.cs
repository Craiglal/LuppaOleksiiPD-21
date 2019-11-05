using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskTel diskTel = new DiskTel();
            diskTel.Call();
            ButtomPhone buttomPhone = new ButtomPhone();
            buttomPhone.Call();
            PhoneBlackWhiteScreen phoneBlackWhiteScreen = new PhoneBlackWhiteScreen();
            phoneBlackWhiteScreen.Call();
            PhoneColorScreen phoneColorScreen = new PhoneColorScreen();
            phoneColorScreen.Call();
            IPhone iPhone = new IPhone();
            iPhone.Call();
            GoogleGlass googleGlass = new GoogleGlass();
            googleGlass.Call();

            Console.ReadKey();
        }
    }
}
