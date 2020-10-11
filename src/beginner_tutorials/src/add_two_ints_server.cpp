#include "ros/ros.h"
#include "beginner_tutorials/AddTwoInts.h"
 
bool prime(beginner_tutorials::AddTwoInts::Request  &req,
     beginner_tutorials::AddTwoInts::Response &res)
    { int num, i, upto;
       int  j=0;
    
    upto = req.a;

   

    for(num = 2; num <= upto; num++) {

        for(i = 2; i <= (num / 2); i++) {

            if(num % i == 0) {
                i = num;
                break;
            }
        }

        // If the number is prime then print it.
        if(i != num) {
            res.prime[j]=num;
            j++;

        }
    }
     return true;
   }
   
   int main(int argc, char **argv)
   {
     ros::init(argc, argv, "add_two_ints_server");
     ros::NodeHandle n;
   
     ros::ServiceServer service = n.advertiseService("add_two_ints", prime);
     ROS_INFO("Ready toprint prime numbers.");
    ros::spin();
   
     return 0;
   }
