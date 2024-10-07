using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Practice16
{
    [Serializable()]
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID{ get; set; }

        public Animal(){ }

        public Animal(string name="No name",
            double weight = 0,
            double height = 0,
            int animalID = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
            AnimalID = animalID;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} kilos and is {2} cm tall.",
                Name, Weight, Height);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name);
            info.AddValue("weight", Weight);
            info.AddValue("height", Height);
            info.AddValue("animalID", AnimalID);
        }

        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("name", typeof(string));
            Weight = (double)info.GetValue("weight", typeof(double));
            Height = (double)info.GetValue("height", typeof(double));
            AnimalID = (int)info.GetValue("animalID", typeof(int));
        }
    }
}
