using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 moveDirection;
    private GameObject playerObject;
    public Rigidbody2D rb;

    public float speed = 5f;

    public int health = 30;

    public AudioSource audioSource;
    void Start()
    {
        playerObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = playerObject.transform.position;
        moveDirection = playerPos - transform.position;
    }

    void FixedUpdate()
    {
        rb.velocity = moveDirection.normalized * speed;
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "weapon"){
            health -= 10;
            audioSource.PlayOneShot(audioSource.clip);
            if(health <= 0){
                Destroy(gameObject);
            }
        }
    }
}
