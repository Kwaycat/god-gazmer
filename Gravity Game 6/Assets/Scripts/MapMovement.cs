using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{

    float scrollSpeed = -5f;
    Vector2 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Time.time * scrollSpeed;
        transform.position = startPos + Vector2.right * newPos;
        Debug.Log("time: " + Time.time + " & Deltatime" + Time.deltaTime);              
    }
}
