using GarbageCollection;

Play play = new Play("A Midsummer Night's Dream", "William Shakespeare", "Comedy", 1595); //Task 1

Shop shop =  new Shop("Apricot", "Velyka Arnautskaya Street, 33", ShopType.Food);//Task 2
shop.Dispose();

using (Play play1 = new Play("A Midsummer Night's Dream", "William Shakespeare", "Comedy", 1595)) //Task 3
{
    Console.WriteLine($"\"{play1.Title}\"");
    Console.WriteLine(play1.AuthorsFullName);
    Console.WriteLine(play1.Genre);
    Console.WriteLine(play1.ReleaseYear);
}

Console.WriteLine();

using (var shop1 = new Shop("Apricot", "Velyka Arnautskaya Street, 33", ShopType.Food))
{
    Console.WriteLine(shop1.Name);
    Console.WriteLine($"Address: {shop1.Address}");
    Console.WriteLine($"{shop1.Type} shop");
}


