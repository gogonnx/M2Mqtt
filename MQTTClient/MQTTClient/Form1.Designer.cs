
namespace MQTTClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectbtn = new System.Windows.Forms.Button();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iptxt = new System.Windows.Forms.TextBox();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.publishtopictxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendMessagetxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.reciveMessagetxt = new System.Windows.Forms.TextBox();
            this.reciveTopic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subscribetopictxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subscribebtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.subscribetopictxt1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reciveMessagetxt1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sendMessagetxt1 = new System.Windows.Forms.TextBox();
            this.publishtopictxt1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(329, 8);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 0;
            this.connectbtn.Text = "connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Location = new System.Drawing.Point(425, 8);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectbtn.TabIndex = 1;
            this.disconnectbtn.Text = "disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // iptxt
            // 
            this.iptxt.Location = new System.Drawing.Point(60, 10);
            this.iptxt.Name = "iptxt";
            this.iptxt.Size = new System.Drawing.Size(116, 21);
            this.iptxt.TabIndex = 3;
            this.iptxt.Text = "192.168.10.165";
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(227, 10);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(72, 21);
            this.porttxt.TabIndex = 5;
            this.porttxt.Text = "1884";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // publishtopictxt
            // 
            this.publishtopictxt.Location = new System.Drawing.Point(60, 48);
            this.publishtopictxt.Name = "publishtopictxt";
            this.publishtopictxt.Size = new System.Drawing.Size(219, 21);
            this.publishtopictxt.TabIndex = 7;
            this.publishtopictxt.Text = "/l2/topic1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOPIC";
            // 
            // sendMessagetxt
            // 
            this.sendMessagetxt.Location = new System.Drawing.Point(13, 80);
            this.sendMessagetxt.Multiline = true;
            this.sendMessagetxt.Name = "sendMessagetxt";
            this.sendMessagetxt.Size = new System.Drawing.Size(328, 119);
            this.sendMessagetxt.TabIndex = 11;
            this.sendMessagetxt.Text = "hello";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(285, 46);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "发布主题";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // reciveMessagetxt
            // 
            this.reciveMessagetxt.Location = new System.Drawing.Point(13, 297);
            this.reciveMessagetxt.Multiline = true;
            this.reciveMessagetxt.Name = "reciveMessagetxt";
            this.reciveMessagetxt.Size = new System.Drawing.Size(328, 141);
            this.reciveMessagetxt.TabIndex = 13;
            // 
            // reciveTopic
            // 
            this.reciveTopic.Location = new System.Drawing.Point(60, 270);
            this.reciveTopic.Name = "reciveTopic";
            this.reciveTopic.Size = new System.Drawing.Size(219, 21);
            this.reciveTopic.TabIndex = 15;
            this.reciveTopic.Text = "/l2/topic1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "TOPIC";
            // 
            // subscribetopictxt
            // 
            this.subscribetopictxt.Location = new System.Drawing.Point(60, 222);
            this.subscribetopictxt.Name = "subscribetopictxt";
            this.subscribetopictxt.Size = new System.Drawing.Size(219, 21);
            this.subscribetopictxt.TabIndex = 17;
            this.subscribetopictxt.Text = "/l2/topic1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "TOPIC";
            // 
            // subscribebtn
            // 
            this.subscribebtn.Location = new System.Drawing.Point(285, 220);
            this.subscribebtn.Name = "subscribebtn";
            this.subscribebtn.Size = new System.Drawing.Size(75, 23);
            this.subscribebtn.TabIndex = 18;
            this.subscribebtn.Text = "订阅主题";
            this.subscribebtn.UseVisualStyleBackColor = true;
            this.subscribebtn.Click += new System.EventHandler(this.subscribebtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "订阅主题";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // subscribetopictxt1
            // 
            this.subscribetopictxt1.Location = new System.Drawing.Point(440, 222);
            this.subscribetopictxt1.Name = "subscribetopictxt1";
            this.subscribetopictxt1.Size = new System.Drawing.Size(219, 21);
            this.subscribetopictxt1.TabIndex = 27;
            this.subscribetopictxt1.Text = "/l2/topic2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "TOPIC";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 21);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "/l2/topic2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "TOPIC";
            // 
            // reciveMessagetxt1
            // 
            this.reciveMessagetxt1.Location = new System.Drawing.Point(393, 297);
            this.reciveMessagetxt1.Multiline = true;
            this.reciveMessagetxt1.Name = "reciveMessagetxt1";
            this.reciveMessagetxt1.Size = new System.Drawing.Size(328, 141);
            this.reciveMessagetxt1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "发布主题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // sendMessagetxt1
            // 
            this.sendMessagetxt1.Location = new System.Drawing.Point(393, 80);
            this.sendMessagetxt1.Multiline = true;
            this.sendMessagetxt1.Name = "sendMessagetxt1";
            this.sendMessagetxt1.Size = new System.Drawing.Size(328, 119);
            this.sendMessagetxt1.TabIndex = 21;
            this.sendMessagetxt1.Text = "hello";
            // 
            // publishtopictxt1
            // 
            this.publishtopictxt1.Location = new System.Drawing.Point(440, 48);
            this.publishtopictxt1.Name = "publishtopictxt1";
            this.publishtopictxt1.Size = new System.Drawing.Size(219, 21);
            this.publishtopictxt1.TabIndex = 20;
            this.publishtopictxt1.Text = "/l2/topic2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "TOPIC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subscribetopictxt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reciveMessagetxt1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendMessagetxt1);
            this.Controls.Add(this.publishtopictxt1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subscribebtn);
            this.Controls.Add(this.subscribetopictxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reciveTopic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reciveMessagetxt);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendMessagetxt);
            this.Controls.Add(this.publishtopictxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnectbtn);
            this.Controls.Add(this.connectbtn);
            this.Name = "Form1";
            this.Text = "MQTT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iptxt;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox publishtopictxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendMessagetxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox reciveMessagetxt;
        private System.Windows.Forms.TextBox reciveTopic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subscribetopictxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button subscribebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox subscribetopictxt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reciveMessagetxt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sendMessagetxt1;
        private System.Windows.Forms.TextBox publishtopictxt1;
        private System.Windows.Forms.Label label8;
    }
}

