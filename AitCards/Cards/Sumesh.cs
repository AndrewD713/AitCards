using UnboundLib.Cards;
using UnityEngine;
using RarityLib.Utils;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Sumesh : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.attackSpeed = 0.2f;
            gun.damage = 2f;
            gun.reloadTime = 0f;
            statModifiers.movementSpeed = 0f;
            statModifiers.numberOfJumps = -500;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Sumesh";
        }

        protected override string GetDescription()
        {
            return "The ROUNDS Legend himself.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Sumesh;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return RarityUtils.GetRarity("Legendary");
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat
                {
                    positive = true,
                    stat = "Attack Speed",
                    amount = "+400%",
                    simepleAmount = SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Damage",
                    amount = "+100%",
                    simepleAmount = SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Ammo",
                    amount = "Infinite",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "Zero",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Jumps",
                    amount = "Zero",
                    simepleAmount = SimpleAmount.notAssigned
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