﻿

using System.Text;

Console.WriteLine("Hvad vil du gerne sige");
string input = Console.ReadLine();

char[] chararray = input.ToLower().ToCharArray();

for (int i = 0; i < chararray.Length; i++)
{
    switch (chararray[i])
    {
        case 'a':
            Console.Write(".-");
            break;

        case 'b':
            Console.Write("-...");
            break ;

        case 'c':
            Console.Write("-.-.");
            break;

        case 'd':
            Console.Write("-..");
            break;

        case 'e':
            Console.Write(".");
            break;

        case 'f':
            Console.Write("..-");
            break;

        case 'g':
            Console.Write("--.");
            break;

        case 'h':
            Console.Write("....");
            break;

        case 'i':
            Console.Write("..");
            break;

        case 'j':
            Console.Write(".---");
            break;

        case 'k':
            Console.Write("-.-");
            break;

        case 'l':
            Console.Write(".-..");
            break;

        case 'm':
            Console.Write("--");
            break;

        case 'n':
            Console.Write("-.");
            break;

        case 'o':
            Console.Write("---");
            break;

        case 'p':
            Console.Write(".--.");
            break;

        case 'q':
            Console.Write("--.-");
            break;

        case 'r':
            Console.Write(".-.");
            break;

        case 's':
            Console.Write("...");
            break;

        case 't':
            Console.Write("-");
            break;

        case 'u':
            Console.Write("..-");
            break;

        case 'v':
            Console.Write("...-");
            break;

        case 'w':
            Console.Write(".--");
            break;

        case 'x':
            Console.Write("-..-");
            break;

        case 'y':
            Console.Write("-.--");
            break;

        case 'z':
            Console.Write("--..");
            break;

        case 'æ':
            Console.Write(".-.-");
            break;

        case 'ø':
            Console.Write("---.");
            break;

        case 'å':
            Console.Write(".--.-");
            break;

        default:
            break;
           
    }
    Console.Write(" ");
}

//StringBuilder morse = new StringBuilder();

//for (int i = 0; i < chararray.Length; i++)
//{
//    morse.Append(chararray[i]);
//}


//Console.WriteLine(morse.ToString());

Console.ReadKey();



