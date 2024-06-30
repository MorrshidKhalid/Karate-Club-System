namespace KCDataAccessLayer
{
    public static class ClsKCContract
    {


        /* Inner class that defines the tables names */
        public static class Tables
        {
            public const string PERSONS = "PERSONS";
            public const string MEMBERS = "MEMBERS";
            public const string INSTRACTORS = "INSTRACTORS";
            public const string PHONES = "PHONES";
            public const string PAYMENTS = "PAYMENTS";
            public const string PAYMENT_METHODS = "METHODS";
            public const string BELT_RANKS = "BELT_RANKS";
            public const string SUBSCRIPTIONS = "SUBSCRIPTIONS";
            public const string FEES = "FEES";
            public const string BELT_TESTS = "BELT_TESTS";
        }


        /* Inner class that defines the (BELT_RANKS) table contents */
        public static class BektRank
        {
            public const string BELT_RANK_COLUMN_PK = "RankID";
            public const string BELT_RANK_COLUMN_NAME = "RankName";
            public const string BELT_RANK_COLUMN_TEST_FEE= "TestFee";
        }




        /* Inner class that defines the (PERSONS) table contents */
        public static class Person
        {
            public const string PERSON_COLUMN_PK = "PersonID";
            public const string PERSON_COLUMN_FIRST_NAME = "FirstName";
            public const string PERSON_COLUMN_MID_NAME = "MidName";
            public const string PERSON_COLUMN_LAST_NAME = "LastName";
            public const string PERSON_COLUMN_ADDRESS = "Address";
        }


        /* Inner class that defines the (MEMBERS) table contents */
        public static class Members
        {
            public const string MEMBER_COLUMN_PK = "MemberID";
            public const string MEMBER_COLUMN_PERSON_ID = "PersonID";
            public const string MEMBER_COLUMN_IS_ACTIVE = "IsActive";
            public const string MEMBER_COLUMN_LBR_ID = "LastBeltRankID";
        }



        /* Inner class that defines the (INSTRACTORS) table contents */
        public static class Instractor
        {
            public const string INSTRACTOR_COLUMN_PK = "InstractorID";
            public const string INSTRACTOR_COLUMN_PERSON_ID = "PersonID";
        }

        /* Inner class that defines the (PHONES) table contents */
        public static class Phone
        {
            public const string PHONE_COLUMN_PK = "PhoneID";
            public const string PHONE_COLUMN_PERSON_ID = "PersonID";
            public const string PHONE_COLUMN_NUMBER = "Number";
        }




        /* Inner class that defines the (PAYMENT) table contents */
        public static class Payment
        {
            public const string PAYMENT_COLUMN_PK = "PaymentID";
            public const string PAYMENT_COLUMN_METHOD_ID = "MethodID";
            public const string PAYMENT_COLUMN_MEMBER_ID = "MemberID";
            public const string PAYMENT_COLUMN_AMOUNT = "AmountPaid";
            public const string PAYMENT_COLUMN_DATE = "Date";
            public const string PAYMENT_COLUMN_NOTE = "Note";
        }



        /* Inner class that defines the (METHODS) table contents */
        public static class Method
        {
            public const string PAYMENT_METHOD_COLUMN_PK = "MethodID";
            public const string PAYMENT_METHOD_COLUMN_METHOD = "MethodName";
        }



        /* Inner class that defines the (SUBSCRIPTIONS) table contents */
        public static class Subscription
        {
            public const string SUBSCRIPTION_COLUMN_PK = "SubscriptionID";
            public const string SUBSCRIPTION_COLUMN_MEMBER_ID = "MemberID";
            public const string SUBSCRIPTION_COLUMN_PAYMENT_ID = "PaymentID";
            public const string SUBSCRIPTION_COLUMN_FEE = "FEE";
            public const string SUBSCRIPTION_COLUMN_S_DATE = "StartDate";
            public const string SUBSCRIPTION_COLUMN_E_DATE = "EndDate";   
        }


        /* Inner class that defines the (FEES) table contents */
        public static class Fee
        {
            public const string FEE_COLUMN_PK = "FeeID";
            public const string FEE_COLUMN_SUBSCRIPTION_Fee = "SubscriptionFee";
        }



        /* Inner class that defines the (TESTS) table contents */
        public static class Test
        {
            public const string TESTS_COLUMN_PK = "TestID";
            public const string TESTS_COLUMN_INSTRACTOR_ID = "TestedByInstructorID";
            public const string TESTS_COLUMN_MEMBER_ID = "MemberID";
            public const string TESTS_COLUMN_RANK_ID = "RankID";
            public const string TESTS_COLUMN_PAYMENT_ID = "PaymentID";
            public const string TESTS_COLUMN_RESULT = "Result";
            public const string TESTS_COLUMN_DATE = "Date";
        }
    }
}