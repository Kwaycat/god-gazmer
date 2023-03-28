using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public KillSquare killSquare;
    public MapMovement map;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && killSquare.isDead == true)
        {
            //SceneManager.LoadScene(0);
            HardReset();
        }
    }
    public void HardReset()
    {
        killSquare.isDead = false;
        map.transform.position = map.startPos;
        map.timePassed = 0;
    }

}
