namespace ConsoleApp32
{
    internal class Program
    {
        public static void MergeSort(List<Workers> workers)
        {
            if (workers.Count <= 1)
                return;

            int mid = workers.Count / 2;
            List<Workers> left = new List<Workers>(workers.GetRange(0, mid));
            List<Workers> right = new List<Workers>(workers.GetRange(mid, workers.Count - mid));

            MergeSort(left);
            MergeSort(right);

            Merge(workers, left, right);
        }

        private static void Merge(List<Workers> workers, List<Workers> left, List<Workers> right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].Salary <= right[j].Salary)
                {
                    workers[k] = left[i];
                    i++;
                }
                else
                {
                    workers[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Count)
            {
                workers[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Count)
            {
                workers[k] = right[j];
                j++;
                k++;
            }
        }

        static void Main()
        {
            List<Workers> workers = new List<Workers>
        {
            new Workers("Ivan", 2500),
            new Workers("Petar", 3500),
            new Workers("Anna", 2000),
            new Workers("Maria", 4000),
            new Workers("Georgi", 2800)
        };

            Console.WriteLine("Before sorting:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            MergeSort(workers);

            Console.WriteLine("\nAfter sorting by salary:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}

    
