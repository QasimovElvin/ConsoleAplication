using ConsoleApp15.Models;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name elave et:");
            string CName = Console.ReadLine();
            while (CName.Length<2)
            {
                Console.WriteLine("Yeniden dqaxil et");
                CName = Console.ReadLine();
            }

            Store store = new Store(CName);
            
                Console.WriteLine("1-Magazadaki butun telefonlari goster");
                Console.WriteLine("2-Magazaya yeni telefon elave et");
                Console.WriteLine("3-Qiymet araliginda uygun telefonalri axtar");
                Console.WriteLine("4-telefonu siyahidan sil");
            Console.WriteLine("--------------------------------------");
            while (true)
            {
                Console.WriteLine("Bir deyer secin:");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        store.ShowAllPhone();
                        break;
                        case 2:
                        Console.Write("Adini qeyd edin:");
                        string PhoneNameAdd = Console.ReadLine();
                        Console.Write("Markasin qeyd edin:");
                        string PhoneBrandAdd= Console.ReadLine();
                        Console.Write("Qiymetin qeyd edin:");
                        int PhonePriceAdd= int.Parse(Console.ReadLine());
                        Console.Write("Sayini qeyd edin:");
                        int PhoneCountAdd= int.Parse(Console.ReadLine());
                        Console.Write("Id daxil edin:");
                        int PhoneIdAdd= int.Parse(Console.ReadLine());
                        Phone phone = new Phone(PhoneNameAdd,PhoneBrandAdd,PhonePriceAdd,PhoneCountAdd, PhoneIdAdd);
                        store.AddPhone(phone);
                        break;
                    case 3:
                        Console.Write("Minimal deyer yazin:");
                        int PhonePriceMin= int.Parse(Console.ReadLine());
                        Console.Write("Maksimal deyer yazin");
                        int PhonePriceMax= int.Parse(Console.ReadLine());
                        store.ShowPhoneForPrice(PhonePriceMin,PhonePriceMax);
                        break;
                    case 4:
                        Console.Write("Silmek istediyiniz Telefonun Id yazin:");
                        int id = int.Parse(Console.ReadLine());
                        store.Removephone(id);
                        Console.WriteLine("Telefon Silindi");
                        break;
                        
                }
            } 
        }
    }
}