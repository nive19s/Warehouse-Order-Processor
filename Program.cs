
// Hardcoded Inventory (SKU, Name, UnitPrice, Stock)
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
public static void main (String[] args) {

    Array Inventory = [(A100, 'WirelessMouse', 25.00, 50),
                    (B200, 'USB - C Cable', 8.50, 12),
                    (C300. 'LaptopStand', 40.00, 3),
                    (D400, 'MechanicalKeyboard', 60.00, 0)
                        ];


    //  function for get Customer order and output the OrderID, OrderStatus, StockAvailability.


    // Main function for get user order input in the order of OrderID, OrderStatus, StockAvailability,
    // after check the user input with the inventory 

    // Order Logic (OrderID - int,SKU-int ,Quantity- int)

    // Output
    var Order = Console.ReadLine();
    Console.WriteLine(Order_Status());
        //Console.WriteLine("Hello, World!");
}

