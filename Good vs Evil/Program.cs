namespace Good_vs_Evil
{
    internal class Program
    {
        public static string GoodVsEvil(string good, string evil) => (good.Split(' ').Select(int.Parse).Zip(new[] { 1, 2, 3, 3, 4, 10 }, (v, w) => v * w).Sum(), evil.Split(' ').Select(int.Parse).Zip(new[] { 1, 2, 2, 2, 3, 5, 10 }, (v, w) => v * w).Sum()) switch { (int g, int e) when g > e => "Battle Result: Good triumphs over Evil", (int g, int e) when g < e => "Battle Result: Evil eradicates all trace of Good", _ => "Battle Result: No victor on this battle field" };

      /*public static string GoodVsEvil(string good, string evil)
        {
            int[] goodWorths = { 1, 2, 3, 3, 4, 10 };
            int[] evilWorths = { 1, 2, 2, 2, 3, 5, 10 };
      
            int goodSum = good.Split(' ').Select(int.Parse).Zip(goodWorths, (value, worth) => value * worth).Sum();
            int evilSum = evil.Split(' ').Select(int.Parse).Zip(evilWorths, (value, worth) => value * worth).Sum();
      
            return goodSum > evilSum ? "Battle Result: Good triumphs over Evil" : goodSum < evilSum ? "Battle Result: Evil eradicates all trace of Good": "Battle Result: No victor on this battle field";
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine(GoodVsEvil("3 2 1 5 4 15", "2 1 5 2 4 3 8"));
        }
    }
}