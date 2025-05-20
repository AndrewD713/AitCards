using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;

namespace AitCards.Cards
{
    class Deposita : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.respawns = 3;
            gun.projectileSpeed = 0.5f;
            statModifiers.movementSpeed = 0.5f;
            statModifiers.health = 0.5f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
        }

        protected override string GetTitle()
        {
            return "Deposita";
        }

        protected override string GetDescription()
        {
            return "Are you sure you killed me? Looks fine on my end. Can you try it again?";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.Deposita;
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
                    stat = "Revives",
                    amount = "+3",
                    simepleAmount = SimpleAmount.notAssigned
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Bullet Speed",
                    amount = "-50%",
                    simepleAmount = (SimpleAmount)7
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Movement Speed",
                    amount = "-50%",
                    simepleAmount = SimpleAmount.aLotLower
                },
                new CardInfoStat
                {
                    positive = false,
                    stat = "Health",
                    amount = "-50%",
                    simepleAmount = SimpleAmount.aLotLower
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