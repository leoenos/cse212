public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var l3 = new[] { 10, 20, 30, 40, 50 };
        var select = new[] { 1, 3, 1, 1, 2, 2, 3, 1, 2, 3, 2, 2, 1};
        var intResult = ListSelector(l1, l2, l3, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] list3, int[] select)
    {
        var result = new int[select.Length];
        var l1Idx = 0;
        var l2Idx = 0;
        var l3Idx = 0;
        for (var i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
                result[i] = list1[l1Idx++];
            else if (select[i] == 2)
                result[i] = list2[l2Idx++];
            else if (select[i] == 3)
                result[i] = list3[l3Idx++];
        }

        return result;
    }
}