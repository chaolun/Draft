using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // CONFIG VARIABLES
    private int StartingHP = 40;
    private int HandSize = 5;
    // END OF CONFIGS


    protected int HealthPoints;
    protected int ManaPool;
    List<Card> MyDeck;
    List<Card> MyHand;
    List<Card> Graveyard;
    List<Card> SummoningPlatform;


    // Use this for initialization
    void Start() {
        HealthPoints = StartingHP;
        ManaPool = 0;
        LoadDeck(null);
        MyHand = new List<Card>();
        Graveyard = new List<Card>();
        SummoningPlatform = new List<Card>();
    }


    // Temp method to load deck later
    void LoadDeck(List<Card> savedDeck)
    {
        print("Loading Deck");
        foreach (Card card in savedDeck)
        {
            MyDeck.Add(card);
        }
    }


    void ReplenishHand()
    {
        print("Replinshing Hand");
        while (MyHand.Count < HandSize)
        {
            MyHand.Add(DrawFromDeck());
        }
        print(MyHand.ToString());
    }


    Card DrawFromDeck()
    {
        if (MyDeck.Count == 0)
        {
            ReplenishDeck();
        }
        int card = Random.Range(0, MyDeck.Count);
        Card drawnCard = MyDeck[card];
        MyDeck.Remove(drawnCard);
        return drawnCard;
    }

    void ReplenishDeck()
    {
        MyDeck = Graveyard;
        Graveyard.Clear();
    }

    void DiscardForMana(Card card)
    {
        ManaPool += card.GetDiscardValue();
    }

    void PlayCard(Card card)
    {
        if (card.GetCostToPlay() <= ManaPool)
        {
            SummoningPlatform.Add(card);
            ManaPool -= card.GetCostToPlay();
        }
    }


    // some setters
    public void TakeDamage(int x)
    {
        this.HealthPoints -= x;
    }
    public void healDamage(int x)
    {
        this.HealthPoints += x;
    }
}
