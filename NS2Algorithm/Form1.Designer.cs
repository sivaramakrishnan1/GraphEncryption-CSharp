namespace NS2Algorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.encryptBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.decryptBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.key11 = new System.Windows.Forms.RichTextBox();
            this.key12 = new System.Windows.Forms.RichTextBox();
            this.key22 = new System.Windows.Forms.RichTextBox();
            this.key21 = new System.Windows.Forms.RichTextBox();
            this.key32 = new System.Windows.Forms.RichTextBox();
            this.key31 = new System.Windows.Forms.RichTextBox();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Message";
            // 
            // encryptBox
            // 
            this.encryptBox.BackColor = System.Drawing.Color.White;
            this.encryptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encryptBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.encryptBox.Location = new System.Drawing.Point(186, 398);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(420, 70);
            this.encryptBox.TabIndex = 10;
            this.encryptBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text";
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.EnableAutoDragDrop = true;
            this.inputBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBox.Location = new System.Drawing.Point(186, 218);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(420, 70);
            this.inputBox.TabIndex = 7;
            this.inputBox.Text = "";
            // 
            // decryptBox
            // 
            this.decryptBox.BackColor = System.Drawing.Color.White;
            this.decryptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decryptBox.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decryptBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decryptBox.Location = new System.Drawing.Point(186, 501);
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.Size = new System.Drawing.Size(420, 70);
            this.decryptBox.TabIndex = 11;
            this.decryptBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted Text";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(254, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.runClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(390, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear Keys";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearKeys);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(77, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Key set 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(269, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key set 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(469, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Key set 3";
            // 
            // key11
            // 
            this.key11.BackColor = System.Drawing.Color.White;
            this.key11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key11.Location = new System.Drawing.Point(32, 85);
            this.key11.Name = "key11";
            this.key11.Size = new System.Drawing.Size(80, 40);
            this.key11.TabIndex = 1;
            this.key11.Text = "";
            // 
            // key12
            // 
            this.key12.BackColor = System.Drawing.Color.White;
            this.key12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key12.Location = new System.Drawing.Point(122, 85);
            this.key12.Name = "key12";
            this.key12.Size = new System.Drawing.Size(80, 40);
            this.key12.TabIndex = 2;
            this.key12.Text = "";
            // 
            // key22
            // 
            this.key22.BackColor = System.Drawing.Color.White;
            this.key22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key22.Location = new System.Drawing.Point(325, 85);
            this.key22.Name = "key22";
            this.key22.Size = new System.Drawing.Size(80, 40);
            this.key22.TabIndex = 4;
            this.key22.Text = "";
            // 
            // key21
            // 
            this.key21.BackColor = System.Drawing.Color.White;
            this.key21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key21.Location = new System.Drawing.Point(235, 85);
            this.key21.Name = "key21";
            this.key21.Size = new System.Drawing.Size(80, 40);
            this.key21.TabIndex = 3;
            this.key21.Text = "";
            // 
            // key32
            // 
            this.key32.BackColor = System.Drawing.Color.White;
            this.key32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key32.Location = new System.Drawing.Point(526, 85);
            this.key32.Name = "key32";
            this.key32.Size = new System.Drawing.Size(80, 40);
            this.key32.TabIndex = 6;
            this.key32.Text = "";
            // 
            // key31
            // 
            this.key31.BackColor = System.Drawing.Color.White;
            this.key31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.key31.Location = new System.Drawing.Point(436, 85);
            this.key31.Name = "key31";
            this.key31.Size = new System.Drawing.Size(80, 40);
            this.key31.TabIndex = 5;
            this.key31.Text = "";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.White;
            this.warning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warning.ForeColor = System.Drawing.Color.OrangeRed;
            this.warning.Location = new System.Drawing.Point(254, 163);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 28);
            this.warning.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(633, 610);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.key32);
            this.Controls.Add(this.key31);
            this.Controls.Add(this.key22);
            this.Controls.Add(this.key21);
            this.Controls.Add(this.key12);
            this.Controls.Add(this.key11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(NS)2 Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox encryptBox;
        private Label label2;
        private RichTextBox inputBox;
        private RichTextBox decryptBox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox key11;
        private RichTextBox key12;
        private RichTextBox key22;
        private RichTextBox key21;
        private RichTextBox key32;
        private RichTextBox key31;
        private Label warning;
    }
}