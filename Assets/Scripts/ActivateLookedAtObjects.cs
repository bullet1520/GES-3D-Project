using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookedAtObjects : MonoBehaviour
{

    [SerializeField]
    Text lookedAtObjectText;

    public void DOActivate()
    {
        throw new System.NotImplementedException();
    }


    [SerializeField]
    private float maxActivateDisctance = 4.0f;

    private IActivatable objectLookedAt;

    // Use this for initialization
    void Start ()
    {
		

	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateObjectLookedAt();
        UpdateLookedAtObjectText();
        HandleInput();
    }

    private void UpdateObjectLookedAt()
    {
        Debug.DrawRay(transform.position, transform.forward * maxActivateDisctance, Color.blue);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxActivateDisctance))
        {
            Debug.Log("Raycast hit " + raycastHit.transform.name);
            objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();
        }

        else
        {
            objectLookedAt = null;
        }
    }

    private void HandleInput()
    {
        if (objectLookedAt != null && Input.GetButtonDown("Activate"))
        {
            objectLookedAt.DoActivate();

        }
    }

    private void UpdateLookedAtObjectText()
    {
        
        if (objectLookedAt == null)
        {
            lookedAtObjectText.text = string.Empty;
        }

        else
        {
            lookedAtObjectText.text = objectLookedAt.nameText;
        }

        //lookedAtObjectText.text = objectLookedAt == null ? string.Empty : objectLookedAt.nameText;
        //the above line is the same as the if else statement
    }



}
