public class EquipmentItem : ClikeableButton
{
    protected override void Start()
    {
        base.Start();
        ResetGraphics();
    }

    private void ResetGraphics()
    {
        nameOfItem.text = "";
        pictureOfItem.sprite = null;
    }

    public bool HasItem()
    {
        return item != null;
    }

    public void EquipItem(Item itemToEquip)
    {
        item = itemToEquip;
        pictureOfItem.sprite = item.GetPicture();
        nameOfItem.text = item.GetNameOfCard();
    }

    public void UnEquipmentItem()
    {
        item = null;
        ResetGraphics();
    }
}