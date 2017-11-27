using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookedAtObjects : MonoBehaviour
{

    [SerializeField]
    private float maxActivateDisctance = 4.0f;



	// Use this for initialization
	void Start ()
    {
		

	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.forward * maxActivateDisctance, Color.blue);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxActivateDisctance))
        {
            Debug.Log("Raycast hit " + raycastHit.transform.name);
            IActivatable objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();

            if (objectLookedAt != null && Input.GetButtonDown("Activate"))
            {
                objectLookedAt.doActivate();

            }

        }


        




	}








}
