using System.Text.Json;

string contents = File.ReadAllText("weapon.json");

Vapen w = JsonSerializer.Deserialize<Vapen>(contents);

Console.WriteLine("How many attacks do you want to make?");

int numAttacks = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
  numAttacksStr = Console.ReadLine();
}