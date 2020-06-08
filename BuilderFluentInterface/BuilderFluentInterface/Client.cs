using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFluentInterface
{
    class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        public double MyWallet { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }

        public Client(Builder builder)
        {
            FirstName = builder.firstname;
            LastName = builder.lastname;
            ZipCode = builder.zipcode;
            MyWallet = builder.myWallet;
            Town = builder.town;
            Street = builder.street;
            HomeNumber = builder.homenumber;
        }


        public class Builder
        {
            public string firstname;
            public string lastname;
            public string zipcode;
            public double myWallet;
            public string town;
            public string street;
            public int homenumber;


            public Builder FirstName(string firstname)
            {
                this.firstname = firstname;
                return this;
            }

            public Builder LastName(string lastname)
            {
                this.lastname = lastname;
                return this;
            }

            public Builder ZipCode(string zipcode)
            {
                this.zipcode = zipcode;
                return this;
            }

            public Builder MyWallet(double myWallet)
            {
                this.myWallet = myWallet;
                return this;
            }

            public Builder Town(string town)
            {
                this.town = town;
                return this;
            }

            public Builder HomeNumber(int homenumber)
            {
                this.homenumber = homenumber;
                return this;
            }

            public Builder Street(string street)
            {
                this.street = street;
                return this;
            }


            public Client build()
            {
                return new Client(this);
            }

        }

    }
}
