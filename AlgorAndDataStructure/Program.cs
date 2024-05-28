// See https://aka.ms/new-console-template for more information
using AlgorAndDataStructure.Array;

#region array testing
//int[,] twosumData = { { 2, 7, 11, 15 } , { 3, 2, 4,7 }, { 3, 3,4,8 } };
List<int[]> twosumData = new List<int[]>();
twosumData.Add(new int []{ 2, 7, 11, 15 });
twosumData.Add(new int[] { 3, 2, 4, 7 });
twosumData.Add(new int[] { 3, 3, 4, 8 });
TwoSum twoSum = new TwoSum();

foreach (var data in twosumData)
{
    int[] twoSumDataResult = twoSum.FinalResult(data, 6);

    if (twoSumDataResult.Count() > 0)
    {
        Console.WriteLine("Test twosum class and reuslt is {0}{1}", twoSumDataResult[0], twoSumDataResult[1]);
    }
    else
    {
        Console.WriteLine("Two sum no matach target data");
    }

}

#endregion