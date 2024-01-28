using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	[SerializeField] private GameObject gameOverImage;

	private void Start() {
		WordDisplay.OnWordGameOver += OnWordGameOver_Action;
	}

	private void OnWordGameOver_Action(object sender, EventArgs e){
		gameOverImage.SetActive(true);
		GetComponent<WordTimer>().enabled = false;
		Player.Instance.Vitutus = Player.Instance.Vitutus + 0.2f;

		WordDisplay.OnWordGameOver -= OnWordGameOver_Action;
	}

	public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());

		words.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
			PlayerPrefsData.Money = 1;
			Player.Instance.Vitutus = Player.Instance.Vitutus -0.003f;
		}
	}

}
