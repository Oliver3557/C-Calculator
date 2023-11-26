using Calculator;

//Declaration Area
int selectedAction;
bool keepGoing = true;
char y;

BasicCalculations calculations = new BasicCalculations();
while (keepGoing)
{
//Calculator Main Body
Console.WriteLine("Pick an option below:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtract");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");
Console.WriteLine("5. Advanced Options");
Console.WriteLine("\n6. Exit\n");

selectedAction = int.Parse(Console.ReadLine());

//Activate Calculator based on user input

    switch (selectedAction)
    {
        case 1:
            calculations.Addition();
            break;

        case 2:
            calculations.Subtract();
            break;

        case 3:
            calculations.Multiply();
            break;

        case 4:
            calculations.Divide();
            break;

        case 5:
            Advanced();
            break;

        case 6:
            keepGoing = false;
            break;

        default:
            Console.Write("Invalid Input, Exiting");
            break;
    }
}
//Advanced Options
void Advanced()
{
    Console.WriteLine("\nPick an option below:");
    Console.WriteLine("1. Squared");
    Console.WriteLine("2. Square Root");
    Console.WriteLine("\n3. Back");
    Console.WriteLine("4. Exit\n");

    selectedAction = int.Parse(Console.ReadLine());

    switch (selectedAction)
    {
        case 1:
            calculations.Square();
            break;

        case 2:
            calculations.SquareRoot();
            break;

        case 3:
            break;

        case 4:
            keepGoing = false;
            break;

        default:
            Console.Write("Invalid Input, Exiting");
            break;
    }
}
