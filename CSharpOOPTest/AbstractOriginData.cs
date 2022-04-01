using System;
namespace CSharpOOPTest
{
    public abstract class OriginData
    {
       protected string name;
       protected float Width;
       protected float Height;
       protected float Scale;
       protected int AmountofSides;
       protected float[] Position;
       protected float[] Rotation;

       public abstract void DataChange();
       public abstract void Edit();
       public abstract void Output();

       public string Name   // property
       {
         get { return name; }
         set { name = value; }
       }
    }
}