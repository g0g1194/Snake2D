namespace Snake2D
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelScore = new System.Windows.Forms.Label();
            this.timerGameDelay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelScore
            // 
            resources.ApplyResources(this.labelScore, "labelScore");
            this.labelScore.BackColor = System.Drawing.SystemColors.Window;
            this.labelScore.Name = "labelScore";
            // 
            // timerGameDelay
            // 
            this.timerGameDelay.Enabled = true;
            this.timerGameDelay.Interval = 200;
            this.timerGameDelay.Tick += new System.EventHandler(this.UpdateGame);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OKP);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerGameDelay;
    }
}

