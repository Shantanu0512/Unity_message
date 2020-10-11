﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.auv_msgs;
using ROSBridgeLib;
using SimpleJSON;


/**
 * This defines a publisher. There had better be a corresponding subscriber somewhere. This is really
 * just a holder for the message topic and message type.
 * 
 * Version History
 * 3.1 - changed methods to start with an upper case letter to be more consistent with c#
 * style.
 * 3.0 - modification from hand crafted version 2.0
 * 
 * @author Michael Jenkin, Robert Codd-Downey and Andrew Speers
 * @version 3.1
 */

namespace ROSBridgeLib {
	public class CombinedInfo_pub : ROSBridgePublisher{
		
		public static string GetMessageTopic() {
			return "/continousCombinedInfo";
		}  
		
		public static string GetMessageType() {
			return "beginner_tutorials/CombinedInfo";
		}
        public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
        return new CombinedInfo(msg);
        }  
        public static string ToYAMLString(CombinedInfo msg) {
        return msg.ToYAMLString();
        }
        
		
	}
}
