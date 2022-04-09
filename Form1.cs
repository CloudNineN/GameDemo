using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDemo
{
    public partial class Form1 : Form
    {
        // 红卡总数 常量
        private const int redCardNum = 11;

        // 红卡已执行数
        private int redCardUsedNum = 0;

        // 弃牌区红卡数
        private int redDiscardNum = 0;

        // 红卡剩余
        private int redSurplus = redCardNum;

        // 蓝卡总数 常量
        private const int blueCardNum = 6;

        // 蓝卡已执行数
        private int blueCardUsedNum = 0;

        // 弃牌区蓝卡数
        private int blueDiscardNum = 0;

        // 蓝卡剩余
        private int blueSurplus = blueCardNum;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // 分配角色按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //获取玩家人数
            var playerNumStr = playerNumTB.Text;
            var playerNum = int.Parse(playerNumStr);
            // 抽签数组
            var roleList = new ArrayList();
            // 根据总玩家数量初始化双方人数
            switch (playerNum)
            {
                case 5:
                    // goodNum = 3;
                    // badNum = 1;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = [ "自由党", "自由党", "自由党", "法西斯", "法西斯-希特勒" ];
                    break;
                case 6:
                    // goodNum = 4;
                    // badNum = 1;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = ["自由党", "自由党", "自由党", "自由党", "法西斯", "法西斯-希特勒"]
                    break;
                case 7:
                    // goodNum = 4;
                    // badNum = 2;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = ["自由党", "自由党", "自由党", "自由党", "法西斯", "法西斯", "法西斯-希特勒"]
                    break;
                case 8:
                    // goodNum = 5;
                    // badNum = 2;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = ["自由党", "自由党", "自由党", "自由党", "自由党", "法西斯", "法西斯", "法西斯-希特勒"]
                    break;
                case 9:
                    // goodNum = 5;
                    // badNum = 3;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = ["自由党", "自由党", "自由党", "自由党", "自由党", "法西斯", "法西斯", "法西斯", "法西斯-希特勒"]
                    break;
                case 10:
                    // goodNum = 6;
                    // badNum = 3;
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("自由党");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯");
                    roleList.Add("法西斯-希特勒");
                    // roleList = ["自由党", "自由党", "自由党", "自由党", "自由党", "自由党", "法西斯", "法西斯", "法西斯", "法西斯-希特勒"]
                    break;
                default:
                    return;
            }

            // 随机打乱角色
            var random = new Random();
            var resultList = new ArrayList();
            for (int i = 0; i < playerNum; i++)
            {
                var next = random.Next(0, roleList.Count);
                resultList.Add(roleList[next]);
                roleList.RemoveAt(next);
            }

            // 转为字符串
            var resultStr = new StringBuilder();
            for (var i = 0; i < resultList.Count; i++)
            {
                resultStr.Append("玩家");
                resultStr.Append(i + 1);
                resultStr.Append(" 身份为：");
                resultStr.Append(resultList[i]);
                resultStr.Append("\r\n");
            }

            roleListTB.Text = resultStr.ToString();

            // 政策卡卡池信息
            var cardTBStr = new StringBuilder();
            cardTBStr.Append(" 自由党法案剩余数量：");
            cardTBStr.Append(blueSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 法西斯法案剩余数量：");
            cardTBStr.Append(redSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区自由党法案数量：");
            cardTBStr.Append(blueDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区法西斯法案数量：");
            cardTBStr.Append(redDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTB.Text = cardTBStr.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // 抽卡按钮
        private void button2_Click(object sender, EventArgs e)
        {
            var cardList = new ArrayList();
            // 红总数-弃牌区-已执行
             redSurplus = redCardNum - redDiscardNum - redCardUsedNum;
            // 蓝总数-弃牌区-已执行
             blueSurplus = blueCardNum - blueDiscardNum - blueCardUsedNum;
            // 剩余少于三张则洗牌
            if (redSurplus + blueSurplus < 3)
            {
                redSurplus += redDiscardNum;
                redDiscardNum = 0;
                blueSurplus += blueDiscardNum;
                blueDiscardNum = 0;
            }

            // 卡池添加红卡
            for (int i = 0; i < redSurplus; i++)
            {
                cardList.Add("法西斯政策卡");
            }

            // 卡池添加蓝卡
            for (int i = 0; i < blueSurplus; i++)
            {
                cardList.Add("自由党政策卡");
            }

            // 抽三张
            var random = new Random();
            var resultList = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                var next = random.Next(0, cardList.Count);
                resultList.Add(cardList[next]);
                cardList.RemoveAt(next);
            }

            for (var i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].Equals("自由党政策卡"))
                {
                    blueSurplus -= 1;
                    blueDiscardNum += 1;
                }

                if (resultList[i].Equals("法西斯政策卡"))
                {
                    redSurplus -= 1;
                    redDiscardNum += 1;
                }
            }

            // 转为字符串
            var resultStr = new StringBuilder();
            for (var i = 0; i < resultList.Count; i++)
            {
                resultStr.Append(resultList[i]);
                resultStr.Append("\r\n");
            }

            drawCardTB.Text = resultStr.ToString();

            // 政策卡卡池信息
            var cardTBStr = new StringBuilder();
            cardTBStr.Append(" 自由党法案剩余数量：");
            cardTBStr.Append(blueSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 法西斯法案剩余数量：");
            cardTBStr.Append(redSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区自由党法案数量：");
            cardTBStr.Append(blueDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区法西斯法案数量：");
            cardTBStr.Append(redDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTB.Text = cardTBStr.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redCardUsedNum = 0;
            redDiscardNum = 0;
            blueCardUsedNum = 0;
            blueDiscardNum = 0;

            roleListTB.Text = "";
            cardTB.Text = "";
            drawCardTB.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void titleLB_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var cardList = new ArrayList();
            // 红总数-弃牌区-已执行
             redSurplus = redCardNum - redDiscardNum - redCardUsedNum;
            // 蓝总数-弃牌区-已执行
             blueSurplus = blueCardNum - blueDiscardNum - blueCardUsedNum;
            // 剩余少于三张则洗牌
            if (redSurplus + blueSurplus < 3)
            {
                redSurplus += redDiscardNum;
                redDiscardNum = 0;
                blueSurplus += blueDiscardNum;
                blueDiscardNum = 0;
            }

            // 卡池添加红卡
            for (int i = 0; i < redSurplus; i++)
            {
                cardList.Add("法西斯政策卡");
            }

            // 卡池添加蓝卡
            for (int i = 0; i < blueSurplus; i++)
            {
                cardList.Add("自由党政策卡");
            }

            // 抽1张
            var random = new Random();
            var resultList = new ArrayList();
            var next = random.Next(0, cardList.Count);
            var result = cardList[next];

            if (result.Equals("自由党政策卡"))
            {
                blueSurplus -= 1;
                blueDiscardNum += 1;
            }

            if (result.Equals("法西斯政策卡"))
            {
                redSurplus -= 1;
                redDiscardNum += 1;
            }

            drawCardTB.Text = result.ToString();

            // 政策卡卡池信息
            var cardTBStr = new StringBuilder();
            cardTBStr.Append(" 自由党法案剩余数量：");
            cardTBStr.Append(blueSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 法西斯法案剩余数量：");
            cardTBStr.Append(redSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区自由党法案数量：");
            cardTBStr.Append(blueDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区法西斯法案数量：");
            cardTBStr.Append(redDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTB.Text = cardTBStr.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 法西斯政策执行
            var count = checkedListBox2.CheckedItems.Count;
            redCardUsedNum = count;
            redDiscardNum -= 1;
            // 政策卡卡池信息
            var cardTBStr = new StringBuilder();
            cardTBStr.Append(" 自由党法案剩余数量：");
            cardTBStr.Append(blueSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 法西斯法案剩余数量：");
            cardTBStr.Append(redSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区自由党法案数量：");
            cardTBStr.Append(blueDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区法西斯法案数量：");
            cardTBStr.Append(redDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTB.Text = cardTBStr.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 自由党政策执行
            var count = checkedListBox1.CheckedItems.Count;
            blueCardUsedNum = count;
            blueDiscardNum -= 1;
            // 政策卡卡池信息
            var cardTBStr = new StringBuilder();
            cardTBStr.Append(" 自由党法案剩余数量：");
            cardTBStr.Append(blueSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 法西斯法案剩余数量：");
            cardTBStr.Append(redSurplus.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区自由党法案数量：");
            cardTBStr.Append(blueDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTBStr.Append(" 弃牌区法西斯法案数量：");
            cardTBStr.Append(redDiscardNum.ToString());
            cardTBStr.Append("\r\n");
            cardTB.Text = cardTBStr.ToString();
        }
    }
}