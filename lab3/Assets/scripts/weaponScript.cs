using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100f;
    public GameObject pivotObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObj.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
