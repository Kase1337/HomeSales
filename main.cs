using System;

class Program {
  
    static void Main(string[] args)
    {
         bool tie = false;
        string initial; // Initialize initials array for each salesperson
        double[] salestotals = new double[3]; // 3 salespersons
        double saleamount; // Amount of sale
        double grandtotal = 0; // Initialize grand total variable
        int salespersonIndex;  // Initialize sales person index 0 - 2; 
        int highestsaleIndex = -1; // Initialize to -1 to indicate that there is no salesperson has the current highest sale

        
       while (true) // Loop until user chooses to exit
         {
            Console.Write("Please type salesperson initial or Press Z to quit: ");
            initial = Console.ReadLine().ToUpper(); // Convert input to uppercase

            if (initial == "Z")
                break;

            
            if (initial == "D")
                salespersonIndex = 0;
            else if (initial == "E")
                salespersonIndex = 1;
            else if (initial == "F")
                salespersonIndex = 2;
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again");
                continue; // Skip to next iteration of loop
             }

            Console.Write("sale: "); // Prompt for sale amount

           saleamount = double.Parse(Console.ReadLine());
            
            
/////////////////////////////Compare Logic:///////////////////////////////////////

            // Add sale amount to grand total
            salestotals[salespersonIndex] += saleamount;
            grandtotal += saleamount;
            
            // Update highest sale index
            if (salestotals[salespersonIndex] > (highestsaleIndex == -1 ? 0 : salestotals[highestsaleIndex])) highestsaleIndex = salespersonIndex; 
        }

        // Determine if there is a tie in entered sale amounts.
       
         for (int i = 0; i < salestotals.Length; i++)
        {
            if (i != highestsaleIndex && salestotals[i] == salestotals[highestsaleIndex])
            {
                tie = true;
                break;
             }
        }


///////////////////////////////End of Logic://///////////////////////////////
        
        // Print out sales totals for each salesperson
       Console.WriteLine($"\nGrand Total: ${grandtotal.ToString("N0")}");


        // Print out highest salesperson or indicate that there is a tie and no highest salesperson can be named.
        if (tie)
        {
            Console.WriteLine("Highest Sale: Unknown (TIE)"); // Print out highest salesperson or indicate that there is a tie and no highest salesperson can be named.
        }
        
        else
         {
      
        string highestSalesPerson = highestsaleIndex == -1 ? "None" : "DEF"[highestsaleIndex].ToString(); // Convert highestsaleIndex to string
            Console.WriteLine("Highest Sale: " + highestSalesPerson); // Print out highest salesperson
    
    }
 }
}