namespace GameDemo
{
    partial class Form1
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
            this.resetRoleBTN = new System.Windows.Forms.Button();
            this.playerNumTB = new System.Windows.Forms.TextBox();
            this.playerNumLB = new System.Windows.Forms.Label();
            this.roleListTB = new System.Windows.Forms.TextBox();
            this.roleListLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.drawCardBTN = new System.Windows.Forms.Button();
            this.restartBTN = new System.Windows.Forms.Button();
            this.drawCardTB = new System.Windows.Forms.TextBox();
            this.drawCardLB = new System.Windows.Forms.Label();
            this.cardLB = new System.Windows.Forms.Label();
            this.cardTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetRoleBTN
            // 
            this.resetRoleBTN.Location = new System.Drawing.Point(783, 91);
            this.resetRoleBTN.Name = "resetRoleBTN";
            this.resetRoleBTN.Size = new System.Drawing.Size(174, 54);
            this.resetRoleBTN.TabIndex = 0;
            this.resetRoleBTN.Text = "分配角色";
            this.resetRoleBTN.UseVisualStyleBackColor = true;
            this.resetRoleBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerNumTB
            // 
            this.playerNumTB.Location = new System.Drawing.Point(578, 91);
            this.playerNumTB.Name = "playerNumTB";
            this.playerNumTB.Size = new System.Drawing.Size(185, 28);
            this.playerNumTB.TabIndex = 1;
            this.playerNumTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerNumLB
            // 
            this.playerNumLB.AutoSize = true;
            this.playerNumLB.BackColor = System.Drawing.SystemColors.Control;
            this.playerNumLB.Font = new System.Drawing.Font("宋体", 12F);
            this.playerNumLB.Location = new System.Drawing.Point(308, 91);
            this.playerNumLB.Name = "playerNumLB";
            this.playerNumLB.Size = new System.Drawing.Size(250, 24);
            this.playerNumLB.TabIndex = 2;
            this.playerNumLB.Text = "输入玩家人数（5-10）";
            this.playerNumLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // roleListTB
            // 
            this.roleListTB.Location = new System.Drawing.Point(468, 157);
            this.roleListTB.Multiline = true;
            this.roleListTB.Name = "roleListTB";
            this.roleListTB.Size = new System.Drawing.Size(295, 148);
            this.roleListTB.TabIndex = 3;
            this.roleListTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // roleListLB
            // 
            this.roleListLB.AutoSize = true;
            this.roleListLB.BackColor = System.Drawing.SystemColors.Control;
            this.roleListLB.Font = new System.Drawing.Font("宋体", 12F);
            this.roleListLB.Location = new System.Drawing.Point(308, 157);
            this.roleListLB.Name = "roleListLB";
            this.roleListLB.Size = new System.Drawing.Size(154, 24);
            this.roleListLB.TabIndex = 4;
            this.roleListLB.Text = "角色分配情况";
            this.roleListLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.BackColor = System.Drawing.SystemColors.Control;
            this.titleLB.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLB.Location = new System.Drawing.Point(379, 32);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(284, 31);
            this.titleLB.TabIndex = 5;
            this.titleLB.Text = "希特勒游戏简易工具";
            this.titleLB.Click += new System.EventHandler(this.titleLB_Click);
            // 
            // drawCardBTN
            // 
            this.drawCardBTN.Location = new System.Drawing.Point(783, 334);
            this.drawCardBTN.Name = "drawCardBTN";
            this.drawCardBTN.Size = new System.Drawing.Size(174, 63);
            this.drawCardBTN.TabIndex = 6;
            this.drawCardBTN.Text = "抽取政策卡";
            this.drawCardBTN.UseVisualStyleBackColor = true;
            this.drawCardBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // restartBTN
            // 
            this.restartBTN.BackColor = System.Drawing.Color.IndianRed;
            this.restartBTN.Location = new System.Drawing.Point(1249, 634);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(135, 54);
            this.restartBTN.TabIndex = 7;
            this.restartBTN.Text = "再来一局";
            this.restartBTN.UseVisualStyleBackColor = false;
            this.restartBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // drawCardTB
            // 
            this.drawCardTB.Location = new System.Drawing.Point(492, 521);
            this.drawCardTB.Multiline = true;
            this.drawCardTB.Name = "drawCardTB";
            this.drawCardTB.Size = new System.Drawing.Size(271, 105);
            this.drawCardTB.TabIndex = 8;
            // 
            // drawCardLB
            // 
            this.drawCardLB.AutoSize = true;
            this.drawCardLB.BackColor = System.Drawing.SystemColors.Control;
            this.drawCardLB.Font = new System.Drawing.Font("宋体", 12F);
            this.drawCardLB.Location = new System.Drawing.Point(308, 521);
            this.drawCardLB.Name = "drawCardLB";
            this.drawCardLB.Size = new System.Drawing.Size(178, 24);
            this.drawCardLB.TabIndex = 9;
            this.drawCardLB.Text = "政策卡抽取情况";
            this.drawCardLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // cardLB
            // 
            this.cardLB.AutoSize = true;
            this.cardLB.BackColor = System.Drawing.SystemColors.Control;
            this.cardLB.Font = new System.Drawing.Font("宋体", 12F);
            this.cardLB.Location = new System.Drawing.Point(309, 335);
            this.cardLB.Name = "cardLB";
            this.cardLB.Size = new System.Drawing.Size(130, 24);
            this.cardLB.TabIndex = 10;
            this.cardLB.Text = "政策卡卡池";
            this.cardLB.Click += new System.EventHandler(this.label5_Click);
            // 
            // cardTB
            // 
            this.cardTB.Location = new System.Drawing.Point(469, 333);
            this.cardTB.Multiline = true;
            this.cardTB.Name = "cardTB";
            this.cardTB.Size = new System.Drawing.Size(295, 115);
            this.cardTB.TabIndex = 11;
            this.cardTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(72, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "自由党政策进度";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(999, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "法西斯政策进度";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 自由党胜利"});
            this.checkedListBox1.Location = new System.Drawing.Point(76, 157);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 354);
            this.checkedListBox1.TabIndex = 24;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("宋体", 7F);
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "1（5-8：空）（9-10：总统查人）",
            "2（5-6：空）（7-10：总统查人）",
            "3（5-6：总统查看3张牌）（7-10：总统指定下任总统）",
            "4 总统必须处决一人（希特勒总理胜利）",
            "5 总统必须处决一人（可全票否决）（希特勒总理胜利）",
            "6 法西斯胜利（希特勒总理胜利）"});
            this.checkedListBox2.Location = new System.Drawing.Point(993, 157);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(391, 364);
            this.checkedListBox2.TabIndex = 25;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(993, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "选举失败三次直接执行一个法案";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardTB);
            this.Controls.Add(this.cardLB);
            this.Controls.Add(this.drawCardLB);
            this.Controls.Add(this.drawCardTB);
            this.Controls.Add(this.restartBTN);
            this.Controls.Add(this.drawCardBTN);
            this.Controls.Add(this.titleLB);
            this.Controls.Add(this.roleListLB);
            this.Controls.Add(this.roleListTB);
            this.Controls.Add(this.playerNumLB);
            this.Controls.Add(this.playerNumTB);
            this.Controls.Add(this.resetRoleBTN);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "希特勒游戏简易工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetRoleBTN;
        private System.Windows.Forms.TextBox playerNumTB;
        private System.Windows.Forms.Label playerNumLB;
        private System.Windows.Forms.TextBox roleListTB;
        private System.Windows.Forms.Label roleListLB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Button drawCardBTN;
        private System.Windows.Forms.Button restartBTN;
        private System.Windows.Forms.TextBox drawCardTB;
        private System.Windows.Forms.Label drawCardLB;
        private System.Windows.Forms.Label cardLB;
        private System.Windows.Forms.TextBox cardTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button1;
    }
}

