using UnityEngine;

namespace AitCards
{
    internal class Assets
    {
        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("aitcardsbundle", typeof(AitCards).Assembly);

        public static GameObject Sumesh = Bundle.LoadAsset<GameObject>("C_Sumesh");
        public static GameObject PlentyOfParking = Bundle.LoadAsset<GameObject>("C_PlentyOfParking");
        public static GameObject Babth = Bundle.LoadAsset<GameObject>("C_Babth");
        public static GameObject Bit9 = Bundle.LoadAsset<GameObject>("C_Bit9");
        public static GameObject CarbonBlock = Bundle.LoadAsset<GameObject>("C_CarbonBlock");
        public static GameObject ThreeStars = Bundle.LoadAsset<GameObject>("C_ThreeStars");
        public static GameObject ScumbagTactics = Bundle.LoadAsset<GameObject>("C_ScumbagTactics");
        public static GameObject DarnGoodCoffee = Bundle.LoadAsset<GameObject>("C_DarnGoodCoffee");
        public static GameObject Windjammers2 = Bundle.LoadAsset<GameObject>("C_Windjammers2");
        public static GameObject Him = Bundle.LoadAsset<GameObject>("C_Him");
        public static GameObject SplitTheMob = Bundle.LoadAsset<GameObject>("C_SplitTheMob");
        public static GameObject Deposita = Bundle.LoadAsset<GameObject>("C_Deposita");
        public static GameObject ImTooWeak = Bundle.LoadAsset<GameObject>("C_ImTooWeak");
    }
}