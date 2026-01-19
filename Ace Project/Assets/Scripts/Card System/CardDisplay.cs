using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardData cardData;
    
    [Header("UI Elements")]
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription;
    public Image artworkImage;
    public TextMeshProUGUI manaCost;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        if (cardData != null)
        {
            LoadCard(cardData);
        }
    }

    public void LoadCard(CardData data)
    {
        cardData = data;
        
        cardName.text = data.cardName;
        cardDescription.text = data.cardDescription;
        artworkImage.sprite = data.cardSprite;
        manaCost.text = data.manaCost.ToString();
        attackText.text = data.attack.ToString();
        healthText.text = data.health.ToString();
    }
}
