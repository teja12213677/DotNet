// See https://aka.ms/new-console-template for more information
using System;
public class PatientBill
{
    public string BillId{get; set;}
    public string PatientName {get; set;}
    public bool HasInsurance {get; set;}
    public decimal ConsultationFee{set; get;}
    public decimal LabCharges{get; set;}
    public decimal MedicineCharges{get; set;}
    
    
    public decimal GrossAmount{get; set;}
    public decimal DiscountAmount{get; set;}
    public decimal FinalPayable {get; set;}
    
    public void CalculateBill(){
        GrossAmount=ConsultationFee+LabCharges+MedicineCharges;
        
        if(HasInsurance==true){
            DiscountAmount=GrossAmount*0.20m;
        }
        else
        {
            DiscountAmount=0;
        }
        FinalPayable=GrossAmount-DiscountAmount;
    }
    public void Display()
    {
        Console.WriteLine("Patient details......");
        Console.WriteLine("Billid "+BillId);
        Console.WriteLine("PatientName: "+PatientName);
        Console.WriteLine("GrossAmount: "+GrossAmount);
        Console.WriteLine("DiscountAmount: "+DiscountAmount);
        Console.WriteLine("FinalPayable: "+FinalPayable);
    }
    
}
class Program
{
    public static void Main(string[] args){
        PatientBill bill=new PatientBill();
        Console.WriteLine("Enter Bill ID: ");
        bill.BillId=Console.ReadLine();
        Console.WriteLine("Enter Patient Name: ");
        bill.PatientName=Console.ReadLine();
        
        Console.WriteLine("Has Insurance(true/false): ");
        bill.HasInsurance=bool.Parse(Console.ReadLine());
        
        Console.WriteLine("Consultation Fee: ");
        bill.ConsultationFee=decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("Lab charges: ");
        bill.LabCharges=decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("Medicine Charges: ");
        bill.MedicineCharges=decimal.Parse(Console.ReadLine());
        
        bill.CalculateBill();
        bill.Display();
    }
}