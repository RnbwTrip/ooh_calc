namespace ooh_calc
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
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.buttonASinus = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonACos = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonATan = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Tan;
            this.buttonDivide.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(237, 154);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(69, 58);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Tan;
            this.buttonPlus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 154);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(69, 58);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Tan;
            this.buttonMinus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(87, 154);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(69, 58);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Tan;
            this.buttonMultiply.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(162, 154);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(69, 58);
            this.buttonMultiply.TabIndex = 11;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.Calculate);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textAnswer
            // 
            this.textAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAnswer.Location = new System.Drawing.Point(13, 112);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.ReadOnly = true;
            this.textAnswer.Size = new System.Drawing.Size(368, 20);
            this.textAnswer.TabIndex = 17;
            // 
            // buttonASinus
            // 
            this.buttonASinus.BackColor = System.Drawing.Color.Tan;
            this.buttonASinus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonASinus.Location = new System.Drawing.Point(12, 282);
            this.buttonASinus.Name = "buttonASinus";
            this.buttonASinus.Size = new System.Drawing.Size(69, 58);
            this.buttonASinus.TabIndex = 18;
            this.buttonASinus.Text = "asin";
            this.buttonASinus.UseVisualStyleBackColor = false;
            this.buttonASinus.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonSqr
            // 
            this.buttonSqr.BackColor = System.Drawing.Color.Tan;
            this.buttonSqr.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqr.Location = new System.Drawing.Point(312, 218);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(69, 58);
            this.buttonSqr.TabIndex = 19;
            this.buttonSqr.Text = "sqr";
            this.buttonSqr.UseVisualStyleBackColor = false;
            this.buttonSqr.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonACos
            // 
            this.buttonACos.BackColor = System.Drawing.Color.Tan;
            this.buttonACos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonACos.Location = new System.Drawing.Point(87, 282);
            this.buttonACos.Name = "buttonACos";
            this.buttonACos.Size = new System.Drawing.Size(69, 58);
            this.buttonACos.TabIndex = 20;
            this.buttonACos.Text = "acos";
            this.buttonACos.UseVisualStyleBackColor = false;
            this.buttonACos.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.Tan;
            this.buttonSqrt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.Location = new System.Drawing.Point(237, 218);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(69, 58);
            this.buttonSqrt.TabIndex = 21;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.Tan;
            this.buttonLn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.Location = new System.Drawing.Point(312, 282);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(69, 58);
            this.buttonLn.TabIndex = 22;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.Color.Tan;
            this.buttonTan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTan.Location = new System.Drawing.Point(162, 218);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(69, 58);
            this.buttonTan.TabIndex = 23;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonATan
            // 
            this.buttonATan.BackColor = System.Drawing.Color.Tan;
            this.buttonATan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonATan.Location = new System.Drawing.Point(162, 282);
            this.buttonATan.Name = "buttonATan";
            this.buttonATan.Size = new System.Drawing.Size(69, 58);
            this.buttonATan.TabIndex = 24;
            this.buttonATan.Text = "atan";
            this.buttonATan.UseVisualStyleBackColor = false;
            this.buttonATan.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.Tan;
            this.buttonCos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.Location = new System.Drawing.Point(87, 218);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(69, 58);
            this.buttonCos.TabIndex = 25;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.Tan;
            this.buttonSin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.Location = new System.Drawing.Point(12, 218);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(69, 58);
            this.buttonSin.TabIndex = 26;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.SingleCalculate);
            // 
            // buttonPow
            // 
            this.buttonPow.BackColor = System.Drawing.Color.Tan;
            this.buttonPow.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPow.Location = new System.Drawing.Point(237, 282);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(69, 58);
            this.buttonPow.TabIndex = 27;
            this.buttonPow.Text = "x^y";
            this.buttonPow.UseVisualStyleBackColor = false;
            this.buttonPow.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Tan;
            this.buttonLog.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.Location = new System.Drawing.Point(13, 346);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(69, 58);
            this.buttonLog.TabIndex = 28;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Tan;
            this.buttonDiv.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.Location = new System.Drawing.Point(88, 346);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(69, 58);
            this.buttonDiv.TabIndex = 29;
            this.buttonDiv.Text = "div";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonMod
            // 
            this.buttonMod.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.buttonMod.BackColor = System.Drawing.Color.Tan;
            this.buttonMod.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMod.Location = new System.Drawing.Point(163, 346);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(69, 58);
            this.buttonMod.TabIndex = 30;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.Calculate);
            // 
            // buttonPercent
            // 
            this.buttonPercent.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.buttonPercent.BackColor = System.Drawing.Color.Tan;
            this.buttonPercent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPercent.Location = new System.Drawing.Point(237, 346);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(69, 58);
            this.buttonPercent.TabIndex = 31;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 459);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonPow);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonATan);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonACos);
            this.Controls.Add(this.buttonSqr);
            this.Controls.Add(this.buttonASinus);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Button buttonASinus;
        private System.Windows.Forms.Button buttonSqr;
        private System.Windows.Forms.Button buttonACos;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonATan;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPercent;
    }
}

