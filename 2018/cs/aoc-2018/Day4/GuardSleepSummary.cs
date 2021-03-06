﻿using System.Collections.Generic;
using System.Linq;

namespace Day4
{
    public class GuardSleepSummary
    {
        public string GuardId { get; set; }
        public Dictionary<int, int> SleepyTimesDictionary { get; set; } = new Dictionary<int, int>();
        public int TotalSleepTime { get; set; } = 0;

        public KeyValuePair<int, int> GetSleepiestMinuteKVP()
        {
            int max = SleepyTimesDictionary.Values.Max();
            return SleepyTimesDictionary.FirstOrDefault(x => x.Value == max);
        }

        public override bool Equals(object obj)
        {
            var g = obj as GuardSleepSummary;
            if (g == null) return false;
            return GuardId == g.GuardId;
        }

        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ GuardId.GetHashCode();
            return hash;
        }
    }
}