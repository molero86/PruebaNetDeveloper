using System;

namespace DataAccess
{
    public class Company
    {
        public Company()
        {

        }

        public Company(string serializedCompany)
        {
            //TODO(R): Meter en una variable el split
            var array = serializedCompany.Split("$%&");

            Date = DateTime.Parse(array[0]);
            Name = array[1];
            SocialObject = array[2];
            Location = array[3];
        }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string SocialObject { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            return string.Format("{0}$%&{1}$%&{2}$%&{3}", Date, Name, SocialObject, Location);
        }
    }
}
