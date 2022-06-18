﻿// Specify the data sourse.
int[] numbers = new int[] { 2, 3, 4, 5 };

// Define the query expression.
IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => 10 * x);

// Execute the query.
foreach (int x in result)
{
    Console.WriteLine(x);
}

