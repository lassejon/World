// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Drawing;
using Sea.Enums;
using Sea.Models.Fish;
using Sea.Repositories;

var rep = new FishRepository();
rep.Fish.ForEach(Console.WriteLine);
