using System.Diagnostics.Metrics;
using System.Security.Cryptography;

string LabyEnsorceler = "╔═════════╦════╦════════════════════════╥════════╗" +//0 a 49
                        "║░░░░░░░░░╢░░░░║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║" +//50 a 99
                        "║░░░░░░░░░╠════╝░░░░╔════╗░░░══════════╗░░░░░║░░░║" +//100 a 149
                        "║░░░░S░░░░║░░░░░░░░░║░░░░║░░░░░░░░░░░░░║░░░░░║░░░║" +//150 a 199
                        "║░░░░░░░░░║░░░░░░░░░║░░░░╚═════════════╣░░░░░║░░░║" +//200 a 249
                        "║░░░░░░░░░║░░░░╔════╣░░░░░░░░░░░░░░░░░░║░░░░░║░░░║" +//250 a 299
                        "╠═════════╝░░░░║░░░░╚═════════════╗░░░░║░░░░░║░░░║" +//300 a 349
                        "║░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░░░║░░░░░░░░░░║░░░║" +//350 a 399
                        "▒░░░╔════════╦═╩═════░░░░════╦════╣░░░╔══════╣░░░║" +//400 a 449
                        "║░░░║░░░░░░░░║░░░░░░░░░░░░░░░║░░░░╠═══╝░░░░░░║░░░║" +//450 a 499
                        "║░░░║░░╔══╗░░║░░░░░╔══╦═╥═╦══╣░░░░║░░░░░░░░░░║░░░║" +//500 a 549
                        "║░░░║░░║██║░░║░░░░░║██║░░░║██║░░░░║░░░░╔════╧╣░░░║" +//550 a 599
                        "║░░░╚┬═╩══╩╨═╣░░░░░║██║░░░║██║░░░░║░░░░║████S║░░░║" +//600 a 649
                        "║░░░░░░░░░░░░║░░░░░║██║░░░║██║░░░░║░░░░╚═════╝░░░║" +//650 a 699
                        "║░░░░╔═══╗░░░║░░░░░║██║░░░║██║░░░░░░░░░░░░░░░░░░░║" +//700 a 749
                        "║░░░░╚═══╝░░░║░░░░░╚══╩═══╩══╩══╦════════════════╣" +//750 a 799
                        "║░░░░░░░░░░░░║░░░░░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░▒" +//800 a 849
                        "╚════════════╩══════════════════╩════════════════╝";//850 a 899

const int LongueurX = 899,
          HauteurY = 18,
          Entrée = 400,
          Sortie = 849;

int PositionJoueur = Entrée;
int Murs = 0,
    Position = 0;

/*while(PositionJoueur == Murailles)*/
while (LabyEnsorceler.Length == Position)
{
    if ((LabyEnsorceler[Position] == '╔') | (LabyEnsorceler[Position] == '╗') | (LabyEnsorceler[Position] == '╝') | (LabyEnsorceler[Position] == '╚') | (LabyEnsorceler[Position] == '║') | (LabyEnsorceler[Position] == '═') | (LabyEnsorceler[Position] == '█') | (LabyEnsorceler[Position] == '╣') | (LabyEnsorceler[Position] == '╦') | (LabyEnsorceler[Position] == '╩') | (LabyEnsorceler[Position] == '╠'))
    {
        Murs++;
        Position++;
    }
    else { Position++; }
}

Main();

void Intro()
{
    Console.WriteLine("Bienvenue");
    Console.WriteLine("Appuie sur une touche pour embarquer...");
    Console.ReadKey();
    Console.WriteLine();
}

void Main()
{
    Intro();

    string FormeJoueur = "■";
    

    while(PositionJoueur != Sortie)
    {
        Input();
        DrawLaby();
    }

}

void DrawLaby()
{
    Console.WriteLine("╔═════════╦════╦════════════════════════╥════════╗\n" +//0 a 49
                            "║░░░░░░░░░╢░░░░║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║\n" +//50 a 99
                            "║░░░░░░░░░╠════╝░░░░╔════╗░░░══════════╗░░░░░║░░░║\n" +//100 a 149
                            "║░░░░S░░░░║░░░░░░░░░║░░░░║░░░░░░░░░░░░░║░░░░░║░░░║\n" +//150 a 199
                            "║░░░░░░░░░║░░░░░░░░░║░░░░╚═════════════╣░░░░░║░░░║\n" +//200 a 249
                            "║░░░░░░░░░║░░░░╔════╣░░░░░░░░░░░░░░░░░░║░░░░░║░░░║\n" +//250 a 299
                            "╠═════════╝░░░░║░░░░╚═════════════╗░░░░║░░░░░║░░░║\n" +//300 a 349
                            "║░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░░░║░░░░░░░░░░║░░░║\n" +//350 a 399
                            "▒░░░╔════════╦═╩═════░░░░════╦════╣░░░╔══════╣░░░║\n" +//400 a 449
                            "║░░░║░░░░░░░░║░░░░░░░░░░░░░░░║░░░░╠═══╝░░░░░░║░░░║\n" +//450 a 499
                            "║░░░║░░╔══╗░░║░░░░░╔══╦═╥═╦══╣░░░░║░░░░░░░░░░║░░░║\n" +//500 a 549
                            "║░░░║░░║██║░░║░░░░░║██║░░░║██║░░░░║░░░░╔════╧╣░░░║\n" +//550 a 599
                            "║░░░╚┬═╩══╩╨═╣░░░░░║██║░░░║██║░░░░║░░░░║████S║░░░║\n" +//600 a 649
                            "║░░░░░░░░░░░░║░░░░░║██║░░░║██║░░░░║░░░░╚═════╝░░░║\n" +//650 a 699
                            "║░░░░╔═══╗░░░║░░░░░║██║░░░║██║░░░░░░░░░░░░░░░░░░░║\n" +//700 a 749
                            "║░░░░╚═══╝░░░║░░░░░╚══╩═══╩══╩══╦════════════════╣\n" +//750 a 799
                            "║░░░░░░░░░░░░║░░░░░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░▒\n" +//800 a 849
                            "╚════════════╩══════════════════╩════════════════╝\n");
    Console.WriteLine("Le Joueur est a la position " + PositionJoueur);
}
void Input()
{
    ConsoleKeyInfo c = Console.ReadKey(true);
    ConsoleKey Right = c.Key,
               Left = c.Key,
               Up = c.Key,
               Down = c.Key,
               Enter = c.Key;

    if (Right == ConsoleKey.RightArrow) { PositionJoueur = PositionJoueur + 1; }
    if (Left == ConsoleKey.LeftArrow) { PositionJoueur = PositionJoueur - 1; }
    if (Up == ConsoleKey.UpArrow) { PositionJoueur = PositionJoueur - 50; }
    if (Down == ConsoleKey.DownArrow) { PositionJoueur = PositionJoueur + 50; }
}

/*void Murailles()
{
    
}

if (Right == ConsoleKey.RightArrow) { PositionJoueur = PositionJoueur + 1;
        if (PositionJoueur == LabyEnsorceler[Murs]) { PositionJoueur = PositionJoueur+0; } }
 */
