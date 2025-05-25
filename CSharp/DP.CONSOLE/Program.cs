// See https://aka.ms/new-console-template for more information
using DP.LIB.Creational;

Console.WriteLine("Hello, World!");
  
//Farctory Method

Car? bmw= Car.CreateCar(CarType.BMW); 
bmw?.Go();

Car? mercedes= Car.CreateCar(CarType.Mercedes ); 
mercedes?.Go();

ITruck mercedesTruck  = ITruck.CreateTruck(TruckType.Mercedes);

ITruck bmwTruck  = ITruck.CreateTruck(TruckType.BMW);

var  bmwPlain = Plane.Factory.CreatePlain(PlaneType.BMW);
bmwPlain.Go();

var  mercedesPlain = Plane.Factory.CreatePlain(PlaneType.Mercedes);
mercedesPlain.Go();
// Prototype

ComplexObject co = new ComplexObject{
  Prices= new List<int>{1,2,3},
  Names = new List<string>{"Pasta","Mangiano","Cetkica"},
  Quantities = new List<int>{2,3,4}
};  
co.Show();

var cpy=co.Clone();
cpy.Show();
//Singleton
var singleton = MyRandomNumber.Instance();
singleton.DoStuff();
//Builder
var builder1 = new PersonBuilder();
var builder=Person.Builder;
Person person = builder.CreatePerson()
  .SpecityName("Ime")
  .SpecifyAge(21)
  .BuildPerson( );


//Person persona = new Person();
