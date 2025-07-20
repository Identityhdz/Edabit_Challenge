using Edabit_Challenge.Challenges;
using Edabit_Challenge.Challenges.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    private readonly IService _service;

    public Program(IService service)
    {
        _service = service;
    }

    public void Run()
    {
        _service.IndexOfCapitals("Radfor YN");
        _service.CountTrue(new bool[] { false, false, true });
        _service.ReverseAndNot(123);
        _service.HackerSpeak("Hello World");
        _service.SevenBoom(new int[] { 11, 22, 31, 4, 5, 6, 701, 8, 9, 10 });
    }

    public static void Main(string[] args)
    {
        var services = new ServiceCollection()
            .AddSingleton<IService, Service>()
            .AddSingleton<Program>()
            .BuildServiceProvider();

        var program = services.GetRequiredService<Program>();
        program.Run();
    }
}
