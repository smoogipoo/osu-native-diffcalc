// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets;
using osu.Game.Rulesets.Catch;
using osu.Game.Rulesets.Mania;
using osu.Game.Rulesets.Osu;
using osu.Game.Rulesets.Taiko;

// ReSharper disable once CheckNamespace

namespace osu.Native
{
    public static class RulesetHelper
    {
        public static Ruleset CreateRuleset(int rulesetId)
        {
            switch (rulesetId)
            {
                case 0:
                    return new OsuRuleset();

                case 1:
                    return new TaikoRuleset();

                case 2:
                    return new CatchRuleset();

                case 3:
                    return new ManiaRuleset();

                default:
                    throw new InvalidOperationException($"Unknown ruleset id: {rulesetId}.");
            }
        }
    }
}
