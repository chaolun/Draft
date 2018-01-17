using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Hero", menuName = "Card/Hero")]
public class HeroData : ScriptableObject {

    public Tribe Tribe;
    public JobClass Class;

    public CardColor Color1;
    public CardColor Color2;
    public CardColor Color3;

    public int Cost;
    public int DiscardValue;

    public int Damage;
    public int Health;

    public Keyword Effect1;
    public Keyword Effect2;
    public Keyword Effect3;

}
