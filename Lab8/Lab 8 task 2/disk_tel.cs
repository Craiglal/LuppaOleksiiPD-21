using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class DiskTel
    {
        public string InputDevice { get; protected set; }
        public virtual void Call()
        {
            Console.WriteLine("Call you from Disk tell!");
        }

    }

    class ButtomPhone : DiskTel
    {
        public override void Call()
        {
            Console.WriteLine("Call you from phone with button!");
        }

        public int Antena { get; protected set; }
    }

    class PhoneBlackWhiteScreen : ButtomPhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from phone with BW screen!");
        }
        public int Screen { get; protected set; }
    }

    class PhoneColorScreen : PhoneBlackWhiteScreen
    {
        public override void Call()
        {
            Console.WriteLine("Call you from phone with color screen!");
        }
        public int WiFi { get; protected set; }
    }

    class IPhone : PhoneColorScreen
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Iphone!");
        }
        public string Apple { get; protected set; }
    }

    class GoogleGlass: IPhone
    {
        public override void Call()
        {
            Console.WriteLine("Call you from Google Glass!");
        }
        public int Glass { get; protected set; }
    }

}
