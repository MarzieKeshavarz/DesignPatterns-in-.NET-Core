// See https://aka.ms/new-console-template for more information

using DesignPattern.IteratorPattern;
using DesignPattern.MementoPattern;
using DesignPattern.State_Pattern;

/// <summary>
/// MementoPattern
/// </summary>

//var editor = new Editor();

//editor.SetContent("content1");
//editor.SetFontName("font1");
//editor.SetFontSize("fontSize1");
//editor.CreateState();

//editor.SetContent("content2");
//editor.SetFontName("font2");
//editor.SetFontSize("fontSize2");
//editor.CreateState();

//editor.UndoContent();
//editor.UndoFontName();
//editor.UndoFontSize();


//Console.WriteLine(editor.GetContent());
//Console.WriteLine(editor.GetFontName());
//Console.WriteLine(editor.GetFontSize());



/// <summary>
/// StatePattern
/// </summary>

//var Claculator = new Claculator();
//Claculator.SetTravelMode(new BicyclingCalculator());

//Claculator.GetDirection();
//Claculator.GetETA();


/// <summary>
/// IteratorPattern
/// </summary>

var productManager = new ProductManager();
productManager.Push(new Product(1, "a"));
productManager.Push(new Product(2, "b"));
productManager.Push(new Product(3, "c"));


var iterator = productManager.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current().toString());
    iterator.GetNext();
}
