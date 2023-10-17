/*
Console.WriteLine(" ╔═════════╦════╦════════════════════════╤════════╗ \n" +
                  " ║░░░░░░░░░╢░░░░║░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░║ \n" +
                  " ║░░░░░░░░░╠════╝░░░░╔════╗░░░══════════╗░░░░░║░░░║ ░ : Sol\n" +
                  " ║░░░░S░░░░║░░░░░░░░░║░░░░║░░░░░░░░░░░░░║░░░░░║░░░║ \n" +
                  " ║░░░░░░░░░║░░░░░░░░░║░░░░╚═════════════╣░░░░░║░░░║ █ : Murs Plein\n" +
                  " ║░░░░░░░░░║░░░░╔════╣░░░░░░░░░░░░░░░░░░║░░░░░║░░░║ \n" +
                  " ╠═════════╝░░░░║░░░░╚═════════════╗░░░░║░░░░░║░░░║ ║ : Murs\n" +
                  " ║░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░░░║░░░░░░░░░░║░░░║ \n" +
                  "→░░░░╔════════╦═╩═════░░░░════╦════╣░░░╔══════╣░░░║ ┬ : Porte semi-invisible\n" +
                  " ║░░░║░░░░░░░░║░░░░░░░░░░░░░░░║░░░░╠═══╝░░░░░░║░░░║ \n" +
                  " ║░░░║░░╔══╗░░║░░░░░╔══╦═╤═╦══╣░░░░║░░░░░░░░░░║░░░║ ╤ : Porte Piége\n" +
                  " ║░░░║░░║██║░░║░░░░░║██║░░░║██║░░░░║░░░░╔════╧╣░░░║ \n" +
                  " ║░░░╚┬═╩══╩╧═╣░░░░░║██║░░░║██║░░░░║░░░░║████S║░░░║ ╧S : Porte Invisible Secret\n" +
                  " ║░░░░░░░░░░░░║░░░░░║██║░░░║██║░░░░║░░░░╚═════╝░░░║ \n" +
                  " ║░░░░╔═══╗░░░║░░░░░║██║░░░║██║░░░░░░░░░░░░░░░░░░░║ → : Entrée/Sortie\n" +
                  " ║░░░░╚═══╝░░░║░░░░░╚══╩═══╩══╩══╦════════════════╣ \n" +
                  " ║░░░░░░░░░░░░║░░░░░░░░░░░░░░░░░░┤░░░░░░░░░░░░░░░░░→ S : Secret\n" +
                  " ╚════════════╩══════════════════╩════════════════╝ \n");

//Tableau des differentes affectation
string[] Info = new string[] { "╔", "╗", "╝", "╚", "║", "═", "█", "░", "╤", "┬", "┤", "╧", "╣", "╦", "╩", "╠", "╢", "■" };
int[] Info[4] = { "x1, y2", "x1, y3", "x1, y4", "x1, y5", "x1, y6", "x1, y7", "x1, y8", "x1, y9", "x1, y11" };
string Joueur = "■";

int[] Murs = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,+
              31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,60,65,99,100,110,111,112,+
              113,114,115,120,121,122,123,124,125,129,130,131,132,133,134,135,136,137,138,139,145,+
              149,150,160,170,175,189,195,199,200,210,220,225,226,227,228,229,230,231,232,233,234,+
              235,236,237,238,239,245,249,250,260,265,266,267,268,269,270,289,295,299,300,301,302,+
              303,304,305,306,307,308,309,310,315,320,321,322,323,324,325,326,327,328,329,330,331,+
              332,333,334,339,345,349,350,384,395,399,404,405,406,407,408,409,410,411,412,413,414,+
              415,416,417,418,419,420,425,426,427,428,429,430,431,432,433,434,445,449,450,454,463,+
              479,484,488,495,499,500,504,507,508,509,510,513,519,529,534,545,549,550,554,557,558,+
              559,560,563};

switch (Joueur)
{
    case (Fleche droite)
        Joueur == PositionDeDroite
            if(PositionDeDroite == Info[4] | Info[5])
        {
            Joueur n'avance pas;
        }
        else
        {
            Joueur avance;
        }
            if (PositionDeDroite == Info[10])
        {
            Joueur avance;
        }
    break;
    case (Fleche haut)
        Joueur == PositionDuHaut
    break;
    case (Fleche Gauche)
        Joueur == PositionDeGauche
    break;
    case (Fleche bas)
        Joueur == PositionDuBas
    break;
}

if (Right == ConsoleKey.RightArrow)
        {
            if (PositionJoueur == Murs)
            {
                PositionJoueur = PositionJoueur + 0;
            }
            else { PositionJoueur = PositionJoueur + 1; }
        }
        if (Left == ConsoleKey.LeftArrow)
        {
            if (PositionJoueur == Murs)
            {
                PositionJoueur = PositionJoueur - 0;
            }
            else { PositionJoueur = PositionJoueur - 1; }
        }
        if (Up == ConsoleKey.UpArrow)
        {
            if (PositionJoueur == Murs)
            {
                PositionJoueur = PositionJoueur - 0;
            }
            else { PositionJoueur = PositionJoueur - 50; }
        }
        if (Down == ConsoleKey.DownArrow)
        {
            if (PositionJoueur == Murs)
            {
                PositionJoueur = PositionJoueur + 0;
            }
            else { PositionJoueur = PositionJoueur + 50; }
        }


*/
