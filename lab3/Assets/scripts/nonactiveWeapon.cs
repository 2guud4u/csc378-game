using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonactiveWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject weapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(weapon, transform.position, Quaternion.identity);
            Debug.Log("picked up weapon");
            Destroy(gameObject);
        }
    }

}
