using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.auv_msgs;
using ROSBridgeLib;
using SimpleJSON;



public class CombinedInfo_subs : ROSBridgeSubscriber
{
 
  
  // These two are important
  public new static string GetMessageTopic() {
    //Topic name is up to the user. It should return the full path to the topic. 
    //For eg, "/turtle1/cmd_vel" instead of "/cmd_vel".
    return "/continousCombinedInfo";
  }

  public new static string GetMessageType() {
    //Same as the definition present in ROS documentation:
    return "beginner_tutorials/CombinedInfo";
  }

  // Important function (I think.. Converts json to PoseMsg)
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new CombinedInfo (msg);
  }
  
  
  public new static void CallBack(ROSBridgeMsg msg) {
     Debug.Log("Hello Hello !"+ msg.ToYAMLString());
    
     }
  
}
