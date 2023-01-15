namespace WinFormsApp10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAllStu = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.birthyear = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(806, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Form2_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(29, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 25);
            this.name.TabIndex = 1;
            this.name.Text = "ชื่อ";
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.student_id.Location = new System.Drawing.Point(12, 222);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(119, 25);
            this.student_id.TabIndex = 2;
            this.student_id.Text = "รหัสนักศึกษา";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(582, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "นักศึกษาทั้งหมด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(493, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "เกรดสูงสุด";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(720, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "เกรดต่ำสุด";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "เพิ่มนักศึกษา";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAllStu
            // 
            this.labelAllStu.AutoSize = true;
            this.labelAllStu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllStu.Location = new System.Drawing.Point(637, 196);
            this.labelAllStu.Name = "labelAllStu";
            this.labelAllStu.Size = new System.Drawing.Size(33, 37);
            this.labelAllStu.TabIndex = 9;
            this.labelAllStu.Text = "0";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(524, 286);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 37);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(754, 286);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(33, 37);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "0";
            // 
            // birthyear
            // 
            this.birthyear.AutoSize = true;
            this.birthyear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthyear.Location = new System.Drawing.Point(12, 286);
            this.birthyear.Name = "birthyear";
            this.birthyear.Size = new System.Drawing.Size(54, 25);
            this.birthyear.TabIndex = 12;
            this.birthyear.Text = "ปีเกิด";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 314);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 23);
            this.textBox3.TabIndex = 13;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.height.Location = new System.Drawing.Point(12, 340);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(68, 25);
            this.height.TabIndex = 14;
            this.height.Text = "ส่วนสูง";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 377);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 23);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 431);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 23);
            this.textBox5.TabIndex = 16;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grade.Location = new System.Drawing.Point(12, 403);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(52, 25);
            this.grade.TabIndex = 17;
            this.grade.Text = "เกรด";
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branch.Location = new System.Drawing.Point(12, 457);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(58, 25);
            this.branch.TabIndex = 18;
            this.branch.Text = "สาขา";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 485);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 23);
            this.textBox6.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 635);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.height);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.birthyear);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelAllStu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label name;
        private Label student_id;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label labelAllStu;
        private Label labelMax;
        private Label labelMin;
        private Label birthyear;
        private TextBox textBox3;
        private Label height;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label grade;
        private Label branch;
        private TextBox textBox6;
    }
}