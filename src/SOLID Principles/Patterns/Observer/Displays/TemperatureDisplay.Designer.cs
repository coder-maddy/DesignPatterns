namespace Observer.Displays
{
    partial class TemperatureDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showFareniht = new System.Windows.Forms.CheckBox();
            this.tempertureData = new System.Windows.Forms.Label();
            this.dataRecivedAt = new System.Windows.Forms.Label();
            this.stopUpdating = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.humidityData = new System.Windows.Forms.Label();
            this.pressureData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showFareniht
            // 
            this.showFareniht.AutoSize = true;
            this.showFareniht.Location = new System.Drawing.Point(48, 14);
            this.showFareniht.Name = "showFareniht";
            this.showFareniht.Size = new System.Drawing.Size(114, 19);
            this.showFareniht.TabIndex = 0;
            this.showFareniht.Text = "Show in Fareniht";
            this.showFareniht.UseVisualStyleBackColor = true;
            // 
            // tempertureData
            // 
            this.tempertureData.AutoSize = true;
            this.tempertureData.Location = new System.Drawing.Point(121, 45);
            this.tempertureData.Name = "tempertureData";
            this.tempertureData.Size = new System.Drawing.Size(24, 15);
            this.tempertureData.TabIndex = 1;
            this.tempertureData.Text = "0 C";
            // 
            // dataRecivedAt
            // 
            this.dataRecivedAt.AutoSize = true;
            this.dataRecivedAt.Location = new System.Drawing.Point(60, 155);
            this.dataRecivedAt.Name = "dataRecivedAt";
            this.dataRecivedAt.Size = new System.Drawing.Size(0, 15);
            this.dataRecivedAt.TabIndex = 2;
            // 
            // stopUpdating
            // 
            this.stopUpdating.Location = new System.Drawing.Point(60, 119);
            this.stopUpdating.Name = "stopUpdating";
            this.stopUpdating.Size = new System.Drawing.Size(75, 23);
            this.stopUpdating.TabIndex = 3;
            this.stopUpdating.Text = "Stop";
            this.stopUpdating.UseVisualStyleBackColor = true;
            this.stopUpdating.Click += new System.EventHandler(this.stopUpdating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Humidity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pressure";
            // 
            // humidityData
            // 
            this.humidityData.AutoSize = true;
            this.humidityData.Location = new System.Drawing.Point(121, 73);
            this.humidityData.Name = "humidityData";
            this.humidityData.Size = new System.Drawing.Size(0, 15);
            this.humidityData.TabIndex = 7;
            // 
            // pressureData
            // 
            this.pressureData.AutoSize = true;
            this.pressureData.Location = new System.Drawing.Point(121, 101);
            this.pressureData.Name = "pressureData";
            this.pressureData.Size = new System.Drawing.Size(0, 15);
            this.pressureData.TabIndex = 8;
            // 
            // TemperatureDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pressureData);
            this.Controls.Add(this.humidityData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopUpdating);
            this.Controls.Add(this.dataRecivedAt);
            this.Controls.Add(this.tempertureData);
            this.Controls.Add(this.showFareniht);
            this.Name = "TemperatureDisplay";
            this.Size = new System.Drawing.Size(246, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox showFareniht;
        private Label tempertureData;
        private Label dataRecivedAt;
        private Button stopUpdating;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label humidityData;
        private Label pressureData;
    }
}
