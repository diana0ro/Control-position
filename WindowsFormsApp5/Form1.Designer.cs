namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Velocity = new System.Windows.Forms.TextBox();
            this.Acceleration = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DistToBe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance To Be";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Velocity
            // 
            this.Velocity.AcceptsReturn = true;
            this.Velocity.Location = new System.Drawing.Point(227, 27);
            this.Velocity.Name = "Velocity";
            this.Velocity.ReadOnly = true;
            this.Velocity.Size = new System.Drawing.Size(100, 20);
            this.Velocity.TabIndex = 4;
            // 
            // Acceleration
            // 
            this.Acceleration.AcceptsReturn = true;
            this.Acceleration.Location = new System.Drawing.Point(227, 72);
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.ReadOnly = true;
            this.Acceleration.Size = new System.Drawing.Size(100, 20);
            this.Acceleration.TabIndex = 5;
            // 
            // Distance
            // 
            this.Distance.AcceptsReturn = true;
            this.Distance.Location = new System.Drawing.Point(22, 73);
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Size = new System.Drawing.Size(100, 20);
            this.Distance.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Acceleration";
            // 
            // DistToBe
            // 
            this.DistToBe.Location = new System.Drawing.Point(22, 26);
            this.DistToBe.Name = "DistToBe";
            this.DistToBe.Size = new System.Drawing.Size(100, 20);
            this.DistToBe.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 187);
            this.Controls.Add(this.DistToBe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Acceleration);
            this.Controls.Add(this.Velocity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Velocity;
        private System.Windows.Forms.TextBox Acceleration;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DistToBe;
    }
}

