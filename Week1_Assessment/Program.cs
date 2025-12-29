using System;
public class PatientBill
{
    public string BillId { get; set; }
    public string PatientName { get; set; }
    public bool HasInsurance { get; set; }

    public decimal ConsultationFee { get; set; }
    public decimal LabCharges { get; set; }
    public decimal MedicineCharges { get; set; }

    public decimal GrossAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal FinalPayable { get; set; }
}
public class BillingService
{
    public static PatientBill LastBill;
    public static bool HasLastBill = false;

    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bill.BillId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        string insuranceInput = Console.ReadLine();

        if (insuranceInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
            bill.HasInsurance = true;
        else if (insuranceInput.Equals("N", StringComparison.OrdinalIgnoreCase))
            bill.HasInsurance = false;
        else
        {
            Console.WriteLine("Invalid insurance option.");
            return;
        }

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal consultationFee) || consultationFee <= 0)
        {
            Console.WriteLine("Consultation fee must be greater than 0.");
            return;
        }
        bill.ConsultationFee = consultationFee;

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal labCharges) || labCharges < 0)
        {
            Console.WriteLine("Lab charges cannot be negative.");
            return;
        }
        bill.LabCharges = labCharges;

        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal medicineCharges) || medicineCharges < 0)
        {
            Console.WriteLine("Medicine charges cannot be negative.");
            return;
        }
        bill.MedicineCharges = medicineCharges;

        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance){
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        }
        else{
            bill.DiscountAmount = 0;
        }

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("Bill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
    }

    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No Bill Available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("---------------- Last Bill ----------------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
        Console.WriteLine("--------------------------------------");
    }

    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("======================== MediSure Clinic Billing ===========================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------------------");

            switch (choice)
            {
                case "1":
                    BillingService.CreateNewBill();
                    break;

                case "2":
                    BillingService.ViewLastBill();
                    break;

                case "3":
                    BillingService.ClearLastBill();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid menu option. Please try again.");
                    break;
            }
        }
    }
}


//------------------------------------------

// using System;

// public class SaleTransaction
// {
    
//     public string InvoiceNo { get; set; }
//     public string CustomerName { get; set; }
//     public string ItemName { get; set; }
//     public int Quantity { get; set; }
//     public decimal PurchaseAmount { get; set; }
//     public decimal SellingAmount { get; set; }

//     public string ProfitOrLossStatus { get; set; }
//     public decimal ProfitOrLossAmount { get; set; }
//     public decimal ProfitMarginPercent { get; set; }
// }

// public class TransactionService
// {
//     public static SaleTransaction LastTransaction;
//     public static bool HasLastTransaction = false;

//     public static void CreateNewTransaction()
//     {
//         SaleTransaction transaction = new SaleTransaction();

//         Console.Write("Enter Invoice No: ");
//         transaction.InvoiceNo = Console.ReadLine();
        
//         if (string.IsNullOrWhiteSpace(transaction.InvoiceNo))
//         {
//             Console.WriteLine("Invoice number cannot be empty.");
//             return;
//         }

//         Console.Write("Enter Customer Name: ");
//         transaction.CustomerName = Console.ReadLine();

//         Console.Write("Enter Item Name: ");
//         transaction.ItemName = Console.ReadLine();

//         Console.Write("Enter Quantity: ");
//         if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
//         {
//             Console.WriteLine("Quantity must be greater than 0.");
//             return;
//         }
//         transaction.Quantity = quantity;

//         Console.Write("Enter Purchase Amount (total): ");
//         if (!decimal.TryParse(Console.ReadLine(), out decimal purchaseAmount) || purchaseAmount <= 0)
//         {
//             Console.WriteLine("Purchase amount must be greater than 0.");
//             return;
//         }
//         transaction.PurchaseAmount = purchaseAmount;

//         Console.Write("Enter Selling Amount (total): ");
//         if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmount) || sellingAmount < 0)
//         {
//             Console.WriteLine("Selling amount cannot be negative.");
//             return;
//         }
//         transaction.SellingAmount = sellingAmount;

//         CalculateProfitLoss(transaction);

//         LastTransaction = transaction;
//         HasLastTransaction = true;

//         Console.WriteLine("Transaction saved successfully.");
//         Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {transaction.ProfitMarginPercent:F2}");
//     }

//     public static void ViewLastTransaction()
//     {
//         if (!HasLastTransaction)
//         {
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }

//         Console.WriteLine("-------------- Last Transaction --------------");
//         Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
//         Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
//         Console.WriteLine($"Item: {LastTransaction.ItemName}");
//         Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
//         Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
//         Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
//         Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
//         Console.WriteLine("--------------------------------------------");
//     }

//     public static void RecalculateProfitLoss()
//     {
//         if (!HasLastTransaction)
//         {
//             Console.WriteLine("No transaction available. Please create a new transaction first.");
//             return;
//         }

//         CalculateProfitLoss(LastTransaction);

//         Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
//         Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
//         Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
//     }

//     private static void CalculateProfitLoss(SaleTransaction transaction)
//     {
//         if (transaction.SellingAmount > transaction.PurchaseAmount)
//         {
//             transaction.ProfitOrLossStatus = "PROFIT";
//             transaction.ProfitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
//         }
//         else if (transaction.SellingAmount < transaction.PurchaseAmount)
//         {
//             transaction.ProfitOrLossStatus = "LOSS";
//             transaction.ProfitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
//         }
//         else
//         {
//             transaction.ProfitOrLossStatus = "BREAK-EVEN";
//             transaction.ProfitOrLossAmount = 0;
//         }

//         transaction.ProfitMarginPercent =
//             (transaction.ProfitOrLossAmount / transaction.PurchaseAmount) * 100;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("======================= QuickMart Traders ========================");
//             Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
//             Console.WriteLine("2. View Last Transaction");
//             Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");

//             string option = Console.ReadLine();
            

//             switch (option)
//             {
//                 case "1":
//                     TransactionService.CreateNewTransaction();
//                     break;

//                 case "2":
//                     TransactionService.ViewLastTransaction();
//                     break;

//                 case "3":
//                     TransactionService.RecalculateProfitLoss();
//                     break;

//                 case "4":
//                     Console.WriteLine("Thank you. Application closed normally.");
//                     exit = true;
//                     break;

//                 default:
//                     Console.WriteLine("Invalid menu option. Please try again.");
//                     break;
//             }
//         }
//     }
// }
