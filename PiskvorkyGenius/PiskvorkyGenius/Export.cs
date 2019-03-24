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
        public static void WriteToTxt(int lenght, int points, int players, int tick1, int tick2, int tick3, int tick4, int last)
        {
            string[,] HraciaPlocha = new string[lenght, lenght];
            HraciaPlocha = Logika.GetGameboard(lenght);
            StringBuilder sb = new StringBuilder();
            sb.Append(lenght);  //veľkosť poľa
            sb.AppendLine();
            sb.Append(points);  //počet bodov na koľko sa hrá
            sb.AppendLine();
            sb.Append(players); //počet aktívnych hráčov
            sb.AppendLine();
            sb.Append(tick1); //znak hráča 1
            sb.AppendLine();
            sb.Append(tick2); //znak hráča 2
            sb.AppendLine();
            sb.Append(tick3); //znak hráča 3
            sb.AppendLine();
            sb.Append(tick4); //znak hráča 4
            sb.AppendLine();
            sb.Append(last); //posledný hráč ktorý urobil tick
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
        /// Načítam textový dokument s informáciou koľko bodov potrebujem k výhre
        /// </summary>
        public static int ReadFromTxtPlayers()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int points = int.Parse(import[2]);
            Debug.WriteLine($"Počet aktívnych hráčov: {points}");
            return points;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou o znaku hráča č.1
        /// </summary>
        public static int ReadFromTxtPlayer1tick()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int tick = int.Parse(import[3]);
            return tick;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou o znaku hráča č.2
        /// </summary>
        public static int ReadFromTxtPlayer2tick()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int tick = int.Parse(import[4]);
            return tick;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou o znaku hráča č.3
        /// </summary>
        public static int ReadFromTxtPlayer3tick()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int tick = int.Parse(import[5]);
            return tick;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou o znaku hráča č.4
        /// </summary>
        public static int ReadFromTxtPlayer4tick()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int tick = int.Parse(import[6]);
            return tick;
        }

        /// <summary>
        /// Načítam textový dokument s informáciou poslednom hráčovi
        /// </summary>
        public static int ReadFromTxtLastPlayerTick()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");

            //dlžka pola - premenna
            int lasttick = int.Parse(import[7]);
            return lasttick;
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
            for (int i = 8; i < lenght+8; i++)
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
            string c="";
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
            int lenght = int.Parse(import[0]);
            //vytiahnem si znak. ku i som pridal 8(1.pozicia je veľkosť pola)(2.pozícia je počet bodov)
            return c = import[i+8][j].ToString();
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
