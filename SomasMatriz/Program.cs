int[,] somas = new int[5, 5]
{
    { 1, 2, 3, 4, 5 },
    { 6, 7, 8, 9, 10 },
    { 11, 12, 13, 14, 15 },
    { 16, 17, 18, 19, 20 },
    { 21, 22, 23, 24, 25 }
};

int somaLinha = 0;
int somaColuna = 0;
int somaDiagonalPrincipal = 0;
int somaDiagonalSecundaria = 0;

for(int i = 0;i < 5;i++)
{
    for(int j = 0;j < 5;j++)
    {
        somaLinha += somas[i, j];
    }
    Console.WriteLine("As somas da linha" + (i + 1) + " :" + somaLinha);
    somaLinha = 0;
}

for(int j = 0;j < 5;j++)
{
    for(int i = 0;i < 5; i++)
    {
        somaColuna += somas[i, j];
    }
    Console.WriteLine("A soma da coluna" + (j+1) + " :" + somaColuna);
    somaColuna = 0;
}

for(int i = 0;i < 5;i++)
{
    somaDiagonalPrincipal += somas[i, i];
}
Console.WriteLine("A soma da diagonal principal é: " + somaDiagonalPrincipal);

for(int i =0;i < 5;i++)
{
    somaDiagonalSecundaria += somas[i, i];
}
Console.WriteLine("A soma da diagonal secundaria é: " + somaDiagonalSecundaria);
