using System;
namespace TD_console
{
    public class TD4
    {
        // Faites vos tests dans cette méthode
        public TD4()
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
            Writer("River_unique", "100", "1 ; 3 ; 5 ; 7 ; 9 ; 20 ; 31 ; 42 ; 53 ; 64 ; 75 ; 86 ; 97.", River_unique(100));
            Writer("Encode_RL", "abcdefghijk", "ghijbcadefk", Encode_RL("abcdefghijk"));
            Writer("Decode_RL", "ghijbcadefk", "abcdefghijk", Decode_RL("ghijbcadefk"));
            Writer("Fibonacci_is_sequence", "9", "False", Fibonacci_is_sequence(9).ToString());
            Writer("Fibonacci_previous", "8", "5", Fibonacci_previous(8).ToString());
            Writer("Fibonacci_next", "8", "13", Fibonacci_next(8).ToString());
            Writer("Fibonacci_max_sequence", "20", "0 ; 1 ; 1 ; 2 ; 3 ; 5 ; 8 ; 13 ; 21.", Fibonacci_max_sequence(20));
            Writer("Fibonacci_n_sequence", "5", "0 ; 1 ; 1 ; 2 ; 3.", Fibonacci_n_sequence(5));
            Writer("Fibonacci_delimiter", "3, 6", "1 ; 2 ; 3 ; 5.", Fibonacci_delimiter(3, 6));
            Writer("Conway_previous", "111221", "1211", Conway_previous("111221"));
            Writer("Syracuse_is_sequence", "34, 18", "False", Syracuse_is_sequence(34, 18).ToString());
            Writer("Syracuse_previous", "22", "7 ; 44.", Syracuse_previous(22));
            Writer("Syracuse_next", "42", "21", Syracuse_next(42).ToString());
            Writer("Syracuse_sequence", "20", "20 ; 10 ; 5 ; 16 ; 8 ; 4 ; 2 ; 1.", Syracuse_sequence(20));
            Writer("Syracuse_n_sequence", "14, 5", "14 ; 7 ; 22 ; 11 ; 34.", Syracuse_n_sequence(14, 5));
            Writer("Syracuse_delimiter", "14, 3, 6", "22 ; 11 ; 34 ; 17.", Syracuse_delimiter(14, 3, 6));
            Writer("Morse_to_morse", "a", ". _", Morse_to_morse('a'));
            Writer("Morse_to_char", ". _", "a", Morse_to_char(". _").ToString());
            Writer("Morse_encode", "Hello World !", ". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ .", Morse_encode("Hello World !"));
            Writer("Morse_decode", ". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ .", "Hello World !", Morse_decode(". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ ."));
        }

