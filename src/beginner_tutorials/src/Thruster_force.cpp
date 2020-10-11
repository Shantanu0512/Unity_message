#include<ros/ros.h>
#include<std_msgs/Float64.h>

int main(int argc ,char** argv)
{
   ros::init(argc, argv, "UNity_node");
   ros::NodeHandle nh;
   ros:: Publisher pub5 = nh.advertise<std_msgs::Float64>("thruster_force",1000);
   std_msgs::Float64 msg;
   while(ros::ok())
{ 
  int val;
  std::cout<<"Write something!";
  std::cin>>val;
  msg.data = val ;
  pub5.publish(msg);
  ros::spinOnce();
  
}
  return 0;
}
