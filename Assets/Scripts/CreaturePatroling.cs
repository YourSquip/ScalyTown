using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaturePatroling : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.01f;
    private Vector2 start_position;
    public int trail_type;
    void Start()
    {
        start_position = transform.position;
    }
    void trail_horiz_right()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        //Debug.Log(transform.position);
        if (transform.position.x > 20f) transform.position = start_position;
    }
    void trail_horiz_left()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        //Debug.Log(transform.position);
        if (transform.position.x > 20f) transform.position = start_position;
    }

    void trail_circle_left_down()
    {
        if(transform.position.x < -1.5f)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            //Debug.Log(transform.position);
        }
        else if (transform.position.x >= -1.5f )
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed*Time.deltaTime);
        }
        if (transform.position.y < -5f)
        {
            transform.position = start_position;
        }
    }

    void trail_circle_right_down()
    {
        if (transform.position.x >= -1.5f)
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            Debug.Log(transform.position);
        }
        else if (transform.position.x < -1.5f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
        if (transform.position.y < -5f)
        {
            transform.position = start_position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        switch(trail_type)
        {
            case 1:
                trail_horiz_right();
                break;
            case 2:
                trail_horiz_left();
                break;
            case 3:
                trail_circle_left_down();
                break;
            case 4:
                trail_circle_right_down();
                break;
        }
    }
}
