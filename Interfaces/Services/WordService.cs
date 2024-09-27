using System;
using Interfaces.Interfaces;

namespace Interfaces.Services;

public class WordService : IWordInterface<string, string>
{
	public List<string> _words = [];

	public WordService()
	{
		_words = ["banan", "äpple", "kiwi"];
	}

	public bool CheckIfWordIsInList(string word)
	{
		return _words.Contains(word);
	}
	public void AddWordToList(string word)
	{
		_words.Add(word);
	}
	public void ShowAllWordsInList()
	{
		Console.WriteLine("Words in list:");
		foreach (string word in _words)
		{
			Console.WriteLine(word);
		}
	}
}
