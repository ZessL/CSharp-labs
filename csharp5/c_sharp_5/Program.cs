using System;

namespace c_sharp_5
{
   class Program
   {
      delegate void MYdelegate();
      static void Main(string[] args)
      {
         Console.OutputEncoding = System.Text.Encoding.Default;

         Ship korabl = new Ship("Аляска", 13200, 345, 128900);
         Steamboat korabl1 = new Steamboat("Аркхем", 9700, 295, 98800, 5);
         Sailing_ship korabl2 = new Sailing_ship("Чёрная жемчужина", 5000, 320, 72500, 1857);
         Corvette korabl3 = new Corvette("Перемога", 13300, 245, 123000, 31);
         MYdelegate mydelegate;
         mydelegate = korabl.PrintDate;
         mydelegate += korabl1.PrintDate;
         mydelegate += korabl1.prinCylinders;
         mydelegate += korabl2.PrintDate;
         mydelegate += korabl2.printArea_sail;
         mydelegate += korabl3.PrintDate;
         mydelegate += korabl3.print_speed;
         mydelegate();
      }

      interface IShip
      {
         uint Weight { get; set; }
         uint Load_capacity { get; set; }
         uint Length { get; set; }

      }

      class Ship : IShip
      {
         private String name;
         private uint weight;
         private uint length;
         private uint load_capacity;

         public Ship(string name, uint weight, uint length, uint load_capacity)
         {
            this.name = name;
            this.weight = weight;
            this.length = length;
            this.load_capacity = load_capacity;
         }

         public uint Weight { get => weight; set => weight = value; }
         public uint Length { get => length; set => length = value; }
         public uint Load_capacity { get => load_capacity; set => load_capacity = value; }
         public string Name { get => name; set => name = value; }

         /*
         uint IShip.getload_capacity()
         {
            return Load_capacity;
         }

         uint IShip.getweight()
         {
            return Weight;
         }

         uint IShip.getlength()
         {
            return Length;
         }

      */

         public void PrintDate()
         {
            Console.WriteLine("\nНазва судна:\t" + this.name +"\nМаса:\t" + this.Weight + " т\nДовжина:\t" + this.Length + "м\nВантажопідйомність:\t" + this.Load_capacity + "т");
         }
      }

      class Steamboat : Ship
      {
         uint kol_cylinders;
         public Steamboat(string name, uint weight, uint lenght, uint load_capacity, uint cylinders)
            : base(name, weight, lenght, load_capacity)
         {
            this.kol_cylinders = cylinders;
         }

         public void prinCylinders()
         {
            Console.WriteLine("Кількість циліндрів:\t" + this.kol_cylinders);
         }
      }

      class Sailing_ship : Ship
      {
         uint area_sail;
         public Sailing_ship(string name, uint weight, uint lenght, uint load_capacity, uint sail)
            : base(name, weight, lenght, load_capacity)
         {
            this.Area_sail = sail;
         }

         public uint Area_sail { get => area_sail; set => area_sail = value; }

         public void printArea_sail()
         {
            Console.WriteLine("Площа вітрил:\t" + this.Area_sail);
         }
      }

      class Corvette : Ship
      {
         uint speed;
         public Corvette(string name, uint weight, uint lenght, uint load_capacity, uint speed)
            : base(name, weight, lenght, load_capacity)
         {
            this.Speed = speed;
         }

         public uint Speed { get => speed; set => speed = value; }

         public void print_speed()
         {
            Console.WriteLine("Швидкість корверта:\t" + this.Speed + " вузлів");
         }
      }
   }
}
