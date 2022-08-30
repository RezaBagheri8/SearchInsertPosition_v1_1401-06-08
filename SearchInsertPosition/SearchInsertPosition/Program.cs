using SearchInsertPosition;
int[] array = { 0, 1, 2, 3, 7, 10, 100 };

Solution solution = new Solution();

var result = solution.RecursiveFind(array, 0, array.Length - 1, 3);

Console.WriteLine(result);