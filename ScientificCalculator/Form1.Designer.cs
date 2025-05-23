﻿namespace ScientificCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnFactorial;

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
        /// Method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDisplay.Location = new System.Drawing.Point(20, 20);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 32);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(20, 60);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 40);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(90, 60);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 40);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(160, 60);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 40);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(230, 60);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(20, 110);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 40);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(90, 110);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 40);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(160, 110);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 40);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(230, 110);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(20, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 40);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(90, 160);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 40);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(160, 160);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 40);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(230, 160);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(20, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 40);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(90, 210);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 40);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(160, 210);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 40);
            this.btnEquals.TabIndex = 15;
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(20, 260);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 40);
            this.btnSqrt.TabIndex = 17;
            this.btnSqrt.Text = "√";
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(90, 260);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(60, 40);
            this.btnPower.TabIndex = 18;
            this.btnPower.Text = "^";
            this.btnPower.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(160, 260);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(60, 40);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "log";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(20, 310);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(60, 40);
            this.btnSin.TabIndex = 21;
            this.btnSin.Text = "sin";
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(90, 310);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(60, 40);
            this.btnCos.TabIndex = 22;
            this.btnCos.Text = "cos";
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(160, 310);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(60, 40);
            this.btnTan.TabIndex = 23;
            this.btnTan.Text = "tan";
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(230, 310);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(60, 40);
            this.btnFactorial.TabIndex = 24;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(320, 370);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnFactorial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientific Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecimal;
    }
}
