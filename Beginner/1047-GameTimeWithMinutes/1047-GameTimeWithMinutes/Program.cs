// See https://aka.ms/new-console-template for more information
//Question : https://www.beecrowd.com.br/judge/en/problems/view/1047
string[] hourInput = Console.ReadLine().Split(' ');

// Separando os numeros que representam as horas (inicial e final) e os minutos (inicial e final)
int initialHour = int.Parse(hourInput[0]);
int initialMinute = int.Parse(hourInput[1]);
int finalHour = int.Parse(hourInput[2]);
int finalMinute = int.Parse(hourInput[3]);

// Numeros que serão printados
int printHour = 0;
int printMinute = 0;

if(finalMinute == initialMinute){
    if(!(initialHour < finalHour)){
        printHour = 24 - (initialHour - finalHour);
    }
    else{
        printHour = finalHour - initialHour;
    }
}
else if(finalMinute < initialMinute){
    // Se não for o caso abaixo, aplica o cálculo da hora para o restante
    if(finalHour > initialHour){
        printHour = (finalHour - initialHour) - 1;
    }
    else{
        printHour = 23 - (initialHour - finalHour);
    }
    // Todos os casos de hora terão que realizar o cálculo dos minutos
    printMinute = 60 - (initialMinute - finalMinute);
}
else{
    if(finalHour < initialHour){
        printHour = 23 - (finalHour - initialHour);
    }
    else{

        printHour = finalHour - initialHour;
    }
    // Todos os casos de hora terão que realizar o cálculo dos minutos
    printMinute = finalMinute - initialMinute;
}

Console.WriteLine($"O JOGO DUROU {printHour} HORA(S) E {printMinute} MINUTO(S)");