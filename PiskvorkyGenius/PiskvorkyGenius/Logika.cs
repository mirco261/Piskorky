using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PiskvorkyGenius
{
    public static class Logika
    {
        public static int PocetHracov;
        public static string[,] Gameboard;
        public static int bod;
        public static string lastTick;



        public static void CreateGameboard(int _playArea)
        {
            string[,] HraciaPlocha = new string[_playArea, _playArea];
            Gameboard = HraciaPlocha;
            for (int i = 0; i < _playArea; i++)
            {
                for (int j = 0; j < _playArea; j++)
                {
                    Gameboard[i, j]=" ";
                }
            }
        }



        public static void AddTick(int lenght, int RowIndex, int ColIndex, string tick)
        {
            //vloženie ticku
            Gameboard[RowIndex, ColIndex] = tick;

            //zobrazenie v debug
            Debug.Write($"\n\nHráč: {tick}\n");
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Debug.Write(Gameboard[i, j]);
                }
                Debug.Write("\n");
            }
        }

        public static bool CheckWin(int lenght, string tick, int body)
        {
            //Zadefinovanie
            lastTick = tick;

            //Zistovanie vyhry po riadkoch
            #region
            //prechádzam riadky
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        if (lastTick == tick)
                        {
                            bod++;
                            Debug.Write($"\nBody v riadku {i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Zistovanie vyhry po stĺpcoch
            #region 
            //prechádzam riadky
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[j, i] == tick)
                    {
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        if (lastTick == tick)
                        {
                            bod++;
                            Debug.Write($"\nBody v stĺpci {i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Zistovanie vyhry po diagonále zľava doprava
            #region 
            for (int i = 0 ; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {
                        int k = i;
                        int l = j;
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        do
                        {
                            //Prepožičal som hodnoty kde sa nachádza aktuálne check a pozerám, či sa vpravo dole diagonálne nič nenachádza
                            if (Gameboard[k, l] == tick)
                            {
                                bod++;
                                Debug.Write($"\nBody v diag L {i}: {bod}");
                            }
                            else
                            {
                                break;
                            }
                            k++;
                            l++;
                        } while (k< lenght && l<lenght);

                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Zistovanie vyhry po diagonále sprava dolava
            #region 
            for (int i = 0; i < lenght; i++)
            {
                //prechádzam jednotlivé stĺpce
                for (int j = 0; j < lenght; j++)
                {
                    //zisťujem, či sa v políčku nachádza znak hráča
                    if (Gameboard[i, j] == tick)
                    {
                        int k = i;
                        int l = j;
                        //ak sa nachádza na predchádzajúcom políčku znak hráča, pridám mu bod
                        do
                        {
                            //Prepožičal som hodnoty kde sa nachádza aktuálne check a pozerám, či sa vpravo dole diagonálne nič nenachádza
                            if (Gameboard[k, l] == tick)
                            {
                                bod++;
                                Debug.Write($"\nBody v diag P {i}: {bod}");
                            }
                            else
                            {
                                break;
                            }
                            k++;
                            l--;
                        } while (k < lenght && l < lenght && l >= 0);

                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva\n");
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        bod = 0;
                    }
                }
            }
            #endregion

            //Nulovanie bodov po každom riadku
            bod = 0;
            lastTick = "";
            return false;
        }

        public static void WriteToTxt(int lenght)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(lenght);
            sb.AppendLine();
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    sb.Append(Gameboard[i,j]);
                }
                sb.Append("\n");

            }
            Debug.Write($"\nZapisujem export: \n{ sb}\n");
            string export = sb.ToString();
            System.IO.File.WriteAllText(@"C:\Users\Public\Documents\piskvorky.txt", export);
        }

        /// <summary>
        /// Načítam textový dokument a naplním si logickú vrstvu dátami
        /// </summary>
        public static void ReadFromTxt()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
            int lenght = int.Parse(import[0]);
            Debug.WriteLine($"Dľžka poľa: {lenght}");

            //vytvorim gameboard
            CreateGameboard(lenght);

            //naplním si gameboard
            for (int i = 1; i <= lenght; i++)
            {
                Debug.WriteLine($"Importný riadok {i} = {import[i]}");
                for (int j = 0; j < lenght; j++)
                {
                    Gameboard[i-1, j] = (import[i][j]).ToString();
                    Debug.WriteLine($"Riadok {i} znaky {Gameboard[i-1,j]}");
                }
            }
        }

        /// <summary>
        /// Načítam si veľkosť poľa
        /// </summary>
        /// <returns>veľkosť poľa</returns>
        public static int ReadFromTxtLenght()
        {
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
            int lenght = int.Parse(import[0]);
            return lenght;
        }

        public static string ReadFromTxtTicks(int i, int j)
        {
            string c;
            string[] import = System.IO.File.ReadAllLines(@"C:\Users\Public\Documents\piskvorky.txt");
            return c = Gameboard[i, j];
        }

        //Do output logu si preverím, či mi načítalo zo súboru hraciu plochu
        public static void debug(int lenght)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    sb.Append(Gameboard[i, j]);
                }
                sb.Append("\n");

            }
            Debug.Write($"\nNačítal som z txt: \n{ sb}\n");
        }
    }
}

