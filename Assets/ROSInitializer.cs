﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib;

public class ROSInitializer : MonoBehaviour
{
   public ROSBridgeWebSocketConnection ros = null;
    
  void Start() {
    // Where the rosbridge instance is running, could be localhost, or some external IP
    ros = new ROSBridgeWebSocketConnection ("ws://localhost", 9090);

    // Add subscribers and publishers (if any)
    ros.AddPublisher (typeof(CombinedInfo_pub));
    ros.AddSubscriber (typeof(CombinedInfo_subs));

    // Fire up the subscriber(s) and publisher(s)
    ros.Connect ();
  }
  
  // Extremely important to disconnect from ROS. Otherwise packets continue to flow
  void OnApplicationQuit() {
    if(ros!=null) {
      ros.Disconnect ();
    }
  }
  // Update is called once per frame in Unity
  void Update () {
    ros.Render ();
  }
}
