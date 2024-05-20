using System.Net;

namespace WebApplication1.Services;

public class TomTom
{
    public int Solution()
    {
        return 1;
    }
}

//public class CompanyT
//{
//    static int CountPieces(int length, int stick1, int stick2)
//    {
//        return (stick1 / length) + (stick2 / length);
//    }

//    static bool CanFormSquare(int length, int stick1, int stick2)
//    {
//        return CountPieces(length, stick1, stick2) >= 4;
//    }

//    public int solution(int A, int B)
//    {
//        for (int length = Math.Max(A, B); length > 0; length--)
//        {
//            if (CanFormSquare(length, A, B))
//            {
//                return length;
//            }
//        }

//        return 0;
//    }
//}

//public class CompanyT1
//{
//    public int solution(string S)
//    {
//        var count = 0;
        
//        for (int i = 0; i < S.Length; i++)
//        {
//            // skip the dash
//            if (S[i] == '-')
//            {
//                continue;
//            }

//            // check for 3 consecutive H or two consecutive H in the beginning or end
//            if ((i == 0 || S[i - 1] != '-') && (i == S.Length - 1 || S[i + 1] != '-'))
//            {
//                return -1;
//            }
            
//            // skip the next 2 characters -H
//            if (i < S.Length - 2 && S[i + 1] == '-' && S[i + 2] == 'H')
//            {
//                i += 2;
//            }

//            count++;
//        }

//        return count;
//    }
//}

// SELECT *
//     FROM (
//         SELECT product,
//              LAG(price) OVER (PARTITION BY product ORDER BY date) AS prev_price,
//              price,
//              ROW_NUMBER() OVER (PARTITION BY product ORDER BY date DESC) AS row_num
//         FROM price_updates
//     ) AS prices
// WHERE row_num = 1 AND prev_price IS NOT NULL AND price > prev_price;


//public class CompanyT2
//{
//    public string solution(string S)
//    {
//        var chars = S.ToCharArray();
//        Array.Reverse(chars);
//        var newstr = new string(chars);
//        var rev = newstr[0] + " " + newstr[1]; 
//        return rev;
//    }

//    public int[] FindIpRegion(string[] ips)
//    {
//        var res = new List<int>();

//        // 1: 0 - 50
//        // 2: 51 - 100
//        // 3: 101 - 150
//        // 4: 151 - 200
//        // 5: 201 - 255

//        var map = new Dictionary<int, int[]>();
//        map.Add(1, new int[] { 0, 50 });
//        map.Add(2, new int[] { 51, 100 });
//        map.Add(3, new int[] { 101, 150 });
//        map.Add(4, new int[] { 151, 200 });
//        map.Add(5, new int[] { 201, 255 });

//        foreach (var ip in ips)
//        {
//            var blocks = ip.Split('.');
//            var regionIp = Convert.ToInt32(blocks[0]);

//            foreach (var block in blocks)
//            {
//                var num = Convert.ToInt32(block);
//                if (num > 255)
//                {
//                    res.Add(-1);
//                    break;
//                }
//            }

//            foreach (var region in map)
//            {
//                var range = region.Value;
//                if (range[0] < regionIp && regionIp < range[1])
//                {
//                    res.Add(region.Key);
//                    break;
//                }
//            }
//        }

//        return res.ToArray();
//    }
// }
