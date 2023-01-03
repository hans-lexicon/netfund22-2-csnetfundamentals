using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_GettersAndSetters.Models
{
    internal class Person_PropFullGetSet
    {
		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}


		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value.Trim(); }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set 
			{
				// Google:  C# Regular Expression Email
				var regEx = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

                value = value.Trim();

				if (new Regex(regEx).IsMatch(value))
					email = value;
				else
					email = "invalid email address";
			}
		}

	}
}
