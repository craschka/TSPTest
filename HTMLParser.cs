using System.Collections.Generic;
using HtmlAgilityPack;

namespace TSPTest
{
    public interface HTMLParser
    {
       IEnumerable<TankstellenEntry> parse(string htmlDocument);
    }
}