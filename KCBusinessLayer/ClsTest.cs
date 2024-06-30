using System;
using System.Data;
using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsTest
    {

        public Mode mode = Mode.Add;


        public int TestID { get; set; }
        public int TestedByInstructorID { get; set; }
        public int MemberID { get; set; }
        public int RankID { get; set; }
        public bool Result { get; set; }
        public DateTime Date { get; set; }
        public int PaymentID { get; set; }


        public ClsTest()
        {
            TestID = 0;
            TestedByInstructorID = 0;
            MemberID = 0;
            RankID = 0;
            Result = false;
            Date = DateTime.Now;
            PaymentID = 0;

            mode = Mode.Add;
        }


        private ClsTest(
            int TestID,
            int TestedByInstructorID, int MemberID, int RankID,
            bool Result, DateTime Date, int PaymentID)
        {
            this.TestID = TestID;
            this.TestedByInstructorID = TestedByInstructorID;
            this.MemberID = MemberID;
            this.RankID = RankID;
            this.Result = Result;
            this.Date = Date;
            this.PaymentID = PaymentID;


            mode = Mode.Update;
        }


        // --------- Methods.
        private bool AddNew() => ClsKCDatabase.AddNewTestToDB(TestedByInstructorID, MemberID, RankID, Result, Date, PaymentID);

        private bool Update()
        {
            return false;
        }

        public bool Save()
        {

            switch (mode)
            {
                case Mode.Add:
                    if (AddNew())
                    {
                        mode = Mode.Update;
                        return true;
                    }
                    else return false;

                case Mode.Update:
                    return Update();
            }

            return false;
        }

        public bool IsExists() => TestID > 0;

    }
}
