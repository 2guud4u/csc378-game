using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class hutScript : MonoBehaviour
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
    public void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "grandma"){
            yay.PlayOneShot(yay.clip);
            SceneManager.LoadScene(3);
        }
    }
}
