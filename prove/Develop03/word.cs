using System;
/*Keeps track of a single word and whether it is shown or hidden.*/

public class Word
{
    //attributes
    // store the text of the word itself (a string) 
    private string _text;
    private bool _isHidden;

    //constructors
    public Word(string text)
    {
        /*accept the text of the word to save it as an attribute and set the initial 
        visibility of the word (whether it is shown or hidden)*/
        _text = text;
        _isHidden = true;
    }

    //methods
    public void Hide() {

    }
    public void Show() {

    }
    public bool IsHidden() {
        return true;
    }
    public string GetDisplayText() {
        return "";
    }


}