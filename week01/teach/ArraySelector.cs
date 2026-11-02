public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int [] result = new int[select.Length];
        // 計算陣列的長度，並建立一個新的陣列result，長度與select相同

        int arrray1Index = 0;
        int array2Index = 0;

        for (int i = 0; i < select.Length; i++)
        // 迴圈，讓i從0到select.Length-1，依序取出select陣列的值
        {
            if (select[i] == 1)
            {
                // 如果select[i]的值為1，則從list1中取出對應的值，並放入result陣列中
                result[i] = list1[arrray1Index];
                arrray1Index++;
            }
            else if (select[i] == 2)
            {
                // 如果select[i]的值為不等於1(等於2)，則從list2中取出對應的值，並放入result陣列中
                result[i] = list2[array2Index];
                array2Index++;
            }
        }
        
        return result;
    }
}