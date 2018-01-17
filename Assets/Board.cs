using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    // SOME CONFIG VARIABLES
    int GridSize = 3;
    int DeckSize = 60;
    // END OF CONFIGS

    List<Card> Deck;
    List<List<Card>> Grid;



    // Use this for initialization
    void Start() {
        Deck = new List<Card>(DeckSize);

        List<Card> TopRow = new List<Card>(GridSize);
        List<Card> MiddleRow = new List<Card>(GridSize);
        List<Card> BottomRow = new List<Card>(GridSize);

        Grid = new List<List<Card>>();
        Grid.Add(TopRow);
        Grid.Add(MiddleRow);
        Grid.Add(BottomRow);
    }

    void PopulateField()
    {
        for (int i = 0; i < GridSize; i++)
        {
            for (int j = 0; j < GridSize; j++)
            {
                Grid[i][j] = DrawFromDeck();
            }
        }
    }

    Card DrawFromDeck()
    {
        int card = Random.Range(0, Deck.Count);
        Card drawnCard = Deck[card];
        Deck.Remove(drawnCard);
        return drawnCard;
    }

    Card DraftCard(int xPos, int yPos)
    {
        Card selected = Grid[xPos][yPos];
        Grid[xPos][yPos] = DrawFromDeck();
        return selected;
    }



}