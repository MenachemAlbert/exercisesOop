using exrsizeOop;

Person person = new Person();

person.SetAge(1);

Console.WriteLine(person.GetAge());

Dog dog = new Dog();

Console.WriteLine(dog.species());

MathOperations mathOperations = new MathOperations(5 , 5);

Console.WriteLine(mathOperations.useInCalculator());