namespace week7
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
            this.endyearL = new System.Windows.Forms.Label();
            this.propL = new System.Windows.Forms.Label();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.browseBT = new System.Windows.Forms.Button();
            this.startBT = new System.Windows.Forms.Button();
            this.endyearNUD = new System.Windows.Forms.NumericUpDown();
            this.resultsRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.endyearNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // endyearL
            // 
            this.endyearL.AutoSize = true;
            this.endyearL.Location = new System.Drawing.Point(13, 13);
            this.endyearL.Name = "endyearL";
            this.endyearL.Size = new System.Drawing.Size(35, 13);
            this.endyearL.TabIndex = 0;
            this.endyearL.Text = "label1";
            // 
            // propL
            // 
            this.propL.AutoSize = true;
            this.propL.Location = new System.Drawing.Point(287, 13);
            this.propL.Name = "propL";
            this.propL.Size = new System.Drawing.Size(35, 13);
            this.propL.TabIndex = 1;
            this.propL.Text = "label2";
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(362, 10);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(171, 20);
            this.fileTB.TabIndex = 2;
            // 
            // browseBT
            // 
            this.browseBT.Location = new System.Drawing.Point(540, 10);
            this.browseBT.Name = "browseBT";
            this.browseBT.Size = new System.Drawing.Size(75, 23);
            this.browseBT.TabIndex = 3;
            this.browseBT.Text = "button1";
            this.browseBT.UseVisualStyleBackColor = true;
            this.browseBT.Click += new System.EventHandler(this.browseBT_Click);
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(621, 10);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(75, 23);
            this.startBT.TabIndex = 4;
            this.startBT.Text = "button2";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // endyearNUD
            // 
            this.endyearNUD.Location = new System.Drawing.Point(55, 10);
            this.endyearNUD.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.endyearNUD.Name = "endyearNUD";
            this.endyearNUD.Size = new System.Drawing.Size(71, 20);
            this.endyearNUD.TabIndex = 5;
            // 
            // resultsRTB
            // 
            this.resultsRTB.Location = new System.Drawing.Point(12, 36);
            this.resultsRTB.Name = "resultsRTB";
            this.resultsRTB.Size = new System.Drawing.Size(684, 442);
            this.resultsRTB.TabIndex = 6;
            this.resultsRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 490);
            this.Controls.Add(this.resultsRTB);
            this.Controls.Add(this.endyearNUD);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.browseBT);
            this.Controls.Add(this.fileTB);
            this.Controls.Add(this.propL);
            this.Controls.Add(this.endyearL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.endyearNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endyearL;
        private System.Windows.Forms.Label propL;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Button browseBT;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.NumericUpDown endyearNUD;
        private System.Windows.Forms.RichTextBox resultsRTB;
    }
}

