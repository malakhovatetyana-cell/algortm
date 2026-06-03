// https://www.hackerrank.com/challenges/sock-merchant/problem
 { var counts = new Dictionary<int, int>();
 int pairs = 0;
foreach (int color in ar)
  {
  if (counts.ContainsKey(color))
   {  counts[color]++;
     }
    else
    {  counts[color] = 1;
    } }
foreach (var pair in counts)
{  pairs += pair.Value / 2;
 } return pairs; }

using System;
using System.Collections.Generic;
using NUnit.Framework; 

public class Result
{

    public static int sockMerchant(int n, List<int> ar)
    {
        var counts = new Dictionary<int, int>();
        int pairs = 0;

        foreach (int color in ar)
        {
            if (counts.ContainsKey(color))
            {
                counts[color]++;
            }
            else
            {
                counts[color] = 1;
            }
        }

        foreach (var pair in counts)
        {
            pairs += pair.Value / 2; 
        }

        return pairs;
    }
}


[TestFixture]
public class Tests
{
    [Test]
    public void test0()
    {
    
        List<int> aa = new List<int> { 10, 20, 20, 10, 20, 30, 12 };
        int n = aa.Count; 
        
        int real = Result.sockMerchant(n, aa); 
        int expected = 1 + 1;                 
        
        Assert.That(real, Is.EqualTo(expected)); 
    }
}
