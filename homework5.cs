var inventotryDima = new Inventory();



var banana = new Product("banana",1,3);
var cherry = new Product("cherry", 12, 10);
var apple = new Product("apple", 4, 1);
var milk = new Product("milk", 3, 2);
inventotryDima.infoAboutProduct =new Product[] {banana,cherry,apple,milk};
inventotryDima.addInYouInventory(banana);
inventotryDima.addInYouInventory(apple);
Console.WriteLine($"price you inventory {inventotryDima.PriceInventory}:$");
inventotryDima.InfoAboutInventory(banana);
inventotryDima.InfoAboutInventory(apple);
var banana2 = inventotryDima.FindProduct("banana");





class Product
{
    
    public string nameProduct;
    public int priceProduct;
    public int countProduct;
   public Product(string nameProduct, int priceProductm, int countProduct)
    {
        this.nameProduct = nameProduct;
        this.priceProduct = priceProductm;
        this.countProduct = countProduct;
        
    }
   
   
}

class Inventory
{
    
    public Product[] infoAboutProduct= new Product[20];
    public int PriceInventory =0 ;
    public void addInYouInventory(Product product)
    {
        PriceInventory += product.priceProduct;
    }
    public Product FindProduct(string name)
    {for (int i = 0; i < infoAboutProduct.Length; i++)
            
        {
            int sumProduct = 0;
            if (infoAboutProduct[i].nameProduct==name)
            {
                return infoAboutProduct[i];
            }
        }return null;
        
    }
    public void InfoAboutInventory(Product product)
    {
        Console.WriteLine($" in you inventory:{product.nameProduct}\n his price :{product.priceProduct}$\n in quantity:{product.countProduct}");
    }


}