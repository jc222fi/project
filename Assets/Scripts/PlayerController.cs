using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float step;

    private bool canFire = true;
    private float coolDown = 0.5f;
	// Use this for initialization
	void Start() 
    {
        
	}
	
	// Update is called once per frame
	void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
        //float step = speed * Time.time;

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (true)//(transform.rotation.z >-1 || (transform.rotation.z <=350 && transform.rotation.z >= 280))
            {
                transform.Rotate(Vector3.forward * -step); 
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (true)//(transform.rotation.z >-1 || (transform.rotation.z <=350 && transform.rotation.z >= 280))
            {
                transform.Rotate(Vector3.forward * step); 
            }
        } 
	}

    IEnumerator Attack()
    {
        if (canFire)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            canFire = false;

            yield return new WaitForSeconds(coolDown);
            canFire = true; 
        }
        //Movement movement = bulletClone.gameObject.GetComponent<Movement>();
        
    }
}
