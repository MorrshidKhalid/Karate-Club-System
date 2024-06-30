using System;
using System.Data;
using KCDataAccessLayer;

namespace KCBusinessLayer
{
    public class ClsBeltRank
    {
        
        public int RankID { get; set; }
        public string RankName { get; set; }
        public decimal TestFee { get; set; }

        //private Mode mode;

        public ClsBeltRank()
        {
            RankID = 0;
            RankName = string.Empty;
            TestFee = 0;

            //mode = Mode.Add;
        }

        public ClsBeltRank(int RankID, string RankName, decimal TestFee)
        {
            this.RankID = RankID;
            this.RankName = RankName;
            this.TestFee = TestFee;

            //mode = Mode.Update;
        }


        // ---------- Methods.
        public static short GetBeltRankID(string name) => ClsKCDatabase.GetBeltRankIDByName(name);

        public static ClsBeltRank Find(int beltRankID)
        {
            string rankName = string.Empty;
            decimal testFee = 0;

            if (ClsKCDatabase.GetBeltRankByID(beltRankID, ref rankName, ref testFee))
                return new ClsBeltRank(beltRankID, rankName, testFee);

            else return new ClsBeltRank();
        }

        public static ClsBeltRank Find(string rankName)
        {
            int beltRankID = 0;
            decimal testFee = 0;

            if (ClsKCDatabase.GetBeltRankByName(ref beltRankID, rankName, ref testFee))
                return new ClsBeltRank(beltRankID, rankName, testFee);

            else return new ClsBeltRank();
        }

        public static DataTable GetAllRanks() => ClsKCDatabase.GetAllBeltRanks();

        public static bool UpdateFee(int rankID, decimal newFee) => ClsKCDatabase.UpdateBeltRankFee(rankID, newFee);

        public bool IsExists() => RankID > 0;

    }
}
