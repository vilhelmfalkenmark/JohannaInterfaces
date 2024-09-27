using System;
using Interfaces.Interfaces;

namespace Interfaces.Services;

public class TestService(IWordInterface<string, string> wordService)
{
	private readonly IWordInterface<string, string> _wordService = wordService;

	public void ShowList()
	{
		_wordService.AddWordToList("Hasselnötter");
		_wordService.ShowAllWordsInList();
	}
}