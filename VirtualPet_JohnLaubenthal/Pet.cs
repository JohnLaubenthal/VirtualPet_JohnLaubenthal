using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_JohnLaubenthal
{
    class Pet
    { //declaring fields
        private string tiredness;
        private int hunger;
        private int thirst;
        private int boredom;
        private string name;

        //declaring properties

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Boredom
        {
            get { return this.Boredom; }
            set { this.Boredom = value; }
        }
        public int Thirst
        {
            get { return this.Thirst; }
            set { this.Thirst = value; }
        }
        public int Hunger
        {
            get { return this.Hunger; }
            set { this.Hunger = value; }
        }
        public string Tiredness
        {
            get { return this.Tiredness; }
            set { this.Tiredness = value; }
        }
        public River()//change name from 'River'
        {
            //default constructor
        }
        public River(string name, int depth, int pollution)
        {
            this.Name = name;
            this.Depth = depth;
            this.Pollution = pollution;
        }



    }//class end
}//namespace end
