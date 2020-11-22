using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Press_Start
{
    class Store
    {
        //create the list of the web
        public List<Gamepad> GamepadList { get; set; }
        public List<Gamepad> ShopList { get; set; }

        public Store()
        {
            GamepadList = new List<Gamepad>();
           
        }
       
    }
}
