using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float step;
	// Use this for initialization
	void Start() 
    {
	
	}
	
	// Update is called once per frame
	void Update() 
    {
        Attack();
        //float step = speed * Time.time;
        
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.forward * -step);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.forward * step);
        }
	}

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            //Movement movement = bulletClone.gameObject.GetComponent<Movement>();
        }
    }
}
