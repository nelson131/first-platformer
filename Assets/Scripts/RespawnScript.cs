using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "KillBox")
        {
            SceneManager.LoadScene(1);
        }

        if(collider.tag == "nextlevel")
        {
            SceneManager.LoadScene(2);
        }
    }
}
