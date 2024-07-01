using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taima : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float mawaru=1/60;
        transform.Rotate(0f, mawaru, 0f);

    }
}
