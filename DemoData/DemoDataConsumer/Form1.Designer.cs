namespace DemoDataConsumer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendBtn = new Button();
            inputTxtBox = new TextBox();
            resultistBox = new ListBox();
            SuspendLayout();
            // 
            // SendBtn
            // 
            SendBtn.Location = new Point(12, 196);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(75, 23);
            SendBtn.TabIndex = 0;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // inputTxtBox
            // 
            inputTxtBox.Location = new Point(12, 12);
            inputTxtBox.Name = "inputTxtBox";
            inputTxtBox.Size = new Size(206, 23);
            inputTxtBox.TabIndex = 1;
            // 
            // resultistBox
            // 
            resultistBox.FormattingEnabled = true;
            resultistBox.ItemHeight = 15;
            resultistBox.Location = new Point(224, 12);
            resultistBox.Name = "resultistBox";
            resultistBox.Size = new Size(212, 199);
            resultistBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 231);
            Controls.Add(resultistBox);
            Controls.Add(inputTxtBox);
            Controls.Add(SendBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendBtn;
        private TextBox inputTxtBox;
        private ListBox resultistBox;
    }
}
