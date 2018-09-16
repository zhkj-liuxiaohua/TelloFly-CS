/*
 * 由SharpDevelop创建。
 * 用户： admin
 * 日期: 2018/9/16
 * 时间: 14:54
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TelloFly.net;
using System.Diagnostics;

namespace TelloFly
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool cmdStoped = true;
		P2PLoader telloController = null;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void StartCmdClick(object sender, EventArgs e)
		{
			startCmd.Enabled = false;
			if(null == telloController) {
				telloController = new P2PLoader();
			}
			telloController.setOnReceiveMsg(onTelloMsg);
			telloController.startListen();
			cmdStoped = false;
			Thread t = new Thread(delegate () {
			                      	try {
			                      	while(!cmdStoped) {
			                      		output.Text = "开启命令！";
			                      		telloController.sendMsg(TELLOMSG.command);
			                      		Thread.Sleep(3000);
			                      		isFalse(cmdStoped);
			                      		output.Text = "起飞！";
			                      		telloController.sendMsg(TELLOMSG.takeoff);
			                      		Thread.Sleep(7000);
			                      		isFalse(cmdStoped);
			                      		output.Text = "翻滚！";
			                      		telloController.sendMsg(TELLOMSG.flip + "r");
			                      		Thread.Sleep(7000);
			                      		isFalse(cmdStoped);
			                      		output.Text = "下落！";
			                      		telloController.sendMsg(TELLOMSG.land);
			                      		Thread.Sleep(7000);
			                      	}
			                      	} catch (Exception ue){
			                      		output.Text = ue.Message;
			                      	} finally {
			                      	// do nothing
			                      }
			                      });
			t.Start();
		}
		
		void StopcmdClick(object sender, EventArgs e)
		{
			telloController.stopListen();
			startCmd.Enabled = true;
			cmdStoped = true;
		}
		
		void onTelloMsg(String ip, String msg) {
			output.Text = "ip= " + ip + " msg=" + msg;
		}
		
		
		public void isFalse(bool f) {
			if (!f) {
				return;
			}
			throw new Exception("用户终止了一个进程");
		}
	}

}
