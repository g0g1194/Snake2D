namespace Snake2D
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.trackBarGameDelay = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSizeX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSizeY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarGameDelay
            // 
            resources.ApplyResources(this.trackBarGameDelay, "trackBarGameDelay");
            this.trackBarGameDelay.LargeChange = 100;
            this.trackBarGameDelay.Maximum = 1000;
            this.trackBarGameDelay.Minimum = 50;
            this.trackBarGameDelay.Name = "trackBarGameDelay";
            this.trackBarGameDelay.SmallChange = 50;
            this.trackBarGameDelay.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGameDelay.Value = 200;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numericUpDownSizeX
            // 
            resources.ApplyResources(this.numericUpDownSizeX, "numericUpDownSizeX");
            this.numericUpDownSizeX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeX.Name = "numericUpDownSizeX";
            this.numericUpDownSizeX.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numericUpDownSizeY
            // 
            resources.ApplyResources(this.numericUpDownSizeY, "numericUpDownSizeY");
            this.numericUpDownSizeY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSizeY.Name = "numericUpDownSizeY";
            this.numericUpDownSizeY.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // buttonSaveSettings
            // 
            resources.ApplyResources(this.buttonSaveSettings, "buttonSaveSettings");
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonRemove
            // 
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSizeY);
            this.Controls.Add(this.numericUpDownSizeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarGameDelay);
            this.Name = "FormSettings";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarGameDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeX;
        private System.Windows.Forms.NumericUpDown numericUpDownSizeY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonRemove;
    }
}