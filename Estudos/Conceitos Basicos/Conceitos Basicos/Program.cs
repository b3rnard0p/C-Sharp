//Variáveis

//Declarativa
//string myString = "Bernardo";
//int myInt = 0;
//DateTime myDateTime = DateTime.Now;
//bool myBool = false;

//Automática
//var myString2 = "Bernardo";
//var myInt2 = 0;
//var myDateTime2 = DateTime.Now;
//var myBool2 = false;

//Mostrar o valor

//Console.WriteLine(myString);
//Console.ReadKey();

////Concatenação de variáveis

////Opção 1
//var myName = "Ana";
//var myAge = "50";

//Console.WriteLine(myName + myAge);
//Console.ReadKey();

////Opção 2
//var myName2 = "Ana";
//var myAge2 = $"{ myName2 } 50";

//Console.WriteLine(myAge2);
//Console.ReadKey();

//Operações com int

//var age = 50;
//var age2 = 50;

//Console.WriteLine(age + age2);
//Console.WriteLine(age - age2);
//Console.WriteLine(age * age2);
//Console.WriteLine(age / age2);
//Console.ReadKey();

//Leitura de valor

//var number = Console.ReadLine();

//Console.WriteLine(number);

//Chamando métodos

//using Conceitos_Basicos;

//var number = int.Parse(Console.ReadLine());
//var number2 = int.Parse(Console.ReadLine());
//var operate = Console.ReadLine();

//Calculator calculator = new Calculator();
//calculator.Calculate(operate, number, number2);

//Console.WriteLine(calculator.Calculate(operate, number, number2));

//Listas

//List<string> list = new List<string>();
//list.Add("name 1");
//list.Add("name 2");
//list.Add("name 3");
//Console.WriteLine(list[1]);

//Mostrando pelo looping
//using Conceitos_Basicos;

//List<string> list = new List<string>();
//list.Add("name 1");
//list.Add("name 2");
//list.Add("name 3");

//Notifications notifications = new Notifications();
//notifications.SendNottifications(list);

//Usando uma classe sem construtor

//using Conceitos_Basicos;

//Customer customerx =  new Customer();
//customerx.Name = "Bernardo";
//customerx.Address = "Rua x";
//customerx.Birthday = DateTime.Now;

//Console.WriteLine(customerx.Name);

//Customer customery = new Customer();
//customery.Name = "Ana";
//customery.Address = "Rua y";
//customery.Birthday = DateTime.Now;
//Console.WriteLine(customery.Name);

//Usando uma classe com construtor
//using Conceitos_Basicos;

//Customer customerx = new Customer("Bernardo", "Rua x", DateTime.Now);

//Console.WriteLine(customerx.Name);

//Customer customery = new Customer("Ana", "Rua y", DateTime.Now);

//Console.WriteLine(customery.Name);

//Usando o método
//using Conceitos_Basicos;

//Customer customerx = new Customer("Bernardo", "Rua x", DateTime.Now);
//customerx.SendWelcomeKit();

//Usando a herança
//using Conceitos_Basicos;

//Customer customerx = new CustomerStore("Bernardo", "Rua x", DateTime.Now);

//customerx.SendWelcomeKit();

//Customer customery = new CustomerOnline("Ana", "Rua y", DateTime.Now);

//customery.SendWelcomeKit();

//Usando Métodos e Classes estáticos
using Conceitos_Basicos;

Console.WriteLine(Calculator.Calculate("+", 10, 10));
