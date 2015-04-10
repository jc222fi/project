using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public Transform bulletPrefab;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            var bulletClone = Instantiate(bulletPrefab) as Transform;
            bulletClone.position = transform.position;

            BulletBehaviour bullet = bulletClone.gameObject.GetComponent<BulletBehaviour>();
            print("Boom");

            Movement movement = bulletClone.gameObject.GetComponent<Movement>();
        }
	}
}
