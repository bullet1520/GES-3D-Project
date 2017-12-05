using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Inventory : MonoBehaviour {

    [SerializeField]
    private GameObject inventoryMenu;

    private bool IsMenuShowing
    {
        get {return inventoryMenu.activeSelf;}
    }

    [SerializeField]
    private FirstPersonController firstPersonController;


    public List<InventoryObject> PlayerInventory{get; private set;}


    private void Awake()
    {
        PlayerInventory = new List<InventoryObject>();
    }

    // Use this for initialization
    void Start ()
    {
        HideMenu();
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        HandleInput();
        
    }

    private void HandleInput()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            if (IsMenuShowing)
            {
                HideMenu();
            }

            else
            {
                ShowMenu();
            }
            
        }
    }

    private void HideMenu()
    {
        inventoryMenu.SetActive(false);
        UpdateCursor();
        firstPersonController.enabled = true;
    }

    private void ShowMenu()
    {
        inventoryMenu.SetActive(true);
        UpdateCursor();
        firstPersonController.enabled = false;
    }


    private void UpdateCursor()
    {
        if (IsMenuShowing)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }

        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
           
    }
}
