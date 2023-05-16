namespace Rock_Paper_Scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LangSelector = new System.Windows.Forms.ComboBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.LangSelectorLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            resources.ApplyResources(this.btnRock, "btnRock");
            this.btnRock.Name = "btnRock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            resources.ApplyResources(this.btnPaper, "btnPaper");
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            resources.ApplyResources(this.btnScissors, "btnScissors");
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // txtMessage
            // 
            resources.ApplyResources(this.txtMessage, "txtMessage");
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Click += new System.EventHandler(this.txtMessage_Click);
            // 
            // roundsText
            // 
            resources.ApplyResources(this.roundsText, "roundsText");
            this.roundsText.Name = "roundsText";
            // 
            // RestartBtn
            // 
            resources.ApplyResources(this.RestartBtn, "RestartBtn");
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.restartGame);
            // 
            // txtTime
            // 
            resources.ApplyResources(this.txtTime, "txtTime");
            this.txtTime.Name = "txtTime";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LangSelector
            // 
            resources.ApplyResources(this.LangSelector, "LangSelector");
            this.LangSelector.FormattingEnabled = true;
            this.LangSelector.Items.AddRange(new object[] {
            resources.GetString("LangSelector.Items"),
            resources.GetString("LangSelector.Items1"),
            resources.GetString("LangSelector.Items2"),
            resources.GetString("LangSelector.Items3")});
            this.LangSelector.Name = "LangSelector";
            this.LangSelector.SelectedIndexChanged += new System.EventHandler(this.LangSelector_SelectedIndexChanged);
            // 
            // picCPU
            // 
            resources.ApplyResources(this.picCPU, "picCPU");
            this.picCPU.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.picCPU.Name = "picCPU";
            this.picCPU.TabStop = false;
            // 
            // picPlayer
            // 
            resources.ApplyResources(this.picPlayer, "picPlayer");
            this.picPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // LangSelectorLB
            // 
            resources.ApplyResources(this.LangSelectorLB, "LangSelectorLB");
            this.LangSelectorLB.Name = "LangSelectorLB";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LangSelectorLB);
            this.Controls.Add(this.LangSelector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LangSelector;
        private System.Windows.Forms.Label LangSelectorLB;
    }
}

