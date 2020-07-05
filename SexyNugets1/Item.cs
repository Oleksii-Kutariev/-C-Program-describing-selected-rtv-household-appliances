using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexyNugets1
{
	class Item
	{
		int id;
		public int prad, zasilania;
		string name; protected string userName;
		double price;
		char color; protected string ColorName;
		string info; protected string userInfo;

		Item(Item a)
		{
			//id = 4;
			prad = a.prad;
			zasilania = a.zasilania;
			ColorName = a.ColorName;
			info = a.info;
			price = a.price;
			name = a.name;
			prad = a.prad;
			zasilania = a.zasilania;
		}

		public Item()
		{
			id = 4;
			string key;
			Console.WriteLine("Write down price of your Item: ");
			do
			{
				key = Console.ReadLine();
			} while (!double.TryParse(key, out price));
			//this.price = double.Parse(Console.ReadLine());
			Console.WriteLine("Write down color of your Item(only one letter): ");
			do
			{
				do
				{
					key = Console.ReadLine();
				} while (!char.TryParse(key, out color));
			} while (color != 'r' && color != 'y' && color != 'w' && color != 'b' && color != 'g' && color != 'p');
			Console.WriteLine("Write down some info about your Item: ");
			this.userInfo = Console.ReadLine();
			Console.WriteLine("Write down name of your Item: ");
			this.userName = Console.ReadLine();
			Set_ItemName(id);
			SetColor(color);
			SetInfo(id);
		}

		public Item(int id, double price, char color, int prad, int zasilania)
		{
			this.id = id;
			//this.price = price;
			Price = price;
			this.color = color;
			Zasilina = zasilania;
			//this.zasilania = zasilania;
			Prad = prad;
			//this.prad = prad;
			SetColor(color);
			SetInfo(id);
			Set_ItemName(id);
		}

		private void SetColor(char color)
		{
			switch (color)
			{
				case 'r':
					ColorName = "Color of this item is: Red";
					break;
				case 'y':
					ColorName = "Color of this item is: Yellow";
					break;
				case 'g':
					ColorName = "Color of this item is: Green";
					break;
				case 'b':
					ColorName = "Color of this item is: Black";
					break;
				case 'p':
					ColorName = "Color of this item is: Pink";
					break;
				default:
					ColorName = "Color of this item is: White";
					break;
			}
		}
		public void Get_ItemColor()
		{
			Console.WriteLine(ColorName);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		private void SetInfo(int id)
		{
			switch (id - 1)
			{
				case 0:
					info = "This is a Laptop, and there is some information about it!";
					break;
				case 1:
					info = "This is a Microwave, and there is some information about it!";
					break;
				case 2:
					info = "This is a Computer, and there is some information about it!";
					break;
				case 3:
					info = userInfo;
					break;
					//return to main menu, smth like that
			}
		}
		public void Get_ItemInfo()
		{
			Console.WriteLine(info);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		public double Price {
			get
			{
				return price;
			}
			set
			{
				price = value;
			}
		}
		public int Prad
		{
			get
			{
				return prad;
			}
			set
			{
				prad = value;
			}
		}
		public int Zasilina
		{
			get
			{
				return zasilania;
			}
			set
			{
				zasilania = value;
			}
		}

		public void Get_ItemPrice()
		{
			Console.WriteLine("This item price is: " + Price + "$");
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		private void Set_ItemName(int id)
		{
			{
				switch (id - 1)
				{
					case 0:
						name = "This is a Laptop";
						break;
					case 1:
						name = "This is a Microwave";
						break;
					case 2:
						name = "This is a Computer";
						break;
					case 3:
						name = "This is a(an) " + userName;
						break;
						//return to main menu, smth like that
				}
			}
		}
		public void Get_ItemName()
		{
			Console.WriteLine(name);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		public void Get_ItemZasilania()
		{
			Console.WriteLine("This item power is: " + Zasilina);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		public void Get_ItemPrad()
		{
			Console.WriteLine("This item electricity is: " + Prad);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		public void GetAll()
		{
			Console.WriteLine("This item price is: " + price + "$");
			Console.WriteLine(ColorName);
			Console.WriteLine(info);
			Console.WriteLine(name);
			Console.WriteLine("This item electricity is: " + prad);
			Console.WriteLine("This item power is: " + zasilania);
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		static public void Example()
		{
			Console.WriteLine("This is the static method , called from main class without creating new object");
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}

		public static Item operator +(Item a , Item b)
		{
			return new Item(a) { prad = a.prad + b.prad, zasilania = a.zasilania + b.zasilania };
		}

		public static bool operator >(Item a, Item b)
		{
			return (a.prad > b.prad);
		}
		public static bool operator <(Item a, Item b)
		{
			return (a.prad < b.prad);
		}
	}
}