﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCanvas : MonoBehaviour
{
    private CanvasScaler scaler;
    public GameObject menuToggleButton;
    public GameObject ui;
    public bool toggleCheck;

    public GameObject inventoryButton;
    public GameObject equipmentButton;
    public GameObject skillButton;
    public GameObject optionsButton;

    private Equip[] equip;



	void Start ()
    {
        toggleCheck = true;
        scaler = GetComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        ui.SetActive(true);
        menuToggleButton.SetActive(true);

        equipmentButton.SetActive(false);
        optionsButton.SetActive(false);
        inventoryButton.SetActive(true);
        skillButton.SetActive(false);
    }

    public void UpdateItemsinItemArray()
    {
        equip = FindObjectsOfType<Equip>();
        foreach(Equip equipped in equip)
        {
            equipped.items = equip;
        }
    }

    public void ToggleButtonOn()
    {
        if(toggleCheck == false)
        {
            ui.SetActive(true);
            toggleCheck = true;
        }
        else if(toggleCheck == true)
        {
            ui.SetActive(false);
            toggleCheck = false;
        }
    }

    public void ActivateInventory()
    {
        equipmentButton.SetActive(false);
        skillButton.SetActive(false);
        optionsButton.SetActive(false);
        inventoryButton.SetActive(true);
    }
    public void ActivateEquip()
    {
        skillButton.SetActive(false);
        inventoryButton.SetActive(false);
        optionsButton.SetActive(false);
        equipmentButton.SetActive(true);
    }
    public void ActivateSkills()
    {
        equipmentButton.SetActive(false);
        inventoryButton.SetActive(false);
        optionsButton.SetActive(false);
        skillButton.SetActive(true);
    }
    public void ActivateOptions()
    {
        equipmentButton.SetActive(false);
        inventoryButton.SetActive(false);
        skillButton.SetActive(false);
        optionsButton.SetActive(true);

    }

    public void SceneTransfer()
    {
        Application.LoadLevel("Other");
    }
}
