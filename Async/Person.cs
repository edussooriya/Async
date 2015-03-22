using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //protected int PId { get; set; }
        //protected string PName { get; set; }

        public virtual int Calculate()
        {
            return 0;
        }
       
    }

    
}
