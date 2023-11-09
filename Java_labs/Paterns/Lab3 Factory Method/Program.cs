//надає інтерф для свтор обєктів але дозвол підкласам вирішувати які саме обєкт створ
//викор для створ різних типів книг за допом фабрик, які спеціал на створ певного типу книг
using System;

abstract class Book
{
    public abstract string DisplayInfo();
}

class Novel : Book
{
    public override string DisplayInfo()
    {
        return "Роман";
    }
}

class Fantasy : Book
{
    public override string DisplayInfo()
    {
        return "Фентезі";
    }
}

abstract class BookStore
{
    public abstract Book CreateBook();
}

class NovelStore : BookStore
{
    public override Book CreateBook()
    {
        return new Novel();
    }
}

class FantasyStore : BookStore
{
    public override Book CreateBook()
    {
        return new Fantasy();
    }
}

class Program
{
    static void Main()
    {
        BookStore novelStore = new NovelStore();
        Book novel = novelStore.CreateBook();
        Console.WriteLine(novel.DisplayInfo());

        BookStore fantasyStore = new FantasyStore();
        Book fantasy = fantasyStore.CreateBook();
        Console.WriteLine(fantasy.DisplayInfo());
    }
}
