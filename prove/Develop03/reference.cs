using System;
using System.Security.Cryptography;
/*Keeps track of the book, chapter, and verse information.*/
public class Reference
{
    //attributes
    private string _book;

    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructors
    /*2 constructor for diferent cases where there is one verse and other multiple 
    verses*/
    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //methods
    public string GetDisplayText() {
        /*display text of the reference, which is just a string combining the book, 
        chapter, and verse (or verses).*/
        return $"{_book} {_chapter} : {_verse}";
    }


}