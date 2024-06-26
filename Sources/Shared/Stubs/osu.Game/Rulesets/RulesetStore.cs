// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Native;

// ReSharper disable once CheckNamespace

namespace osu.Game.Rulesets
{
    public class RulesetStore
    {
        public RulesetInfo GetRuleset(int id) => RulesetHelper.CreateRuleset(id).RulesetInfo;
    }
}
