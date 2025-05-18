using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class ThreeStars : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.damage = 1.03f;
            gun.knockback = 1.03f;
            statModifiers.health = 1.03f;
            statModifiers.lifeSteal = 0.03f;
            statModifiers.regen = 3f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "3 Stars";
        }

        protected override string GetDescription()
        {
            return "You exceeded our expectations, which were our expectations of you, so we gave you a 'meets expectations'.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.ThreeStars;
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
                    stat = "Damage",
                    amount = "+3%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Knockback",
                    amount = "+3%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Health",
                    amount = "+3%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Lifesteal",
                    amount = "+3%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Regen",
                    amount = "+3",
                    simepleAmount = SimpleAmount.aLittleBitOf
                }
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