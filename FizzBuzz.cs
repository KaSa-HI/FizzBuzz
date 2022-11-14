 static string FizzBuzz(int number)
{
    string answer = "";
    if (number % 3 == 0)
    {
        answer = "fizz";
    }
    if (number % 5 == 0)
    {
        answer = "buzz";
    }
    if (number % 3 == 0 && number % 5 == 0)
    {
        answer = "fizz" + "buzz";
    }
    return answer;

    //when the number is divisible by 3 return the word fizz

    //when the number is divisible by 5 return the word buzz

    //when the number is divisible by both, return the word fizzbuzz

}   


Console.WriteLine($"{FizzBuzz(3)}");
Console.WriteLine($"{FizzBuzz(5)}");
Console.WriteLine($"{FizzBuzz(15)}");
