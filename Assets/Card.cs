using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Card : MonoBehaviour {

    //Stuff that all cards are able to do
    protected int CostToPlay;
    protected int DiscardValue;

    protected int HealthPoints;
    protected int MaxHealthPoints;
    protected int AttackPoints;

    //All cards need UI data...
    public TextMeshProUGUI UIName;
    public TextMeshProUGUI UIEffect;
    public TextMeshProUGUI UICost;
    public TextMeshProUGUI UIColor;

    public virtual void UpdateCardText()
    {
        print(name + " Card got updated Text");
    }

    public virtual void Play()
    {
        //Play A Card to the field
        //Override based on being a Unit or Spell
        print(name + " | Was Played");
    }

    public void ToGraveyard(Player player)
    {
        //Move the Card to the graveyard
        print(name + " | being sent to graveyard");
        //remember to resolve all effects the card had
    }

    public void Remove()
    {
        print(name + " | being removed from game");
        //REMOVE the card from play from game
    }

    public void Attack(Player player)
    {
        print(name + " | is attacking");
        player.TakeDamage(this.AttackPoints);
    }



    // getters and setters
    public void IncreaseAttack(int x)
    {
        this.AttackPoints += x;
    }

    public void DecreaseAttack(int x)
    {
        this.AttackPoints -= x;
    }
    
    public int GetDiscardValue()
    {
        return DiscardValue;
    }

    public int GetCostToPlay()
    {
        return CostToPlay;
    }
}
