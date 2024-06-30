using System.Data;
using KCBusinessLayer;
using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsPhone
    {
        
        public Mode mode = Mode.Add;

        // All Getters and Setters.
        public int PhoneID { get; }
        public int PersonID { get; set; }
        public string PhoneNumber { get; set; }


        // Defualt Constructor.
        public ClsPhone()
        {
            PersonID = 0;
            PhoneNumber = string.Empty;

            mode = Mode.Add;
        }

        // Private Constructor used to add (Phone) Object to Database.
        private ClsPhone(int PhoneID, int PersonID, string PhoneNumber)
        {
            this.PhoneID = PhoneID;
            this.PersonID = PersonID;
            this.PhoneNumber = PhoneNumber;

            mode = Mode.Update;
        }

        private bool AddNew() => ClsKCDatabase.AddNewPhoneToDB(PersonID, PhoneNumber);

        public bool Update()
        {
            //return ClsClinicDatabase.UpdatePhone(this.PhoneID, this.PersonID, this.PhoneNumber);
            return false;
        }

        public static ClsPhone Find(int personID)
        {
            return new ClsPhone();
        }

        public bool Save()
        {
            switch (mode)
            {
                case Mode.Add:
                    if (AddNew())
                    {
                        mode = Mode.Update; // Refresh the mode.
                        return true;
                    }
                    else return false;

                case Mode.Update:
                    return Update();
            }

            return false;
        }

        public static bool Delete(int phoneID) => ClsKCDatabase.DeletePhoneByID(phoneID);

        public static DataTable GetPhones(int personID) => ClsKCDatabase.GetPersonPhones(personID);

        public bool IsExists() => PersonID > 0;
    }
}