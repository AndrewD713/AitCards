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
    }
}