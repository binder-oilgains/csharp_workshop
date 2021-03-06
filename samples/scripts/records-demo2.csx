#load "records.csx"


// INHERITANCE VS VALUE semantics

Person3 basePerson = new ("John","Doe");

Person3 p1 = new ("John","Doe");

// event though we have parent p5 as Person2, other details of instance are preserved
WriteLine($"object.Equals: {Equals(basePerson, p1)}");

Person3 p2 = p1 with {};

// this is also true for cloning
WriteLine($"object.Equals: {Equals(basePerson, p2)}");
WriteLine($"object.Equals: {Equals(p1, p2)}");
