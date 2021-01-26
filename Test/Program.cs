using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int n, m, k;
            int[] a;
            //read stdin
            {
                var line1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                n = line1[0]; //object count
                m = line1[1]; //box count
                k = line1[2]; //box size

                //1-based array because the requirements say so
                a = new int[n + 1];
                //Copy the input line to the `array` 
                var index = 1;
                foreach (var item in Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
                    a[index++] = item;

                //We could do all this with a blank slot in the beginning but the requirements don't specifically allow it,
                //Even though they do dictate how to index it.
            }

            //compute the results

            var maxObj = 0;

            {
                //iterate all possible starting points for packaging
                for (var j = 1; j <= n; j++)
                {
                    var putObjects = 0;
                    var unusedBoxes = m;
                    var unusedSize = 0;
                    //iterate through objects to determine which can fit in the box
                    for (var index = j; index <= n; index++)
                    {
                        //will it overflow?
                        if (a[index] > unusedSize)
                        {
                            //grab a new box and put it in
                            unusedBoxes--;
                            unusedSize = k - a[index];
                            //are we out of boxes?
                            if (unusedBoxes == -1)
                                break;
                            putObjects++;
                        }
                        else
                        {
                            //put it in the current box
                            unusedSize -= a[index];
                            putObjects++;
                        }
                    }
                    //Did we get a better result this time?
                    maxObj = Math.Max(maxObj, putObjects);
                }
            }

            //print the results
            {
                Console.WriteLine(maxObj);
            }
        }
    }
}
