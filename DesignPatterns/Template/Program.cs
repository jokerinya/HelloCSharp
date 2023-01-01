﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Program
    {
        // Prevents lots of if-else usage
        static void Main(string[] args)
        {
            ScoringAlgorithm algorithm;
            algorithm = new MensScoringAlgorithm();
            Console.WriteLine("Men's: {0}", algorithm.GenerateScore(3, new TimeSpan(0, 2, 34)));
            // women
            algorithm = new WomensScoringAlgorithm();
            Console.WriteLine("Women's: {0}", algorithm.GenerateScore(3, new TimeSpan(0, 2, 34)));
            // Children
            algorithm = new ChildrensScoringAlgorithm();
            Console.WriteLine("Children's: {0}", algorithm.GenerateScore(3, new TimeSpan(0, 2, 34)));

            Console.ReadLine();
        }
    }

    abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);

            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateOverallScore(int score, int reduction);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
    }

    class MensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
    }

    class WomensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
    }

    class ChildrensScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }

        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }
    }
}
