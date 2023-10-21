using System;

class Program
{
    static void Main(string[] args)
    {
        // Products
        Product prdct1 = new Product("Soap", 132431, 20.56, 7);
        Product prdct2 = new Product("Contact Lens", 102938, 31.99, 3);
        Product prdct3 = new Product("Pillow", 564738, 19.99, 2);

        // Addres and Costumer
        Address adrs1 = new Address("5692 NEWBURY STREET","ARCATA", "CALIFORNIA", "USA");
        Costumer ctmr1 = new Costumer("Baki Hanma", adrs1);
        
        // Order
        Order rdr1 = new Order(ctmr1);

        // Add products to the Order List<Product> _products list.
        rdr1.SetProducts(prdct1);
        rdr1.SetProducts(prdct2);
        rdr1.SetProducts(prdct3);

        Console.WriteLine($"--- Packing Label --- \n");
        rdr1.PackingLabel();

        Console.WriteLine($"--- Shipping Label --- \n");
        rdr1.ShippingLabel();

        double orderCost = rdr1.CalculateOrderCost();
        Console.WriteLine($"Total price of the order: \n${orderCost}\n");
        Console.WriteLine("____________________________________________________________");

        // ----------------------------------------------------------------
        // Products
        Product prdct2_1 = new Product("Mega Sword", 194673, 399.99, 1);
        Product prdct2_2 = new Product("Headphones Super-iper-duper-mega Pros", 794613, 79.99, 1);
        Product prdct2_3 = new Product("Hair Rubber Band", 659832, 3.50, 25);

        // Addres and Costumer
        Address adrs2 = new Address("9635 DOLIVAN","SHIBUYA", "TOKYO", "JAPAN");
        Costumer ctmr2 = new Costumer("Suguru Geto", adrs2);
        
        // Order
        Order rdr2 = new Order(ctmr2);

        // Add products to the Order List<Product> _products list.
        rdr2.SetProducts(prdct2_1);
        rdr2.SetProducts(prdct2_2);
        rdr2.SetProducts(prdct2_3);

        Console.WriteLine($"--- Packing Label --- \n");
        rdr2.PackingLabel();

        Console.WriteLine($"--- Shipping Label --- \n");
        rdr2.ShippingLabel();

        double orderCost2 = rdr2.CalculateOrderCost();
        Console.WriteLine($"Total price of the order: \n${orderCost2}\n");
        Console.WriteLine("____________________________________________________________");

        // ----------------------------------------------------------------
        // Products
        Product prdct3_1 = new Product("Dungeons Dungeons And More Dungeons", 123456, 30.00, 1);
        Product prdct3_2 = new Product("Wax Larry King", 192855, 59.99, 1);
        Product prdct3_3 = new Product("Blue-White Pine Hat", 936582, 3.99, 1);

        // Addres and Costumer
        Address adrs3 = new Address("618 GOPHER ROAD","GRAVITY FALL", "OREGON", "USA");
        Costumer ctmr3 = new Costumer("Duck-Tective", adrs3);
        
        // Order
        Order rdr3 = new Order(ctmr3);

        // Add products to the Order List<Product> _products list.
        rdr3.SetProducts(prdct3_1);
        rdr3.SetProducts(prdct3_2);
        rdr3.SetProducts(prdct3_3);

        Console.WriteLine($"--- Packing Label --- \n");
        rdr3.PackingLabel();

        Console.WriteLine($"--- Shipping Label --- \n");
        rdr3.ShippingLabel();

        double orderCost3 = rdr3.CalculateOrderCost();
        Console.WriteLine($"Total price of the order: \n${orderCost3}\n");
        Console.WriteLine("____________________________________________________________");
    }
}