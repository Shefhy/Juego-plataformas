using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour

{
    
    //(una forma de hacerlo)
    public float speed = 5;
    private float horizontal; 
    //private Transform playerTransform;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //playerTransform = GetComponent<Transform>();
    }

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //(lo mismo de otra manera) playerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;
        //(lo mismo de otra manera) playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Sapace.World);
        rb.velocity = new Vector2 (horizontal * speed, 0f);
    
    }

    
}