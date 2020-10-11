
# %Tag(FULLTEXT)%
cmake_minimum_required(VERSION 2.8.3)
project(beginner_tutorials)

## Find catkin and any catkin packages
find_package(catkin REQUIRED COMPONENTS roscpp std_msgs genmsg  message_generation)

add_message_files(
  FILES
  CombinedInfo.msg
)
add_service_files(
  FILES
  AddTwoInts.srv
)

generate_messages(
  DEPENDENCIES
  std_msgs
  
)

## Generate added messages and services


## Declare a catkin package
catkin_package(
  CATKIN_DEPENDS std_msgs   roscpp message_runtime
)

## Build talker and listener
include_directories(include ${catkin_INCLUDE_DIRS})

add_executable(talker src/talker.cpp)
target_link_libraries(talker ${catkin_LIBRARIES})
add_dependencies(talker beginner_tutorials_generate_messages_cpp)

add_executable(listener src/listener.cpp)
target_link_libraries(listener ${catkin_LIBRARIES})
add_dependencies(listener beginner_tutorials_generate_messages_cpp)

add_executable(final src/final.cpp)
target_link_libraries(final ${catkin_LIBRARIES})
add_dependencies(final beginner_tutorials_generate_messages_cpp)

add_executable(Thruster_force src/Thruster_force.cpp)
target_link_libraries(Thruster_force ${catkin_LIBRARIES})
add_dependencies(Thruster_force beginner_tutorials_generate_messages_cpp)

add_executable(add_two_ints_server src/add_two_ints_server.cpp)
target_link_libraries(add_two_ints_server ${catkin_LIBRARIES})
add_dependencies(add_two_ints_server beginner_tutorials_gencpp)

add_executable(add_two_ints_client src/add_two_ints_client.cpp)
target_link_libraries(add_two_ints_client ${catkin_LIBRARIES})
add_dependencies(add_two_ints_client beginner_tutorials_gencpp)

add_executable(talk src/talk.cpp)
target_link_libraries(talk ${catkin_LIBRARIES})
add_dependencies(talk beginner_tutorials_gencpp)




# %EndTag(FULLTEXT)%
