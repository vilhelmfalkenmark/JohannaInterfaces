
using Microsoft.Extensions.DependencyInjection; // Installerat Nuget paket! "dotnet add package Microsoft.Extensions.DependencyInjection"
using Interfaces.Interfaces;
using Interfaces.Services;


// Registrera en ny samling av services
var serviceProvider = new ServiceCollection()
		.AddSingleton<IWordInterface<string, string>>(new WordService())
		.AddSingleton<GameService>()
		.AddSingleton<TestService>()
		.BuildServiceProvider();

// Hämta services från samlingen
var menuService = serviceProvider.GetService<GameService>();
var testService = serviceProvider.GetService<TestService>();

// Kalla på metoder från services
menuService?.StartGame();
testService?.ShowList();