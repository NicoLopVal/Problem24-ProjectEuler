List<string> combinations = new List<string>();

for (int i0 = 0; i0 < 10; i0++)
{
    for (int i1 = 0; i1 < 10; i1++)
    {
        for (int i2 = 0; i2 < 10; i2++)
        {
            for (int i3 = 0; i3 < 10; i3++)
            {
                for (int i4 = 0; i4 < 10; i4++)
                {
                    for (int i5 = 0; i5 < 10; i5++)
                    {
                        for (int i6 = 0; i6 < 10; i6++)
                        {
                            for (int i7 = 0; i7 < 10; i7++)
                            {
                                for (int i8 = 0; i8 < 10; i8++)
                                {
                                    for (int i9 = 0; i9 < 10; i9++)
                                    {
                                        if (i0 != i1 && i1 != i2 && i2 != i3 && i3 != i4 && i4 != i5 && i5 != i6 && i6 != i7 && i7 != i8 && i8 != i9 &&
                                            i0 != i2 && i1 != i3 && i2 != i4 && i3 != i5 && i4 != i6 && i5 != i7 && i6 != i8 && i7 != i9 &&
                                            i0 != i3 && i1 != i4 && i2 != i5 && i3 != i6 && i4 != i7 && i5 != i8 && i6 != i9 &&
                                            i0 != i4 && i1 != i5 && i2 != i6 && i3 != i7 && i4 != i8 && i5 != i9 &&
                                            i0 != i5 && i1 != i6 && i2 != i7 && i3 != i8 && i4 != i9 &&
                                            i0 != i6 && i1 != i7 && i2 != i8 && i3 != i9 &&
                                            i0 != i7 && i1 != i8 && i2 != i9 &&
                                            i0 != i8 && i1 != i9 &&
                                            i0 != i9)
                                        {
                                            string combination = i0.ToString() + i1.ToString() + i2.ToString() + i3.ToString() + i4.ToString() +
                                                i5.ToString() + i6.ToString() + i7.ToString() + i8.ToString() + i9.ToString();
                                            combinations.Add(combination);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

var orderedCombinations = combinations.OrderBy(combination => combination.ToString()).Skip(1000000 - 1).Take(1);
foreach (string item in orderedCombinations)
{
    Console.WriteLine(item);
}