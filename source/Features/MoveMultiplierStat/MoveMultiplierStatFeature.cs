﻿using BattleTech;
using UnityEngine;

namespace MechEngineer.Features.MoveMultiplierStat
{
    internal class MoveMultiplierStatFeature : Feature<MoveMultiplierStatSettings>
    {
        internal static MoveMultiplierStatFeature Shared = new MoveMultiplierStatFeature();

        internal override MoveMultiplierStatSettings Settings => Control.settings.MoveMultiplierStat;

        internal void InitEffectStats(Mech mech)
        {
            MoveMultiplierStat(mech.StatCollection);
        }

        internal void MoveMultiplier(Mech mech, ref float multiplier)
        {
            var multiplierStat = MoveMultiplierStat(mech.StatCollection);
            var rounded = Mathf.Max(mech.Combat.Constants.MoveConstants.MinMoveSpeed, multiplierStat);
            multiplier *= rounded;
        }

        private float MoveMultiplierStat(StatCollection statCollection) 
        {
            const string key = "MoveMultiplier";
            var statistic = statCollection.GetStatistic(key);
            if (statistic == null)
            {
                const float defaultValue = 1.0f;
                statistic = statCollection.AddStatistic(key, defaultValue);
            }
            return statistic.Value<float>();
        }
    }
}
