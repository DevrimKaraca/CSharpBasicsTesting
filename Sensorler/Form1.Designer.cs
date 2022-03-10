
namespace Sensorler
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
            this.buttonSensor1 = new System.Windows.Forms.Button();
            this.buttonSensor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSensor1
            // 
            this.buttonSensor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSensor1.Location = new System.Drawing.Point(0, 0);
            this.buttonSensor1.Name = "buttonSensor1";
            this.buttonSensor1.Size = new System.Drawing.Size(75, 165);
            this.buttonSensor1.TabIndex = 0;
            this.buttonSensor1.Text = "Sensör1";
            this.buttonSensor1.UseVisualStyleBackColor = true;
            this.buttonSensor1.Click += new System.EventHandler(this.buttonSensor1_Click);
            // 
            // buttonSensor2
            // 
            this.buttonSensor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSensor2.Location = new System.Drawing.Point(75, 0);
            this.buttonSensor2.Name = "buttonSensor2";
            this.buttonSensor2.Size = new System.Drawing.Size(167, 165);
            this.buttonSensor2.TabIndex = 1;
            this.buttonSensor2.Text = "Sensör2";
            this.buttonSensor2.UseVisualStyleBackColor = true;
            this.buttonSensor2.Click += new System.EventHandler(this.buttonSensor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 165);
            this.Controls.Add(this.buttonSensor2);
            this.Controls.Add(this.buttonSensor1);
            this.Name = "Form1";
            this.Text = "Sensörler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSensor1;
        private System.Windows.Forms.Button buttonSensor2;
    }
}

