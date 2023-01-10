using ConsoleApp1.Factory.Resturents;
using design_patterns.Behavioral.Chain_of_Responsibility;
using design_patterns.Behavioral.Chain_of_Responsibility.Handlers;
using design_patterns.Builder;
using design_patterns.Prototype;

/* 
 * Factory (Creational)
 */

// Resturant beefResturant = new BeefBurgerResturent();
// beefResturant.OrderBurger();

//Resturant chickenResturent = new ChickenBurgerResturent();
//chickenResturent.OrderBurger();


/*
 * Builder (Creational)
 */

//CarBuilder carBuilder = new CarBuilder();
//carBuilder.Id(0);
//carBuilder.Name("HamZa Car");
//carBuilder.Model("BMW");
//carBuilder.Color("Red");
//Car car = carBuilder.Build();
//car.PrintInfo();


//CarBuilder bmwCarBuilder = new CarBuilder();
//Director director = new Director();
//director.BuildBMW(bmwCarBuilder);
//Car bmw = bmwCarBuilder.Build();
//bmw.PrintInfo();


/*
 * Prototype (Creational)
 */

//Bus b1 = new Bus();
//b1.brand = "BMW";
//b1.color = "Red";

//Bus b2 = (Bus) b1.Clone();
//b2.color = "blue";

//Console.WriteLine("b1 Id: " + b1.GetId());
//Console.WriteLine("b2 Id: " + b2.GetId());
//Console.WriteLine("b1 Color: " + b1.color);
//Console.WriteLine("b2 Color: " + b2.color);


/*
 * Chain of Responsibility (Behavioral)
 */

// Database db = new Database();
// Handler handler = new UserExistsHandler(db);
// handler.SetNextHandler(new ValidatePasswordHandler(db))
//     .SetNextHandler(new CheckRoleHandler(db));

// UserExistsHandler -> ValidatePasswordHandler -> CheckRoleHandler -> null

// AuthService service = new AuthService(handler);
// // service.Login("admin", "admin");
// // service.Login("user", "user");


Console.ReadLine();