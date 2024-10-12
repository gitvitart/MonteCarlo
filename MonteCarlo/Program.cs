// See https://aka.ms/new-console-template for more information
using System;


using System;


class Program

{

    static void Main()

    {

        int CountGame = 10000;

        int FirstWin = 0;

        int SecondWin = 0;

        int Draw = 0;

        int FirstWinRound=0;
        int SecondWinRound=0;

        Random random = new Random();


        string[] Action = { "камень", "ножницы", "бумага" };

        for (int i = 0; i < CountGame; i++)
        {
            string SecondAction = Action[random.Next(3)];
            while ((FirstWin < 2) || (SecondWin < 2))
            {
                string FirstAction = Action[random.Next(3)];

                if ((FirstAction == "камень" && SecondAction == "ножницы") ||

                        (FirstAction == "ножницы" && SecondAction == "бумага") ||

                        (FirstAction == "бумага" && SecondAction == "камень"))

                {

                    FirstWin++;

                    if (FirstAction == "камень")
                    {
                        SecondAction = "";
                    }
                    else if (FirstAction == "ножницы")
                    {
                        SecondAction = "камень";
                    }
                    else { SecondAction = "ножницы"; }

                }




                else if ((SecondAction == "камень" && FirstAction == "ножницы") ||

                         (SecondAction == "ножницы" && FirstAction == "бумага") ||

                         (SecondAction == "бумага" && FirstAction == "камень"))

                {
                    SecondWin++;

                    if (FirstAction == "камень")
                    {
                        SecondAction = "камень";
                    }
                    else if (FirstAction == "ножницы")
                    {
                        SecondAction = "ножницы";
                    }
                    else { SecondAction = "бумага"; }



                }

                else

                {

                    Draw++;
                    if (FirstAction == "камень")
                    {
                        SecondAction = "ножницы";
                    }
                    else if (FirstAction == "ножницы")
                    {
                        SecondAction = "бумага";
                    }
                    else { SecondAction = "камень"; }


                }
            }


            if (FirstWin > SecondWin)
            {
                FirstWinRound++;
            }
            else
            {
                SecondWinRound++;
            }
            FirstWin = 0;
            SecondWin = 0;

        }
        if (SecondWin == 0)






        Console.WriteLine("Вероятность выигрыша для каждого действия:");

        Console.WriteLine($"Количество побед первого игрока {FirstWinRound / (double)CountGame}");

        Console.WriteLine($"Количество побед первого игрока {FirstWinRound}");


        Console.WriteLine($"Количество побед второго игрока {SecondWinRound / (double)CountGame}");
        Console.WriteLine($"Количество побед второго игрока {SecondWinRound}");
        

    }

}


////            while ((FirstWin < 2) || (SecondWin < 2))
////            {
////                string FirstAction = Action[random.Next(3)];

////                if ((FirstAction == "камень" && SecondAction == "ножницы") ||

////                        (FirstAction == "ножницы" && SecondAction == "бумага") ||

////                        (FirstAction == "бумага" && SecondAction == "камень"))

////                {

////                    FirstWin++;

////                    if (FirstAction == "камень")
////                    {
////                        SecondAction = "бумага";
////                    }
////                    else if (FirstAction == "ножницы")
////                    {
////                        SecondAction = "камень";
////                    }
////                    else { SecondAction = "ножницы"; }

////                }




////                else if ((SecondAction == "камень" && FirstAction == "ножницы") ||

////                         (SecondAction == "ножницы" && FirstAction == "бумага") ||

////                         (SecondAction == "бумага" && FirstAction == "камень"))

////                {
////                    SecondWin++;

////                    if (FirstAction == "камень")
////                    {
////                        SecondAction = "камень";
////                    }
////                    else if (FirstAction == "ножницы")
////                    {
////                        SecondAction = "ножницы";
////                    }
////                    else { SecondAction = "бумага"; }



////                }

////                else

////                {

////                    Draw++;
////                    if (FirstAction == "камень")
////                    {
////                        SecondAction = "ножницы";
////                    }
////                    else if (FirstAction == "ножницы")
////                    {
////                        SecondAction = "бумага";
////                    }
////                    else { SecondAction = "камень"; }


////                }
////            }


////            if (FirstWin > SecondWin)
////            {
////                FirstWinRound++;
////            }
////            else
////            {
////                SecondWinRound++;
////            }
////            FirstWin = 0;
////            SecondWin = 0;

////        }
////            //if (SecondWin == 0)                    






////        Console.WriteLine("Вероятность выигрыша для каждого действия:");

////        Console.WriteLine($"Количество побед первого игрока {FirstWinRound/ (double)CountGame}");

////        Console.WriteLine($"Количество побед первого игрока {FirstWinRound}");


////        Console.WriteLine($"Количество побед второго игрока {SecondWinRound / (double)CountGame}");
////        Console.WriteLine($"Количество побед второго игрока {SecondWinRound}");
////        //Console.WriteLine($"Бумага: {выигрыш_бумага / (double)количество_игр}");

////    }

////}