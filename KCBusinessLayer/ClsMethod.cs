using System.Data;
using KCDataAccessLayer;


namespace KCBusinessLayer
{
    public class ClsMethod
    {
        public int MethodID { get; set; }
        public string MethodName { get; set; }

        private Mode mode = Mode.Add;


        // Defualt Constructor.
        public ClsMethod()
        {
            MethodID = 0;
            MethodName = string.Empty;

            mode = Mode.Add;
        }


        // Constructor. Used to add a METHOD to DB.
        private ClsMethod(int MethodID, string MethodName)
        {
            this.MethodID = MethodID;
            this.MethodName = MethodName;

            mode = Mode.Update;
        }


        // ------------- Methods.
        private bool AddNew() => ClsKCDatabase.AddNewPaymentMethod(MethodName);

        private bool Update() => ClsKCDatabase.UpdateMethod(MethodID, MethodName);

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

        public static ClsMethod Find(int methodID)
        {
            string methodName = string.Empty;
            if (ClsKCDatabase.GetMethodIDByID(methodID, ref methodName))
                return new ClsMethod(methodID, methodName);

            else return new ClsMethod();
        }

        public static int GetMethodID(string method) => ClsKCDatabase.GetMethodIDByName(method);

        public static bool Delete(int methodID)
        {
            //return ClsClinicDatabase.DeleteByID(id, PAYMENT_METHODS, PAYMENT_METHOD_COLUMN_PK);
            return false;
        }

        public static DataTable AllMethods() => ClsKCDatabase.GetAllPaymentMethods();

        public bool IsExists() => MethodID > 0;
    }
}
