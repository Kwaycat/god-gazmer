using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gravity : MonoBehaviour

{
    private Rigidbody2D rb2d;

    private bool top;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.gravityScale *= -1;
            Rotation();
        }
        void Rotation()
        {
            if (top == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 180f);
            }
            else
            {
                transform.eulerAngles = Vector3.zero;
            }
            top = !top;
        }
    }
}