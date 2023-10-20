using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTV()
        { 
            if(IsOn)
            {
                Console.WriteLine("Watching the TV!");
            }
            else
            {
                Console.WriteLine("TVis switched off, switch it on first");
            }
        }

    }

}
