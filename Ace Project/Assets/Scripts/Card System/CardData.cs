using UnityEngine;

[CreateAssetMenu(fileName = "NovaCarta", menuName = "Card System/Nova Carta")]
public class CardData : ScriptableObject
{
    [Header("Informações Basicas")]
    public string id;
    public string cardName;
    [TextArea] public string cardDescription;
    public Sprite cardSprite;
    
    [Header("Status")]
    public int manaCost;
    public int attack;
    public int health;
}
