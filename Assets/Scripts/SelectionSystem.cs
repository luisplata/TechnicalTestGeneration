using System;
using UnityEngine;

public class SelectionSystem : MonoBehaviour
{
    private ClikeableButton itemSelected;
    public void SelectItem(ClikeableButton clikeableButton)
    {
        itemSelected?.UnselectItem();
        try
        {
            Debug.Log(clikeableButton.GetItem().GetNameOfCard());
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        itemSelected = clikeableButton;
    }

    public ClikeableButton GetItemSelected()
    {
        if (itemSelected == null)
        {
            throw new Exception("Item no Selected");
        }
        return itemSelected;
    }
}
