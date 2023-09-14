using _24._09;

Tasks.Task1(4, '#');
Console.WriteLine(Tasks.Task2(11222111) + "\n");
Tasks.Task3(
    new List<int>() { 1, 2, 3, 4, 5 },
    new List<int>() { 1, 5 })
    .ForEach(x => Console.Write(x + " "));