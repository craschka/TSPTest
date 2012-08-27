using System;

namespace TSPTest
{
    public class TankstellenEntry
    {
	    public TankstellenEntry(decimal price, string name, DateTime date)
	    {
		    this.price = price;
		    this.name = name;
		    this.date = date;
	    }

	    private readonly DateTime date;
        private readonly string name;
        private readonly decimal price;

		 public string Name()
		 {
			 return name;
		 }

		 public DateTime Date()
		 {
			 return date;
		 }

        public string Price()
        {
            return price.ToString();
        }
        
        public bool IsPmOrStar()
        {
            return name.Equals("PM Pfennings") || name.Equals("JET");
        }

        public bool IsNewerThan(TankstellenEntry oldEntry)
        {
            return oldEntry==null || date > oldEntry.date;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}, bei {2})",Price(),Date().ToString(),Name()) ;
        }
    }
}