using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public int point;
    public  bool cp;
    // Start is called before the first frame update
    void Start()
    {
        point=0;
        cp=true;
    }

    void changepoint(){
        gameObject.GetComponent<Text>().text = "　　　　　　 " + point +"円";
    }

    // Update is called once per frame
    void Update()
    {
        if(cp){
            cp=false;
            changepoint();
        }
    }
}
