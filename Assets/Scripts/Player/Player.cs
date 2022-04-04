using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float xMovement;
    float yMovement;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetMovement();
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector2(xMovement,yMovement));
    }

    void SetMovement()
    {
        xMovement = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        yMovement = Input.GetAxisRaw("Vertical") *speed *Time.deltaTime;
    }
}
