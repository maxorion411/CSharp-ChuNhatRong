using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ve_Hinh_Chu_Nhat_Rong
{
 class Program
 {
 static void Main(string[] args)
 {
 // Ve hinh chu nhat rong trong C#
 Console.Write("Moi ban nhap vao chieu dai: ");
 int cd = int.Parse(Console.ReadLine());
 Console.Write("Moi ban nhap vao chieu rong: ");
 int cr = int.Parse(Console.ReadLine());
 // In canh ngan
 for (int stt_cr = 1; stt_cr <= cr; stt_cr++)
 {
 // In canh dai
 for (int stt_cd = 1; stt_cd <= cd; stt_cd++)
 {
 if ((stt_cd == 1) || (stt_cd == cd) || (stt_cr == 1) || (stt_cr == cr))
 {
 Console.Write('*');
 }
 else
 {
 Console.Write(' ');
 }
 }
 Console.WriteLine();
 }
 Console.ReadLine();
 }
 }
}
