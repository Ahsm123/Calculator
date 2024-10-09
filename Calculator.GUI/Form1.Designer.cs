namespace Calculator.GUI
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
            txtboxDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubtract = new Button();
            btnEquals = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btbClear = new Button();
            SuspendLayout();
            // 
            // txtboxDisplay
            // 
            txtboxDisplay.BackColor = SystemColors.ButtonHighlight;
            txtboxDisplay.Location = new Point(73, 34);
            txtboxDisplay.Margin = new Padding(6, 5, 6, 5);
            txtboxDisplay.Multiline = true;
            txtboxDisplay.Name = "txtboxDisplay";
            txtboxDisplay.ReadOnly = true;
            txtboxDisplay.Size = new Size(636, 89);
            txtboxDisplay.TabIndex = 0;
            txtboxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDarkDark;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(73, 293);
            btn7.Margin = new Padding(6, 5, 6, 5);
            btn7.Name = "btn7";
            btn7.Padding = new Padding(2);
            btn7.Size = new Size(150, 150);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDarkDark;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(235, 293);
            btn8.Margin = new Padding(6, 5, 6, 5);
            btn8.Name = "btn8";
            btn8.Padding = new Padding(2);
            btn8.Size = new Size(150, 150);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDarkDark;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(397, 293);
            btn9.Margin = new Padding(6, 5, 6, 5);
            btn9.Name = "btn9";
            btn9.Padding = new Padding(2);
            btn9.Size = new Size(150, 150);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += NumberButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Orange;
            btnMultiply.FlatStyle = FlatStyle.Popup;
            btnMultiply.ForeColor = SystemColors.ButtonHighlight;
            btnMultiply.Location = new Point(559, 453);
            btnMultiply.Margin = new Padding(6, 5, 6, 5);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Padding = new Padding(2);
            btnMultiply.Size = new Size(150, 150);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Orange;
            btnDivide.FlatStyle = FlatStyle.Popup;
            btnDivide.ForeColor = SystemColors.ButtonHighlight;
            btnDivide.Location = new Point(559, 293);
            btnDivide.Margin = new Padding(6, 5, 6, 5);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(150, 150);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperator_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDarkDark;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(397, 453);
            btn6.Margin = new Padding(6, 5, 6, 5);
            btn6.Name = "btn6";
            btn6.Padding = new Padding(2);
            btn6.Size = new Size(150, 150);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDarkDark;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(235, 453);
            btn5.Margin = new Padding(6, 5, 6, 5);
            btn5.Name = "btn5";
            btn5.Padding = new Padding(2);
            btn5.Size = new Size(150, 150);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDarkDark;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(73, 453);
            btn4.Margin = new Padding(6, 5, 6, 5);
            btn4.Name = "btn4";
            btn4.Padding = new Padding(2);
            btn4.Size = new Size(150, 150);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += NumberButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(559, 613);
            btnAdd.Margin = new Padding(6, 5, 6, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(2);
            btnAdd.Size = new Size(150, 150);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOperator_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDarkDark;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(397, 613);
            btn3.Margin = new Padding(6, 5, 6, 5);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(2);
            btn3.Size = new Size(150, 150);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDarkDark;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(235, 613);
            btn2.Margin = new Padding(6, 5, 6, 5);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(2);
            btn2.Size = new Size(150, 150);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += NumberButton_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDarkDark;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(73, 613);
            btn1.Margin = new Padding(6, 5, 6, 5);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(2);
            btn1.Size = new Size(150, 150);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += NumberButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Orange;
            btnSubtract.FlatStyle = FlatStyle.Popup;
            btnSubtract.ForeColor = SystemColors.ButtonHighlight;
            btnSubtract.Location = new Point(559, 773);
            btnSubtract.Margin = new Padding(6, 5, 6, 5);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Padding = new Padding(2);
            btnSubtract.Size = new Size(150, 150);
            btnSubtract.TabIndex = 16;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnOperator_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ControlDarkDark;
            btnEquals.FlatStyle = FlatStyle.Popup;
            btnEquals.ForeColor = SystemColors.ButtonHighlight;
            btnEquals.Location = new Point(397, 773);
            btnEquals.Margin = new Padding(6, 5, 6, 5);
            btnEquals.Name = "btnEquals";
            btnEquals.Padding = new Padding(2);
            btnEquals.Size = new Size(150, 150);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ControlDarkDark;
            btnDecimal.FlatStyle = FlatStyle.Popup;
            btnDecimal.ForeColor = SystemColors.ButtonHighlight;
            btnDecimal.Location = new Point(235, 773);
            btnDecimal.Margin = new Padding(6, 5, 6, 5);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Padding = new Padding(2);
            btnDecimal.Size = new Size(150, 150);
            btnDecimal.TabIndex = 14;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += NumberButton_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDarkDark;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(73, 773);
            btn0.Margin = new Padding(6, 5, 6, 5);
            btn0.Name = "btn0";
            btn0.Padding = new Padding(2);
            btn0.Size = new Size(150, 150);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NumberButton_Click;
            // 
            // btbClear
            // 
            btbClear.BackColor = SystemColors.ControlDarkDark;
            btbClear.FlatStyle = FlatStyle.Popup;
            btbClear.ForeColor = SystemColors.ButtonHighlight;
            btbClear.Location = new Point(559, 133);
            btbClear.Margin = new Padding(6, 5, 6, 5);
            btbClear.Name = "btbClear";
            btbClear.Padding = new Padding(2);
            btbClear.Size = new Size(150, 150);
            btbClear.TabIndex = 17;
            btbClear.Text = "CE";
            btbClear.UseVisualStyleBackColor = false;
            btbClear.Click += btbClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(776, 968);
            Controls.Add(btbClear);
            Controls.Add(btnSubtract);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtboxDisplay);
            Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Padding = new Padding(2);
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSubtract;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btn0;
        private Button btbClear;
    }
}
