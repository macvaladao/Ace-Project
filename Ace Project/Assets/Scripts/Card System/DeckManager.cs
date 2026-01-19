using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    public List<CardData> deck = new List<CardData>();
    public GameObject cardPrefab;
    public Transform handArea;

    public void DrawCard()
    {
        if (deck.Count == 0) return;
        
        CardData data = deck[0];
        deck.RemoveAt(0);
        
        GameObject newCard = Instantiate(cardPrefab, handArea);
        
        CardDisplay display = newCard.GetComponent<CardDisplay>();
        display.LoadCard(data);
    }
}
