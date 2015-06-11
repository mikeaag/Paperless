using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperless.Domain
{
    /// <summary>
    /// Contains data on a person
    /// </summary>
    public class Person
    {
        private string title;
        private string firstName;
        private string lastName;
        //private Address address;
        private string phoneNumber;
        private string emailAddress;
        //private Company company;
        private string jobTitle;
        private string notes;

        /// <summary>
        /// Sets the persons title, firstname and lastname
        /// </summary>
        /// <param name="title"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public Person SetName(string title, string firstName, string lastName)
        {
            this.title = title;
            this.firstName = firstName;
            this.lastName = lastName;
            return this;
        }

        /// <summary>
        /// Returns the fullname as a string separated by spaces
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return String.Format("{0} {1} {2}", title, firstName, lastName);
        }

    }
}
