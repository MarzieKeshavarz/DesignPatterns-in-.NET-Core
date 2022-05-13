// See https://aka.ms/new-console-template for more information

using DesignPattern.CommandPattern;
using DesignPattern.CommandPattern.FW;
using DesignPattern.CommandPattern.Services;
using DesignPattern.IteratorPattern;
using DesignPattern.MementoPattern;
using DesignPattern.State_Pattern;
using DesignPattern.StrategyPattern;
using DesignPattern.TemplateMethodPattern;

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

//var productManager = new ProductManager();
//productManager.Push(new Product(1, "a"));
//productManager.Push(new Product(2, "b"));
//productManager.Push(new Product(3, "c"));


//var iterator = productManager.CreateIterator();

//while (iterator.HasNext())
//{
//    Console.WriteLine(iterator.Current().toString());
//    iterator.GetNext();
//}

/// <summary>
/// StrategyPattern
/// </summary>

//var aESEncryption = new TextEncryption(new AESEncryption());
//var dESEncryption = new TextEncryption(new DESEncryption());
//aESEncryption.Encrypt("hello ");
//dESEncryption.Encrypt("world ");


/// <summary>
/// TemplateMethodPattern
/// </summary>

//var homeWindow = new HomeWindow(new CachData());
//homeWindow.CloseWindow();

/// <summary>
/// CommandPattern
/// </summary>

var history = new DesignPattern.CommandPattern.FW.History();
var editor = new VideoEditor();

var lableCommand = new LabelCommand(editor, history);
lableCommand.execute();
Console.WriteLine("label status :" +editor.GetHasLabel());

var undoCommand = new UndoCommand(history);
undoCommand.execute();
Console.WriteLine("label status :" + editor.GetHasLabel());

var contrastCommand = new ConstrastCommand(editor, history);
contrastCommand.execute();
Console.WriteLine("contrast status :" + editor.GetContrast());

undoCommand.execute();
Console.WriteLine("contrast status :" + editor.GetContrast());
