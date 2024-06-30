using System.Data;
using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsInstractor : ClsPerson
    {
        public int InstractorID { get; set; }


        // Defual Constractor.
        public ClsInstractor() : base() => InstractorID = 0;


        // Constructor. Used to Find or Add (Instractor) Object.
        private ClsInstractor
            (
            int InstractorID, int personPK,
            string firstName, string midName, string lastName, string address
            ) : base(personPK, firstName, midName, lastName, address)
        {
            this.InstractorID = InstractorID;
        }


        // ------- Methods.
        private bool AddNew()
        {
            if (AddPerson()) // Must Add Parent First.
                return ClsKCDatabase.AddNewInstractorToDB(PersonID);

            return false;
        }

        protected override bool Update() => ClsKCDatabase.UpdatePersonByID(PersonID, FirstName, MidName, LastName, Address);

        public override bool Save()
        {
            switch (mode)
            {
                case Mode.Add:
                    if (AddNew())
                    {
                        mode = Mode.Update;
                        return true;
                    }

                    return false;

                case Mode.Update:
                    return Update();
            }

            return false;
        }

        public bool Delete() => ClsKCDatabase.DeleteInstractorByID(InstractorID, PersonID);

        public static ClsInstractor Find(int instractorID)
        {

            int personID = 0;
            string fName = string.Empty, 
                   mName = string.Empty,
                   lName = string.Empty, 
                   address = string.Empty;

            if (ClsKCDatabase.GetInstractorByID(instractorID, ref personID, ref fName, ref mName, ref lName, ref address))
                return new ClsInstractor(instractorID, personID, fName, mName, lName, address);

            return new ClsInstractor();
        }

        public static ClsInstractor Find(string name)
        {
            
            int personID = 0, instractorID = 0;
            string fName = string.Empty,
                   mName = string.Empty,
                   lName = string.Empty,
                   address = string.Empty;

            if (ClsKCDatabase.GetInstractorByID(ref instractorID, ref personID, name, ref fName, ref mName, ref lName, ref address))
                return new ClsInstractor(instractorID, personID, fName, mName, lName, address);

            return new ClsInstractor();
        }
        public static DataTable AllInstractoras() => ClsKCDatabase.GetAllInstractor();

        public bool IsExists() => InstractorID > 0;
    }
}
