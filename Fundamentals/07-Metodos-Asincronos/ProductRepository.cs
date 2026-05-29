using CsBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        //Obtener datois de una BD, Api externa, archivo, etc..
        WriteLine("Buscando producto...");
        await Task.Delay(2000);
        return new Product("Producto simulado", 500);
    }
}
