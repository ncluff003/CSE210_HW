using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<string> strings = new List<string>(text.Split(" "));

        foreach (string word in strings)
        {
            this._words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsNotHidden = 0;

        for (int i = 0; i < this._words.Count(); i++)
        {
            if (!this._words[i].IsHidden())
            {
                wordsNotHidden++;
            }
        }

        if (wordsNotHidden < numberToHide)
        {
            numberToHide = wordsNotHidden;
        }

        int wordsHidden = 0;
        Random random = new Random();
        int wordIndex = random.Next(0, this._words.Count);

        while (wordsHidden != numberToHide)
        {
            if (!this._words[wordIndex].IsHidden())
            {
                this._words[wordIndex].Hide();
                wordsHidden++;
            }
            else
            {
                wordIndex = random.Next(0, this._words.Count);
            }
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();

        string text = "";

        for (int i = 0; i < this._words.Count; i++)
        {
            if (i == this._words.Count - 1)
            {
                text += $"{this._words[i].GetDisplayText()}";
            }
            else
            {
                text += $"{this._words[i].GetDisplayText()} ";
            }
        }

        return $"{this._reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        int wordsHidden = 0;

        foreach (Word word in this._words)
        {
            if (word.IsHidden())
            {
                wordsHidden++;

                if (wordsHidden == this._words.Count)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
