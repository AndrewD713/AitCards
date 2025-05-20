using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class ScumbagTactics : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.regen = 10f;
            statModifiers.movementSpeed = 2f;
            statModifiers.health = 0.75f;
            gun.spread = 0.05f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Scumbag Tactics";
        }

        protected override string GetDescription()
        {
            return "Boo, Stroup! He's bad at games!";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.ScumbagTactics;
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
                    stat = "Regen",
                    amount = "+10",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Movement Speed",
                    amount = "+100%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Health",
                    amount = "-25%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Spread",
                    amount = "+5%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                }
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