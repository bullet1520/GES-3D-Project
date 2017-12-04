using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable
{
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
        Debug.Log(transform.name + " was activated");
    }

    //private void Start()
    //{
    //    DoActivate();

    //}







}
