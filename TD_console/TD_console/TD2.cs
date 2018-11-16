using System;
namespace TD_console
{
    public class TD2
    {
        // Faites vos tests dans cette méthode
        public TD2()
        {

        }

        // Ne pas modifier cette méthode
        public static void Writer(string methode, string param, string attendu, string resultat)
        {
            Console.WriteLine("Test " + methode + "(" + param + ");\n"
                              + "Résultat attendu : \"" + attendu + "\";\n"
                              + "Résultat : \"" + resultat + "\";\n"
                              + "Test : " + (string.Equals(attendu, resultat) ? "ok" : "echec") + "\n\n");
        }

        // Ne pas modifier cette méthode
        public static void Test()
        {
            Writer("Alphabet_aZ", "none", "aBcDeFgHiJkLmNoPqRsTuVwXyZ", Alphabet_aZ());
            Writer("Position_az", "Je sUiS uN StrinG, S", "6", Position_az("Je sUiS uN StrinG", 'S').ToString());
            Writer("Replace_az", "Je sUiS uN StrinG, i", "Je sUS uN StrnG", Replace_az("Je sUiS uN StrinG", 'i'));
            Writer("River_max_sequence", "42, 100", "42 ; 48 ; 60 ; 66 ; 78 ; 93 ; 105.", River_max_sequence(42, 100));
            Writer("Conway_next", "1211", "111221", Conway_next("1211"));
            Writer("Conway_is_sequence", "1132121", "False", Conway_is_sequence("1132121").ToString());
            Writer("Conway_n_sequence", "7", "\n1\n11\n21\n1211\n111221\n312211\n13112221", "\n" + Conway_n_sequence(7));
            Writer("Conway_delimiter", "3, 5", "\n21\n1211\n111221", "\n" + Conway_delimiter(3, 5));
            Writer("Pyramide", "3", "\n  /*\\\n /***\\\n/*****\\", "\n" + Pyramide(3));
        }

        public static string Alphabet_aZ()
        {
            string alphabet = "";
            // Ne rien modifier au dessus de ce commentaire
            int a = 0;
            for (char i = 'a'; i <= 'z';i++){
                a++;
                if (a % 2 == 0){
                    alphabet += i.ToString().ToUpper();
                }else{
                    alphabet += i.ToString();
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return alphabet;
        }

        public static int Position_az(string sentence, char search)
        {
            int position = 0;
            // Ne rien modifier au dessus de ce commentaire
            int i = 0;
            foreach(char a in sentence){

                if(a != ' '){
                    i++;
                }
                if(search == a){
                    position = i;
                    break;
                }

            }
            // Ne rien modifier au dessous de ce commentaire
            return position;
        }

        public static string Replace_az(string sentence, char search)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire
            foreach(char a in sentence){
                if(a != search){
                    newSentence += a.ToString();
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string River_max_sequence(long river, long max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            long riverbase = river;
            Boolean stop = false;
            while(stop== false){
                if(river == riverbase){
                    sequence += riverbase + " ; ";
                }
                else if(river < max ){
                    sequence += river.ToString() + " ; ";
                }
                else if(river >= max){
                    sequence += river.ToString() + ".";
                    stop = true;
                    break;
                }
                river = TD1.River_next(river);
            }

            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }
        public static string Conway_next(string start)
        {
            string conway = "";
            // Ne rien modifier au dessus de ce commentaire
            for (int i = 0; i < start.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < start.Length; j++)
                {

                    if (start[i] == start[j])
                    {

                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                conway += count.ToString();
                conway += start[i];
                i += count - 1;
            }
            // Ne rien modifier au dessous de ce commentaire
            return conway;
        }

        public static bool Conway_is_sequence(string conway)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire
            string test = "1";
            while (test != conway){
                isSequence  = false;
                test = Conway_next(test);
                if(test == conway){
                    isSequence = true;
                    break;
                }
                else if(int.Parse(test) > int.Parse(conway)){
                    break;
                }
            }
                
               
            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }

        public static string Conway_n_sequence(int n)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire
            string conway = "1";
            int count = 0;
            while (count != n){
                count++;
                if (count < n){
                    sequences += conway + "\n";
                }else{
                    sequences += conway;
                }
                conway = Conway_next(conway);
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Conway_delimiter(int min, int max)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire
            string conway = "1";
            int count = min;
            int countmin = 0;
            bool stop = false;
            while(stop == false){
                countmin++;
                if(countmin >= count && countmin <= max){
                    if(countmin == max){
                        sequences += conway;
                        stop = true;
                    }
                    else{
                        sequences += conway + ("\n");
                        count++;
                    }
                }
                conway = Conway_next(conway);
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Pyramide(int height)
        {
            string pyramide = "";
            // Ne rien modifier au dessus de ce commentaire
            int espace = height - 1;
            int etoile = 2;
            char et = '*';
            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    for (int count = 1; count <= espace; count++)
                    {
                        pyramide += ' ';
                    }
                    pyramide += "/*\\";
                    espace--;
                }
                else
                {
                    pyramide += "\n";
                    for (int count = 0; count <= espace; count++)
                    {
                        pyramide += ' ';
                    }
                    pyramide += '/';
                    for (int count = 0; count <= etoile; count++)
                    {
                        pyramide += et.ToString();
                    }

                    pyramide += "\\";
                    etoile += 2;
                }
                espace--;

            }
            // Ne rien modifier au dessous de ce commentaire
            return pyramide;
        }
    }
}