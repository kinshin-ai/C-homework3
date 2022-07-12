// sdfsd
Console.Write("введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
    {
    int i = 1;
    int length = cube.Length;
    while (i < length)
        {
            cube[i] = Convert.ToInt32(Math.Pow(i, 3));
            Console.Write(cube[i]+" ");
            i++;
        }
    }
int[] arry = new int[cube+1];
Cube(arry);