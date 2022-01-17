using System;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_negative = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.52778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.47222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.button_sum, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_subtraction, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_division, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_equals, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_multiplication, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_point, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_square, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_negative, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_root, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 349);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button_sum
            // 
            this.button_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_sum.Location = new System.Drawing.Point(221, 136);
            this.button_sum.Margin = new System.Windows.Forms.Padding(0);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(64, 78);
            this.button_sum.TabIndex = 11;
            this.button_sum.Text = "+";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_subtraction.Location = new System.Drawing.Point(221, 59);
            this.button_subtraction.Margin = new System.Windows.Forms.Padding(0);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(64, 77);
            this.button_subtraction.TabIndex = 7;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_subtraction_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(221, 0);
            this.button_division.Margin = new System.Windows.Forms.Padding(0);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(64, 59);
            this.button_division.TabIndex = 3;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_equals
            // 
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_equals.Location = new System.Drawing.Point(221, 283);
            this.button_equals.Margin = new System.Windows.Forms.Padding(0);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(64, 66);
            this.button_equals.TabIndex = 15;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(221, 214);
            this.button_multiplication.Margin = new System.Windows.Forms.Padding(0);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(64, 69);
            this.button_multiplication.TabIndex = 12;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_point
            // 
            this.button_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_point.Location = new System.Drawing.Point(144, 283);
            this.button_point.Margin = new System.Windows.Forms.Padding(0);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(77, 66);
            this.button_point.TabIndex = 14;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(67, 283);
            this.button_0.Margin = new System.Windows.Forms.Padding(0);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(76, 66);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(0, 214);
            this.button_1.Margin = new System.Windows.Forms.Padding(0);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(67, 69);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(67, 214);
            this.button_2.Margin = new System.Windows.Forms.Padding(0);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(76, 69);
            this.button_2.TabIndex = 9;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(144, 214);
            this.button_3.Margin = new System.Windows.Forms.Padding(0);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(77, 69);
            this.button_3.TabIndex = 10;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(144, 136);
            this.button_6.Margin = new System.Windows.Forms.Padding(0);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(77, 78);
            this.button_6.TabIndex = 6;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(67, 136);
            this.button_5.Margin = new System.Windows.Forms.Padding(0);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(76, 78);
            this.button_5.TabIndex = 5;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(0, 136);
            this.button_4.Margin = new System.Windows.Forms.Padding(0);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(67, 78);
            this.button_4.TabIndex = 4;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(0, 59);
            this.button_7.Margin = new System.Windows.Forms.Padding(0);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(67, 77);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_delete.Location = new System.Drawing.Point(0, 0);
            this.button_delete.Margin = new System.Windows.Forms.Padding(0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(67, 59);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "C";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(67, 59);
            this.button_8.Margin = new System.Windows.Forms.Padding(0);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(76, 77);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_square
            // 
            this.button_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_square.Location = new System.Drawing.Point(67, 0);
            this.button_square.Margin = new System.Windows.Forms.Padding(0);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(77, 59);
            this.button_square.TabIndex = 17;
            this.button_square.Text = "square";
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(144, 59);
            this.button_9.Margin = new System.Windows.Forms.Padding(0);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(77, 77);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_negative
            // 
            this.button_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_negative.Location = new System.Drawing.Point(0, 283);
            this.button_negative.Margin = new System.Windows.Forms.Padding(0);
            this.button_negative.Name = "button_negative";
            this.button_negative.Size = new System.Drawing.Size(67, 66);
            this.button_negative.TabIndex = 18;
            this.button_negative.Text = "+/-";
            this.button_negative.UseVisualStyleBackColor = true;
            this.button_negative.Click += new System.EventHandler(this.button_negative_Click);
            // 
            // button_root
            // 
            this.button_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_root.Location = new System.Drawing.Point(144, 0);
            this.button_root.Margin = new System.Windows.Forms.Padding(0);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(77, 59);
            this.button_root.TabIndex = 19;
            this.button_root.Text = "root";
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.button_root_Click);
            // 
            // visor
            // 
            this.visor.Location = new System.Drawing.Point(0, 0);
            this.visor.Margin = new System.Windows.Forms.Padding(0);
            this.visor.Multiline = true;
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(285, 96);
            this.visor.TabIndex = 14;
            this.visor.TextChanged += new System.EventHandler(this.visor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator of SAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public String result = "";
        public String operation = "";
        public float finalvalor;
        public float firtnumber = 0;
        public float secondnumber = 0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_negative;
    }
}

