﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemReturnManager : MonoBehaviour
{
    private Actor actor;

    public InventoryItemDisplay inventoryItemDisplayPrefab;
    public static Transform targetTransform;
    private InventoryDisplay inventoryDisplay;
    public List<InventoryItem> items = new List<InventoryItem>();

    private List<int> ids = new List<int>();
    public bool hasAddedItems;

    private GameObject[] inventoryItems;

    public List<InventoryItem> itemsNotAdded = new List<InventoryItem>();

    void Start ()
    {
        if (hasAddedItems == false)
        {
            actor = FindObjectOfType<Actor>();
            targetTransform = GameObject.Find("InventoryDisplay").transform;
            inventoryItems = GameObject.FindGameObjectsWithTag("Item");
            inventoryDisplay = FindObjectOfType<InventoryDisplay>();
            StartCoroutine(BeginReturningIDS());
            hasAddedItems = true;
        }
        Actor[] actors = FindObjectsOfType<Actor>();
        for (int i = 1; i < actors.Length; i++)
        {
            Destroy(actors[i].gameObject);
        }
    }

    public void ItemsNeedToBeAdded()
    {
        if (SceneManager.GetActiveScene().name != "Primary")
            return;

        if (itemsNotAdded.Count > 0)
        {
            for (int i = 0; i < itemsNotAdded.Count; i++)
            {
                actor.data.ids.Add(itemsNotAdded[i].itemId);
                InventoryItemDisplay display = (InventoryItemDisplay)Instantiate(inventoryItemDisplayPrefab);
                display.transform.SetParent(targetTransform, false);

                InventoryItem returnInventoryItem = display.gameObject.AddComponent<InventoryItem>();

                display.GetComponent<InventoryItem>().itemId = itemsNotAdded[i].itemId;
                display.GetComponent<InventoryItem>().ReturnItems();

                display.item = returnInventoryItem;

                //itemsNotAdded.Remove(itemsNotAdded[i]);                
            }
            itemsNotAdded.Clear();
        }    
    }
	
	IEnumerator BeginReturningIDS()
    {
        if (SceneManager.GetActiveScene().name != "Primary")
            yield break;

        yield return new WaitForSeconds(.3f);

        foreach(int id in actor.data.ids)
        {
            ids.Add(id);
            //Debug.Log("Got an id");
        }
        for (int i = 0; i < ids.Count; i++)
        {
            InventoryItemDisplay display = (InventoryItemDisplay)Instantiate(inventoryItemDisplayPrefab);
            display.transform.SetParent(targetTransform, false);

            InventoryItem returnInventoryItem = display.gameObject.AddComponent<InventoryItem>();

            display.GetComponent<InventoryItem>().itemId = actor.data.ids[i];
            display.GetComponent<InventoryItem>().ReturnItems();

            display.item = returnInventoryItem;           
        }
    }
}
