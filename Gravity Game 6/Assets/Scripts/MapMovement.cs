using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour
{

    float scrollSpeed = -5f;
    public Vector2 startPos;
    public float timePassed = 0;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        float newPos = timePassed * scrollSpeed;
        transform.position = startPos + Vector2.right * newPos;
    }
}
