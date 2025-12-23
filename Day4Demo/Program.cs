// See https://aka.ms/new-console-template for more information
using InterfaceDemoProj;

Console.WriteLine("Demo on Interfaces");
/*IAdd m1=new MathClass();
ISub m2=new MathClass();
IAll m3=new MathClass();*/

//Approach 1
Product pObj=new Product();
pObj.ProdID=101;
pObj.Name="Borosil Flask";
pObj.Price=850;
  

  //Approach 2
  //Object initializer
  Product pObj1=new Product()
  {
      ProdID=102,
        Name="Cello Pen",
  };

  //Collection Initializer
List<Product> products=new List<Product>()
{
    new Product(){ProdID=201,Name="Notebook",Price=45},
    new Product(){ProdID=202,Name="Geometry Box",Price=95},
    new Product(){ProdID=203,Name="Eraser",Price=5},
    new  Product(){ProdID=204,Name="Sharpener",Price=10},
    new Product(){ProdID=205,Name="Bag",Price=550},
    new Product(){ProdID=206,Name="Pencil",Price=3},
    
};
foreach(var item in products)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}

