using System;
using System.Data;
using KCDataAccessLayer;


namespace KCBusinessLayer
{
    public class ClsPayment
    {
        
        public Mode mode = Mode.Add;

        
        public int PaymentID { get; set; }
        public int MethodID { get; set; }
        public int MemberID { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public int insertedID = 0;

        // Defualt Constructor.
        public ClsPayment()
        {
            PaymentID = 0;
            MethodID = 0;
            MemberID = 0;
            AmountPaid = 0;
            Date = DateTime.Now;
            Note = string.Empty;

            mode = Mode.Add;
        }


        // Constructor. Used to add a Payment to DB.
        private ClsPayment(int PaymentID, int MethodID, int MemberID, decimal AmountPaid, DateTime Date, string Note)
        {
            this.PaymentID = PaymentID;
            this.MethodID = MethodID;
            this.MemberID = MemberID;
            this.AmountPaid = AmountPaid;
            this.Date = Date;
            this.Note = Note;

            mode = Mode.Update;
        }



        private bool AddNew() => ClsKCDatabase.AddNewPaymentToDB(MethodID, MemberID, AmountPaid, Date, Note, ref insertedID);

        private bool Update()
        {
            //return ClsClinicDatabase.UpdatePayment(MemberID, MemberID, AmountPaid, Date, Note);
            return false;
        }

        public static bool Delete(int id)
        {
            //return ClsClinicDatabase.DeleteByID(id, PAYMENTS, PAYMENT_COLUMN_PK);
            return false;
        }

        public static DataTable GetAllPayments()
        {
            //return ClsClinicDatabase.GetAll(PAYMENTS);
            return null;
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

        public bool IsExists() => PaymentID > 0;
    }
}