        public static string River_unique(long max)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire
            for (long i = 0; i <= max; i++)
            {
                for (long j = 1; j < i;j++){
                    if(!TD1.River_is_sequence(j,i)){
                        sequences += i + " ";
                        break;
                    }
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Encode_RL(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire
            int nb = 0;
            bool turn = true;
            for (int i = 0; i < sentence.Length;i++){
                string sentence1 = "";
                sentence1 += sentence[i];
                for (int j = i + 1; j <= nb + i; j++)
                {
                    if (j < sentence.Length)
                    {
                        sentence1 += sentence[j];

                    }
                } 
                if(turn == true)
                {

                    newSentence += sentence1;
                    turn = false;
                } else {
                    newSentence = sentence1 + newSentence;
                    turn = true; 
                }
                i += nb;
                nb++;
            }
            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string Decode_RL(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static bool Fibonacci_is_sequence(long sequence)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            for (long i = 0; i <= sequence;i++){
                long nouv = a;
                a = b;
                b = nouv + b;

                if( a == sequence){
                    break;
                }
                else if(a > sequence){
                    isSequence = false;
                    break;
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }

        public static long Fibonacci_previous(long n)
        {
            long fibonacci = 0;
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            for (long i = 0; i <= n; i++)
            {
                long nouv = a;
                a = b;
                b = nouv + b;

                if(b == n){
                    fibonacci = a;
                    break;
                }

            }
                // Ne rien modifier au dessous de ce commentaire
                return fibonacci;
        }

        public static long Fibonacci_next(long n)
        {
            long fibonacci = 0;
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            for (long i = 0; i <= n; i++)
            {
                long nouv = a;
                a = b;
                b = nouv + b;

                if (a == n)
                {
                    fibonacci = nouv + a;
                    break;
                }

            }
            // Ne rien modifier au dessous de ce commentaire
            return fibonacci;
        }

        public static string Fibonacci_max_sequence(long max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            bool stop = false;
            while(stop== false)
            {
                long nouv = a;
                a = b;
                b = nouv + b;

                if(nouv == 0){
                    sequence += nouv + " ; ";
                }
                else if(nouv <= max){
                    sequence += nouv + " ; ";
                }
                else if(nouv > max){
                    sequence += nouv+".";
                    stop = true;
                    break;
                }

            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Fibonacci_n_sequence(int n)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            int i = 1;
            while (true)
            {
                long nouv = a;
                a = b;
                b = nouv + b;


                if (i < n)
                {
                    sequence += nouv + " ; ";
                }
                else{
                    sequence += nouv + ".";
                    break;
                }
                i++;
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Fibonacci_delimiter(int min, int max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            long a = 0;
            long b = 1;
            long countmin = 1;
            long count = min;
            bool stop = false;

            while(stop == false)
            {
                countmin++;
                long nouv = a;
                a = b;
                b = nouv + b;


                if (countmin >= count && countmin <= max)
                {
                    if (countmin == max)
                    {
                        sequence += a + ".";
                        stop = true;
                        break;
                    }
                    else
                    {
                        sequence += a + " ; ";
                        count++;

                    }
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Conway_previous(string start)
        {
            string conway = "";
            // Ne rien modifier au dessus de ce commentaire
            string nbconway = "1";
            while(nbconway != start){
                nbconway = TD2.Conway_next(nbconway);
                if(nbconway == start){
                    break;
                }
                conway = nbconway;
            }
            // Ne rien modifier au dessous de ce commentaire
            return conway;
        }

        public static bool Syracuse_is_sequence(long syracuse, long sequence)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire
            Console.Write(syracuse+" ");
            while (true){

                Console.Write(syracuse + " ");
                if (syracuse % 2 == 0)
                {
                    syracuse /= 2;
                }
                else if (syracuse % 2 == 1)
                {
                    syracuse *= 3;
                    syracuse += 1;
                }

                if (syracuse == sequence)
                {
                    break;
                }
                if(syracuse == 1 && sequence != 1){
                    isSequence = false;
                    break;
                }else if (syracuse == 1 && sequence == 1){
                    break;
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }

        public static string Syracuse_previous(long n)
        {
            string syracuses = "";
            // Ne rien modifier au dessus de ce commentaire
            long prev = (n / 3);
            long suiv = n * 2;

            if((n-1) % 3 !=0){
                syracuses += suiv + ".";
            }
            else{
                syracuses += prev + " ; " + suiv + ".";
            }
            // Ne rien modifier au dessous de ce commentaire
            return syracuses;
        }

        public static long Syracuse_next(long n)
        {
            long syracuse = 0;
            // Ne rien modifier au dessus de ce commentaire
            if(n %2 == 0){
                syracuse += n / 2;
            }else{
                syracuse += (n*3) +1;
            }
            // Ne rien modifier au dessous de ce commentaire
            return syracuse;
        }

        public static string Syracuse_sequence(long syracuse)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            syracuse += syracuse;
            while (true)
            {
                if (syracuse % 2 == 0)
                {
                    syracuse /= 2;
                }
                else if (syracuse % 2 == 1)
                {
                    syracuse *= 3;
                    syracuse += 1;
                }
                if(syracuse != 1)
                    sequence += syracuse+" ; ";

                if(syracuse == 1){
                    sequence += syracuse + ".";
                    break;
                }
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Syracuse_n_sequence(long syracuse, int n)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            int i = 1;
            while (i <= n)
            {
                if (n > i)
                    sequence += syracuse + " ; ";

                if (i == n)
                {
                    sequence += syracuse + ".";
                    break;
                }
                if (syracuse % 2 == 0)
                {
                    syracuse /= 2;
                }
                else if (syracuse % 2 == 1)
                {
                    syracuse *= 3;
                    syracuse += 1;
                }

                i++;
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Syracuse_delimiter(long syracuse, int min, int max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            int i = 1;
            while (i <= max)
            {

                if (i >= min && i != max)
                    sequence += syracuse + " ; ";

                if (i == max)
                {
                    sequence += syracuse + ".";
                    break;
                }


                if (syracuse % 2 == 0)
                {
                    syracuse /= 2;
                }
                else if (syracuse % 2 == 1)
                {
                    syracuse *= 3;
                    syracuse += 1;
                }

                i++;
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }


        public static string Morse_to_morse(char c)
        {
            string morse = "";
            // Ne rien modifier au dessus de ce commentaire 
            //  if (c == '  ') { return morse += "ESPACE"; }
            if (c == 'a' || c == 'A') { return morse += ". _"; }
            else if (c == 'b' || c == 'B') { return morse += "_ . . ."; }
            else if (c == 'c' || c == 'C') { return morse += "_ . _ ."; }
            else if (c == 'd' || c == 'D') { return morse += "_ . ."; }
            else if (c == 'e' || c == 'E') { return morse += "."; }
            else if (c == 'f' || c == 'F') { return morse += ". . _ ."; }
            else if (c == 'g' || c == 'G') { return morse += "_ _ ."; }
            else if (c == 'h' || c == 'H') { return morse += ". . . ."; }
            else if (c == 'i' || c == 'I') { return morse += ". ."; }
            else if (c == 'j' || c == 'J') { return morse += ". _ _"; }
            else if (c == 'k' || c == 'K') { return morse += "_ . _"; }
            else if (c == 'l' || c == 'L') { return morse += ". _ . ."; }
            else if (c == 'm' || c == 'M') { return morse += "_ _"; }
            else if (c == 'n' || c == 'N') { return morse += "_ ."; }
            else if (c == 'o' || c == 'O') { return morse += "_ _ _"; }
            else if (c == 'p' || c == 'P') { return morse += ". _ _ ."; }
            else if (c == 'q' || c == 'Q') { return morse += "_ _ . _"; }
            else if (c == 'r' || c == 'R') { return morse += ". _ ."; }
            else if (c == 's' || c == 'S') { return morse += ". . ."; }
            else if (c == 't' || c == 'T') { return morse += "_"; }
            else if (c == 'u' || c == 'U') { return morse += ". . _ _"; }
            else if (c == 'v' || c == 'V') { return morse += ". . . _ "; }
            else if (c == 'w' || c == 'W') { return morse += ". _ _"; }
            else if (c == 'x' || c == 'X') { return morse += "_ . . _"; }
            else if (c == 'y' || c == 'Y') { return morse += "_ . _ _"; }
            else if (c == 'z' || c == 'Z') { return morse += "_ _ . ."; }
            else if (c == '1') { return morse += ". _ _ _ _"; }
            else if (c == '2') { return morse += ". . _ _ _"; }
            else if (c == '3') { return morse += ". . . _ _"; }
            else if (c == '4') { return morse += ". . . . _"; }
            else if (c == '5') { return morse += ". . . . ."; }
            else if (c == '6') { return morse += "_ . . . ."; }
            else if (c == '7') { return morse += "_ _ . . ."; }
            else if (c == '8') { return morse += "_ _ _ . ."; }
            else if (c == '9') { return morse += "_ _ _ _ ."; }
            else if (c == '0') { return morse += "_ _ _ _ _"; }
            else if (c == '.') { return morse += ". _ . _"; }
            else if (c == ',') { return morse += "_ _ . . _ _"; }
            else if (c == '?') { return morse += ". . _ _ . ."; }
            else if (c == '\'') { return morse += "_ . . _ _ ."; }
            //else if (c == '!') { return morse += "_ . _ . _ _"; }

            else if (c == '!') { return morse += "_ _ _ ."; }
            else if (c == '(') { return morse += "_ . _ _ ."; }
            else if (c == ')') { return morse += "_ . _ _ . _"; }
            else if (c == '&') { return morse += ". _ . . ."; }
            else if (c == ':') { return morse += "_ _ _ . . ."; }
            else if (c == ';') { return morse += "_ . _ . _ ."; }
            else if (c == '=') { return morse += "_ . . . _"; }
            else if (c == '+') { return morse += ". _ . _ ."; }
            else if (c == '-') { return morse += "_ . . . . _"; }
            else if (c == '_') { return morse += ". _ . . _ ."; }
            else if (c == '"') { return morse += ". _ . . _ ."; }
            else if (c == '@') { return morse += ". _ _ . _ ."; }
            else if (c == ' ') { return morse += " / "; }

            // Ne rien modifier au dessous de ce commentaire
            return morse;
        }

        public static char Morse_to_char(string morse)
        {
            char c = '\0';
            // Ne rien modifier au dessus de ce commentaire

            if (morse == ". _") { return c = 'a'; }
            else if (morse == "_ . . .") { return c = 'b'; }
            else if (morse == "_ . _ .") { return c = 'c'; }
            else if (morse == "_ .") { return c = 'd'; }
            else if (morse == ".") { return c = 'e'; }
            else if (morse == ". . _ .") { return c = 'f'; }
            else if (morse == "_ _ .") { return c = 'g'; }
            else if (morse == ". . . .") { return c = 'h'; }
            else if (morse == ". .") { return c = 'i'; }
            else if (morse == ". _ _") { return c = 'j'; }
            else if (morse == "_ . _") { return c = 'k'; }
            else if (morse == ". _ . .") { return c = 'l'; }
            else if (morse == "_ _") { return c = 'm'; }
            else if (morse == "_ .") { return c = 'n'; }
            else if (morse == "_ _ _") { return c = 'o'; }
            else if (morse == ". _ _ .") { return c = 'p'; }
            else if (morse == "_ _ . _") { return c = 'q'; }
            else if (morse == ". _ .") { return c = 'r'; }
            else if (morse == ". . .") { return c = 's'; }
            else if (morse == "_") { return c = 't'; }
            else if (morse == ". . _ _") { return c = 'u'; }
            else if (morse == ". . . _ ") { return c = 'v'; }
            else if (morse == ". _ _") { return c = 'w'; }
            else if (morse == "_ . . _") { return c = 'x'; }
            else if (morse == "_ . _ _") { return c = 'y'; }
            else if (morse == ". _ _ _ _") { return c = '1'; }
            else if (morse == ". . _ _ _") { return c = '2'; }
            else if (morse == ". . . _ _") { return c = '3'; }
            else if (morse == ". . . . _") { return c = '4'; }
            else if (morse == ". . . . .") { return c = '5'; }
            else if (morse == "_ . . . .") { return c = '6'; }
            else if (morse == "_ _ . . .") { return c = '7'; }
            else if (morse == "_ _ _ . .") { return c = '8'; }
            else if (morse == "_ _ _ _ .") { return c = '9'; }
            else if (morse == "_ _ _ _ _") { return c = '0'; }
            else if (morse == ". _ . _") { return c = '.'; }
            else if (morse == "_ _ . . _ _") { return c = ','; }
            else if (morse == ". . _ _ . .") { return c = '?'; }
            else if (morse == "_ . . _ _ .") { return c = '\''; }
            else if (morse == "_ . _ . _ _") { return c = '!'; }
            else if (morse == "_ . _ _ .") { return c = '('; }
            else if (morse == "_ . _ _ . _") { return c = ')'; }
            else if (morse == ". _ . . .") { return c = '&'; }
            else if (morse == "_ _ _ . . .") { return c = ':'; }
            else if (morse == "_ . _ . _ .") { return c = ';'; }
            else if (morse == "_ . . . _") { return c = '='; }
            else if (morse == ". _ . _ .") { return c = '+'; }
            else if (morse == "_ . . . . _") { return c = '-'; }
            else if (morse == ". _ . . _ .") { return c = '_'; }
            else if (morse == ". _ . . _ .") { return c = '"'; }
            else if (morse == ". _ _ . _ .") { return c = '@'; }


            // Ne rien modifier au dessous de morsee commentaire
            return c;
        }

        public static string Morse_encode(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire



            foreach (char c in sentence)
            {

                if (newSentence == "")
                {
                    newSentence += Morse_to_morse(c);
                }
                else
                {
                  
                    if (newSentence[newSentence.Length - 2] == '/')
                    {

                        if (c == ' ')
                        {
                            newSentence += Morse_to_morse(c);
                        }

                        else
                        {

                            newSentence += Morse_to_morse(c);

                        }
                    }
                    else if (c == ' ')
                    {
                        newSentence += Morse_to_morse(c);
                    }
                    else
                    {
                        newSentence += "   " + Morse_to_morse(c);
                    }

                }

            }
            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string Morse_decode(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }
    }
}
