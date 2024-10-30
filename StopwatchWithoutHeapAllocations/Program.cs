using System.Diagnostics;

// Avoiding the instantiation of the Stopwatch class with the static GetTimestamp method

var startingTimestamp = Stopwatch.GetTimestamp();
{
    await Task.Delay(500);
}
var elapsed = Stopwatch.GetElapsedTime(startingTimestamp);

Console.WriteLine($"\nElapsed Time:  {elapsed}");
