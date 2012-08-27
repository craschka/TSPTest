// 
//    Copyright...:  (c)  Schleupen AG
// 

using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using TSPTest;

namespace Tests
{
	internal sealed partial class AgilityHTMLParserTest
	{
		private string htmlFile;
		private AgilityHTMLParser htmlParser;
		private string htmlEntry;

		[SetUp]
		public void Setup()
		{
			htmlFile = File.ReadAllText("TSP.html.part");
			htmlEntry = File.ReadAllText("entry.html.part");
			htmlParser = new AgilityHTMLParser();
		}

		[Test]
		public void ParseEntryAsHTML()
		{
			var s = htmlParser.FindRows(htmlFile);
			foreach (var each in s)
			{
				Assert.That(each.InnerHtml.Contains("colErg1"));
				Assert.That(each.InnerHtml.Contains("colErg2"));
				Assert.That(each.InnerHtml.Contains("colErg3"));
			}
		}

		[Test]
		public void ParseName()
		{
			var s = htmlParser.ParseName(htmlEntry);
			Assert.That(s, Is.EqualTo("PM Pfennings"));
		}

		[Test]
		public void ParseDateTime()
		{
			var s = htmlParser.ParseDateTime(htmlEntry);
			Assert.That(s, Is.EqualTo(new DateTime(2012, 8, 22, 14, 29, 14)));
		}

		[Test]
		public void ParsePrice()
		{
			var s = htmlParser.ParsePrice(htmlEntry);
			Assert.That(s, Is.EqualTo(1.629));
		}

		[Test]
		public void Parse()
		{
			var s = htmlParser.parse(htmlFile).ToList();
			
			Assert.That(s.Count,Is.EqualTo(14));
		}
	}
}
   