using UnityEngine;

[CreateAssetMenu(menuName = "Custom/Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string nameOfItem;
    [SerializeField] private Sprite image;

    public string GetNameOfCard()
    {
        return nameOfItem;
    }

    public Sprite GetPicture()
    {
        return image;
    }
}