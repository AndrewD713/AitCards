using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Bit9 : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            block.additionalBlocks = 1;
            block.cdMultiplier = 0.9f;
            statModifiers.movementSpeed = 0.75f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Bit9";
        }

        protected override string GetDescription()
        {
            return "Don't you feel safe now?";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Bit9;
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
                    stat = "Blocks",
                    amount = "+1",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Block Cooldown",
                    amount = "-10%",
                    simepleAmount = SimpleAmount.Some
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "-25%",
                    simepleAmount = SimpleAmount.lower
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