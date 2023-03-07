using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6
{
    public class Car
    {
        //attriburs (varibles)
        int id;
        int speed;
        string name;

        //automtic proprety
        public int Speed { get; set; }
        public int Id { get; set; }

        //full prorety
        public string Name { 
            get {
                return name;
            } 
            set { 
                name = value;
            } 
        }
        
        //if no user defind constrouctor ,compiler will genrat empty paramters constrouctor

        //empty paramter constroctor
        public Car() { }

        //user defind constrouctor
        public Car(int _id,int _speed, string _name)
        {
            id = _id;
            speed = _speed;
            name = _name;
        }

        //constrocrtor refer to public Car(int _id,int _speed, string _name)
        public Car(int _id,int _speed):this(_id, _speed,"basel") { }
        
    }
}
