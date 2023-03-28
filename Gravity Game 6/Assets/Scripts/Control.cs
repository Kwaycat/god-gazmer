using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public PlayerDeath playerDeath;
    public MapMovement map;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerDeath.isDead == true)
        {
            //SceneManager.LoadScene(0);
            HardReset();
        }
    }
    public void HardReset()
    {
        playerDeath.isDead = false;
        map.transform.position = map.startPos;
        map.timePassed = 0;
        player.SetActive(true);
    }

}
