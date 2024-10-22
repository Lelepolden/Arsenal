using System.Text.Json.Serialization;

public class Vapen
{
  [JsonInclude]
  public string vapnet;

  [JsonInclude]
  private int SkadaMin = 10;

  [JsonInclude]
  private int SkadaMax = 20;

  public int Attack()
  {
    return Random.Shared.Next(SkadaMin, SkadaMax);
  }
}