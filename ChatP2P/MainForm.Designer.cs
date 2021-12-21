
namespace ChatP2P
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChatButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.OtherPortTextBox = new System.Windows.Forms.TextBox();
            this.OtherIPTextBox = new System.Windows.Forms.TextBox();
            this.MyPortTextBox = new System.Windows.Forms.TextBox();
            this.MyIPTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NicknameTextBox = new System.Windows.Forms.TextBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(70)))));
            this.HeaderPanel.Controls.Add(this.label6);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 41);
            this.HeaderPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.SettingsButton);
            this.ButtonsPanel.Controls.Add(this.ChatButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 41);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(800, 40);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(88)))));
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsButton.Location = new System.Drawing.Point(400, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(400, 40);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChatButton
            // 
            this.ChatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(77)))), ((int)(((byte)(183)))));
            this.ChatButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChatButton.FlatAppearance.BorderSize = 0;
            this.ChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChatButton.Location = new System.Drawing.Point(0, 0);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Size = new System.Drawing.Size(400, 40);
            this.ChatButton.TabIndex = 2;
            this.ChatButton.Text = "Чат";
            this.ChatButton.UseVisualStyleBackColor = false;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Controls.Add(this.ChatPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 81);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 467);
            this.MainPanel.TabIndex = 2;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.OtherPortTextBox);
            this.SettingsPanel.Controls.Add(this.OtherIPTextBox);
            this.SettingsPanel.Controls.Add(this.MyPortTextBox);
            this.SettingsPanel.Controls.Add(this.MyIPTextBox);
            this.SettingsPanel.Controls.Add(this.label5);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.NicknameTextBox);
            this.SettingsPanel.Controls.Add(this.ConnectButton);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(800, 467);
            this.SettingsPanel.TabIndex = 1;
            // 
            // OtherPortTextBox
            // 
            this.OtherPortTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.OtherPortTextBox.Location = new System.Drawing.Point(400, 121);
            this.OtherPortTextBox.Name = "OtherPortTextBox";
            this.OtherPortTextBox.Size = new System.Drawing.Size(388, 30);
            this.OtherPortTextBox.TabIndex = 10;
            this.OtherPortTextBox.Text = "8002";
            // 
            // OtherIPTextBox
            // 
            this.OtherIPTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.OtherIPTextBox.Location = new System.Drawing.Point(400, 50);
            this.OtherIPTextBox.Name = "OtherIPTextBox";
            this.OtherIPTextBox.Size = new System.Drawing.Size(388, 30);
            this.OtherIPTextBox.TabIndex = 9;
            // 
            // MyPortTextBox
            // 
            this.MyPortTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MyPortTextBox.Location = new System.Drawing.Point(31, 121);
            this.MyPortTextBox.Name = "MyPortTextBox";
            this.MyPortTextBox.Size = new System.Drawing.Size(359, 30);
            this.MyPortTextBox.TabIndex = 8;
            this.MyPortTextBox.Text = "8001";
            // 
            // MyIPTextBox
            // 
            this.MyIPTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.MyIPTextBox.Location = new System.Drawing.Point(31, 48);
            this.MyIPTextBox.Name = "MyIPTextBox";
            this.MyIPTextBox.Size = new System.Drawing.Size(359, 30);
            this.MyIPTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label5.Location = new System.Drawing.Point(396, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Порт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label4.Location = new System.Drawing.Point(396, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Связаться с IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мой порт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мой IP-адресс";
            // 
            // NicknameTextBox
            // 
            this.NicknameTextBox.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.NicknameTextBox.Location = new System.Drawing.Point(31, 194);
            this.NicknameTextBox.Name = "NicknameTextBox";
            this.NicknameTextBox.Size = new System.Drawing.Size(359, 30);
            this.NicknameTextBox.TabIndex = 1;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.SendButton);
            this.ChatPanel.Controls.Add(this.MessageTextBox);
            this.ChatPanel.Controls.Add(this.ChatTextBox);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(800, 467);
            this.ChatPanel.TabIndex = 0;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageTextBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.MessageTextBox.Location = new System.Drawing.Point(0, 400);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(720, 67);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageTextBox_KeyDown);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatTextBox.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.ChatTextBox.Location = new System.Drawing.Point(0, 0);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(800, 400);
            this.ChatTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(10)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Peer-to-peer chat application";
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Image = global::ChatP2P.Properties.Resources.saveSettings;
            this.ConnectButton.Location = new System.Drawing.Point(713, 372);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 64);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Image = global::ChatP2P.Properties.Resources.send;
            this.SendButton.Location = new System.Drawing.Point(720, 400);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(80, 67);
            this.SendButton.TabIndex = 2;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::ChatP2P.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(764, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 33);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peer-to-peer chat application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ChatButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.TextBox OtherPortTextBox;
        private System.Windows.Forms.TextBox OtherIPTextBox;
        private System.Windows.Forms.TextBox MyPortTextBox;
        private System.Windows.Forms.TextBox MyIPTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label6;
    }
}

