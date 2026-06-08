// https://www.hackerrank.com/challenges/apple-and-orange/problem
{   int appleCount = apples.Count(apple => (a + apple) >= s && (a + apple) <= t);
        int orangeCount = oranges.Count(orange => (b + orange) >= s && (b + orange) <= t);

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }
