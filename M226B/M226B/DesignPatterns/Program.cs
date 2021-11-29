using DesignPatterns.Composite;
using DesignPatterns.Iterator;

///
/// COMPOSITES
/// 

CompositeOperation rootOperation = new CompositeOperation(100);
CompositeOperation subOperation1 = new CompositeOperation(50);

//create single operations
PrimitiveOperation primitiveSubOp1 = new PrimitiveOperation(25);
PrimitiveOperation primitiveSubOp2 = new PrimitiveOperation(12.5);

//make single operations sub operations of subOperation1
subOperation1.AddChild(primitiveSubOp1);
subOperation1.AddChild(primitiveSubOp2);

//make subOperation1 sub operation of root
rootOperation.AddChild(subOperation1);

PrimitiveOperation primitiveSubOp3 = new PrimitiveOperation(6.25);

//add single sub operation to root

rootOperation.AddChild(primitiveSubOp3);

Console.WriteLine("Value of Root: " + rootOperation.GetValue() + "\n\n");


///
/// ITERATOR
///

IEnumerable<int> randomNums = Iterator.GetRandoms(69);
foreach (int num in randomNums)
    Console.WriteLine(num);

