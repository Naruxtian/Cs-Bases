
using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        WriteLine("Hello, World!");

        //Declaración explicita
        int quantity = 5;
        string message = "Hello, World!";
        decimal price = 19.99m;
        WriteLine($"Quantity: {quantity}, Message: {message}, Price: {price:C}");

        //Declaración implícita
        var grettings = "Hola";
        var porcentage = 20.00m;
        WriteLine($"Grettings: {grettings}, Porcentage: {porcentage}%");
        
        var Laptop = new Product("Laptop", 1200);
        WriteLine(Laptop.GetDescription());

        var Soporte = new ServiceProduct("Soporte técnico", 300, 30);
        WriteLine(Soporte.GetDescription());



    }
}