using System.Text.Json;

string contents = File.ReadAllText("vapen.json");

Vapen v = JsonSerializer.Deserialize<Vapen>(contents);

Console.WriteLine("Hur många attacker vill du göra?");

int mängdattacker = 0;
string attackstyrka = "";

while (!int.TryParse(attackstyrka, out mängdattacker))
{
  attackstyrka = Console.ReadLine();
}

int skada1 = 0;

Console.ForegroundColor = ConsoleColor.Red;

for (int a = 0; a < mängdattacker; a++)
{
  int skada = v.Attack();
  Console.WriteLine($"+{skada}");
  skada1 += skada;
}

Console.ResetColor();

Console.WriteLine($"Du gjorde {skada1} skada");

Console.ReadLine();
