using System;

namespace Interfaces.Interfaces;

public interface IWordInterface<T, TResult>
{
	public bool CheckIfWordIsInList(T word);
	public void AddWordToList(T word);
	public void ShowAllWordsInList();
}