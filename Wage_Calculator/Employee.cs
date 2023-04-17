/*
 Create an “Employee” class with six fields: first name, last name, workID, yearStartedWked,initSalary, and curSalary. 
 It includes constructor(s) and properties to initialize values for allfields (curSalary is read-only). 
 It also includes a calcCurSalary function that assigns thecurSalary equal to initSalary.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Calculator
{
	class Employee
	{
		// employee variables
		string fname;
		string lname;
		string wid;
		int yearStartedWked;
		double initSalary;
		private double curSalary;

		//constructor for employee
		public Employee()
		{
			fname = "";
			lname = "";
			wid = "";
			yearStartedWked = 0;
			initSalary = 0;
			curSalary = 0;
		}

		//employee propertys
		public string Fname
		{
			set { fname = value; }
			get { return fname; }
		}

		public string Lname
		{
			set { lname = value; }
			get { return lname; }
		}

		public string Wid
		{
			set { wid = value; }
			get { return wid; }
		}

		public int YearStartedWked
		{
			set { yearStartedWked = value; }
			get { return yearStartedWked; }
		}

		public double InitSalary
		{
			set { initSalary = value; }
			get { return initSalary; }
		}

		public double CurSalary
		{
			set { curSalary = value; }
			get { return curSalary; }
		}

		//method for calcCurSalary
		public virtual void CalcCurSalary()
		{
			curSalary = initSalary;
		}
	}
}
