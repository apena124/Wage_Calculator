/*
 Create a “Worker” classes that are derived from Employee class.
  In Worker class, it has one field, yearWorked. 
 It includes constructor(s) and properties.It also includes two functions: 
 first, calcYearWorked function, it takes one parameter(currentyear) 
 and calculates the number of year the worker has been working (currentyear–yearStartedWked) and save it in the yearWorked variable. 
 Second, thecalcCurSalary function that calculate the current year salary by overriding the base class function using initial salary with 3% yearly increment.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Calculator
{
	class Worker : Employee
	{
		//worker variable
		public int yearWorked;

		//worker constructor
		public Worker()
		{
			yearWorked = 0;
		}

		//worker properties
		public int YearWorked
		{
			set { yearWorked = value; }
			get { return yearWorked; }
		}

		//function for worker class
		public void CalcYearWorked(int currentyear)
		{
			yearWorked = currentyear - YearStartedWked;
		}

		public void ThecalcCurSalary(int currentyear)
		{
			double salary = InitSalary;
			for (int i = YearStartedWked; i < currentyear; i++)
			{
				salary *= 1.03;
			}
			CurSalary = Math.Round(salary, 2);
		}
	}
}
