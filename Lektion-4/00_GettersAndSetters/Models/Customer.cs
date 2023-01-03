namespace _00_GettersAndSetters.Models
{
    internal class Customer
    {

        private string firstName = null!;
        private string lastName = null!;
        private string email = null!;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.Trim(); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value.Trim(); }
        }

        public string Email
        {
            get { return email; }
            set { email = value.Trim().ToLower(); }
        }

    }
}
