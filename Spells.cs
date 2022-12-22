using Newtonsoft.Json;
public class Spells : StatusEffects
{
    // [JsonProperty("Spells")]
    static string path = $@"{Directory.GetCurrentDirectory()}\data\spells.json";
    public int ManaCost { get; set; }
    public string ID { get; set; }

    static string spellString = File.ReadAllText(path);
    public static List<SpellProperties> spellList = JsonConvert.DeserializeObject<List<SpellProperties>>(spellString);
    public static List<string> spellIDs = new();
    public static List<string> spellNames = new();
    public static List<ulong> spellDurations = new();
    public static List<int> spellPotencies = new();
    public static List<int> spellCosts = new();
    public static List<StatusType> spellTypes = new();
    public static List<Target> spellTargets = new();
    public static List<StatusEffects> playerEffects = new();
    public static List<StatusEffects> enemyEffects = new();
    static Spells()
    {
        foreach (SpellProperties spell in spellList)
        {
            spellIDs.Add(spell.ID);
            spellNames.Add(spell.Name);
            spellDurations.Add(spell.Duration);
            spellPotencies.Add(spell.Potency);
            spellCosts.Add(spell.ManaCost);
            spellTypes.Add(spell.Type);
            spellTargets.Add(spell.Target);
        }
    }
    public Spells(string name, ref int mana, string origin) //change properties to their list index's values
    {
        int index = spellNames.IndexOf(name);
        ID = spellIDs[index];
        Name = spellNames[index];
        Duration = spellDurations[index];
        Potency = spellPotencies[index];
        ManaCost = spellCosts[index];
        Type = spellTypes[index];
        mana -= ManaCost;
        if (origin == "Player") playerEffects.Add(new(Type, Duration, Potency));
        else enemyEffects.Add(new(Type, Duration, Potency));
    }
}
public struct SpellProperties
{
    [JsonProperty(PropertyName = "ID")]
    public string ID { get; set; }
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName = "Duration")]
    public ulong Duration { get; set; }
    [JsonProperty(PropertyName = "Potency")]
    public int Potency { get; set; }
    [JsonProperty(PropertyName = "ManaCost")]
    public int ManaCost { get; set; }
    [JsonProperty(PropertyName = "Type")]
    public StatusType Type { get; set; }
    [JsonProperty(PropertyName = "Target")]
    public Target Target { get; set; }
}