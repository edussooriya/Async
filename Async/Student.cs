using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Student:Person,IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }


        public Student(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public double Diposit(double amount)
        {
            this.Balance = this.Balance + amount;
            return this.Balance;
        }

        public void Widthdraw(int amount)
        {
            if (this.Balance > 0 && this.Balance > amount)
            {
                this.Balance = this.Balance - amount;
            }
            else
            {
                throw new Exception("you can not perform this transaction");
            }
            //return this.Balance;
        }


        public override int Calculate()
        {
            return base.Calculate();
        }


        public override 

        ~Student()
        {

            System.Diagnostics.Trace.WriteLine("Calling Destructer...");
        }
        
    }
}
