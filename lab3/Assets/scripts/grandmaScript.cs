using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grandmaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource yay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "Player"){
            yay.PlayOneShot(yay.clip);
        }
    }

    
    
}
