using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace TSPTest
{
	internal class AgilityHTMLParser : HTMLParser
	{
		public IEnumerable<TankstellenEntry> parse(string htmlDocument)
		{
			return FindRows(htmlDocument).Select(row => new TankstellenEntry(ParsePrice(row.InnerHtml), ParseName(row.InnerHtml), ParseDateTime(row.InnerHtml)));
		}

		internal HtmlNodeCollection FindRows(string htmlFile)
		{
			var doc = new HtmlDocument();
			TextReader t = new StringReader(htmlFile);
			doc.Load(t);
			return doc.DocumentNode.SelectNodes("//tr[@class]");
		}

		internal string ParseName(string htmlEntry)
		{
			var doc = new HtmlDocument();
			TextReader t = new StringReader(htmlEntry);
			doc.Load(t);
			return doc.DocumentNode.SelectNodes("//strong").First().InnerText;
		}

		internal DateTime ParseDateTime(string htmlEntry)
		{
			var doc = new HtmlDocument();
			TextReader t = new StringReader(htmlEntry);
			doc.Load(t);
			string innerText = doc.DocumentNode.SelectNodes("//td").Last().InnerText;
			return DateTime.Parse(innerText);
		}

		internal decimal ParsePrice(string htmlEntry)
		{
			var doc = new HtmlDocument();
			TextReader t = new StringReader(htmlEntry);
			doc.Load(t);
			string innerText = doc.DocumentNode.SelectNodes("//strong").Last().InnerText;
			return decimal.Parse(innerText.Replace(" Euro", "").Replace('.',','));
		}
	}
}