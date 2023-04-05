
namespace ConsoleApp15.Models;

internal class Store
{
	public Store(string name)
	{
		Name = name;
	}
	private string _name;

	public string Name
	{
		get { return _name; }
		set
		{
			if (value.Length > 2)
			{
				_name=value;
			}
		}
	}
	private Phone[] Phones = new Phone[0];

	public void AddPhone(Phone phone)
	{
		Array.Resize(ref Phones, Phones.Length+1);
		Phones[Phones.Length-1] = phone;
	}
	public void ShowAllPhone()
	{
		if(Phones.Length > 0)
		{
            foreach (Phone phone in Phones)
            {
                Console.WriteLine($"Adi:{phone.Name},Qiymeti:{phone.Price},Sayi:{phone.Count}");
            }
        }
		else
		{
			Console.WriteLine("Depoda telefon yoxdu");
		}
	}
	public void ShowPhoneForPrice(int min , int max)
	{
		if (Phones.Length > 0)
		{
            foreach (Phone phone in Phones)
            {
                if (min <= phone.Price || max >= phone.Price)
                {
                    Console.WriteLine($"Adi:{phone.Name}");
                }
            }
        }
	}
	public void Removephone(int id)
	{
		Phone[] newPhones = new Phone[0];
		foreach (Phone phone in Phones)
		{
			if(phone.Id != id)
			{
				Array.Resize(ref newPhones, newPhones.Length+1);
				newPhones[newPhones.Length-1]=phone;
			}
		}
		Phones = newPhones;
	}


}
