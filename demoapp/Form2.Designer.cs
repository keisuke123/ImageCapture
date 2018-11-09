namespace demoapp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.initial_speed_form = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.final_speed_form = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.acceleration_form = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.initial_speed_form);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 62);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "加速度";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 19);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "初速[pps]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // initial_speed_form
            // 
            this.initial_speed_form.Location = new System.Drawing.Point(102, 24);
            this.initial_speed_form.Name = "initial_speed_form";
            this.initial_speed_form.Size = new System.Drawing.Size(162, 19);
            this.initial_speed_form.TabIndex = 0;
            this.initial_speed_form.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.initial_speed_form.Validating += new System.ComponentModel.CancelEventHandler(this.ok_button_Validating);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.final_speed_form);
            this.panel3.Location = new System.Drawing.Point(-2, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 62);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(3, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 62);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "加速度";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 19);
            this.textBox3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "最終速度[pps]";
            // 
            // final_speed_form
            // 
            this.final_speed_form.Location = new System.Drawing.Point(102, 24);
            this.final_speed_form.Name = "final_speed_form";
            this.final_speed_form.Size = new System.Drawing.Size(162, 19);
            this.final_speed_form.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.acceleration_form);
            this.panel5.Location = new System.Drawing.Point(-2, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 62);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Location = new System.Drawing.Point(3, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 62);
            this.panel6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "加速度";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(74, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 19);
            this.textBox5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "加速度[ms]";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // acceleration_form
            // 
            this.acceleration_form.Location = new System.Drawing.Point(102, 24);
            this.acceleration_form.Name = "acceleration_form";
            this.acceleration_form.Size = new System.Drawing.Size(162, 19);
            this.acceleration_form.TabIndex = 0;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(16, 219);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(110, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(152, 219);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(110, 23);
            this.OK_button.TabIndex = 7;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "CP-500 速度設定";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox initial_speed_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox final_speed_form;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox acceleration_form;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button OK_button;
    }
}