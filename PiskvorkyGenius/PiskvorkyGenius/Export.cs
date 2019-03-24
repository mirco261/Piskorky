using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace PiskvorkyGenius
{
    class Export
    {

        /// <summary>
        /// Zapísanie poľa do txt
        /// </summary>
        /// <param name="lenght"></param>
        public static void WriteToTxt(int lenght, int points)
        {
            string[,] HraciaPlocha = new string[lenght, lenght];
            HraciaPlocha = Logika.GetGameboard(lenght);
            StringBuilder sb = new StringBuilder();
            sb.Append(lenght);
            sb.AppendLine();
            sb.Append(points);
            sb.AppendLine();
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    sb.Append(HraciaPlocha[i,j]);
                }
                sb.Append("\n");
            }
           Debug.Write($"\nZapisujem export: \n{sb.ToString()}\n");
            System.IO.File.WriteAllText(@"C:\Users\Public\Documents\piskvorky.txt", sb.ToString());
        }

        /// <summary>
        /// Načítam textový dokument s informáciou aký je veľký grid
        /// </summary>
        public static int ReadFromTxtLenght()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int lenght = int.Parse(import[0]);
            Debug.WriteLine($"Dľžka poľa: {lenght}");
            return lenght;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou koľko bodov potrebujem k výhre
        /// </summary>
        public static int ReadFromTxtPoints()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int points = int.Parse(import[1]);
            Debug.WriteLine($"Počet bodov potrebných k výhre: {points}");
            return points;
        }

        /// <summary>
        /// Načítam textový dokument s poľom znakov
        /// </summary>
        /// <returns></returns>
        public static string ReadFromTxtGrid()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int lenght = int.Parse(import[0]);
            Debug.WriteLine($"Dľžka poľa: {lenght}");

            //Vytvorenie stringu 
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < lenght+2; i++)
            {
                sb.Append(import[i]);
                sb.Append("\n");
            }
            Debug.Write($"posielam tento string\n{sb}");
            return sb.ToString();
        }

        /// <summary>
        /// Načítam textový dokument s poľom znakov
        /// </summary>
        /// <returns></returns>
        //public static string ReadFromTxtGrid(int i, int j)
        //{
        //    string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
        //    string d;
        //    //dlžka pola - premenna
        //    int lenght = int.Parse(import[0]);
        //    Debug.WriteLine($"Dľžka poľa: {lenght}");

        //    return d = import[i][j].ToString();

        //}


        /// <summary>
        /// Vráti mi znak z txt 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static string ReadFromTxtTicks(int i, int j)
        {
            string c;
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
            int lenght = int.Parse(import[0]);
            //vytiahnem si znak. ku i som pridal 2(1.pozicia je veľkosť pola)(2.pozícia je počet bodov)
            return c = import[i+2][j].ToString();
        }

        //Do output logu si preverím, či mi načítalo zo súboru hraciu plochu
        //public static void debug(int lenght)
        //{
        //    string[,] HraciaPlocha = new string[lenght, lenght];
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        for (int j = 0; j < lenght; j++)
        //        {
        //            sb.Append(HraciaPlocha[i, j]);
        //        }
        //        sb.Append("\n");

        //    }
        //    Debug.Write($"\nNačítal som z txt: \n{ sb}\n");
        //}
    }
}
