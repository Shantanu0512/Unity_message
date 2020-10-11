using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.auv_msgs;
using ROSBridgeLib;
using SimpleJSON;


public class Data_Manger : MonoBehaviour
{
  
    //Required for TwistMsg
    
    int[] lin = {1,2,3};
    int[] ang = {4,5,6};
    int[] rota = {7,8,9};
    GameObject rosObj;
     CombinedInfo msg;
    // Start is called before the first frame update
   void Start()
    {
      //Since we attached ROSInitiazer to Main Camera:
        rosObj = GameObject.Find ("Main Camera");
       
    }

    // Update is called once per frame
    void Update()
    {
      //dependant on the message defintion:
        
        
        msg =  new CombinedInfo(lin,ang,rota);
        rosObj.GetComponent<ROSInitializer>().ros.Publish(
            CombinedInfo_pub.GetMessageTopic(),msg
        );
    }
}