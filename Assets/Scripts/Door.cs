using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable
{

    private Animator animator;

    [SerializeField]
    private string NameText;

    public string nameText
    {
        get
        {
            return NameText;
        }
    }

    public void DoActivate()
    {
        throw new System.NotImplementedException();
        animator.SetBool("shouldOpen", true);
    }



	// Use this for initialization
	void Start ()
    {
        //animator.GetComponent<Animator>();
	}
}
