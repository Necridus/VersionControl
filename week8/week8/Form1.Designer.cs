namespace week8
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.nextLB = new System.Windows.Forms.Label();
            this.carFactoryBT = new System.Windows.Forms.Button();
            this.ballFactoryBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(-3, 152);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainPanel.Size = new System.Drawing.Size(1000, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // nextLB
            // 
            this.nextLB.AutoSize = true;
            this.nextLB.Location = new System.Drawing.Point(253, 37);
            this.nextLB.Name = "nextLB";
            this.nextLB.Size = new System.Drawing.Size(70, 13);
            this.nextLB.TabIndex = 1;
            this.nextLB.Text = "Coming Next:";
            // 
            // carFactoryBT
            // 
            this.carFactoryBT.Location = new System.Drawing.Point(13, 32);
            this.carFactoryBT.Name = "carFactoryBT";
            this.carFactoryBT.Size = new System.Drawing.Size(75, 23);
            this.carFactoryBT.TabIndex = 2;
            this.carFactoryBT.Text = "CAR";
            this.carFactoryBT.UseVisualStyleBackColor = true;
            this.carFactoryBT.Click += new System.EventHandler(this.carFactoryBT_Click);
            // 
            // ballFactoryBT
            // 
            this.ballFactoryBT.Location = new System.Drawing.Point(118, 32);
            this.ballFactoryBT.Name = "ballFactoryBT";
            this.ballFactoryBT.Size = new System.Drawing.Size(75, 23);
            this.ballFactoryBT.TabIndex = 3;
            this.ballFactoryBT.Text = "BALL";
            this.ballFactoryBT.UseVisualStyleBackColor = true;
            this.ballFactoryBT.Click += new System.EventHandler(this.ballFactoryBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.ballFactoryBT);
            this.Controls.Add(this.carFactoryBT);
            this.Controls.Add(this.nextLB);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label nextLB;
        private System.Windows.Forms.Button carFactoryBT;
        private System.Windows.Forms.Button ballFactoryBT;
    }
}

