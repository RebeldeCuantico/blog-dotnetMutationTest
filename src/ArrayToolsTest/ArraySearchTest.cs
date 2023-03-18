using ArrayTools;
using FluentAssertions;

namespace ArrayToolsTest
{
    public class ArrayToolTest
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void CheckArrayFindElement(int[] arr, int valueToFind, int expected)
        {
            var result = ArraySearch.FindIndex(arr, valueToFind);
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { new int[] { 1, 3, 5, 2, 4 }, 2, 3 };
            yield return new object[] { new int[] { 1, 3, 5, 2, 4 }, 4, 4 };
            yield return new object[] { new int[] { 1, 3, 5, 2, 4 }, 9, -1 };
        }
    }
}