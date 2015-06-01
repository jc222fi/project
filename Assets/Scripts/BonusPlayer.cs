using UnityEngine;
using System.Collections;

public class BonusPlayer : MonoBehaviour 
{
    public int speed;
    public GameObject shitPrefab;
    public Transform shitSpawn;

    //Player controlls for bonus level
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shitPrefab, shitSpawn.position, shitSpawn.rotation);
        }
    }
}
