using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource audioSource;
    public float rotationSpeed = 100f;
    public GameObject pivotObj;

    private SpringJoint2D mySpringJoint;

    // Start is called before the first frame update
    void Start()
    {
        mySpringJoint = GetComponent<SpringJoint2D>();
        pivotObj = GameObject.FindGameObjectWithTag("Player");
        mySpringJoint.connectedBody = pivotObj.GetComponent<Rigidbody2D>();
        mySpringJoint.distance = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObj.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("hit");
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
