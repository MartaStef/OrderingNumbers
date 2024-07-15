Console.WriteLine("Witaj w programie sortującym liczby rosnąco i malejąco!");
Console.WriteLine("Aby skończyć dodawanie liczb i uzyskać sgregację napisz słowo 'next'.");
Console.WriteLine();

List<float> numbersListAsc = new List<float>();
List<float> numbersListDesc= new List<float>();

while (true)
{
    Console.WriteLine("Podaj liczbę: ");
    string inputNumber = Console.ReadLine();
    if (float.TryParse(inputNumber, out float number))
    {
        numbersListAsc.Add(number);
        numbersListDesc.Add(number);
    }
    else if(inputNumber == "next")
    {
        break;
    }
    else
    {
        Console.WriteLine("Wprowadzona wartość nie jest liczbą");
    }
}

List<float> numbersAscending = new List<float>();

    while (numbersListAsc.Count > 0)
    {
        float minimum = numbersListAsc.Min();
        numbersListAsc.Remove(minimum);
        numbersAscending.Add(minimum);
    }

    Console.WriteLine();
    Console.WriteLine("Posortowane liczby rosnąco:");
    foreach (var number in numbersAscending)
    {
        Console.Write(number + "; ");
    }
    Console.WriteLine();

List<float> numbersDescending = new List<float>();

    while(numbersListDesc.Count > 0)
    {
        float maximum = numbersListDesc.Max();
        numbersListDesc.Remove(maximum);
        numbersDescending.Add(maximum);
    }
    Console.WriteLine();
    Console.WriteLine("Posortowane liczby malejąco: ");
    foreach (var number in numbersDescending)
    {
        Console.Write(number + "; ");
    }
    Console.WriteLine();


//1.znaleść najmniejszą
//2. zrobić nową listę bez najmniejszej
//3. patrz punkt 1
//4. patrz punkt2
//5. 1 i 2 trzeba zrobić pętle
//6. pętla ma się zatrzymać jak skoncza sie liczby

//  OK  1. utworzyć nową liste numbersSorted 
//2.znaleść najmniejszą i usunać ja z listy poczatkowej numbersList
//3.dodać najmniejszą do listy numbersSorted
//4. patrz punt 2 i 3 (w petli)
//5. wypisz listę numbersSorted na konsoli