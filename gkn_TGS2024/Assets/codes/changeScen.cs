using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void naguru(){


        SceneManager.LoadScene("game");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            naguru();
        }
    }
    void FixedUpdate(){

    }
}
