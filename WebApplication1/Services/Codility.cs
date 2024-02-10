namespace WebApplication1.Services;

public class Codility
{
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