using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsFee
    {
        public static bool Update(decimal newFee) => ClsKCDatabase.UpdateFee(newFee);

        public static decimal CurrentFee() => ClsKCDatabase.GetCurrentFee();
        
    }
}
