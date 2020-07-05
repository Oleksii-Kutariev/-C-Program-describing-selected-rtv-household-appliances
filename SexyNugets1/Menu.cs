using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SexyNugets1
{
	class Menu
	{
		static int id;
		char ExitKey;
		static Item Laptop = new Item(1, 150, 'r', 100, 220);
		static Item Microwave = new Item(2, 300, 'b', 100, 220);
		static Item Computer = new Item(3, 80, 'w', 100, 220);
		private string[] UI = { ".Get item price.", ".Get item color.", ".Item name.", ".Information about item.", ".Power of item.", ".Electricity of item.", ".Get all information about item.", ".Compare Item parameters with another Item",".Back to item ID`s ", ".Exit program" , ".Show me static method."};

		public Menu()
		{
			Start(ref id);
			Item LaptopCopied = Laptop;
			if ((id - 1) == 5)
			{
				Console.Clear();
				Sum(out id, ref Laptop, ref Microwave, ref Computer);
				//Console.Clear();
			} 
			switch (id - 1)
			{
				case 0:

					Console.Clear();
					Console.SetCursorPosition(5, 0);
					Console.WriteLine("*Laptop*");
					Menu a = new Menu(Laptop, 1);
					break;
				case 1:
					Console.Clear();
					Console.SetCursorPosition(5, 0);
					Console.WriteLine("*Microwave*");
					Menu b = new Menu(Microwave, 2);
					break;
				case 2:

					Console.Clear();
					Console.SetCursorPosition(5, 0);
					Console.WriteLine("*Computer*");
					Menu c = new Menu(Computer, 3);
					break;
				case 3:
					Console.Clear();
					Console.SetCursorPosition(5, 0);
					Console.WriteLine("*LaptopCopied*");
					Menu d = new Menu(LaptopCopied, 1);
					break;
				case 4:
					Console.Clear();
					Item userItem = new Item();
					Menu e = new Menu(userItem, 4);
					break;
			}
		}

		protected Menu(Item a, int IDKey)
		{
			int key;
			string Skey;
			bool Bkey = true;
			do
			{
				for (int i = 0; i < 11; i++)
					Console.WriteLine((i + 1) + UI[i]);
				do
				{
					Skey = Console.ReadLine();
					if (!(int.TryParse(Skey, out key)))
						Console.WriteLine("Wrong key , pls choose number from below upper");
				} while (!(int.TryParse(Skey, out key)));
				if (key >= 1 || key <= 11)
				{
					switch (key - 1)
					{
						case 0:
							a.Get_ItemPrice();
							Console.Clear();
							break;
						case 1:
							a.Get_ItemColor();
							Console.Clear();
							break;
						case 2:
							a.Get_ItemName();
							Console.Clear();
							break;
						case 3:
							a.Get_ItemInfo();
							Console.Clear();
							break;
						case 8:
							Console.Clear();
							Menu newA = new Menu();
							break;
						case 4:
							a.Get_ItemZasilania();
							Console.Clear();
							break;
						case 5:
							a.Get_ItemPrad();
							Console.Clear();
							break;
						case 6:
							a.GetAll();
							Console.Clear();
							break;
						case 9:
							Exit(ref ExitKey);
							if (ExitKey == 'y' || ExitKey == 'Y')
							{
								Bkey = false;
								Environment.Exit(0);
							}
							else
							{
								Console.WriteLine("Press any key to continue");
								Console.ReadKey();
							}
							Console.Clear();
							break;
						case 10:
							Item.Example(); // !!!!!!!!Static method!!!!!!!!!
							Console.Clear();
							break;
						case 7:
							Console.Clear();
							Compare(IDKey, ref Laptop, ref Microwave, ref Computer);
							Console.Clear();
							break;
					}
				}
				if (key < 1 || key > 11)
				{
					do
					{
						Skey = Console.ReadLine();
						if (!(int.TryParse(Skey, out key)))
							Console.WriteLine("Wrong key , pls choose number from below upper");
						else if (key < 1 || key > 11)
							Console.WriteLine("Wrong key , pls choose number from below upper");
					} while (!(int.TryParse(Skey, out key)));
				}
			} while (Bkey == true);
		}

		private void Start(ref int id)
		{
			string[] List = { " ID].Laptop", " ID].Microwave", " ID].Computer", " ID].Copied Laptop", " ID].Create your own item", " --].Add two items parameters" };
			string key;

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine("[" + (i + 1) + List[i]);
			}
			Console.Write("Choose ID of item: ");
			do
			{
				key = Console.ReadLine();
			} while (!int.TryParse(key, out id));
			if (int.TryParse(key, out id))
			{
				//id = int.Parse(Console.ReadLine());
				if (id < 1 || id > 6)
				{
					Console.WriteLine("Wrong number");
					do
					{
						key = Console.ReadLine();
						int.TryParse(key, out id);
					} while (id < 1  || id > 6);
				}
			}
		}
		private void Exit(ref char exitKey)
		{
			string key;
			Console.WriteLine("Are you sure you want Exit program?");
			Console.WriteLine("Y or N: ");
			do
			{
				//ExitKey = char.Parse(Console.ReadLine());
				do
				{
					key = Console.ReadLine();
				} while (!char.TryParse(key, out exitKey));
			} while (ExitKey != 'y' && ExitKey != 'n' && ExitKey != 'Y' && ExitKey != 'N');
		}	

		private void Sum(out int id, ref Item a, ref Item b, ref Item c)
		{
			string[] List = { ".Laptop = Laptop + Micrawave.", ".Microvawe = Microwave + Computer", ".Computer = Computer + Laptop" };
			string key;
			for (int i = 0; i < 3; i++)
				Console.WriteLine((1 + i) + List[i]);
			do
			{
				key = Console.ReadLine();
			} while (!int.TryParse(key, out id));
			if (int.TryParse(key, out id))
			{
				//id = int.Parse(Console.ReadLine());
				if (id < 1 || id > 3)
				{
					Console.WriteLine("Wrong number");
					do
					{
						key = Console.ReadLine();
						int.TryParse(key, out id);
					} while (id < 1 || id > 3);
				}
				switch (id - 1)
				{
					case 0:
						a = a + b;
						break;
					case 1:
						b = b + c;
						break;
					case 2:
						c = c + a;
						break;
				}
			}
		}
		private void Compare(int id, ref Item a, ref Item b, ref Item c)
		{
			if (id == 1)
			{
				if (a > b)
					Console.WriteLine("Laptop power more then Microwave| " + " Laptop Power: " + a.prad + "| Microwave Power: " + b.prad);
				else if (a < b)
					Console.WriteLine("Microwave power more then Laptop| " + " Laptop Power: " + a.prad + "| Microwave Power: " + b.prad);
				else
					Console.WriteLine("Laptop power equal Microwave power| " + " Laptop Power: " + a.prad + "| Microwave Power: " + b.prad);
				if (a > c)
					Console.WriteLine("Laptop power more then Computer| " + " Laptop Power: " + a.prad + "| Computer Power: " + c.prad);
				else if (a < c)
					Console.WriteLine("Computer power more then Laptop| " + " Laptop Power: " + a.prad + "| Computer Power: " + c.prad);
				else
					Console.WriteLine("Laptop power equal Computer power| " + " Laptop Power: " + a.prad + "| Computer Power: " + c.prad);
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
			}
			if (id == 2)
			{
				if (b > a)
					Console.WriteLine("Microwave power more then Laptop| " + " Microwave Power: " + b.prad + "| Laptop Power: " + a.prad);
				else if (b < a)
					Console.WriteLine("Laptop power more then Microwave| " + " Microwave Power: " + b.prad + "| Laptop Power: " + a.prad);
				else
					Console.WriteLine("Microwave power equal Laptop power| " + " Microwave Power: " + b.prad + "| Laptop Power: " + a.prad);
				if (b > c)
					Console.WriteLine("Microwave power more then Computer| " + " Microwave Power: " + b.prad + "| Computer Power: " + c.prad);
				else if (b < c)
					Console.WriteLine("Computer power more then Microwave| " + " Microwave Power: " + b.prad + "| Computer Power: " + c.prad);
				else
					Console.WriteLine("Microwave power equal Computer power| " + " Microwave Power: " + b.prad + "| Computer Power: " + c.prad);
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
			}
			if (id == 3)
			{
				if (c > a)
					Console.WriteLine("Computer power more then Laptop| " + " Computer Power: " + c.prad + "| Laptop Power: " + a.prad);
				else if (c < a)
					Console.WriteLine("Laptop power more then Computer| " + " Computer Power: " + c.prad + "| Laptop Power: " + a.prad);
				else
					Console.WriteLine("Computer power equal Laptop power| " + " Computer Power: " + c.prad + "| Laptop Power: " + a.prad);
				if (c > b)
					Console.WriteLine("Computer power more then Microwave| " + " Computer Power: " + c.prad + "| Microwave Power: " + b.prad);
				else if (c < b)
					Console.WriteLine("Microwave power more then Computer| " + " Computer Power: " + c.prad + "| Microwave Power: " + b.prad);
				else
					Console.WriteLine("Computer power equal Microwave power| " + " Computer Power: " + c.prad + "| Microwave Power: " + b.prad);
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
			}
			if (id == 4)
			{
				Console.WriteLine("No compering for this ID.");
				Console.WriteLine("Press any key to continue");
				Console.ReadKey();
			}
		}
	}
}
