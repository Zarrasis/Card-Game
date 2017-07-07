using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TargetingOptions{
    EnemyCreatures,
    YourCreatures, 
    EnemyCharacters,
    YourCharacters
}

public class CardAsset : ScriptableObject{
    [Header("General info")]
    [TextArea(2,3)]
    public string Description;
	public Sprite CardImage;
	public Sprite UnitImage;
    public int ManaCost;

    [Header("Creature Info")]
    public int MaxHealth;
    public int Attack;
    public string CreatureScriptName;
    public int specialCreatureAmount;

    [Header("SpellInfo")]
    public string SpellScriptName;
    public int specialSpellAmount;
    public TargetingOptions Targets;
}