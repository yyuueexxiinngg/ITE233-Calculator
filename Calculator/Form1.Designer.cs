namespace Calculator
{
    partial class Calculator
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
            this.textBox1_结果显示 = new System.Windows.Forms.TextBox();
            this.btn_科学计数 = new System.Windows.Forms.Button();
            this.btn_取余数 = new System.Windows.Forms.Button();
            this.btn_阶乘 = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.groupBox1_basic = new System.Windows.Forms.GroupBox();
            this.btn_mm = new System.Windows.Forms.Button();
            this.btn_mp = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.btn_小数点 = new System.Windows.Forms.Button();
            this.btn_num_0 = new System.Windows.Forms.Button();
            this.btn_正负 = new System.Windows.Forms.Button();
            this.btn_等于 = new System.Windows.Forms.Button();
            this.btn_减 = new System.Windows.Forms.Button();
            this.btn_num_3 = new System.Windows.Forms.Button();
            this.btn_num_2 = new System.Windows.Forms.Button();
            this.btn_num_1 = new System.Windows.Forms.Button();
            this.btn_加 = new System.Windows.Forms.Button();
            this.btn_num_6 = new System.Windows.Forms.Button();
            this.btn_num_5 = new System.Windows.Forms.Button();
            this.btn_num_4 = new System.Windows.Forms.Button();
            this.btn_乘 = new System.Windows.Forms.Button();
            this.btn_num_9 = new System.Windows.Forms.Button();
            this.btn_num_8 = new System.Windows.Forms.Button();
            this.btn_num_7 = new System.Windows.Forms.Button();
            this.btn_除 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1_function = new System.Windows.Forms.GroupBox();
            this.btn_指数 = new System.Windows.Forms.Button();
            this.btn_倒数 = new System.Windows.Forms.Button();
            this.btn_十指数 = new System.Windows.Forms.Button();
            this.btn_立方 = new System.Windows.Forms.Button();
            this.btn_平方 = new System.Windows.Forms.Button();
            this.listBox1_记忆 = new System.Windows.Forms.ListBox();
            this.textBox2_步骤显示 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3_记忆显示 = new System.Windows.Forms.TextBox();
            this.groupBox1_basic.SuspendLayout();
            this.groupBox1_function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_结果显示
            // 
            this.textBox1_结果显示.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_结果显示.Font = new System.Drawing.Font("宋体", 35F);
            this.textBox1_结果显示.Location = new System.Drawing.Point(10, 42);
            this.textBox1_结果显示.Name = "textBox1_结果显示";
            this.textBox1_结果显示.ReadOnly = true;
            this.textBox1_结果显示.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1_结果显示.Size = new System.Drawing.Size(566, 54);
            this.textBox1_结果显示.TabIndex = 0;
            this.textBox1_结果显示.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1_结果显示.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_结果显示_KeyPress);
            // 
            // btn_科学计数
            // 
            this.btn_科学计数.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_科学计数.Location = new System.Drawing.Point(182, 20);
            this.btn_科学计数.Name = "btn_科学计数";
            this.btn_科学计数.Size = new System.Drawing.Size(97, 49);
            this.btn_科学计数.TabIndex = 2;
            this.btn_科学计数.Tag = ".exp+";
            this.btn_科学计数.Text = "Exp";
            this.btn_科学计数.UseVisualStyleBackColor = true;
            this.btn_科学计数.Click += new System.EventHandler(this.btn_科学计数_Click);
            // 
            // btn_取余数
            // 
            this.btn_取余数.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_取余数.Location = new System.Drawing.Point(326, 20);
            this.btn_取余数.Name = "btn_取余数";
            this.btn_取余数.Size = new System.Drawing.Size(97, 49);
            this.btn_取余数.TabIndex = 3;
            this.btn_取余数.Tag = "%";
            this.btn_取余数.Text = "Mod";
            this.btn_取余数.UseVisualStyleBackColor = true;
            this.btn_取余数.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_阶乘
            // 
            this.btn_阶乘.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_阶乘.Location = new System.Drawing.Point(471, 20);
            this.btn_阶乘.Name = "btn_阶乘";
            this.btn_阶乘.Size = new System.Drawing.Size(97, 49);
            this.btn_阶乘.TabIndex = 4;
            this.btn_阶乘.Text = "n!";
            this.btn_阶乘.UseVisualStyleBackColor = true;
            this.btn_阶乘.Click += new System.EventHandler(this.btn_阶乘_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_CE.Location = new System.Drawing.Point(33, 31);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(85, 85);
            this.btn_CE.TabIndex = 6;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_c.Location = new System.Drawing.Point(152, 31);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(85, 85);
            this.btn_c.TabIndex = 7;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // groupBox1_basic
            // 
            this.groupBox1_basic.AutoSize = true;
            this.groupBox1_basic.Controls.Add(this.btn_mm);
            this.groupBox1_basic.Controls.Add(this.btn_mp);
            this.groupBox1_basic.Controls.Add(this.btn_mc);
            this.groupBox1_basic.Controls.Add(this.btn_小数点);
            this.groupBox1_basic.Controls.Add(this.btn_num_0);
            this.groupBox1_basic.Controls.Add(this.btn_正负);
            this.groupBox1_basic.Controls.Add(this.btn_等于);
            this.groupBox1_basic.Controls.Add(this.btn_减);
            this.groupBox1_basic.Controls.Add(this.btn_num_3);
            this.groupBox1_basic.Controls.Add(this.btn_num_2);
            this.groupBox1_basic.Controls.Add(this.btn_num_1);
            this.groupBox1_basic.Controls.Add(this.btn_加);
            this.groupBox1_basic.Controls.Add(this.btn_num_6);
            this.groupBox1_basic.Controls.Add(this.btn_num_5);
            this.groupBox1_basic.Controls.Add(this.btn_num_4);
            this.groupBox1_basic.Controls.Add(this.btn_乘);
            this.groupBox1_basic.Controls.Add(this.btn_num_9);
            this.groupBox1_basic.Controls.Add(this.btn_num_8);
            this.groupBox1_basic.Controls.Add(this.btn_num_7);
            this.groupBox1_basic.Controls.Add(this.btn_除);
            this.groupBox1_basic.Controls.Add(this.btn_back);
            this.groupBox1_basic.Controls.Add(this.btn_CE);
            this.groupBox1_basic.Controls.Add(this.btn_c);
            this.groupBox1_basic.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1_basic.Location = new System.Drawing.Point(58, 279);
            this.groupBox1_basic.Name = "groupBox1_basic";
            this.groupBox1_basic.Size = new System.Drawing.Size(582, 636);
            this.groupBox1_basic.TabIndex = 2;
            this.groupBox1_basic.TabStop = false;
            this.groupBox1_basic.Text = "Basic";
            // 
            // btn_mm
            // 
            this.btn_mm.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_mm.Location = new System.Drawing.Point(483, 418);
            this.btn_mm.Name = "btn_mm";
            this.btn_mm.Size = new System.Drawing.Size(85, 111);
            this.btn_mm.TabIndex = 28;
            this.btn_mm.Text = "M-";
            this.btn_mm.UseVisualStyleBackColor = true;
            this.btn_mm.Click += new System.EventHandler(this.btn_mm_Click);
            // 
            // btn_mp
            // 
            this.btn_mp.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_mp.Location = new System.Drawing.Point(483, 254);
            this.btn_mp.Name = "btn_mp";
            this.btn_mp.Size = new System.Drawing.Size(85, 111);
            this.btn_mp.TabIndex = 27;
            this.btn_mp.Text = "M+";
            this.btn_mp.UseVisualStyleBackColor = true;
            this.btn_mp.Click += new System.EventHandler(this.btn_mp_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_mc.Location = new System.Drawing.Point(483, 95);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(85, 111);
            this.btn_mc.TabIndex = 26;
            this.btn_mc.Text = "MC";
            this.btn_mc.UseVisualStyleBackColor = true;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // btn_小数点
            // 
            this.btn_小数点.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_小数点.Location = new System.Drawing.Point(263, 500);
            this.btn_小数点.Name = "btn_小数点";
            this.btn_小数点.Size = new System.Drawing.Size(85, 85);
            this.btn_小数点.TabIndex = 25;
            this.btn_小数点.Text = ".";
            this.btn_小数点.UseVisualStyleBackColor = true;
            this.btn_小数点.Click += new System.EventHandler(this.btn_小数点_Click);
            // 
            // btn_num_0
            // 
            this.btn_num_0.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_0.Location = new System.Drawing.Point(152, 500);
            this.btn_num_0.Name = "btn_num_0";
            this.btn_num_0.Size = new System.Drawing.Size(85, 85);
            this.btn_num_0.TabIndex = 24;
            this.btn_num_0.Text = "0";
            this.btn_num_0.UseVisualStyleBackColor = true;
            this.btn_num_0.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_正负
            // 
            this.btn_正负.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_正负.Location = new System.Drawing.Point(33, 500);
            this.btn_正负.Name = "btn_正负";
            this.btn_正负.Size = new System.Drawing.Size(85, 85);
            this.btn_正负.TabIndex = 23;
            this.btn_正负.Text = "±";
            this.btn_正负.UseVisualStyleBackColor = true;
            this.btn_正负.Click += new System.EventHandler(this.btn_正负_Click);
            // 
            // btn_等于
            // 
            this.btn_等于.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_等于.Location = new System.Drawing.Point(380, 500);
            this.btn_等于.Name = "btn_等于";
            this.btn_等于.Size = new System.Drawing.Size(85, 85);
            this.btn_等于.TabIndex = 22;
            this.btn_等于.Text = "=";
            this.btn_等于.UseVisualStyleBackColor = true;
            this.btn_等于.Click += new System.EventHandler(this.btn_等于_Click);
            // 
            // btn_减
            // 
            this.btn_减.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_减.Location = new System.Drawing.Point(380, 382);
            this.btn_减.Name = "btn_减";
            this.btn_减.Size = new System.Drawing.Size(85, 85);
            this.btn_减.TabIndex = 21;
            this.btn_减.Tag = "-";
            this.btn_减.Text = "－";
            this.btn_减.UseVisualStyleBackColor = true;
            this.btn_减.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_num_3
            // 
            this.btn_num_3.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_3.Location = new System.Drawing.Point(263, 382);
            this.btn_num_3.Name = "btn_num_3";
            this.btn_num_3.Size = new System.Drawing.Size(85, 85);
            this.btn_num_3.TabIndex = 20;
            this.btn_num_3.Text = "3";
            this.btn_num_3.UseVisualStyleBackColor = true;
            this.btn_num_3.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_2
            // 
            this.btn_num_2.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_2.Location = new System.Drawing.Point(152, 382);
            this.btn_num_2.Name = "btn_num_2";
            this.btn_num_2.Size = new System.Drawing.Size(85, 85);
            this.btn_num_2.TabIndex = 19;
            this.btn_num_2.Text = "2";
            this.btn_num_2.UseVisualStyleBackColor = true;
            this.btn_num_2.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_1
            // 
            this.btn_num_1.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_1.Location = new System.Drawing.Point(33, 382);
            this.btn_num_1.Name = "btn_num_1";
            this.btn_num_1.Size = new System.Drawing.Size(85, 85);
            this.btn_num_1.TabIndex = 18;
            this.btn_num_1.Text = "1";
            this.btn_num_1.UseVisualStyleBackColor = true;
            this.btn_num_1.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_加
            // 
            this.btn_加.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_加.Location = new System.Drawing.Point(380, 267);
            this.btn_加.Name = "btn_加";
            this.btn_加.Size = new System.Drawing.Size(85, 85);
            this.btn_加.TabIndex = 17;
            this.btn_加.Tag = "+";
            this.btn_加.Text = "＋";
            this.btn_加.UseVisualStyleBackColor = true;
            this.btn_加.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_num_6
            // 
            this.btn_num_6.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_6.Location = new System.Drawing.Point(263, 267);
            this.btn_num_6.Name = "btn_num_6";
            this.btn_num_6.Size = new System.Drawing.Size(85, 85);
            this.btn_num_6.TabIndex = 16;
            this.btn_num_6.Text = "6";
            this.btn_num_6.UseVisualStyleBackColor = true;
            this.btn_num_6.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_5
            // 
            this.btn_num_5.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_5.Location = new System.Drawing.Point(152, 267);
            this.btn_num_5.Name = "btn_num_5";
            this.btn_num_5.Size = new System.Drawing.Size(85, 85);
            this.btn_num_5.TabIndex = 15;
            this.btn_num_5.Text = "5";
            this.btn_num_5.UseVisualStyleBackColor = true;
            this.btn_num_5.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_4
            // 
            this.btn_num_4.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_4.Location = new System.Drawing.Point(33, 267);
            this.btn_num_4.Name = "btn_num_4";
            this.btn_num_4.Size = new System.Drawing.Size(85, 85);
            this.btn_num_4.TabIndex = 14;
            this.btn_num_4.Text = "4";
            this.btn_num_4.UseVisualStyleBackColor = true;
            this.btn_num_4.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_乘
            // 
            this.btn_乘.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_乘.Location = new System.Drawing.Point(380, 147);
            this.btn_乘.Name = "btn_乘";
            this.btn_乘.Size = new System.Drawing.Size(85, 85);
            this.btn_乘.TabIndex = 13;
            this.btn_乘.Tag = "*";
            this.btn_乘.Text = "×";
            this.btn_乘.UseVisualStyleBackColor = true;
            this.btn_乘.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_num_9
            // 
            this.btn_num_9.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_9.Location = new System.Drawing.Point(263, 147);
            this.btn_num_9.Name = "btn_num_9";
            this.btn_num_9.Size = new System.Drawing.Size(85, 85);
            this.btn_num_9.TabIndex = 12;
            this.btn_num_9.Text = "9";
            this.btn_num_9.UseVisualStyleBackColor = true;
            this.btn_num_9.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_8
            // 
            this.btn_num_8.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_8.Location = new System.Drawing.Point(152, 147);
            this.btn_num_8.Name = "btn_num_8";
            this.btn_num_8.Size = new System.Drawing.Size(85, 85);
            this.btn_num_8.TabIndex = 11;
            this.btn_num_8.Text = "8";
            this.btn_num_8.UseVisualStyleBackColor = true;
            this.btn_num_8.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_num_7
            // 
            this.btn_num_7.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_num_7.Location = new System.Drawing.Point(33, 147);
            this.btn_num_7.Name = "btn_num_7";
            this.btn_num_7.Size = new System.Drawing.Size(85, 85);
            this.btn_num_7.TabIndex = 10;
            this.btn_num_7.Text = "7";
            this.btn_num_7.UseVisualStyleBackColor = true;
            this.btn_num_7.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_除
            // 
            this.btn_除.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_除.Location = new System.Drawing.Point(380, 31);
            this.btn_除.Name = "btn_除";
            this.btn_除.Size = new System.Drawing.Size(85, 85);
            this.btn_除.TabIndex = 9;
            this.btn_除.Tag = "/";
            this.btn_除.Text = "÷";
            this.btn_除.UseVisualStyleBackColor = true;
            this.btn_除.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_back.Location = new System.Drawing.Point(263, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 85);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "←Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1_function
            // 
            this.groupBox1_function.Controls.Add(this.btn_指数);
            this.groupBox1_function.Controls.Add(this.btn_倒数);
            this.groupBox1_function.Controls.Add(this.btn_十指数);
            this.groupBox1_function.Controls.Add(this.btn_立方);
            this.groupBox1_function.Controls.Add(this.btn_平方);
            this.groupBox1_function.Controls.Add(this.btn_科学计数);
            this.groupBox1_function.Controls.Add(this.btn_取余数);
            this.groupBox1_function.Controls.Add(this.btn_阶乘);
            this.groupBox1_function.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1_function.Location = new System.Drawing.Point(58, 125);
            this.groupBox1_function.Name = "groupBox1_function";
            this.groupBox1_function.Size = new System.Drawing.Size(582, 148);
            this.groupBox1_function.TabIndex = 6;
            this.groupBox1_function.TabStop = false;
            this.groupBox1_function.Text = "Function";
            // 
            // btn_指数
            // 
            this.btn_指数.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_指数.Location = new System.Drawing.Point(41, 20);
            this.btn_指数.Name = "btn_指数";
            this.btn_指数.Size = new System.Drawing.Size(97, 49);
            this.btn_指数.TabIndex = 9;
            this.btn_指数.Tag = "^";
            this.btn_指数.Text = "Xⁿ";
            this.btn_指数.UseVisualStyleBackColor = true;
            this.btn_指数.Click += new System.EventHandler(this.Symbol_Btn_Click);
            // 
            // btn_倒数
            // 
            this.btn_倒数.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_倒数.Location = new System.Drawing.Point(471, 93);
            this.btn_倒数.Name = "btn_倒数";
            this.btn_倒数.Size = new System.Drawing.Size(97, 49);
            this.btn_倒数.TabIndex = 8;
            this.btn_倒数.Text = "1/x";
            this.btn_倒数.UseVisualStyleBackColor = true;
            this.btn_倒数.Click += new System.EventHandler(this.btn_倒数_Click);
            // 
            // btn_十指数
            // 
            this.btn_十指数.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_十指数.Location = new System.Drawing.Point(41, 93);
            this.btn_十指数.Name = "btn_十指数";
            this.btn_十指数.Size = new System.Drawing.Size(97, 49);
            this.btn_十指数.TabIndex = 7;
            this.btn_十指数.Text = "10ⁿ";
            this.btn_十指数.UseVisualStyleBackColor = true;
            this.btn_十指数.Click += new System.EventHandler(this.btn_十指数_Click);
            // 
            // btn_立方
            // 
            this.btn_立方.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_立方.Location = new System.Drawing.Point(326, 93);
            this.btn_立方.Name = "btn_立方";
            this.btn_立方.Size = new System.Drawing.Size(97, 49);
            this.btn_立方.TabIndex = 6;
            this.btn_立方.Text = "X³";
            this.btn_立方.UseVisualStyleBackColor = true;
            this.btn_立方.Click += new System.EventHandler(this.btn_立方_Click);
            // 
            // btn_平方
            // 
            this.btn_平方.Font = new System.Drawing.Font("宋体", 20F);
            this.btn_平方.Location = new System.Drawing.Point(182, 93);
            this.btn_平方.Name = "btn_平方";
            this.btn_平方.Size = new System.Drawing.Size(97, 49);
            this.btn_平方.TabIndex = 5;
            this.btn_平方.Text = "X²";
            this.btn_平方.UseVisualStyleBackColor = true;
            this.btn_平方.Click += new System.EventHandler(this.btn_平方_Click);
            // 
            // listBox1_记忆
            // 
            this.listBox1_记忆.FormattingEnabled = true;
            this.listBox1_记忆.ItemHeight = 12;
            this.listBox1_记忆.Location = new System.Drawing.Point(674, 112);
            this.listBox1_记忆.Name = "listBox1_记忆";
            this.listBox1_记忆.Size = new System.Drawing.Size(243, 796);
            this.listBox1_记忆.TabIndex = 7;
            this.listBox1_记忆.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_记忆_MouseDoubleClick);
            // 
            // textBox2_步骤显示
            // 
            this.textBox2_步骤显示.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_步骤显示.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox2_步骤显示.Location = new System.Drawing.Point(10, 22);
            this.textBox2_步骤显示.Name = "textBox2_步骤显示";
            this.textBox2_步骤显示.ReadOnly = true;
            this.textBox2_步骤显示.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2_步骤显示.Size = new System.Drawing.Size(566, 23);
            this.textBox2_步骤显示.TabIndex = 10;
            this.textBox2_步骤显示.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2_步骤显示);
            this.groupBox1.Controls.Add(this.textBox1_结果显示);
            this.groupBox1.Location = new System.Drawing.Point(58, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // textBox3_记忆显示
            // 
            this.textBox3_记忆显示.Font = new System.Drawing.Font("宋体", 30F);
            this.textBox3_记忆显示.Location = new System.Drawing.Point(674, 24);
            this.textBox3_记忆显示.Name = "textBox3_记忆显示";
            this.textBox3_记忆显示.ReadOnly = true;
            this.textBox3_记忆显示.Size = new System.Drawing.Size(243, 53);
            this.textBox3_记忆显示.TabIndex = 8;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 927);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3_记忆显示);
            this.Controls.Add(this.listBox1_记忆);
            this.Controls.Add(this.groupBox1_function);
            this.Controls.Add(this.groupBox1_basic);
            this.MinimumSize = new System.Drawing.Size(16, 50);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.groupBox1_basic.ResumeLayout(false);
            this.groupBox1_function.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_结果显示;
        private System.Windows.Forms.Button btn_科学计数;
        private System.Windows.Forms.Button btn_取余数;
        private System.Windows.Forms.Button btn_阶乘;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.GroupBox groupBox1_basic;
        private System.Windows.Forms.Button btn_减;
        private System.Windows.Forms.Button btn_num_3;
        private System.Windows.Forms.Button btn_num_2;
        private System.Windows.Forms.Button btn_num_1;
        private System.Windows.Forms.Button btn_加;
        private System.Windows.Forms.Button btn_num_6;
        private System.Windows.Forms.Button btn_num_5;
        private System.Windows.Forms.Button btn_num_4;
        private System.Windows.Forms.Button btn_乘;
        private System.Windows.Forms.Button btn_num_9;
        private System.Windows.Forms.Button btn_num_8;
        private System.Windows.Forms.Button btn_num_7;
        private System.Windows.Forms.Button btn_除;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1_function;
        private System.Windows.Forms.Button btn_平方;
        private System.Windows.Forms.Button btn_小数点;
        private System.Windows.Forms.Button btn_num_0;
        private System.Windows.Forms.Button btn_正负;
        private System.Windows.Forms.Button btn_等于;
        private System.Windows.Forms.Button btn_倒数;
        private System.Windows.Forms.Button btn_十指数;
        private System.Windows.Forms.Button btn_立方;
        private System.Windows.Forms.Button btn_mm;
        private System.Windows.Forms.Button btn_mp;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.ListBox listBox1_记忆;
        private System.Windows.Forms.Button btn_指数;
        private System.Windows.Forms.TextBox textBox2_步骤显示;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3_记忆显示;
    }
}

