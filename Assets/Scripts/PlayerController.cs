using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
	// Use this for initialization
	void Start() 
    {
	
	}
	
	// Update is called once per frame
	void Update() 
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            
            //Movement movement = bulletClone.gameObject.GetComponent<Movement>();
        }
	}
}
