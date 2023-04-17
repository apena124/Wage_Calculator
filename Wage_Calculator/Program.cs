using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Worker[] wk = new Worker[1];
			Manager[] mg = new Manager[1];

			//calling methods 
			ReadData(wk, mg);
			ObjSort(wk, mg);

			//prompt user for range of current salary
			//Console.Write("Enter the range of current salary: ");
			//double range = Convert.ToDouble(Console.ReadLine());

			//display the range of employees within the current salary

			Console.ReadLine();
		}

		//method to read data 
		public static void ReadData(Worker[] wk, Manager[] mg)
		{
			//read information from worker file to worker array
			StreamReader sreader = new StreamReader("worker.txt");
			int size = Convert.ToInt32(sreader.ReadLine());
			wk = new Worker[size];
			for (int i = 0; i < wk.Length; i++)
			{
				wk[i] = new Worker();
				wk[i].Fname = sreader.ReadLine();
				wk[i].Lname = sreader.ReadLine();
				wk[i].Wid = sreader.ReadLine();
				wk[i].YearStartedWked = Convert.ToInt32(sreader.ReadLine());
				wk[i].InitSalary = Convert.ToDouble(sreader.ReadLine());
			}

			//read information from manager file to manager array
			StreamReader sreader2 = new StreamReader("manager.txt");
			int size2 = Convert.ToInt32(sreader2.ReadLine());
			mg = new Manager[size2];
			for (int x = 0; x < mg.Length; x++)
			{
				mg[x] = new Manager();
				mg[x].Fname = sreader2.ReadLine();
				mg[x].Lname = sreader2.ReadLine();
				mg[x].Wid = sreader2.ReadLine();
				mg[x].YearStartedWked = Convert.ToInt32(sreader2.ReadLine());
				mg[x].InitSalary = Convert.ToDouble(sreader2.ReadLine());
				mg[x].YearPromo = Convert.ToInt32(sreader2.ReadLine());
			}

			//promt user for current year
			Console.Write("Enter the current year: ");
			int currentyear = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			//call mehtods to calculate years worked and current salary
			for (int x = 0; x < wk.Length; x++)
			{
				wk[x].ThecalcCurSalary(currentyear);
				wk[x].CalcYearWorked(currentyear);
				Console.WriteLine("worker: " + wk[x].Fname + " " + wk[x].Lname + "\nworker id: " + wk[x].Wid + "\nstarted working: " + wk[x].YearStartedWked +
					"\nWorked a total: " + wk[x].YearWorked + " years" + "\ncurent salary: $" + wk[x].CurSalary + "\n");
			}
		}

		//metod to sort the obj array
		public static void ObjSort(Worker[] wk, Manager[] mg)
		{
			//sort worker array
			int size = wk.Length;
			for (int i = 0; i < size - 1; i++)
			{
				for (int j = 0; j < size - i - 1; j++)
				{
					if (wk[j].CurSalary > wk[j + 1].CurSalary)
					{
						Worker w = wk[j];
						wk[j] = wk[j + 1];
						wk[j + 1] = w;
					}
				}
			}

			//sort manager array
			size = mg.Length;
			for (int a = 0; a < size - 1; a++)
			{
				for (int b = 0; b < size - a - 1; b++)
				{
					if (mg[b].CurSalary < mg[b + 1].CurSalary)
					{
						Manager m = mg[b];
						mg[b] = mg[b + 1];
						mg[b + 1] = m;
					}
				}
			}

		}
	}
}
