namespace WebApplication1.Services;

public class Codility
{
    public int Dominator(int[] A) 
    {
        if (A.Length == 0)
        {
            return -1;
        }
        
        if (A.Length == 1)
        {
            return 0;
        }

        var hashMap = new Dictionary<int, int>();
            
        var left = 0;
        var right = A.Length - 1;
        var res = -1;
        var half = Math.Floor((decimal)A.Length / 2);
        
        while (left <= right)
        {
            if (left >= 0)
            {
                if (hashMap.ContainsKey(A[left]))
                {
                    hashMap[A[left]]++;
                }
                else
                {
                    hashMap.Add(A[left], 1);
                }
                
                if (hashMap[A[left]] > half)
                {
                    res = left;
                }
            }
            
            if (right < A.Length && left != right)
            {
                if (hashMap.ContainsKey(A[right]))
                {
                    hashMap[A[right]]++;
                }
                else
                {
                    hashMap.Add(A[right], 1);
                }
                
                if (hashMap[A[right]] > half)
                {
                    res = right;
                }
            }

            left++;
            right--;
        }
        
        return res;
    }
    
    public int DistinctNumbers(int[] A)
    {
        // [2, 1, 1, 2, 3, 1]
        // [1]

        if (A.Length == 0)
        {
            return 0;
        }

        var distinct = new HashSet<int>();
            
        var left = 0;
        var right = A.Length - 1;

        while (left <= right)
        {
            if (left >= 0)
            {
                distinct.Add(A[left]);
            }
            
            if (right < A.Length)
            {
                distinct.Add(A[right]);
            }

            left++;
            right--;
        }
        
        return distinct.Count;
    }
    
    public int PassingCars(int[] A)
    {
        var countOne = 0;
        var res = 0;
        var n = A.Length;

        while (n > 0)
        {
            if (A[n - 1] == 1)
            {
                countOne++;
            }
            else
            {
                res += countOne;
            }

            n--;
        }

        return Math.Abs(res) > 1000000000 ? -1 : res;
    }
    
    public int Permutation(int[] A)
    {
        var count = new int[A.Length + 1];
        foreach (var a in A)
        {
            if (a > A.Length)
            {
                return 0;
            }

            count[a]++;
        }

        for (var i = 1; i < count.Length; i++)
        {
            if (count[i] != 1)
            {
                return 0;
            }
        }

        return 1;
    }

    public int ValidBrackets(string S)
    {
        var hashMap = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        var stack = new Stack<char>();

        foreach (var c in S)
        {
            if (!hashMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 || stack.Pop() != hashMap[c])
            {
                return 0;
            }
        }

        return stack.Count == 0 ? 1 : 0;
    }

    public int ValidParentheses(string S)
    {
        var stack = new Stack<char>();

        foreach (var c in S)
        {
            if (c == '(')
            {
                stack.Push(c);
                continue;
            }

            if (!stack.Any())
            {
                return 0;
            }

            stack.Pop();
        }

        return stack.Count == 0 ? 1 : 0;
    }

    public int[] CyclingRotate(int[] A, int K)
    {
        if (!A.Any())
        {
            return A;
        }

        var linkedList = new LinkedList<int>(A);

        for (var i = 0; i < K; i++)
        {
            var last = linkedList.Last!;
            linkedList.RemoveLast();
            linkedList.AddFirst(last);
        }

        return linkedList.ToArray();
    }

    public int FindOddNumber2(int[] A)
    {
        var hashMap = new Dictionary<int, int>();

        for (var i = 0; i < A.Length; i++)
        {
            hashMap[A[i]] = hashMap.TryGetValue(A[i], out var value) ? value + 1 : 1;
        }

        foreach (var hm in hashMap)
        {
            if (hm.Value % 2 != 0)
            {
                return hm.Key;
            }
        }

        return -1;
    }

    public int FindOddNumber(int[] A)
    {
        Array.Sort(A);

        var hashMap = new Dictionary<int, int>();

        for (var i = 0; i < A.Length; i++)
        {
            var curr = A[i];

            hashMap[curr] = hashMap.TryGetValue(curr, out var value) ? value + 1 : 1;

            if (i > 0 && A[i - 1] != curr)
            {
                var prev = A[i - 1];

                var count = hashMap[prev];

                if (count % 2 != 0)
                {
                    return prev;
                }

                if (i == A.Length - 1)
                {
                    return A[i];
                }
            }
        }

        return A[0];
    }
}