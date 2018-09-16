/*
 * 由SharpDevelop创建。
 * 用户： admin
 * 日期: 2018/9/16
 * 时间: 14:54
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace TelloFly
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button startCmd;
		private System.Windows.Forms.Button stopcmd;
		private System.Windows.Forms.TextBox output;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.startCmd = new System.Windows.Forms.Button();
			this.stopcmd = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// startCmd
			// 
			this.startCmd.Location = new System.Drawing.Point(72, 35);
			this.startCmd.Name = "startCmd";
			this.startCmd.Size = new System.Drawing.Size(126, 47);
			this.startCmd.TabIndex = 0;
			this.startCmd.Text = "开始执行";
			this.startCmd.UseVisualStyleBackColor = true;
			this.startCmd.Click += new System.EventHandler(this.StartCmdClick);
			// 
			// stopcmd
			// 
			this.stopcmd.Location = new System.Drawing.Point(258, 36);
			this.stopcmd.Name = "stopcmd";
			this.stopcmd.Size = new System.Drawing.Size(112, 46);
			this.stopcmd.TabIndex = 1;
			this.stopcmd.Text = "停止执行";
			this.stopcmd.UseVisualStyleBackColor = true;
			this.stopcmd.Click += new System.EventHandler(this.StopcmdClick);
			// 
			// output
			// 
			this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.output.Location = new System.Drawing.Point(72, 152);
			this.output.Multiline = true;
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(352, 150);
			this.output.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 338);
			this.Controls.Add(this.output);
			this.Controls.Add(this.stopcmd);
			this.Controls.Add(this.startCmd);
			this.Name = "MainForm";
			this.Text = "特洛命令集";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
