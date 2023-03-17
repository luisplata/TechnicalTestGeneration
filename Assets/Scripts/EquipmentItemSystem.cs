using System;
using UnityEngine;

public class EquipmentItemSystem : MonoBehaviour
{
    [SerializeField] private SelectionSystem selectionSystem;
    [SerializeField] private EquipmentItem[] items;
    
    public void EquipItem()
    {
        try
        {
            var item = selectionSystem.GetItemSelected().GetItem();
            foreach (var equipmentItem in items)
            {
                if (equipmentItem.HasItem()) continue;
                equipmentItem.EquipItem(item);
                return;
            }

            //Esta el equipamiento lleno
            Debug.Log("Equipamiento lleno");
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public void UnEquippingItem()
    {
        try
        {
            var item = selectionSystem.GetItemSelected();
            if (typeof(EquipmentItem) == item.GetType())
            {
                var itemEquipment = (EquipmentItem) item;
                itemEquipment.UnEquipmentItem();
                return;
            }
            //Lo seleccionado no es un item equipado
            Debug.Log("Item selected to un equip is not a equipment item");
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}