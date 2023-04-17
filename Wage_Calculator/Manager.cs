/*
 Create a “Manager” classes that are derived from Worker class.
  In Manager class, it includes one field: yearPromo. 
 It includes the constructor(s) and property. 
 It also includes a calcCurSalary function that calculate the current year salary by overriding the base class function using initial salary with 5% yearly increment plus 10% bonus. 
 The manager’s salary calculates in two parts. It calculates as a workerbefore the year promoted and as a manager after the promotion.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Calculator
{
	class Manager : Worker
	{
		//variables for manager class
		int yearPromo;

		//consturctor for manager class
		public Manager()
		{
			yearPromo = 0;
		}

		//manager class property
		public int YearPromo
		{
			set { yearPromo = value; }
			get { return yearPromo; }
		}

		//function for manager class
		public override void CalcCurSalary()
		{
			double salary = InitSalary;
			int currentyear = 0;
			for (int i = YearStartedWked; i < currentyear; ++i)
			{
				if (i < yearPromo)
					salary *= 1.03;
				else
					salary *= 1.05;
			}
			CurSalary = Math.Round(salary * 1.1, 2); // 10% bonus
		}
	}
}
