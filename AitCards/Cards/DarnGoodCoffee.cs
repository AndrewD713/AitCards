using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class DarnGoodCoffee : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.movementSpeed = 1.25f;
            gun.attackSpeed = 0.75f;
            statModifiers.health = 0.9f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Darn Good Coffee";
        }

        protected override string GetDescription()
        {
            return "It's alright.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.DarnGoodCoffee;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Movement Speed",
                    amount = "+25%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Attack Speed",
                    amount = "+50%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Health",
                    amount = "-10%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}