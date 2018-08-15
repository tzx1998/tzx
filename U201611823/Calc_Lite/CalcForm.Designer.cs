namespace WindowsFormsApp3
{
    partial class CalcForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(157, 141);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(53, 23);
            this.num9.TabIndex = 5;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num_click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(83, 141);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(53, 23);
            this.num8.TabIndex = 4;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num_click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(13, 140);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(53, 23);
            this.num7.TabIndex = 3;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num_click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(233, 96);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(53, 23);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(233, 140);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(53, 23);
            this.multiplication.TabIndex = 7;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(233, 181);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(53, 23);
            this.subtraction.TabIndex = 11;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(157, 180);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(53, 23);
            this.num6.TabIndex = 10;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num_click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(83, 181);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(53, 23);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num_click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(13, 180);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(53, 23);
            this.num4.TabIndex = 8;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num_click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(233, 220);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(53, 23);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(157, 219);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(53, 23);
            this.num3.TabIndex = 14;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num_click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(83, 220);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(53, 23);
            this.num2.TabIndex = 13;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num_click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(13, 219);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(53, 23);
            this.num1.TabIndex = 12;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num_click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(157, 259);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(129, 23);
            this.calc.TabIndex = 0;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(83, 259);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(53, 23);
            this.button18.TabIndex = 18;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(12, 259);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(53, 23);
            this.buttonexit.TabIndex = 16;
            this.buttonexit.Text = "退出";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(12, 43);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(274, 29);
            this.result.TabIndex = 22;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(157, 96);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(53, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 326);
            this.ControlBox = false;
            this.Controls.Add(this.result);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.clear);
            this.KeyPreview = true;
            this.Name = "CalcForm";
            this.Text = "简易版计算器";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button clear;
    }
}

