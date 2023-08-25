//JOSE ALEXANDRO V. GALLARDO - BSCpE - 2nd YEAR

Console.WriteLine("Enter your full name: ");
string MyName = Console.ReadLine();
Console.WriteLine("Enter your nickname: ");
string MyNickname = Console.ReadLine();
Console.WriteLine("Enter your age: ");
int MyAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your favorite number: ");
int FaveNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your favorite cartoon character: ");
string FaveCart = Console.ReadLine();

Console.Clear();
Console.WriteLine("Full name: ");
Console.WriteLine("");
Console.WriteLine(" " + MyName);
Console.WriteLine("");
Console.WriteLine("Nickname: ");
Console.WriteLine("");
Console.WriteLine(" " + MyNickname);
Console.WriteLine("");
Console.WriteLine("Age: ");
Console.WriteLine("");
Console.WriteLine(" " + MyAge);
Console.WriteLine("");
Console.WriteLine("Favorite Number: ");
Console.WriteLine("");
Console.WriteLine(" " + FaveNum);
Console.WriteLine("");
Console.WriteLine("Favorite cartoon character: ");
Console.WriteLine("");
Console.WriteLine(" " + FaveCart);
Console.WriteLine("");
Console.WriteLine("Hi! My full name is " + MyName + ", you can call me " + MyNickname + "! I am " + MyAge + " years old. My favorite number is " + FaveNum + " and I love " + FaveCart + "!");
