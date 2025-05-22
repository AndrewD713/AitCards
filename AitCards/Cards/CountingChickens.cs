using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class CountingChickens : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.ammo = 9;
            gun.projectileColor = new Color(255f, 255f, 240);
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Counting Chickens";
        }

        protected override string GetDescription()
        {
            return "I have 12 eggs, so I should have 12 chickens.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.CountingChickens;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Ammo",
                    amount = "+12",
                    simepleAmount = SimpleAmount.notAssigned
                 },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Ammo",
                    amount = "-3",
                    simepleAmount = SimpleAmount.notAssigned
                 },
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.TechWhite;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}