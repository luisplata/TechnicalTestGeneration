using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClikeableButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] protected Item item;
    [SerializeField] private SelectionSystem selectionSystem;
    [SerializeField] private Image panel;
    [SerializeField] protected TextMeshProUGUI nameOfItem;
    [SerializeField] protected Image pictureOfItem;
    private readonly Color _colorToSelect = new(1, 1, 0, 0.4f);
    private readonly Color _colorToUnselect = new(0, 0, 0, 0.4f);

    // Start is called before the first frame update
    protected virtual void Start()
    {
        UnselectItem();
        button.onClick.AddListener(() =>
        {
            panel.color = _colorToSelect;
            selectionSystem.SelectItem(this);
        });
    }

    public void UnselectItem()
    {
        panel.color = _colorToUnselect;
    }

    public Item GetItem()
    {
        if (item == null)
        {
            throw new Exception("Item not found");
        }
        return item;
    }

    public void Config(Item randomItem, SelectionSystem system)
    {
        item = randomItem;
        selectionSystem = system;
        pictureOfItem.sprite = item.GetPicture();
        nameOfItem.text = item.GetNameOfCard();
    }
}