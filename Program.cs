// See https://aka.ms/new-console-template for more information
var drink1 = "sprite";
var drink2 = "water";
var buffetPrice = 9.99; // per person
var priceSprite = 2.00;
var countSprite = 0;
var countWater = 0;
var countInput = 0;

// ask for party size
Console.WriteLine($"Welcome to our Buffet. All you can eat for ${buffetPrice}! We only charge extra for {drink1}.\nHow many people are in your group? Please, parties of 6 or lower.");
int input = int.Parse(Console.ReadLine());

if (input <= 6 && input >= 1)
{
    // ask for drinks
    Console.WriteLine($"\nA table for {input}! Please follow me!\nLet's get everyone started with some drinks. We've got {drink1} and {drink2}\n");

    while (countInput < input)
    {
        countInput += 1;
        Console.WriteLine($"Alright, Person {countInput}, {drink1} or {drink2}?");
        var drinkInput = Console.ReadLine();
        var person = drinkInput.ToLower();

        // Keeping track of member's drink orders | How many times each drink was ordered
        if (person == drink1)
        {
            countSprite += 1;
            Console.WriteLine($"Alright, {drink1}!\n");
        }
        else if (person == drink2)
        {
            countWater += 1;
            Console.WriteLine($"{drink2}, good choice!\n");
        }
        else
        {
            Console.WriteLine($"I'm sorry Person {countInput}, we don't have {person}\n");
            continue;
        }
    }
    // to Plural
    if (countSprite > 1 && countWater > 1)
    {
        drink1 = "sprites";
        drink2 = "waters";
    }
    else if (countSprite > 1)
    {
        drink1 = "sprites";
    }
    else if (countWater > 1)
    {
        drink2 = "waters";
    }
    var totalBuffetPrice = buffetPrice * countInput;
    var totalpriceSprite = priceSprite * countSprite;
    var totalPrice = totalBuffetPrice + totalpriceSprite;
    Console.WriteLine($"Ok, so we got {countSprite} {drink1} and {countWater} {drink2}. I'll be right back.  Feel free to grab your food!\n");
    Console.WriteLine($"Here is your bill! Total price: ${totalPrice}");
}
else
{
    Console.WriteLine("I'm sorry, we can only seat parties of up to 6 people. Have a nice day.");
}