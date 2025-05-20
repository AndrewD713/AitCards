using RarityLib.Utils;
using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class ImTooWeak : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.respawns = 1;
            gun.reloadTime = 0f;
            gun.projectileSpeed = 2f;
            gun.attackSpeed = 0.5f;
            statModifiers.lifeSteal = 0.25f;
            statModifiers.health = 0.5f;
            gun.projectileColor = new Color(115f, 165f, 255f);
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "I'm Too Weak";
        }

        protected override string GetDescription()
        {
            return "UNLIMITED POWER!";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.ImTooWeak;
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
                    stat = "Revives",
                    amount = "+1",
                    simepleAmount = SimpleAmount.notAssigned
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
                    positive = true,
                    stat = "Bullet Speed",
                    amount = "+100%",
                    simepleAmount = SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Attack Speed",
                    amount = "+100%",
                    simepleAmount = SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Lifesteal",
                    amount = "+25%",
                    simepleAmount = SimpleAmount.aLittleBitOf
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Health",
                    amount = "-50%",
                    simepleAmount = SimpleAmount.aLotLower
                },
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