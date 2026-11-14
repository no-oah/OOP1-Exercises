SortedSet<int> SetA = new SortedSet<int>();
SortedSet<int> SetB = new SortedSet<int>();

SetA.Add(1);
SetA.Add(2);

SetB.Add(1);
SetB.Add(3);

Console.WriteLine("SetA:");
foreach (int i in SetA) {
    Console.WriteLine(i);
}

Console.WriteLine("SetB:");
foreach (int i in SetB) {
    Console.WriteLine(i);
}

Console.WriteLine("Intersection");
ISet<int> InterSet = SetCalc.Intersection(SetA, SetB);

foreach (int i in InterSet) {
    Console.WriteLine(i);
}

Console.WriteLine("Union");
ISet<int> UnionSet = SetCalc.Union(SetA, SetB);

foreach (int i in UnionSet) {
    Console.WriteLine(i);
}

Console.WriteLine("Difference");
ISet<int> DiffSet = SetCalc.Difference(SetA, SetB);

foreach (int i in DiffSet) {
    Console.WriteLine(i);
}
    
public class SetCalc {
    public static ISet<T> Intersection<T>(ISet<T> SetA, ISet<T> SetB) {
        ISet<T> IntersectedSet = new SortedSet<T>();
        IntersectedSet.UnionWith(SetA);
        IntersectedSet.IntersectWith(SetB);
        return IntersectedSet;
    }

    public static ISet<T> Union<T>(ISet<T> SetA, ISet<T> SetB) {
        ISet<T> UnionSet = new SortedSet<T>();
        UnionSet.UnionWith(SetA);
        UnionSet.UnionWith(SetB);
        return UnionSet;
    }

    public static ISet<T> Difference<T>(ISet<T> SetA, ISet<T> SetB) {
        ISet<T> DifferentSet = new SortedSet<T>();
        DifferentSet.UnionWith(SetA);
        DifferentSet.ExceptWith(SetB);
        return DifferentSet;
    }
}