using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Spell", menuName = "Card/Spell")]
public class SpellData : ScriptableObject {

    public int Cost;
    public int DiscardValue;
    public SpellType Spell;
    public CardColor Color;

}
