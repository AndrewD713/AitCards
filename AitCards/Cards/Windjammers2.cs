using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Windjammers2 : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.reflects = 3;
            gun.gravity = 0.5f;
            gun.dmgMOnBounce = 1.5f;
            gun.projectileColor = new Color(50f, 255f, 255f);
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Windjammers 2";
        }

        protected override string GetDescription()
        {
            return "Literally EVERYONE hates Windjammers.";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Windjammers2;
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
                    stat = "Bounces",
                    amount = "+3",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "Bullet Gravity",
                    amount = "-50%",
                    simepleAmount = SimpleAmount.slightlyLower
                },
                new CardInfoStat
                {
                    positive = true,
                    stat = "DMG on Bounce",
                    amount = "+50%",
                    simepleAmount = SimpleAmount.Some
                },
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }

        public override string GetModName()
        {
            return AitCards.ModInitials;
        }
    }
}