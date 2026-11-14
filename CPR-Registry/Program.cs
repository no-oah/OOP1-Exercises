public class Person {
    private string name;
    private int age;
    private string cpr;

    public Person(string name, int age, string cpr) {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

    public string GetName() {
        return this.name;
    }

    public int GetAge() {
        return this.age;
    }

    public string GetCpr() {
        return this.cpr;
    }

    public override string ToString() {
        return this.name+" "+this.age+" "+this.cpr;
    }

    public static void Main() {
        List<Person> people = new List<Person>(); 
        
        people.Add(new Person("John Doe", 32, "101010-1010"));
        people.Add(new Person("Jane Doe", 31, "010101-0101"));
        people.Add(new Person("Mr. Meow", 4, "690420-6769"));
        people.Add(new Person("idk", 100, "102223-4000"));
        people.Add(new Person("idk v2", 50, "322342-6000"));

        foreach (Person i in people) {
            if (i.GetCpr() == "010101-0101") {
                Console.WriteLine("Found in list (3 lines of code): "+i.ToString());
            }
        }

        Dictionary<string, Person> map = new Dictionary<string, Person>();

        foreach (Person i in people) {
            map.Add(i.GetCpr(), i);
        }
        Console.WriteLine("Found in dictionary (1 line of code): "+map["010101-0101"].ToString());
    }
}