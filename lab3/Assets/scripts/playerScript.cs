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
    public Animator anim;

    public InputActionReference movement, jump;

    public AudioSource cookieSound;
    public int lives = 100;
    

    private float moveX;
    private float moveY;

    private bool facingLeft = true;
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
        moveY = jump.action.ReadValue<float>();

        anim.SetFloat("Up", Mathf.Abs(moveY));

        if (moveX > 0 && !facingLeft) 
        {
            Flip();
        }

        else if (moveX < 0 && facingLeft)
        {
            Flip();
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveX* speed, 0));
    }

    void performJump(InputAction.CallbackContext context)
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

    }

    void Flip() 
    {
        facingLeft = !facingLeft;
        
        //flip scaling on the x axis 
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "cookie"){
            Destroy(other.gameObject);
            cookieSound.Play();
            lives += 5;
            GeneralUI.instance.updateLives(lives);
        }
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
