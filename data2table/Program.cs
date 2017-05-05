using System;

class Program {
    
	static void Main(string[] args) {
        
        Country[] countries = { 
            new Country{name="USA",population="350 million"}, 
            new Country{name="China",population="1.4 billion"},
            new Country{name="Russia",population="145 million"}
        };

        Console.WriteLine("DUMP:");
		foreach (Country c in countries) {
            Console.WriteLine("{{:name => {0}, :population => {1}}}", c.name, c.population);
        }
        Console.WriteLine();


        Console.WriteLine("TABLE:");
        Console.WriteLine("Countries | Population");
        string line = new String('-', "Countries | Population".Length);
        Console.WriteLine(line);
		foreach (Country c in countries) {
            int whitespace = "Countries ".Length - c.name.Length;
            string s = new String(' ', whitespace);
            Console.Write("{0}{1}|", c.name, s);
            Console.Write("{0}", c.population);
            Console.WriteLine();
		}
	}
}

class Country {
	public string name { get; set; }
	public string population { get; set; }
}