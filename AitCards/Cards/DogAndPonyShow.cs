using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class DogAndPonyShow : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.projectileSize = 6f;
            gun.damage = 0.85f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Dog and Pony Show";
        }

        protected override string GetDescription()
        {
            return "These new bullets will do so much damage. You can tell by the size and the way that it is.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.DogAndPonyShow;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Projectile Size",
                    amount = "+500%",
                    simepleAmount = SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Damage",
                    amount = "-15%",
                    simepleAmount = SimpleAmount.slightlyLower
                },
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}