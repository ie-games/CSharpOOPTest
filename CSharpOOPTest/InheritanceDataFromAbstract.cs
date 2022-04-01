using System;

namespace CSharpOOPTest
{
    public class InheritanceDataFromAbstract : OriginData
    {
        public float  PosX ,PosY,PosZ; 
        public float  RotationX,RotationY,RotationZ;

        public override void DataChange()
        {
           name = "";
           Width = 0;
           Height = 0;
           AmountofSides = 0; 
        }
        public override void Edit()
        {
            // assign XYZ Position/Rotation values
            Position = new float [3] {PosX,PosY,PosZ};
            Rotation = new float[3] {RotationX,RotationY,RotationZ};
            Scale = 0;
        }
        public override void Output()
        {
            Edit();
            DataChange();
             
            //foreach(int Pos in Position){Console.WriteLine("Position" + Pos);}
            //foreach(int rotation in Rotation){Console.WriteLine("Rotation"+rotation);}

           // XYZpOSITION
            Console.WriteLine("Position" +"\n"+"X" +' '+ Position[0]+"\n"+ "Y" +' '+ Position[1]+"\n"+
            "Z" +' '+ Position[2]+"\n");
            // XYZ Rotation
            Console.WriteLine("Rotation" +"\n"+"X" +' '+ Rotation[0]+"\n"+ "Y" +' '+ Rotation[1]+"\n"+
            "Z" +' '+ Rotation[2]+"\n"); 
           // Scale
            Console.WriteLine("Scale is" +' '+ Scale);

            // float/string/int Data
            Console.WriteLine("Name is " +' '+ name +"\n"+ "Width is" +' '+ Width+"\n"+
            "Height is" +' '+ Height+"\n"+ "AmountofSides is" +' '+AmountofSides);

        }
    }
}