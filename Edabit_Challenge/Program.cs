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
        _service.countTrue(new bool[] { false, false, true });
        _service.ReverseAndNot(123);
        _service.HackerSpeak("Hello World");
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
