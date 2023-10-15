namespace HomeWork2 {
    internal class Program {
        private static void Main(string[] args) {
            if(args.Length == 0) {

                //Дан двумерный массив.
                //732
                //496
                //185

                //Отсортировать данные в нем по возрастанию.
                //123
                //456
                //789

                //Вывести результат на печать.

                int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

                void printMatrix(int[,] matrix) {
                    for (int i = 0; i < matrix.GetLength(0); i++) {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                            Console.Write($"{matrix[i, j]}\t");
                        Console.WriteLine($"\n");
                    }
                }

                int[] getArrayByMAtrix(int[,] matrix) {
                    int[] array = new int[9];
                    int z = 0;
                    for (int i = 0; i < a.GetLength(0); i++)
                        for (int j = 0; j < a.GetLength(1); j++) {
                            array[z] = a[i, j];
                            z++;
                        }
                    return array;
                }

                void printArraySTR(int[] array) {
                    string arraySTR = string.Join(" ", array);
                    Console.WriteLine(arraySTR);
                }

                int[] sortArray(int[] array) {
                    /*for (int i = 0; i < array.Length; i++) { }
                    int[] result = array.OrderBy(i => i).ToArray();
                    for (int i = 0; i < result.Length; i++) { }*/
                    Array.Sort(array);
                    return array;
                }

                int[,] getMatrixByArray(int[] array) {
                    int[,] sortMatrix = new int[3, 3];
                    int k = 0;
                    for (int i = 0; i < sortMatrix.GetLength(0); i++) {
                        for (int j = 0; j < sortMatrix.GetLength(1); j++) {
                            sortMatrix[i, j] = array[k];
                            k++;
                        }
                    }
                    return sortMatrix;
                }

                Console.WriteLine("Дан двумерный массив:");
                printMatrix(a);
                int[] myArray = getArrayByMAtrix(a);
                Console.WriteLine("Преобразовали в одномерный массив:");
                printArraySTR(myArray);
                int[] mySortArray = sortArray(myArray);
                Console.WriteLine("Отсортировали одномерный массив:");
                printArraySTR(mySortArray);
                Console.WriteLine("Отсортированный по возрастанию двумерный массив:");
                int[,] sortMatrix = getMatrixByArray(mySortArray);
                printMatrix(sortMatrix);

            } else {
                Console.WriteLine("Don't need args");
            }
        }
    }
}