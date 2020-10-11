    #include "ros/ros.h"
    #include "beginner_tutorials/AddTwoInts.h"
    #include <cstdlib>
    
    int main(int argc, char **argv)
    {
      ros::init(argc, argv, "add_two_ints_client");
      if (argc != 2)
      {
       ROS_INFO("usage: add_two_ints_client X ");
       return 1;
     }
   
     ros::NodeHandle n;
     ros::ServiceClient client = n.serviceClient<beginner_tutorials::AddTwoInts>("add_two_ints");
     beginner_tutorials::AddTwoInts srv;
     srv.request.a = atoll(argv[1]);
     
     
     if (client.call(srv))
     {
      
       
       for(int t =0;t<156;t++){
       if(srv.response.prime[t]==0)
       break;
       ROS_INFO("%ld",(long int)srv.response.prime[t]);
       }}
     else
     {
       ROS_ERROR("Failed to call service add_two_ints");
       return 1;
     }
   
     return 0;
   }
