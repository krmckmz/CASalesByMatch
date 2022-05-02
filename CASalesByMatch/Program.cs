class Program
{
    static void Main(string[] args)
    {
        int result = CalculateMatches(9, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
        Console.WriteLine(result);
        Console.ReadLine();
    }

    private static int CalculateMatches(int sockCount, List<int> sockList)
    {
        int pairCount = default(int);
        HashSet<int> colors = new HashSet<int>();

        for (int i = 0; i < sockCount; i++)
            if (!colors.Contains(sockList[i]))
                colors.Add(sockList[i]);

        foreach (var color in colors)
        {
            int colorCount = sockList.Count(x => x == color);
            int colorPairCount = colorCount / 2;
            pairCount += colorPairCount;
        }

        return pairCount;
    }
}