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
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            comboBoxOperation = new ComboBox();
            BtnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(132, 140);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(125, 27);
            txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(385, 140);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(125, 27);
            txtBox2.TabIndex = 1;
            // 
            // comboBoxOperation
            // 
            comboBoxOperation.FormattingEnabled = true;
            comboBoxOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBoxOperation.Location = new Point(291, 140);
            comboBoxOperation.Name = "comboBoxOperation";
            comboBoxOperation.Size = new Size(62, 28);
            comboBoxOperation.TabIndex = 2;
            comboBoxOperation.SelectedIndexChanged += comboBoxOperation_SelectedIndexChanged;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(132, 224);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(94, 29);
            BtnCalculate.TabIndex = 3;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(385, 224);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(BtnCalculate);
            Controls.Add(comboBoxOperation);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox1;
        private TextBox txtBox2;
        private ComboBox comboBoxOperation;
        private Button BtnCalculate;
        private Label lblResult;
    }
}
