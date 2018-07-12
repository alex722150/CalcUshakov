namespace CalcUshakov
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
            this.Addition = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Minimum = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Maximum = new System.Windows.Forms.Button();
            this.Deg2 = new System.Windows.Forms.Button();
            this.Logariphm = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.Fabs = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Inversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(29, 80);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(53, 43);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(289, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(289, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 311);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(289, 20);
            this.textBox6.TabIndex = 3;
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(29, 129);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(53, 43);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.button1_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(88, 80);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(53, 43);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(88, 129);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(53, 43);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(88, 178);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(53, 43);
            this.Sqrt.TabIndex = 10;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Square_Click);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(29, 227);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(53, 43);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Square_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(29, 178);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(53, 43);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Square_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(147, 178);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(53, 43);
            this.Square.TabIndex = 7;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(206, 80);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(53, 43);
            this.Mod.TabIndex = 14;
            this.Mod.Text = "mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(147, 129);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(53, 43);
            this.Minimum.TabIndex = 13;
            this.Minimum.Text = "min";
            this.Minimum.UseVisualStyleBackColor = true;
            this.Minimum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(265, 80);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(53, 43);
            this.Average.TabIndex = 12;
            this.Average.Text = "(x+y)/2";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(147, 80);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(53, 43);
            this.Maximum.TabIndex = 11;
            this.Maximum.Text = "max";
            this.Maximum.UseVisualStyleBackColor = true;
            this.Maximum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deg2
            // 
            this.Deg2.Location = new System.Drawing.Point(147, 227);
            this.Deg2.Name = "Deg2";
            this.Deg2.Size = new System.Drawing.Size(53, 43);
            this.Deg2.TabIndex = 18;
            this.Deg2.Text = "2^x";
            this.Deg2.UseVisualStyleBackColor = true;
            this.Deg2.Click += new System.EventHandler(this.Square_Click);
            // 
            // Logariphm
            // 
            this.Logariphm.Location = new System.Drawing.Point(206, 178);
            this.Logariphm.Name = "Logariphm";
            this.Logariphm.Size = new System.Drawing.Size(53, 43);
            this.Logariphm.TabIndex = 17;
            this.Logariphm.Text = "log(10)";
            this.Logariphm.UseVisualStyleBackColor = true;
            this.Logariphm.Click += new System.EventHandler(this.Square_Click);
            // 
            // Tanh
            // 
            this.Tanh.Location = new System.Drawing.Point(265, 178);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(53, 43);
            this.Tanh.TabIndex = 16;
            this.Tanh.Text = "tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Square_Click);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(88, 227);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(53, 43);
            this.Tan.TabIndex = 15;
            this.Tan.Text = "Tg";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Square_Click);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(265, 129);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(53, 43);
            this.Degree.TabIndex = 19;
            this.Degree.Text = "x^y";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fabs
            // 
            this.Fabs.Location = new System.Drawing.Point(206, 227);
            this.Fabs.Name = "Fabs";
            this.Fabs.Size = new System.Drawing.Size(53, 43);
            this.Fabs.TabIndex = 20;
            this.Fabs.Text = "| x |";
            this.Fabs.UseVisualStyleBackColor = true;
            this.Fabs.Click += new System.EventHandler(this.Square_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(206, 129);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(53, 43);
            this.Log.TabIndex = 21;
            this.Log.Text = "logx(y)";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inversion
            // 
            this.Inversion.Location = new System.Drawing.Point(265, 227);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(53, 43);
            this.Inversion.TabIndex = 22;
            this.Inversion.Text = "-x";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.Square_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(349, 389);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Fabs);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Deg2);
            this.Controls.Add(this.Logariphm);
            this.Controls.Add(this.Tanh);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Minimum;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Maximum;
        private System.Windows.Forms.Button Deg2;
        private System.Windows.Forms.Button Logariphm;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Fabs;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Inversion;
    }
}

