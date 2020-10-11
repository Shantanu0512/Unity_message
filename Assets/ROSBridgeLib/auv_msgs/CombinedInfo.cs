using System.Collections;
using System.Text;
using SimpleJSON;

/* 
 * @brief ROSBridgeLib
 * @author Michael Jenkin, Robert Codd-Downey, Andrew Speers and Miquel Massot Campos
 */

namespace ROSBridgeLib {
	namespace auv_msgs {
        public class CombinedInfo : ROSBridgeMsg {
        private int[] linear_acceleration  ;
        private int[] angular_velocity;
        private int[] rotation;
        
       
         public CombinedInfo(JSONNode msg) {
               
               linear_acceleration = new int[msg["linear_acceleration"].Count];
				for (int i = 0; i < linear_acceleration.Length; i++) {
                    linear_acceleration[i] = int.Parse(msg["linear_acceleration"][i]);
                }
                 angular_velocity = new int[msg["angular_velocity"].Count];
				for (int i = 0; i < angular_velocity.Length; i++) {
                    angular_velocity[i] = int.Parse(msg["angular_velocity"][i]);
                }
                 rotation = new int[msg["rotation"].Count];
				for (int i = 0; i < rotation.Length; i++) {
                    rotation[i] = int.Parse(msg["rotation"][i]);
                }
            } 
           public static string GetMessageType() {
                return "auv_msgs/CombinedInfo";
            }
           
           public CombinedInfo( int[] data1, int[] data2, int[] data3) {
                
                linear_acceleration = data1;
                angular_velocity = data2;
                rotation = data3;
            }
            public int[] GetData_linear_acceleration() {
                return linear_acceleration;
            }
            public int[] GetData_angular_velocity() {
                return angular_velocity;
            }
            public int[] GetData_rotation() {
                return rotation;
            }
            public override string ToString ()
			{
				string array = "[";
				for (int i = 0; i < linear_acceleration.Length; i++) {
					array = array + linear_acceleration[i];
					if (linear_acceleration.Length - i > 1)
						array += ",";
				}
				array += "]";

				string array2 = "[";
				for (int i = 0; i < angular_velocity.Length; i++) {
					array2 = array2 + angular_velocity[i];
					if (angular_velocity.Length - i > 1)
						array2 += ",";
				}
				array2 += "]";
                string array3 = "[";
				for (int i = 0; i < rotation.Length; i++) {
					array2 = array2 + rotation[i];
					if (rotation.Length - i > 1)
						array2 += ",";
				}
				array3 += "]";
				return "CombinedInfo [linear_acceleration=" + array + ", angular_velocity=" + array2 + ", rotation=" + array3 + "]";
			}

			public override string ToYAMLString() {
				string array = "[";
				for (int i = 0; i < linear_acceleration.Length; i++) {
					array = array + linear_acceleration[i];
					if (linear_acceleration.Length - i > 1)
						array += ",";
				}
				array += "]";

				string array2 = "[";
				for (int i = 0; i < angular_velocity.Length; i++) {
					array2 = array2 + angular_velocity[i];
					if (angular_velocity.Length - i > 1)
						array2 += ",";
				}
				array2 += "]";
                string array3 = "[";
				for (int i = 0; i < rotation.Length; i++) {
					array2 = array2 + rotation[i];
					if (rotation.Length - i > 1)
						array2 += ",";
				}
				array3 += "]";
				return "{\"linear_acceleration\" : " + array + ", \"angular_velocity\" : " + array2 +", \"rotation\" : " + array3 + "}";
			}
         
         }

      }
}
