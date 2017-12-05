using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string NameText;

    //[a tag can go here to enlarge input text box in editor]
    [SerializeField]
    private string descriptionText;

    private MeshRenderer meshRenderer;
    private Collider collider;

    private List<InventoryObject> playerInventory;

    public string nameText
    {
        get
        {
            return NameText;
        }
    }

    public void DoActivate()
    {
        playerInventory.Add(this);
        meshRenderer.enabled = false;
        collider.enabled = false;
    }

    // Use this for initialization
    void Start ()
    {
        //https://github.com/dantogno/GES-3D-Demo reference this for help
        playerInventory = FindObjectOfType<inventoryMenu>().PlayerInventory;
        meshRenderer.GetComponent<MeshRenderer>();
        collider.GetComponent<Collider>();
	}
	
	// Update is called once per frame

}
