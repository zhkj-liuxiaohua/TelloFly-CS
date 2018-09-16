/*
 * 由SharpDevelop创建。
 * 用户： admin
 * 日期: 2018/9/16
 * 时间: 16:05
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace TelloFly
{
	/// <summary>
	/// Description of TELLOMSG.
	/// </summary>
	public class TELLOMSG
	{
		public TELLOMSG()
		{
		}
		
		/// <summary>
		/// 进入SDK命令模式
		/// </summary>
		public const String command = "command";
		
		/// <summary>
		/// 自动起飞
		/// </summary>
		public const String takeoff = "takeoff";
		
		/// <summary>
		/// 自动降落
		/// </summary>
		public const String land = "land";
		
		/// <summary>
		/// 打开视频流
		/// </summary>
		public const String streamon = "streamon";
		
		/// <summary>
		/// 关闭视频流
		/// </summary>
		public const String streamoff = "streamoff";
		
		/// <summary>
		/// 停止电机转动
		/// </summary>
		public const String emergency = "emergency";
		
		/// <summary>
		/// 格式：up x<br/>
		/// 向上飞 x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String up = "up ";
		
		/// <summary>
		/// 格式：down x<br/>
		/// 向下飞 x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String down = "down ";
		
		/// <summary>
		/// 格式：left x<br/>
		/// 向左飞 x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String left = "left ";
		
		/// <summary>
		/// 格式：right x<br/>
		/// 向右飞x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String right = "right ";
		
		/// <summary>
		/// 格式：forward x<br/>
		/// 向前飞 x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String forward = "forward ";
		
		/// <summary>
		/// 格式：back x<br/>
		/// 向后飞 x 厘米<br/>
		/// x = 20-500
		/// </summary>
		public const String back = "back ";
		
		/// <summary>
		/// 格式：cw x<br/>
		/// 顺时针旋转x°<br/>
		/// x = 1-3600
		/// </summary>
		public const String cw = "cw ";
		
		/// <summary>
		/// 格式：ccw x<br/>
		/// 逆时针旋转 x°<br/>
		/// x = 1-3600
		/// </summary>
		public const String ccw = "ccw ";
		
		/// <summary>
		/// 格式：flip x<br/>
		/// 朝 x 方向翻 滚<br/>
		/// l = (left)<br/>
		/// r =(right)<br/>
		/// f = (forward)<br/>
		/// b = (back)
		/// </summary>
		public const String flip = "flip ";
		
		/// <summary>
		/// 格式：go x y z speed<br/>
		/// 以设置速度（cm/s）飞往坐标 （x,y,z）<br/>
		/// x: 20-500<br/>
		/// y: 20-500<br/>
		/// z: 20-500<br/>
		/// speed: 10-100
		/// </summary>
		public const String go = "go ";
		
		/// <summary>
		/// 格式：curve x1 y1 z1 x2 y2 z2 speed<br/>
		/// 以设置速度（ cm/s ）飞弧线，经过（x1,y1,z1）到（x2,y2,z2）<br/>
		/// 如果弧线半径不在0.5-10米范围 内，则返回相应提醒。<br/>
		/// x1, x2: -500 - 500<br/>
		/// y1, y2: -500 - 500<br/>
		/// z1, z2: -500 - 500<br/>
		/// speed: 10-60<br/>
		/// x、y、z不能同时在-20 ~ 20之间
		/// </summary>
		public const String curve = "curve ";
		
		/// <summary>
		/// 格式：speed x<br/>
		/// 将当前速度设为 x cm/s<br/>
		/// x = 10-100
		/// </summary>
		public const String speed = "speed ";
		
		/// <summary>
		/// 格式：rc a b c d
		/// 设置遥控器的4个通道杆量<br/>
		/// a: 横滚  (-100~100)<br/>
		/// b: 俯仰(-100~100)<br/>
		/// c: 油门 (-100~100)<br/>
		/// d: 旋转(-100~100)
		/// </summary>
		public const String rc = "rc ";
		
		/// <summary>
		/// 格式：wifi ssid pass<br/>
		/// 设置WiFi SSID 密码
		/// </summary>
		public const String wifi = "wifi ssid ";
		
		/// <summary>
		/// 获取当前设置速度 （cm/s）
		/// <returns> x<br/>x = (10-100) </returns>
		/// </summary>
		public const String readspeed = "speed?";
		
		/// <summary>
		/// 获取当前电池剩余 电量的百分比值
		/// <returns> x<br/>x= (0-100)</returns>
		/// </summary>
		public const String readbattery = "battery?";
		
		/// <summary>
		/// 获取电机运转时间 （s）
		/// <returns>x</returns>
		/// </summary>
		public const String readtime = "time?";
		
		/// <summary>
		/// 获取相对高度 (cm) 
		/// <returns>x: 10-3000</returns>
		/// </summary>
		public const String readheight = "height?";
		
		/// <summary>
		/// 获取主板 最高和最低温度(℃)
		/// <returns>x: 0-90 </returns>
		/// </summary>
		public const String readtemp = "temp?";
		
		/// <summary>
		/// 获取IMU 三轴姿态数据
		/// <returns>pitch roll yaw<br/>
		/// pitch=（-89°- 89°）<br/>
		/// roll=（-179°- 179°）<br/>
		/// yaw=（-179°- 179°）</returns>
		/// </summary>
		public const String readattitude = "attitude?";
		
		/// <summary>
		/// 获取气压计高度(m)
		/// <returns>x</returns>
		/// </summary>
		public const String readbaro = "baro?";
		
		/// <summary>
		/// 获取IMU 三轴加速度数据(0.001g) 
		/// <returns>x y z</returns>
		/// </summary>
		public const String readacceleration = "acceleration?";
		
		/// <summary>
		/// 获取ToF 的高度值(cm)
		/// <returns>x: 10-400 & 6553<br/>
		/// 返回 6553 意味着测量值超过 ToF量程。 </returns>
		/// </summary>
		public const String readtof = "tof?";
		
		/// <summary>
		/// 获得Wi-Fi信噪比
		/// <returns>snr</returns>
		/// </summary>
		public const String readwifi = "wifi?";
	}
}
