using RarityLib.Utils;
using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Him : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.health = 2f;
            gun.knockback = 3f;
            statModifiers.sizeMultiplier *= 1.5f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "HIM";
        }

        protected override string GetDescription()
        {
            return "To: Samantha Curiel, Cc: Ryan Wahl";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Him;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityUtils.GetRarity("Epic");
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Health",
                    amount = "+100%",
                    simepleAmount = SimpleAmount.aLotOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Knockback",
                    amount = "+200%",
                    simepleAmount = SimpleAmount.aLotOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Player Size",
                    amount = "+50%",
                    simepleAmount = SimpleAmount.aLotOf
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.NatureBrown;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}