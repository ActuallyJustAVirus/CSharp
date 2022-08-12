//Un-comment below code and fix the issues
//Push to github


int RecursiveFibonacci(int count)
{  
    if(count <= 2) {
        if (count == 0) return 0;
        return 1;
    }else{
        return (RecursiveFibonacci(count-2)+RecursiveFibonacci(count-1));
    }
}

for (;;) {
    String input = Console.ReadLine(); 
    int lastFibo = RecursiveFibonacci(int.Parse(input));
    Console.WriteLine("The fibo number to " + input + " is " + lastFibo);
}
