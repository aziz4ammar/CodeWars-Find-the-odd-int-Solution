using System;
using System.Linq;

public class Kata
{
  public static int find_it(int[] seq) 
  {
    return seq.GroupBy(x => x).Single(g => g.Count() % 2 != 0).Key;
  }
}
