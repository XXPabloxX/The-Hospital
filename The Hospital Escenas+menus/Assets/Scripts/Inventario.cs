using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventario : MonoBehaviour {

    public Image[] itemImage = new Image[numItemSlots];
    public Item[] items = new Item[numItemSlots];

    public const int numItemSlots= 5;

    public void AddItem(Item itemToAdd)
    {
        for(int i = 0; i< items.Length; i ++)
        {
            if(items[i] == null)
            {
                items[i] = itemToAdd;
                itemImage[i].sprite = itemToAdd.sprite;
                itemImage[i].enabled = true;
                return;
            }
        }
    }

    public void RemoveItem(Item itemToRemove)
    {
        for (int i = 0; i < items.Length; i ++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImage[i].sprite = null;
                itemImage[i].enabled = false;
                return;
            }
        }
    }

}
