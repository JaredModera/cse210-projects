using System;
/*Keeps track of both the reference and the text of the scripture.
 Can hide words and get the rendered display of the text.*/
public class Scripture
{
    //attributes
    private Reference _reference;
    private List<Word> _words;

    //constructors

    public Scripture(Reference reference, string text)
    {
        /*creating the list, and splitting up the words in the string 
        to create Word objects for each one and put them in the list.*/

    }

    //methods
    public void HideRandomWords(int numberToHide) 
    {

    }

    public string GetDisplayText() {
        return "";
    }

    public bool IsCompletelyHidden() {
        return true;
    }
}