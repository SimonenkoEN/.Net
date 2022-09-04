// void PrintRandMatrix(int[,] inMatrix)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < inMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inMatrix.GetLength(1); j++)
//         {
//             inMatrix[i, j] = rnd.Next(0, 2);
//             Console.Write(inMatrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
                Console.Write(" ");
            else
                Console.Write("█");
        }
        Console.WriteLine();
    }
}

int[,] FillImage(int[,] pic, int row, int col)
{
     int[,] outPic = new int[pic.GetLength(0),pic.GetLength(1)];
     outPic = pic;
     if(outPic[row,col] == 0)
    {
        outPic[row,col] = 1;
        FillImage(outPic, row-1, col);
        FillImage(outPic, row, col-1);
        FillImage(outPic, row+1, col);
        FillImage(outPic, row, col+1);
    }
    return outPic;
}

int[,] matrix = 
{
    { 0,0,0,0,1,1,1,1,1,0,0,0,1,1,1,1,1,0,0,0,0},
    { 0,0,1,1,0,0,0,0,0,1,0,1,0,0,0,0,0,1,1,0,0},
    { 0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0},
    { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    { 0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0},
    { 0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0},
    { 0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0},
    { 0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0},
    { 0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0}
};
// PrintRandMatrix(matrix);
// Console.WriteLine();
PrintImage(matrix);
PrintImage(FillImage(matrix, 5, 5));