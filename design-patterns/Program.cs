using ConsoleApp1.Factory.Resturents;
using design_patterns.Behavioral.Chain_of_Responsibility;
using design_patterns.Behavioral.Chain_of_Responsibility.Handlers;
using design_patterns.Behavioral.Command.Example1;
using design_patterns.Behavioral.Command.Example2;
using design_patterns.Behavioral.Memento;
using design_patterns.Behavioral.Observer;
using design_patterns.Builder;

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


/*
 * Command (Behavioral)
 */

// Example 1
//RemoteControl remote = new RemoteControl(); 
//Television tv = new Television();

//remote.AddCommand(new TurnOnTelevision(tv));
//remote.AddCommand(new TurnOffTelevision(tv));

//remote.OnButtonPressed(0);
//remote.OnButtonPressed(1);


// Example 2
// Calculator calc = new Calculator();
// calc.ExcuteCommand(new AddCommand(10));
// Console.WriteLine(calc.value);
// calc.UndoCommand();
// Console.WriteLine(calc.value);


/*
 * Memento (Behavioural)
 */

//Editor editor = new Editor();

//editor.Write("H");
//editor.Write("Ha");
//editor.Write("Ham");
//editor.Write("HamZ");
//editor.Write("HamZa");

//Console.WriteLine("Current Text: " + editor.textarea.Text);

//editor.Undo();
//Console.WriteLine("Undo #1 Text: " + editor.textarea.Text);

//editor.Undo();
//Console.WriteLine("Undo #2 Text: " + editor.textarea.Text);

//editor.Redo();
//Console.WriteLine("Redo #1 Text: " + editor.textarea.Text);


/*
 * Observer (Behavioral)
 */

var service = new Store().GetNotificationService();
service.Subscribe(new EmailListener("Customer #1"));
service.Subscribe(new EmailListener("Customer #2"));
service.notify();





Console.ReadLine();