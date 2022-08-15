using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console                   //Corrected by Blake Cannon
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;      //The loop here seems to work fine.          
            else
            {
                elements.Add(val);
                return true;
            }
            
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count;i++)
            {
                if (val == elements[i]) 
                    return true;
                //else                    //Stops the if loop from running once it finds one duplicate. 
                    //return false;

            }
            return false;
        }
        public override string ToString()   //Seems to work fine. Converts all ints to string. Not sure if it's the cause of elements (b) changing though.
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()  //Not sure what this is suppose to do. Clear method would delete the two different elements in the list.
        {
            elements.Clear();
        }
        public Set union(Set rhs)
        {
            //for (int i = 0; i < rhs.elements.Count; i++)
            for (int i = 0; i < elements.Count; i++)     //Stays within the two value of the two elements already created.
            {
                //this.addElement(rhs.elements[i]);
                rhs.addElement(i);    //Adds the values to the rhs element.
            }
            return rhs;
        }
    }
}
