/*
This message class is generated automatically with 'SimpleMessageGenerator' of ROS#
*/ 

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;
using RosSharp.RosBridgeClient.Messages.Navigation;
using RosSharp.RosBridgeClient.Messages.Sensor;
using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.Messages.Actionlib;

namespace RosSharp.RosBridgeClient.Messages
{
public class ExampleMessage : Message
{
[JsonIgnore]
public const string RosMessageName = "beginner_tutorials/ExampleMessage";

public int a;
public String str;
public Odometry odom;

public ExampleMessage()
{
a = new int();
str = new String();
odom = new Odometry();
}
}
}

