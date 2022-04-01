using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfFamilyTest
{
    public class Family
    {
        public int DistinctFamilies(List<Tuple<string, string>> relations)
        {
            int numberFamilies = 0;
            if (relations.Count <= 1) return relations.Count;
            var parents = relations.Select(r => r.Item1).Distinct().ToList();
            var childs = relations.Select(r => r.Item2).Distinct().ToList();
            parents = parents.Where(r => !childs.Contains(r)).Select(r => r).ToList();

            numberFamilies = parents.Count;
            return numberFamilies;
        }
    }
}
