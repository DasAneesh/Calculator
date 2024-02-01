
string input = "1 2 3 4 + * +";
string[] tokens = input.Split(' ');


string[] openBrackets = ["(", "[", "{"];
string[] closeBrackets = [")", "]", "}"];
string[] operators = ["+", "-", "/", "*"];


bool IsCorrectBrackets(string[] equation){
    Stack<string> brackets = new Stack<string>();
    string[] copy = equation;

    for (int i = 0; i < copy.Length; i++)
    {
        if (openBrackets.Contains(copy[i]))
        {
            copy[i] = openBrackets[0];
        }
        if (closeBrackets.Contains(copy[i]))
        {
            copy[i] = closeBrackets[0];
        }
    }

    foreach (var token in copy)
    {
        if(token == "(")
        {
            brackets.Push(token);
        }
        else if(token == ")" ) {
            if(brackets.Count == 0) { return false; }
            brackets.Pop();
        }
    }
    return brackets.Count == 0;
}

double EvaluatePostfix(string[] equation)
{
    double a;
    double b;
    Stack<double> values = new Stack<double>();
    foreach (var token in equation)
    {
        if (!operators.Contains(token))
        {
            values.Push(double.Parse(token));
        }
        else
        {
            switch (token)
            {
                case "+":
                    a = values.Pop();
                    b = values.Pop();
                    values.Push(a + b);
                    break;

                case "-":
                    a = values.Pop();
                    b = values.Pop();
                    values.Push(a - b);
                    break;

                case "*":
                    a = values.Pop();
                    b = values.Pop();
                    values.Push(a * b);
                    break;

                case "/":
                    a = values.Pop();
                    b = values.Pop();
                    values.Push(a / b);
                    break;
            }
        }
    }
    return values.Peek();
}

Console.WriteLine(EvaluatePostfix(tokens));








//string path = "24-153.txt";
//string text;
//using (StreamReader reader = new StreamReader(path))
//{
//    text = reader.ReadToEnd();
//}

////155)	(А.Кабанов)Текстовый файл 24-153.txt содержит строку из заглавных букв A, B, C, D, E, F, всего не более 106 символов. AF-подстроками назовём последовательности символов A, B, C, D, E, F, ограниченные в начале символом A, а в конце символом F (граничные символы входят в подстроку). Определите минимальную длину AF-подстроки. Подстроки, состоящие из двух символов, не учитывать.

////text = "ABABAAABAEEBECBCEBECCBFACB" +
////    "CCABCBBBBCBFCAFCBCCBEBEBC" +
////    "EBCEBCEBCFBBBBCBCEAFECEBC" +
////    "BEBCEBCEBBBCBFEBAFEABBBBB" +
////    "BCBBEBCEEECCC";

//int minimum_length = text.Length;
//int sequence_length = 0;

//for (int i = 0; i < text.Length-1; i++)
//{
//    char currentChar = text[i];
//    int j = i;
//    char candidate = text[j+1];
//    bool wasFoundA = false;
//    if (currentChar == 'A' && candidate != 'F' && candidate != 'A')
//    {
//        sequence_length++;
//        for (int k = j+1; k < text.Length; k++)
//        {
//            candidate = text[k];

//            if (candidate == 'F')
//            {
//                j = k-1;
//                sequence_length++;
//                break;
//            }

//            if (candidate == 'A')
//            {
//                wasFoundA = true;
//                j = k-1;
//                sequence_length = 0;
//                break;
//            }

//            sequence_length++;
//        }
//        if (!wasFoundA && sequence_length < minimum_length)
//        {
//            minimum_length = sequence_length;
//            sequence_length = 0;
//        }
//    }
//    i = j;
//}

//Console.WriteLine(minimum_length);
