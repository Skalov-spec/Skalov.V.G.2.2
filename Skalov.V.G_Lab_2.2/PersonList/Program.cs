using System;

namespace medecineList
{
	class Program
	{
		public static bool Add(int x, int y, out int z)
		{
			z=x+y;
			return true;
		}
		public static void Main(string[] args)
		{
			medecineList list =new medecineList(new medecine("Мефенамінка","якась група","група"));
			list.Addmedecine(new medecine("антивір", "якась група", "група", 10));
			list.Addmedecine(new medecine("вугілля", "якась група0", "група", 0));
			list.Addmedecine(new medecine("вугілля", "якась група0", "група", 8));
			list.Addmedecine(new medecine("сироп", "якась група0", "група", 10));
			list.Addmedecine(new medecine("дуфалак", "якась група", "група", 0));
			Console.WriteLine(list);
			medecine res =list.Findmedecine("вугілля");
			Console.WriteLine(res);

			medecineList resList =list.FindAllmedecine("якась група0");
			Console.WriteLine(resList);			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}