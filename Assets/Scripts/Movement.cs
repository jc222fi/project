using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
    //Decides the movement for enemies and bullet, specify speed directly in Unity for variation depending on gameobject without changing the script

    public float speed;

	void Start() 
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        Destroy(gameObject, 7);
	}
}
