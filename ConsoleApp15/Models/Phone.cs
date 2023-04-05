
namespace ConsoleApp15.Models;

internal class Phone
{
	public Phone(string name, string brandname, int price, int count, int id)
	{
		Name = name;
		BrandName = brandname;
		Price = price;
		Count = count;
		Id = id;
	}
	private string _name;

	public string Name
	{
		get { return _name; }
		set 
		{
			if (value.Length > 1)
			{
				_name = value;
			}
		}
	}
	private string _brandname;

	public string BrandName
	{
		get { return _brandname; }
		set 
		{
			if (value.Length > 2)
			{
				_brandname=value;
			}
		}
	}
	private int _price;

	public int Price
	{
		get { return _price; }
		set 
		{
			if (value > 0)
			{
				_price = value;
			}
		}
	}
	private int _count;

	public int Count
	{
		get { return _count; }
		set 
		{
			if(value > 0)
			{
				_count=value;
			}
		}
	}

	private int _id;

	public int Id
	{
		get { return _id; }
		set
		{
			if (value > 0)
			{
				_id = value;
			}
		}
	}

	public void ShowInfo()
	{
		Console.WriteLine($"Adi:{Name}");
		Console.WriteLine($"Marka:{BrandName}");
		Console.WriteLine($"Qiymet:{Price}");
		Console.WriteLine($"Sayi:{Count}");
		Console.WriteLine($"Id:{Id}");
	}





}
