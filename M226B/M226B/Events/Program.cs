using Events.Classes;
using Events.EventArgs;

Bomb someBomb = new Bomb("Harley", 69);
someBomb.Explosion += OnBombExplosion;

Console.WriteLine("Before Explosion");

someBomb.Detonate();

Console.WriteLine("After Explosion\n\n");

IEnumerable<Bomb> allBombs = new List<Bomb>(5);

for (int i = 0; i < 5; i++)
{
    Bomb newBomb = new Bomb($"Bomb: {i}", 10 * i);

    allBombs = allBombs.Append(newBomb).ToList();
}

foreach (Bomb bombFromList in
         allBombs
             .Where(x => x.MegaTonnes >= 20)
             .OrderBy(x => x.Name))
{
    bombFromList.Explosion += OnBombExplosion;
    bombFromList.Detonate();
}

void OnBombExplosion(object? sender, ExplosionEventArgs args)
{
    Bomb? senderBomb = (Bomb?)sender;

    Console.WriteLine($"Bomb {senderBomb?.Name} exploded:");
    Console.WriteLine($"Force: \t {args.MT}");
}