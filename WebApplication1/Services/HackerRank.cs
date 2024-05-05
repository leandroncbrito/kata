using System.Numerics;

namespace WebApplication1.Services;

public class HackerRank
{
    public string SameNumberOfTimes(string input)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var key in input)
        {
            if (frequencies.ContainsKey(key))
            {
                frequencies[key] += 1;
            }
            else
            {
                frequencies.Add(key, 1);
            }
        }

        var freqCount = new Dictionary<int, int>();

        // Count frequencies of frequencies
        foreach (int freq in frequencies.Values)
        {
            if (freqCount.ContainsKey(freq))
                freqCount[freq]++;
            else
                freqCount[freq] = 1;
        }


        // Check if all frequencies are the same
        if (freqCount.Count == 1)
        {
            return "YES";
        }

        // Check if removing one character can make frequencies the same
        if (freqCount.Count == 2)
        {
            var keys = new int[freqCount.Count];
            freqCount.Keys.CopyTo(keys, 0);
            var maxFreq = Math.Max(keys[0], keys[1]);
            var minFreq = Math.Min(keys[0], keys[1]);

            if ((maxFreq - minFreq == 1 && freqCount[maxFreq] == 1) || (minFreq == 1 && freqCount[minFreq] == 1))
            {
                return "YES";
            }
        }

        return "NO";
    }

    public int[] DenseRank(int[] ranked, int[] player)
    {
        var uniqueRanked = ranked.Distinct().OrderByDescending(x => x).ToList();
        var playerRanks = new List<int>();

        int j = uniqueRanked.Count;
        foreach (int score in player)
        {
            while (j > 0 && score >= uniqueRanked[j - 1])
            {
                j--;
            }
            playerRanks.Add(j + 1);
        }

        return playerRanks.ToArray();
    }
}