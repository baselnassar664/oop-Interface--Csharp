using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoNet6
{
    public class PhoneBook
    {
        int[] numbers;
        string[] names;
        int size;

        public PhoneBook(int _size)
        {
            size = _size;
            numbers = new int[size];
            names = new string[size];
        }

        public int Size{
            get {
                return size; //set value from constroctor not need to set
             }
        }

        //indexer >>special proprety
        //use indexer
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                        return numbers[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value;
                    }

                }
            }
        }
         
        //use indexer
        public string this[int index]
        {
            get { 
              return $"{index}::{names[index]}::{numbers[index]}";
            }
            
        }

        //not use indexer
        public int GetNumber(string name)
        {
            for(int i=0; i< names.Length; i++)
            {
                if (name == names[i])
                    return numbers[i];
            }

            return -1;
        }

        //not use indexer
        public void setNumber(string name,int number)
        {
          
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i]) {
                    numbers[i] = number;
                }
                       
                }
            
        }

        public void addNewNumber(string name,int number,int postion)
        {
               if(postion>=0 && postion <size) {
                numbers[postion] = number;
                names[postion] = name;
            }
        }
    }
}
