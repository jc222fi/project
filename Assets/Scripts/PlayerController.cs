using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float step;

    private AudioSource audio;
    private bool canFire = true;
    private float coolDown = 0.75f;
    //Initializing soundclip for the gun
	void Start() 
    {
        audio = GetComponent<AudioSource>();
	}
	void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
        //If the player presses Down or Right arrow the player moves the specified amount of steps to the right/down OR left/up on the Left or Up arrow
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * -step);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * step);
        } 
	}

    IEnumerator Attack()
    {
        //Bool canFire is changed with the cool-down for reloading the gun, adjusted for the reload on the soundclip for the gun
        if (canFire)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            canFire = false;
            audio.Play();

            yield return new WaitForSeconds(coolDown);
            canFire = true; 
        }
    }
}
