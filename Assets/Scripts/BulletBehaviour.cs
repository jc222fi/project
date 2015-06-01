using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class BulletBehaviour : MonoBehaviour 
{
	void Start() 
    {
        //Limited life span to prevent "leaking"
        Destroy(gameObject, 5);
        
	}
}
