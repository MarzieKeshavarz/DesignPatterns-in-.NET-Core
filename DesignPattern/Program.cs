// See https://aka.ms/new-console-template for more information

using DesignPattern.MementoPattern;
using DesignPattern.State_Pattern;

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

var Claculator = new Claculator();
Claculator.SetTravelMode(new BicyclingCalculator());

Claculator.GetDirection();
Claculator.GetETA();

