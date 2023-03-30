// See https://aka.ms/new-console-template for more information
using Num_3_ExtendingLinq;

Examples examples = new();
examples.GetSongsDuration();
examples.RangesFullView();

var x =examples.CountBy("A,A,C,B,C,C,G,F,D,F,G".Split(","));
Console.WriteLine("Hello, World!");