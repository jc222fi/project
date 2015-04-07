using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour 
{
    //public Rigidbody2D bullet;
    //public int bulletSpeed = 2;

    //private Transform bulletSpawn;

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 0);

    private Vector2 movement;
	// Use this for initialization
	void Start() 
    {
        //bulletSpawn = transform.Find("Bullet");
	}

    void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }
	
	void FixedUpdate() 
    {
        GetComponent<Rigidbody2D>().velocity = movement;
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Rigidbody2D bulletClone;
        //    bulletClone = Instantiate(bullet) as Rigidbody2D;
        //    bulletClone.AddForce(new Vector2(1, 0), ForceMode2D.Force);
        //}
	}
}
