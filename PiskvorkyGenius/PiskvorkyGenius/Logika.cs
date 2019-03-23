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
        private static int _pocetHracov;
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

            //vynulujem counter
            bod = 0;

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
                            Debug.Write($"\nBody v riadku{i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva");
                            return true;
                        }
                        else
                        {
                            continue;
                            return false;
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
                            Debug.Write($"\nBody v stĺpci{i}: {bod}");
                            lastTick = tick;
                        }
                        else
                        {
                            lastTick = "";
                        }
                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva");
                            return true;
                        }
                        else
                        {
                            continue;
                            return false;
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
                                Debug.Write($"\nBody v diagonale L-P{i}: {bod}");
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
                            Debug.Write($"\nHráč: {tick} vyhráva");
                            return true;
                        }
                        else
                        {
                            continue;
                            return false;
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
                                Debug.Write($"\nBody v diagonale P-L{i}: {bod}");
                            }
                            else
                            {
                                break;
                            }
                            k++;
                            l--;
                        } while (k < lenght && l < lenght);

                        //Zistovanie či hráč vyhral alebo nie
                        if (bod == body)
                        {
                            Debug.Write($"\nHráč: {tick} vyhráva");
                            return true;
                        }
                        else
                        {
                            continue;
                            return false;
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
       
    }
}

