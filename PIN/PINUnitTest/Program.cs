Pin pin = new Pin();

Console.WriteLine("Under critical amount");
for (int i=0 ; i<20 ; i++) {
    bool give_pin = pin.Expend(42);
    Console.WriteLine(i + ": 42 -> " + give_pin);
}

Console.WriteLine("\nRandom amount");
Random r = new Random();
for (int i = 0 ; i<20 ; i++) {
    int amount = r.Next(0,350*2);
    bool give_pin = pin.Expend(amount);
    Console.WriteLine(i+": "+amount+" -> "+give_pin);
}


RandomPin rPin = new RandomPin();

Console.WriteLine("\n20% chance");
int n = 0;
for (int i = 0 ; i < 100 ; i++) {
    bool pin_req = rPin.Expend(1);
    Console.WriteLine(i+": 1 ->"+pin_req);
    if (pin_req) {
        n++;
    }
}
Console.WriteLine("Times pin was required out of 100:"+n);