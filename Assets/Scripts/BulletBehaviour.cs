using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour 
{
    //public Rigidbody2D bullet;
    //public int bulletSpeed = 2;

    //private Transform bulletSpawn;


	// Use this for initialization
	void Start() 
    {
        //Limited life span
        Destroy(gameObject, 7);
	}

    void Update()
    {

    }
	
	void FixedUpdate() 
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Rigidbody2D bulletClone;
        //    bulletClone = Instantiate(bullet) as Rigidbody2D;
        //    bulletClone.AddForce(new Vector2(1, 0), ForceMode2D.Force);
        //}
	}
}
