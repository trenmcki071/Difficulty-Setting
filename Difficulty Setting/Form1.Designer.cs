
namespace Difficulty_Setting
{
    partial class selectDifficulty
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
            this.Easy = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Begin = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.Black;
            this.Easy.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.ForeColor = System.Drawing.Color.White;
            this.Easy.Location = new System.Drawing.Point(12, 122);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(107, 34);
            this.Easy.TabIndex = 0;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Medium
            // 
            this.Medium.BackColor = System.Drawing.Color.Black;
            this.Medium.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium.ForeColor = System.Drawing.Color.White;
            this.Medium.Location = new System.Drawing.Point(125, 122);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(112, 34);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = false;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.Black;
            this.Hard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.ForeColor = System.Drawing.Color.White;
            this.Hard.Location = new System.Drawing.Point(243, 122);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(107, 34);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hero Name:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(178, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(130, 20);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Difficulty";
            // 
            // Begin
            // 
            this.Begin.BackColor = System.Drawing.Color.Black;
            this.Begin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.ForeColor = System.Drawing.Color.White;
            this.Begin.Location = new System.Drawing.Point(115, 184);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(137, 43);
            this.Begin.TabIndex = 6;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = false;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(50, 317);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 7;
            // 
            // selectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 339);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Easy);
            this.Name = "selectDifficulty";
            this.Text = "Hero Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Label Message;
    }
}

