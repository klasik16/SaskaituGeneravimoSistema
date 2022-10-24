using SaskaituGeneravimoSistema.Model;
using SaskaituGeneravimoSistema.Repository;
using System.Collections.Generic;

BillRepository BillRepo = new BillRepository();
ItemRepository ItemRepo = new ItemRepository();

while (true)
{
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("| Pasirinkite norimą veiksmą:     |");
    Console.WriteLine("| 1 - Peržiurėti visas sąskaitas  |");
    Console.WriteLine("| 2 - Peržiurėti sąskaitą         |");
    Console.WriteLine("| ENTER - Išvalyti                |");
    Console.WriteLine("| X - Išjungti Programą           |");
    Console.WriteLine("-----------------------------------");

    string command = Console.ReadLine();

    switch (command)
    {
        case "1":
            GetAllBill(BillRepo, ItemRepo);
            break;
        case "2":
            GetBillX(BillRepo, ItemRepo);
            break;
        case "x":
            return;
        default:
            Console.Clear();
            break;
    }
}

static void GetAllBill(BillRepository billRepo, ItemRepository itemRepo)
{
    decimal allBilsTotalPrice = 0;

    foreach (Bill bill in billRepo.Bills)
    {
        Console.WriteLine("Bill ID:" + bill.Id);
        bill.TotalPrice = 0;
        for (int i = 0; i < bill.Item.Count; i++)
        {
            Console.WriteLine(itemRepo.Items[bill.Item[i]].Name + " " + itemRepo.Items[bill.Item[i]].Price);
            bill.TotalPrice = bill.TotalPrice + itemRepo.Items[bill.Item[i]].Price;
        }

        Console.WriteLine("Total Price: " + bill.TotalPrice);
        allBilsTotalPrice = allBilsTotalPrice + bill.TotalPrice;
    }
    Console.WriteLine("All Bills Total Price: " + allBilsTotalPrice);

    
}

static void GetBillX(BillRepository billRepo, ItemRepository itemRepo)
{
    Console.WriteLine("Pasirinkite Saskaitą (ID):");

    if (int.TryParse(Console.ReadLine(), out int billId))
    {
        if (billId <= billRepo.Bills.Count)
        {
            var bill = billRepo.Bills[billId - 1];

            Console.WriteLine("Bill ID:" + bill.Id);
            bill.TotalPrice = 0;
            for (int i = 0; i < bill.Item.Count; i++)
            {
                Console.WriteLine(itemRepo.Items[bill.Item[i]].Name + " " + itemRepo.Items[bill.Item[i]].Price);
                bill.TotalPrice = bill.TotalPrice + itemRepo.Items[bill.Item[i]].Price;
            }

            Console.WriteLine("Total Price: " + bill.TotalPrice);


        }
        else
        {
            Console.Clear();
            Console.WriteLine("Tokios saskaitos nerasta");
        }
    }
    else {
        Console.Clear();
        Console.WriteLine("Tokios saskaitos nerasta"); }
}

