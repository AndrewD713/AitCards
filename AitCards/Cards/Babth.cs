using RarityLib.Utils;
using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Babth : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.projectileSize = 3f;
            gun.damage = 3f;
            gun.ammo = -100;
            gun.reloadTime = 1.5f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "B.A.B.T.H.";
        }

        protected override string GetDescription()
        {
            return "Watch out! He's got that big ass bullet that hurts!";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Babth;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityUtils.GetRarity("Epic");
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullets",
                    amount = "BIG",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    amount = "HURT",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Ammo",
                    amount = "1",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "+50%",
                    simepleAmount = SimpleAmount.lower
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DestructiveRed;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}