// Напишите программу, которая на вход принимает
// пятизначное число и проверяет, является ли оно палиндромом.


Console.Write ("Пятизначное число ");
int N=int.Parse(Console.ReadLine());
if (N>99999 || N<10000) {
  Console.Write ("Введено не верное число ");
  return;
} 
int x1 = N/10000;
int x02=N/1000; int x2 = x02%10;
int x04 = N/10; int x4=x04%10;
int x5 = N%10;
if (x1==x5 && x2==x4){
Console.WriteLine ("Число является палиндромом");
}
else Console.WriteLine ("Число не является палиндромом" );



// int i = 1;
// int m=N; 
// if (N<0)
// {
//   i=N;
//   m=-N;
//   N=-1;
// }
// int []result = new int [m];
// int j=0;
// for (; i<N; i++)
// {
//   result [j]=i*i;
//   j++;
// }
// for (j=0; j<m; j++)
// {
//   Console.Write($"{result[j]} ");
// }