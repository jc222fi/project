using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public Transform bulletPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Boom");
        }
	}
}
