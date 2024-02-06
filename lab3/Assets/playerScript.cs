using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 300.0f;

    public float jumpForce = 150.0f;
    public Rigidbody2D rb;

    public InputActionReference movement, jump;

    public int lives = 100;

    private float moveX;
    void Start()
    {
        
    }
    private void OnEnable()
    {
        jump.action.started += performJump;
    }

    private void OnDisable()
    {
        jump.action.started -= performJump;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = movement.action.ReadValue<float>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveX* speed, 0));
    }

    void performJump(InputAction.CallbackContext context)
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy"){
            lives -= 1;
            GeneralUI.instance.updateLives(lives);
            if(lives <= 0){
                Destroy(gameObject);
            }
        }
    }
    
}
