using Interfaces.Interfaces;

namespace Interfaces.Services;

// Gör en dependency injection av IWordInterface<string, string> wordService = Kom åt alla som ärver av det interfacet  
public class GameService(IWordInterface<string, string> wordService)
{
	private readonly IWordInterface<string, string> _wordService = wordService;

	public void StartGame()
	{

		Console.Clear();
		_wordService.ShowAllWordsInList();
		Console.WriteLine("Enter a new word");

		string newWord = Console.ReadLine() ?? "";

		if (_wordService.CheckIfWordIsInList(newWord))
		{
			Console.WriteLine("Word already exists in list and will not be added");
		}
		else
		{
			_wordService.AddWordToList(newWord);

		}

		Console.WriteLine("Type 1 to see all words in the list");
		string option = Console.ReadLine() ?? "";
		if (option == "1")
		{
			_wordService.ShowAllWordsInList();
		}

	}

}
