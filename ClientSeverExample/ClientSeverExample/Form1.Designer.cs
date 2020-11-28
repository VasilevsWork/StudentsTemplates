namespace ClientSeverExample
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
            this.btn_startServer = new System.Windows.Forms.Button();
            this.btn_startClient = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_sendToServer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_startServer
            // 
            this.btn_startServer.Location = new System.Drawing.Point(12, 12);
            this.btn_startServer.Name = "btn_startServer";
            this.btn_startServer.Size = new System.Drawing.Size(140, 54);
            this.btn_startServer.TabIndex = 0;
            this.btn_startServer.Text = "StartServer";
            this.btn_startServer.UseVisualStyleBackColor = true;
            this.btn_startServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btn_startClient
            // 
            this.btn_startClient.Location = new System.Drawing.Point(545, 10);
            this.btn_startClient.Name = "btn_startClient";
            this.btn_startClient.Size = new System.Drawing.Size(140, 58);
            this.btn_startClient.TabIndex = 1;
            this.btn_startClient.Text = "StartClient";
            this.btn_startClient.UseVisualStyleBackColor = true;
            this.btn_startClient.Click += new System.EventHandler(this.btn_startClient_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 368);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(417, 164);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 277);
            this.listBox2.TabIndex = 3;
            // 
            // btn_sendToServer
            // 
            this.btn_sendToServer.Location = new System.Drawing.Point(545, 74);
            this.btn_sendToServer.Name = "btn_sendToServer";
            this.btn_sendToServer.Size = new System.Drawing.Size(140, 30);
            this.btn_sendToServer.TabIndex = 4;
            this.btn_sendToServer.Text = "Отправить на сервер";
            this.btn_sendToServer.UseVisualStyleBackColor = true;
            this.btn_sendToServer.Click += new System.EventHandler(this.btn_sendToServer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sendToServer);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_startClient);
            this.Controls.Add(this.btn_startServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startServer;
        private System.Windows.Forms.Button btn_startClient;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_sendToServer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

