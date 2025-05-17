using UnityEngine;

namespace AitCards
{
    internal class Assets
    {
        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("aitcardsbundle", typeof(AitCards).Assembly);

        public static GameObject Sumesh = Bundle.LoadAsset<GameObject>("C_Sumesh");
    }
}