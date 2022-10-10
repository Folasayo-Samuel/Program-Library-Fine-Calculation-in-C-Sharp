using System;

namespace LibraryFineCalculationApp
{
	public class Program
	{
		public static void Main(string[]args)
		{
			int days;
			float fine = 0;
			Console.Write("Enter total days: ");
			days = Convert.ToInt32(Console.ReadLine());
			
			if(days <= 5)
			{
				fine = 0;
			} 
			else if(days > 5 && days <= 10)
			{
				fine = (days - 5) * 0.5F;
			} 
			else if(days > 10 && days <= 30)
			{
				//  ----- 5 days -----   --- between 10 and 30 ---
				fine = 5 * 0.5F + (days - 10) * 1;
			} 
			else
			{
				//  --- 5 days --- ---10, 30--- 
				fine = 5 * 0.5F + 20 * 1 + (days - 30) * 1.5F;
				Console.WriteLine("Canceled your Membership");
			}
			
			Console.WriteLine("Your fine: "+fine);

			Console.ReadLine();

		}
	}
}