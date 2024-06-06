using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float CharacterSpeed;
    Rigidbody2D rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(HorizontalInput * CharacterSpeed,rb.velocity.y);

        //karakter saða gidecekse saða döndür
        if (HorizontalInput> 0.01f)
        {
            transform.localScale = new Vector3(0.009f, 0.009f, 0.009f);
        }
        //Karakter sola gidecekse sola döndür
        else if (HorizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-0.009f, 0.009f, 0.009f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, CharacterSpeed);
        }
    }
}