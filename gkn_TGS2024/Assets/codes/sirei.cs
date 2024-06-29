using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sirei : MonoBehaviour
{
    // Start is called before the first frame update
    private int randamu;//ランダムな値を代入するためのint
    private int hito1;
    void Start()
    {
        randamu=0;//初期化
        hito1=1;
        MonoBehaviour ido1no1=new MonoBehaviour();//ほかのスクリプトを呼ぶための関数（御呪い）
    }

    // Update is called once per frame
    void Update()
    {
        randamu=UnityEngine.Random.Range(1,10001);
        if(randamu<=10){
            //Debug.Log("発進");
           /* if(hito1==1){
                ido1no1.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==3){
                ido1no3.start=true;
            }else if(hito1==4){
                ido1no4.start=true;
            }else if(hito1==5){
                ido1no5.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }else if(hito1==2){
                ido1no2.start=true;
            }*/
        hito1++;
        }
        if(randamu<=20&&randamu>10){
            
        }

    }
}
