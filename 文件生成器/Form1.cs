using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 文件生成器
{
    public partial class Form1 : Form
    {
        //主窗口
        public Form1()
        {
            InitializeComponent();
        }

        //初始选项 (已初始化)
        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            //分类选项
            { 
                comboBox1.Items.Add("史诗");
                comboBox1.Items.Add("每日");
                comboBox1.Items.Add("重复");
                comboBox1.Items.Add("成就");
                comboBox1.Items.Add("普通");
            }
            //职业选项
            {
                comboBox2.Items.Add("全职业");
                comboBox2.Items.Add("鬼剑士");
                comboBox2.Items.Add("男格斗");
                comboBox2.Items.Add("女格斗");
                comboBox2.Items.Add("男枪手");
                comboBox2.Items.Add("女枪手");
                comboBox2.Items.Add("女法师");
                comboBox2.Items.Add("盗贼"  );
                comboBox2.Items.Add("圣职者");
            }
            //任务要求
            {
                comboBox3.Items.Add("对话");
                comboBox3.Items.Add("收集");
                comboBox3.Items.Add("强化");
                comboBox3.Items.Add("击杀");
                comboBox3.Items.Add("寻人");
                comboBox3.Items.Add("通关模板");
                comboBox3.Items.Add("收集模板");
                comboBox3.Items.Add("寻人模板");
                comboBox3.Items.Add("房间模板");
            }
            //任务条件
            {
                comboBox4.Items.Add("不限");
                comboBox4.Items.Add("通关时间");
                comboBox4.Items.Add("被击数");
                comboBox4.Items.Add("不用复活币");
                comboBox4.Items.Add("组队人数");
                comboBox4.Items.Add("难度");
                comboBox4.Items.Add("连击杀伤率");
                comboBox4.Items.Add("背击数");
                comboBox4.Items.Add("破招数");
                comboBox4.Items.Add("连击数");
                comboBox4.Items.Add("全图房间数");
                comboBox4.Items.Add("群体攻击数");
            }
            //奖励选择
            {
                comboBox5.Items.Add("选择");
                comboBox5.Items.Add("全部");
                comboBox5.Items.Add("两者");
            }
        }

        //qst分类 (label1.Text) - 已初始化
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if      (comboBox1.Text == "史诗")
            {
                label1.Text = "#PVF_File" + "\n" + "\n" + "[grade]" + "\n" + "\t" + "`[epic]`"           + "\n" + "\n";
            }
            else if (comboBox1.Text == "每日")
            {
                label1.Text = "#PVF_File" + "\n" + "\n" + "[grade]" + "\n" + "\t" + "`[daily]`"          + "\n" + "\n";
            }
            else if (comboBox1.Text == "重复")
            {
                label1.Text = "#PVF_File" + "\n" + "\n" + "[grade]" + "\n" + "\t" + "`[normaly repeat]`" + "\n" + "\n";
            }
            else if (comboBox1.Text == "成就")
            {
                label1.Text = "#PVF_File" + "\n" + "\n" + "[grade]" + "\n" + "\t" + "`[achievement]`"    + "\n" + "\n";
            }
            else if (comboBox1.Text == "普通")
            {
                label1.Text = "#PVF_File" + "\n" + "\n" + "[grade]" + "\n" + "\t" + "`[common unique]`"  + "\n" + "\n";
            }
        }

        //obj角色 (label2.Text) - 已初始化
        private void ComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if      (comboBox2.Text == "全职业")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[all]`"        + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n" ;
            }
            else if (comboBox2.Text == "鬼剑士")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[swordman]`"   + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "男格斗")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[at fighter]`" + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "女格斗")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[fighter]`"    + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "男枪手")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[gunner]`"     + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "女枪手")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[at gunner]`"  + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "女法师")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[mage]`"       + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "盗贼"  )
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[thief]`"      + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
            else if (comboBox2.Text == "圣职者")
            {
                label2.Text = "[job]" + "\n" + "\t" + "`[priest]`"     + "\n" + "\n" + "[grow type]" + "\n" + "\t" + "-1" + "\n" + "\n";
            }
        }

        //任务要求
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if      (comboBox3.Text == "寻人"    )
            {
             //  [type]
             //      `[meet npc]`
             //
             //  [sub type]
             //      -1
             //
             //  [int data] 对话NPC
             //      2
             //  [/int data]
             //
             //  [reward type]
             //      `[item]`
            }
            else if (comboBox3.Text == "收集"    )
            {

            }
            else if (comboBox3.Text == "击杀"    )
            {
             // [type]
	         //     `[hunt monster]`
             //
             // [sub type]
             //     -1
             //
             // [int data] 副本 难度 怪物 数量
             //     14	1	700	50	14	1	701	50	14	1	702	1
             // [/int data]
             //
             // [reward type]
             //     `[item]`
            }
            else if (comboBox3.Text == "寻人"    )
            {

            }
            else if (comboBox3.Text == "房间"    )
            {

            }
            else if (comboBox3.Text == "通关模板")
            {

            }
            else if (comboBox3.Text == "收集模板")
            {

            }
            else if (comboBox3.Text == "寻人模板")
            {

            }
            else if (comboBox3.Text == "房间模板")
            {

            }
        }

        //任务内容
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if      (comboBox4.Text == "不限"      )
            {

            }
            else if (comboBox4.Text == "通关时间"  )
            {

            }
            else if (comboBox4.Text == "被击数"    )
            {

            }
            else if (comboBox4.Text == "不用复活币")
            {

            }
            else if (comboBox4.Text == "组队人数"  )
            {

            }
            else if (comboBox4.Text == "难度"      )
            {

            }
            else if (comboBox4.Text == "连击杀伤率")
            {

            }
            else if (comboBox4.Text == "背击数"    )
            {

            }
            else if (comboBox4.Text == "破招数"    )
            {

            }
            else if (comboBox4.Text == "连击数"    )
            {

            }
            else if (comboBox4.Text == "全图房间数")
            {

            }
            else if (comboBox4.Text == "群体攻击数")
            {

            }
        }

        //奖励选项 (label43.Text)
        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////
        //预览输出 - 简体(richTextBox1.Text) - 编辑中...
        private void Button1_Click(object sender, EventArgs e)
        {
            //QP任务点
            {
                label51.Text = "[quest point]" + "\n" + "\t" + textBox26.Text + "\n" + "\n";
            }
            //发布NPC&对话NPC (label40.Text) (label41.Text)
            {
                label40.Text = "[npc index]"          + "\n" + "\t" + textBox5.Text  + "\n" + "\n";
                label41.Text = "[complete npc index]" + "\n" + "\t" + textBox25.Text + "\n" + "\n";
            }

            //等级区间 (label42.Text)
            {
                label42.Text = "[level]" + "\n" + "\t" + textBox2.Text + "\t" + textBox3.Text + "\n" + "\n";
            }

            //前置任务 (label39.Text)
            {
                label39.Text = "[pre required quest]"  + "\n" +
                               "\t" + textBox4.Text    + "\n" +
                               "[/pre required quest]" + "\n" + "\n";
            }

            //任务名称&对话 (label38.Text)
            {
                label38.Text = "[name]"              + "\n" + "\t" + "`" + richTextBox6.Text + "`" + "\n" + "\n" +
                               "[depend message]"    + "\n" + "\t" + "`" + richTextBox3.Text + "`" + "\n" + "\n" +
                               "[condition message]" + "\n" + "\t" + "`" + richTextBox4.Text + "`" + "\n" + "\n" +
                               "[solve message]"     + "\n" + "\t" + "`" + richTextBox5.Text + "`" + "\n" + "\n" ;
            }

            //物品判定 (label43.Text)
            {
                //物品判定 1 (label3.Text)
                {
                    if      (textBox9.Text != "" && textBox10.Text != "")
                    {
                        label3.Text = "\t" + textBox9.Text + "\t" + textBox10.Text;
                    }
                    else if (textBox9.Text == "" && textBox10.Text == "")
                    {
                        label3.Text = "";
                    }
                    else if (textBox9.Text == "" && textBox10.Text != "")
                    {
                        MessageBox.Show("物品 1 ID  未填写！", "警告！");
                        label3.Text = "";
                    }
                    else if (textBox9.Text != "" && textBox10.Text == "")
                    {
                        MessageBox.Show("物品 1 数量未填写！", "警告！");
                        label3.Text = "";
                    }
                }
                //物品判定 2 (label4.Text)
                {
                    if      (textBox11.Text != "" && textBox12.Text != "")
                    {
                        label4.Text = "\t" + textBox11.Text + "\t" + textBox12.Text;
                    }
                    else if (textBox11.Text == "" && textBox12.Text == "")
                    {
                        label4.Text = "";
                    }
                    else if (textBox11.Text == "" && textBox12.Text != "")
                    {
                        MessageBox.Show("物品 2 ID  未填写！", "警告！");
                        label4.Text = "";
                    }
                    else if (textBox11.Text != "" && textBox12.Text == "")
                    {
                        MessageBox.Show("物品 2 数量未填写！", "警告！");
                        label4.Text = "";
                    }
                }
                //物品判定 3 (label45.Text)
                {
                    if      (textBox13.Text != "" & textBox14.Text != "")
                    {
                        label45.Text = "\t" + textBox13.Text + "\t" + textBox14.Text;
                    }
                    else if (textBox13.Text == "" && textBox14.Text == "")
                    {
                        label45.Text = "";
                    }
                    else if (textBox13.Text == "" && textBox14.Text != "")
                    {
                        MessageBox.Show("物品 3 ID  未填写！", "警告！");
                        label45.Text = "";
                    }
                    else if (textBox13.Text != "" && textBox14.Text == "")
                    {
                        MessageBox.Show("物品 3 数量未填写！", "警告！");
                        label45.Text = "";
                    }
                }
                //物品判定 4 (label46.Text)
                {
                    if      (textBox15.Text != "" & textBox16.Text != "")
                    {
                        label46.Text = "\t" + textBox15.Text + "\t" + textBox16.Text;
                    }
                    else if (textBox15.Text == "" && textBox16.Text == "")
                    {
                        label46.Text = "";
                    }
                    else if (textBox15.Text == "" && textBox16.Text != "")
                    {
                        MessageBox.Show("物品 4 ID  未填写！", "警告！");
                        label46.Text = "";
                    }
                    else if (textBox15.Text != "" && textBox16.Text == "")
                    {
                        MessageBox.Show("物品 4 数量未填写！", "警告！");
                        label46.Text = "";
                    }
                }
                //物品判定 5 (label47.Text)
                {
                    if      (textBox18.Text != "" & textBox17.Text != "")
                    {
                        label47.Text = "\t" + textBox18.Text + "\t" + textBox17.Text;
                    }
                    else if (textBox18.Text == "" && textBox17.Text == "")
                    {
                        label47.Text = "";
                    }
                    else if (textBox18.Text == "" && textBox17.Text != "")
                    {
                        MessageBox.Show("物品 5 ID  未填写！", "警告！");
                        label47.Text = "";
                    }
                    else if (textBox18.Text != "" && textBox17.Text == "")
                    {
                        MessageBox.Show("物品 5 数量未填写！", "警告！");
                        label47.Text = "";
                    }
                }
                //物品判定 6 (label48.Text)
                {
                    if      (textBox20.Text != "" & textBox19.Text != "")
                    {
                        label48.Text = "\t" + textBox20.Text + "\t" + textBox19.Text;
                    }
                    else if (textBox20.Text == "" && textBox19.Text == "")
                    {
                        label48.Text = "";
                    }
                    else if (textBox20.Text == "" && textBox19.Text != "")
                    {
                        MessageBox.Show("物品 6 ID  未填写！", "警告！");
                        label48.Text = "";
                    }
                    else if (textBox20.Text != "" && textBox19.Text == "")
                    {
                        MessageBox.Show("物品 6 数量未填写！", "警告！");
                        label48.Text = "";
                    }
                }
                //物品判定 7 (label49.Text)
                {
                    if      (textBox22.Text != "" & textBox21.Text != "")
                    {
                        label49.Text = "\t" + textBox22.Text + "\t" + textBox21.Text;
                    }
                    else if (textBox22.Text == "" && textBox21.Text == "")
                    {
                        label49.Text = "";
                    }
                    else if (textBox22.Text == "" && textBox21.Text != "")
                    {
                        MessageBox.Show("物品 7 ID  未填写！", "警告！");
                        label49.Text = "";
                    }
                    else if (textBox22.Text != "" && textBox21.Text == "")
                    {
                        MessageBox.Show("物品 7 数量未填写！", "警告！");
                        label49.Text = "";
                    }
                }
                //物品判定 8 (label50.Text)
                {
                    if      (textBox24.Text != "" & textBox23.Text != "")
                    {
                        label50.Text = "\t" + textBox24.Text + "\t" + textBox23.Text;
                    }
                    else if (textBox24.Text == "" && textBox23.Text == "")
                    {
                        label50.Text = "";
                    }
                    else if (textBox24.Text == "" && textBox23.Text != "")
                    {
                        MessageBox.Show("物品 8 ID  未填写！", "警告！");
                        label50.Text = "";
                    }
                    else if (textBox24.Text != "" && textBox23.Text == "")
                    {
                        MessageBox.Show("物品 8 数量未填写！", "警告！");
                        label50.Text = "";
                    }
                }
            }

            //奖励输出 (label43.Text)
            {
                if      (comboBox5.Text == "选择")
                {
                    label43.Text = "[reward int data]"     + "\n" +
                                   "[/reward int data]"    + "\n" + "\n" +
                                   "[reward selection int data]"  + "\n" +
                                    label3.Text +  label4.Text    +
                                   label45.Text + label46.Text    +
                                   label47.Text + label48.Text    +
                                   label49.Text + label50.Text    + "\n" +
                                   "[/reward selection int data]" + "\n" + "\n";
                }
                else if (comboBox5.Text == "全部")
                {
                    label43.Text = "[reward int data]"     + "\n" +
                                     label3.Text +  label4.Text   +
                                    label45.Text + label46.Text   +
                                    label47.Text + label48.Text   +
                                    label49.Text + label50.Text   + "\n" +
                                   "[/reward int data]"    + "\n" + "\n" +
                                   "[reward selection int data]"  + "\n" +
                                   "[/reward selection int data]" + "\n" + "\n";
                }
                else if (comboBox5.Text == "两者")
                {
                    label43.Text = "[reward int data]"     + "\n" +
                                    label3.Text +  label4.Text    +
                                   label45.Text + label46.Text    + "\n" +
                                   "[/reward int data]"    + "\n" + "\n" +
                                   "[reward selection int data]"  + "\n" +
                                   label47.Text + label48.Text    +
                                   label49.Text + label50.Text    + "\n" +
                                   "[/reward selection int data]" + "\n" + "\n";
                }
            }

            //组合窗体输出 (richTextBox1.Text)
            {
                richTextBox1.Text =  label1.Text +
                                    label40.Text +
                                    label42.Text +
                                    label41.Text +
                                     label2.Text +
                                    label43.Text +
                                    label39.Text +
                                    label51.Text +
                                    label38.Text ;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////

        //预览输出 - 繁体(richTextBox2.Text)
        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Microsoft.VisualBasic.Strings.StrConv(richTextBox1.Text, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
        }

        //简体转繁体
        public static string Fan_TransLate(string str)
        {
            var resultStr = Microsoft.VisualBasic.Strings.StrConv(str, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
            return resultStr;
        }

        //繁体转简体
        public static string Jan_TransLate(string str)
        {
            var resultStr = Microsoft.VisualBasic.Strings.StrConv(str, Microsoft.VisualBasic.VbStrConv.SimplifiedChinese, 0);
            return resultStr;
        }

        //保存文件(richTextBox2)
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog
            {
                Filter = "(*.qst)|*.qst|" + "(*.*)|*.*",
                FileName = textBox1.Text + ".qst"
            };
            if (objSave.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox2.SaveFile(objSave.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //预览 1 - 不用
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //软件
        private void 软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t" + "这是一个PVF的qst任务文件生成器!" + "\n" +
                "\t" + "输入你需要的参数就可以了..." + "\n" +
                "\t" + "看起来挺好用的...", "软件大概就是这样了...");
        }

        //关于
        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    Ae (FreyaGrace) 的小软件 " + "\n" + "    这是一个自学，代码来自网页，拼拼凑凑的一个小程序 ...", "关于");
        }

        //奖励 - 帮助按钮
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择" + "\n" + "\t" + "填入1-8个奖励，仅供选择其中一个。" + "\n" + 
                            "全部" + "\n" + "\t" + "填入1-8个奖励，任务完成奖励所有。" + "\n" + 
                            "两者" + "\n" + "\t" + "在1-4填入选择奖励，在5-8填入全部奖励。" + "\n", "关于奖励选项");
        }
    }
}
