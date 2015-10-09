using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabTest1_2015_2_Milton
{
    class Pet
    {
        private string petName;
        private string petBreed;
        private int petAge;
        private string ownerName;
        private string address;
        private long contact;
        private decimal accountBalance;

        public Pet(string _petName, string _petBreed, int _petAge, string _ownerName, string _address, long _contact)
        {
            PetName = _petName;
            PetBreed = _petBreed;
            PetAge = _petAge;
            OwnerName = _ownerName;
            Address = _address;
            Contact = _contact;
            AccountBalance = 0;
        }

        public Pet(string _petName, string _petBreed, string _ownerName, long _contact)
        {
            PetName = _petName;
            PetBreed = _petBreed;
            OwnerName = _ownerName;
            Contact = _contact;
            AccountBalance = 0;
        }



        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

        public string PetBreed
        {
            get { return petBreed; }
            set { petBreed = value; }
        }

        public int PetAge
        {
            get { return petAge; }
            set { petAge = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public long Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set {
                if (accountBalance != 0)
                    accountBalance += value;
                else
                    accountBalance = value;
            }
        }

        public void Payment(decimal amount)
        {
            accountBalance = accountBalance - amount;
        }

        public override string ToString()
        {
            string tostring = "";
            tostring += "PetName: " + PetName + "\n";
            tostring += "OwnerName: " + OwnerName + "\n";
            tostring += "AccountBalance: " + String.Format("{0:C}", AccountBalance);

            return tostring;
        }

    }
}
