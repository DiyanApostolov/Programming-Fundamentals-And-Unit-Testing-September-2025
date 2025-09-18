
//"banana", "apple", "kiwi", "cherry" or "lemon" -> fruits
//"cucumber", "pepper" or "carrot" -> vegetables

string product = Console.ReadLine();

if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon")
{
    Console.WriteLine("fruit");
}
else if (product == "cucumber" || product == "pepper" || product == "carrot")
{
    Console.WriteLine("vegetable");
}
else
{
    Console.WriteLine("unknown");
}

// решение със switch конструкция:

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
        Console.WriteLine("fruit");
        break;
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknown");
        break;

}

