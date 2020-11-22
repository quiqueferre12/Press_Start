using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Press_Start
{
    public class Gamepad
    {
        //Atributes
        public String Id { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public String Info { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        //Constructors
        public Gamepad()
        {
            this.Id = "Introduce some";
            this.Make = "Introduce some";
            this.Model = "";
            this.Info = "";
            this.Stock = 0;
            this.Price = 0.00M;
        }
        //Parametrized Constructor
        public Gamepad(string id,string ma, string mo, string i, int st, decimal pr)
        {
            Info = id;
            Make = ma;
            Model = mo;
            Info = i;
            Stock = st;
            Price = pr;
        }
    }
}
