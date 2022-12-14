namespace calculator
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.res = new System.Windows.Forms.TextBox();
            this.hist = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(355, 130);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(115, 22);
            this.number1.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(766, 128);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(115, 22);
            this.number2.TabIndex = 0;
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "contains",
            "is in"});
            this.operation.Location = new System.Drawing.Point(536, 128);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(194, 24);
            this.operation.TabIndex = 1;
            this.operation.Text = "choose or type an operation";
            this.operation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(12, 245);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(343, 128);
            this.res.TabIndex = 2;
            this.res.Text = "RESULT:";
            // 
            // hist
            // 
            this.hist.Location = new System.Drawing.Point(375, 245);
            this.hist.Multiline = true;
            this.hist.Name = "hist";
            this.hist.Size = new System.Drawing.Size(275, 400);
            this.hist.TabIndex = 2;
            this.hist.Text = "HISTORY";
            this.hist.Visible = false;
            this.hist.TextChanged += new System.EventHandler(this.boxHistory_TextChanged);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Peru;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(907, 126);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 37);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 128);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "HISTORY";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.boxHistory_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(965, 245);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 128);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "HISTORY";
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.boxHistory_TextChanged);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1232, 953);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hist);
            this.Controls.Add(this.res);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "App";
            this.Text = "app";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.TextBox hist;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}