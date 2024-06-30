using System;
using System.Data;
using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsSubscription
    {

        private Mode mode = Mode.Add;

        public int SubscriptionID { get; set; }
        public int MemberID { get; set; }
        public int PaymentID { get; set; }
        public decimal Fee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }


        // Default Constructor.
        public ClsSubscription()
        {
            SubscriptionID = 0;
            MemberID = 0;
            PaymentID = 0;
            Fee = 0;
            StartDate = DateTime.MinValue;
            EndtDate = DateTime.MinValue;

            mode = Mode.Add;
        }


        // ------------- Methods.
        private bool AddNew() => ClsKCDatabase.AddNewSubscriptionToDB(MemberID, PaymentID, Fee, StartDate, EndtDate);

        public bool Update()
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

        public static DataTable Find(int subscriptionID) => ClsKCDatabase.FindSubscriptionByID(subscriptionID);

        public static DataTable GetSubscription()
            => ClsKCDatabase.GetAllSubscription();

        public static DataTable GetMemberSubscription(DateTime startDate, DateTime endDate, string member)
            => ClsKCDatabase.GetSubscriptionByMember(startDate, endDate, member);

        public static DataTable GetSubscription(DateTime startDate, DateTime endDate)
            => ClsKCDatabase.GetSubscriptionByDateAllMethods(startDate, endDate);

        public static DataTable GetSubscription(DateTime startDate, DateTime endDate, string method)
            => ClsKCDatabase.GetSubscriptionByDateAndByMthods(startDate, endDate, method);

        public static DataTable GetSubscription(DateTime startDate, DateTime endDate, string method, string member)
            => ClsKCDatabase.GetSubscriptionByDateAndByMthodsAndByMember(startDate, endDate, method, member);
    }
}