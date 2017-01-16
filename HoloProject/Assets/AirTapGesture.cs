using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AirTapGesture : MonoBehaviour, IInputClickHandler
{
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnInputClicked(InputEventData eventData)
    {
        gameObject.AddComponent<Rigidbody>();
    }
}
