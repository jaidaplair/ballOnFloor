using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x;
        float y;

        x = Random.Range(-7f,7f);//random spot on the x axis
        y = Random.Range(-3.5f, 3.5f);//random spot on the y axis

        Vector3 myPosition = new Vector3(x, y, 0f);
        transform.position = myPosition;

        Rigidbody2D ballRigidBody = GetComponent<Rigidbody2D>();//get rigid body2d component for ball
        ballRigidBody.velocity = new Vector2(3, 4);

        //SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
       // spriteRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
