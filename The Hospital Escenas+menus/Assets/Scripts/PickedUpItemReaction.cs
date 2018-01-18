using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedUpItemReaction : MonoBehaviour {

    public Item item;

    private Inventario inventory;

    protected override void SpecificInit()
    {

        inventory = FindObjectOfType<Inventario>();

    }

    protected override void ImmediateReaction()
    {

        inventory.AddItem(item);

    }
}
