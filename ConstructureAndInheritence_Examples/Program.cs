using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;


    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();

}

//Write MyBook class
class MyBook : Book
{

    public int price = 0;

    public MyBook(string t, string a, int price) : base(t, a)
    {
        Console.WriteLine("Title: " + t);
        Console.WriteLine("Author: " + a);
        Console.WriteLine("Price: " + price);
    }

    public override void display()
    {
        Console.WriteLine("Title: " + title + "\nAuthor: " + author + "\nPrice: " + price);
    }

}
class Solution
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price); //Inherited constructure 
        new_novel.display();
    }
}