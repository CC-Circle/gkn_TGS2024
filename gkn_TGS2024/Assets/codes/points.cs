using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public static int point;
    public static bool cp;
    // Start is called before the first frame update
    void Start()
    {
        point=0;
        changepoint();
    }

    void changepoint(){
        gameObject.GetComponent<Text>().text = "助けた人数; " + point +"人";
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
