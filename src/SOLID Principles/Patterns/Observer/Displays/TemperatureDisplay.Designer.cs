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
            this.tempertureData.Location = new System.Drawing.Point(89, 51);
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
            this.stopUpdating.Location = new System.Drawing.Point(70, 101);
            this.stopUpdating.Name = "stopUpdating";
            this.stopUpdating.Size = new System.Drawing.Size(75, 23);
            this.stopUpdating.TabIndex = 3;
            this.stopUpdating.Text = "Stop";
            this.stopUpdating.UseVisualStyleBackColor = true;
            this.stopUpdating.Click += new System.EventHandler(this.stopUpdating_Click);
            // 
            // TemperatureDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
