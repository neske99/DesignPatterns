// See https://aka.ms/new-console-template for more information
using DP.LIB.Behavioral;
using DP.LIB.Creational;
using DP.LIB.Structural;
using DT.LIB.Behavioral;

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
var builder=Person.Builder;
Person person = builder.CreatePerson()
  .SpecityName("Ime")
  .SpecifyAge(21)
  .BuildPerson( );

  //Decorator
IMeal meal = new KetchupMealAddOn(new KetchupMealAddOn( new Burger())); 
Console.WriteLine(meal.ConsumeMeal());

//Composite
Triangle t = new Triangle();
t.Children.Add(new Triangle());
t.Children.Add(new Triangle());
t.Children.Add(new Triangle());
t.Display();
Console.WriteLine();
//Chain of responsibility

var sh=new StarHandler(new AmpersendHandler());
sh.Handle(RequestType.AmpersendPrint,"body!!");
sh.Handle(RequestType.StarPrint,"!!body!!");

//Memento
var ct= new Context("neki context");
var m = ct.GetMemento();
ct.DoSomething();

var ct1 = new Context("");
ct1.UpdateState(m);
ct1.DoSomething();
//Visitor
var p = new Pivo("jelen","0.25l");
var pv=new PrintVisitor();
p.Accept(pv);
//State
var email = new Email();
email.MoveToNextState();
email.MoveToNextState();
email.MoveToNextState();
email.MoveToNextState();

