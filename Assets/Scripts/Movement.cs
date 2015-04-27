using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{

    public float speed;
    //public Vector2 speed = new Vector2(10, 10);
    //public Vector2 direction = new Vector2(1, 0);

    //private Vector2 movement;
	// Use this for initialization
	void Start() 
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        Destroy(gameObject, 5);
	}
	
	 //Update is called once per frame
    //void Update()
    //{
    //    if (GetComponent<Rigidbody2D>() == GameObject.FindGameObjectWithTag("Enemy"))
    //    {
    //        GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
    //        print(GetComponent<Rigidbody2D>());
    //    }
    //}
    //void FixedUpdate()
    //{
    //    GetComponent<Rigidbody2D>().velocity = movement;
    //}
}
