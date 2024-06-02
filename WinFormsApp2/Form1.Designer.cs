namespace WinFormsApp2
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
            lockableButton1 = new WinFormsControlLibrary2.LockableButton();
            SuspendLayout();
            // 
            // lockableButton1
            // 
            lockableButton1.Location = new Point(281, 183);
            lockableButton1.MaxClicks = 5;
            lockableButton1.Name = "lockableButton1";
            lockableButton1.Size = new Size(150, 50);
            lockableButton1.TabIndex = 0;
            lockableButton1.UnlockTime = 5000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lockableButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary2.LockableButton lockableButton1;
    }
}