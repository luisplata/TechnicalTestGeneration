using UnityEngine;
using UnityEngine.UI;

public class ItemCreatorSystem : MonoBehaviour
{
    [SerializeField] private Item[] items;
    [SerializeField] private ClikeableButton panelPrefab;
    [SerializeField] private GridLayoutGroup group;
    [SerializeField] private SelectionSystem selectionSystem;
    [SerializeField] private int maxCountItem;
    private int _count;

    public void CreateItem()
    {
        if (_count >= maxCountItem) return;
        _count++;
        var instanceOfPanel = Instantiate(panelPrefab, group.gameObject.transform);
        int randomIndex = Random.Range(0, items.Length); // get a random index within the array bounds
        var randomObject = items[randomIndex];
        instanceOfPanel.Config(randomObject, selectionSystem);
    }
}