using KCDataAccessLayer;
using System;
using System.Data;

namespace KCBusinessLayer
{

    public class ClsMember : ClsPerson
    {
        public int MemberID { get; set; }
        public bool IsActive { get; set; }
        public int LastBeltRankID { get; set; }
        public int insertedID = 0;

        
        // Defual Constractor.
        public ClsMember() : base() => MemberID = 0;


        // Constructor. Used to Find (Menmber) Object.
        private ClsMember
            (
            int MemberID, int personPK, int LastBeltRankID,
            string firstName, string midName, string lastName, string address
            ) : base(personPK, firstName, midName, lastName, address) 
        {
            this.MemberID = MemberID;
            this.LastBeltRankID = LastBeltRankID;
        }


        // ------------- Methods Section.
        private bool AddNew()
        {
            if (AddPerson()) // Must Add Parent First.
                return ClsKCDatabase.AddNewMemberToDB(PersonID, IsActive, LastBeltRankID, ref insertedID);

            return false;
        }

        protected override bool Update() => ClsKCDatabase.UpdatePersonByID(PersonID, FirstName, MidName, LastName, Address);

        public static ClsMember Find(int memberID)
        {
            int personID = 0, lastBeltRankID = 0;
            string fName = string.Empty,
                   mName = string.Empty,
                   lName = string.Empty,
                   address = string.Empty;


            if (ClsKCDatabase.GetMemberByID(memberID, ref personID, ref lastBeltRankID, ref fName, ref mName, ref lName, ref address))
                return new ClsMember(memberID, personID, lastBeltRankID, fName, mName, lName, address);

            else return new ClsMember();
        }

        public static ClsMember Find(string memberName)
        {
            int memberID = 0, personID = 0, lastBeltRankID = 0;
            string fName = string.Empty,
                   mName = string.Empty,
                   lName = string.Empty,
                   address = string.Empty;

            if (ClsKCDatabase.GetMemberByName(memberName, ref memberID, ref personID, ref lastBeltRankID, ref fName, ref mName, ref lName, ref address))
                return new ClsMember(memberID, personID, lastBeltRankID, fName, mName, lName, address);

            else return new ClsMember();
        }

        public static DataTable AllMembers() => ClsKCDatabase.GetAllMembers();

        public static DataTable GetHistory(int memberID) => ClsKCDatabase.GetPaymentHistoryByMemberID(memberID);

        public static DataTable GetHistory(int memberID, DateTime from, DateTime to, int methodID) => ClsKCDatabase.GetPaymentHistoryByMemberIDAndDateAndMethod(memberID, from, to, methodID);

        public bool Delete() => ClsKCDatabase.DeleteMemberByID(MemberID, PersonID);

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

        public bool IsExists() => MemberID > 0;
    }
}