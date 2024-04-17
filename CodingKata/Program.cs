// See https://aka.ms/new-console-template for more information

using CodingKata;

Console.WriteLine(HelloWorld.Hello());

var testArray = new[] { 0, 0, 1, 1, 2, 2, 3, 3, 3, 4 };

var result = RemoveDuplicates(testArray);
Console.WriteLine(result);
return;

int RemoveDuplicates(IReadOnlyList<int> nums)
{
    var expectedNums = Array.Empty<int>();
    var currentIndex = 0;

    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] == nums[i + 1]) continue;
        expectedNums[currentIndex] = nums[i];
        currentIndex++;
    }

    return expectedNums.Length;
}