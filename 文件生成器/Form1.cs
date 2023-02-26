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
                comboBox3.Items.Add("对话"    );
                comboBox3.Items.Add("收集"    );
                comboBox3.Items.Add("通关"    );
            }
            //任务条件
            {
                comboBox4.Items.Remove("寻人");
                comboBox4.Items.Remove("击杀怪物掉落");
                comboBox4.Items.Remove("寻怪并击杀");
                comboBox4.Items.Remove("指定副本");
                comboBox4.Items.Remove("限制消耗品");
                comboBox4.Items.Remove("不使用复活币");
                comboBox4.Items.Remove("击杀指定怪物");
                comboBox4.Items.Remove("限时通关");
            }
            //奖励选择
            {
                comboBox5.Items.Add("选择");
                comboBox5.Items.Add("全部");
                comboBox5.Items.Add("两者");
            }
            //任务是否可放弃
            {
                comboBox6.Items.Add("可以放弃");
                comboBox6.Items.Add("不可放弃");
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

        //任务要求 (comboBox3.Text) - 已初始化
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if      (comboBox3.Text == "对话")
            {
                //清空状态
                { 
                    comboBox4.Items.Remove("寻人");
                    comboBox4.Items.Remove("击杀怪物掉落");
                    comboBox4.Items.Remove("材料");
                    comboBox4.Items.Remove("指定副本");
                    comboBox4.Items.Remove("限制消耗品");
                    comboBox4.Items.Remove("不使用复活币");
                    comboBox4.Items.Remove("击杀指定怪物");
                    comboBox4.Items.Remove("限时通关");
                 
                }
                comboBox4.Items.Add("寻人");
                comboBox4.Text = "";
                if (comboBox4.Text == "寻人")
                {

                }
                else
                {
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label20.Enabled = false;
                    label53.Text = "";
                    label53.Enabled = false;
                    label54.Text = "";
                    label54.Enabled = false;
                    textBox8.Text = "";
                    textBox8.Enabled = false;
                    label19.Text = "";
                    label19.Enabled = false;
                    textBox7.Text = "";
                    textBox7.Enabled = false;
                    textBox6.Text = "";
                    textBox6.Enabled = false;
                    textBox27.Text = "";
                    textBox27.Enabled = false;
                    textBox28.Text = "";
                    textBox28.Enabled = false;
                }
            }
            else if (comboBox3.Text == "收集")
            {
                //清空状态
                { 
                    comboBox4.Items.Remove("寻人");
                    comboBox4.Items.Remove("击杀怪物掉落");
                    comboBox4.Items.Remove("材料");
                    comboBox4.Items.Remove("指定副本");
                    comboBox4.Items.Remove("限制消耗品");
                    comboBox4.Items.Remove("不使用复活币");
                    comboBox4.Items.Remove("击杀指定怪物");
                    comboBox4.Items.Remove("限时通关");
                }
                comboBox4.Items.Add("材料");
                comboBox4.Items.Add("击杀怪物掉落");
                comboBox4.Text = "";

                if (comboBox4.Text == "材料" || 
                    comboBox4.Text == "击杀怪物掉落")
                {

                }
                else
                {
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label20.Enabled = false;
                    label53.Text = "";
                    label53.Enabled = false;
                    label54.Text = "";
                    label54.Enabled = false;
                    textBox8.Text = "";
                    textBox8.Enabled = false;
                    label19.Text = "";
                    label19.Enabled = false;
                    textBox7.Text = "";
                    textBox7.Enabled = false;
                    textBox6.Text = "";
                    textBox6.Enabled = false;
                    textBox27.Text = "";
                    textBox27.Enabled = false;
                    textBox28.Text = "";
                    textBox28.Enabled = false;
                }
            }
            else if (comboBox3.Text == "通关")
            {
                //清空状态
                { 
                    comboBox4.Items.Remove("寻人");
                    comboBox4.Items.Remove("击杀怪物掉落");
                    comboBox4.Items.Remove("材料");
                    comboBox4.Items.Remove("指定副本");
                    comboBox4.Items.Remove("限制消耗品");
                    comboBox4.Items.Remove("不使用复活币");
                    comboBox4.Items.Remove("击杀指定怪物");
                    comboBox4.Items.Remove("限时通关");
                }
                comboBox4.Items.Add("指定副本");
                comboBox4.Items.Add("限时通关");
                comboBox4.Items.Add("限制消耗品");
                comboBox4.Items.Add("不使用复活币");
                comboBox4.Text = "";
                if (comboBox4.Text == "指定副本"     || 
                    comboBox4.Text == "限时通关"     || 
                    comboBox4.Text == "限制消耗品"   || 
                    comboBox4.Text == "不使用复活币")
                {

                }
                else
                {
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label20.Enabled = false;
                    label53.Text = "";
                    label53.Enabled = false;
                    label54.Text = "";
                    label54.Enabled = false;
                    textBox8.Text = "";
                    textBox8.Enabled = false;
                    label19.Text = "";
                    label19.Enabled = false;
                    textBox7.Text = "";
                    textBox7.Enabled = false;
                    textBox6.Text = "";
                    textBox6.Enabled = false;
                    textBox27.Text = "";
                    textBox27.Enabled = false;
                    textBox28.Text = "";
                    textBox28.Enabled = false;
                }
            }
        }

        //任务内容
        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "击杀怪物掉落")
            {
                label18.Text = "怪物 ID";
                label18.Enabled = true;
                label19.Text = "掉落物品 ID";
                label19.Enabled = true;
                label20.Text = "副本 ID";
                label20.Enabled = true;
                label53.Text = "任务物品 ID";
                label53.Enabled = true;
                label54.Text = "任务物品 数量";
                label54.Enabled = true;
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox6.Enabled = true;
                textBox27.Text = "";
                textBox27.Enabled = true;
                textBox28.Text = "";
                textBox28.Enabled = true;


                textBox8.Enabled = true;

                textBox7.Enabled = true;

            }
            else if (comboBox4.Text == "寻人")
            {
                label18.Text = "寻找的NPC ID";
                label20.Text = "";
                textBox8.Text = "";
                label19.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                label53.Text = "";
                label54.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox6.Enabled = true;
                label18.Enabled = true;
                label20.Enabled = false;
                textBox8.Enabled = false;
                label19.Enabled = false;
                textBox7.Enabled = false;

            }
            else if (comboBox4.Text == "材料")
            {
                label18.Text = "需要材料物品 ID";
                label19.Text = "需要物品数量";
                label20.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                label53.Text = "";
                label54.Text = "";
                textBox27.Text = "";
                textBox28.Text = "";
                textBox27.Enabled = false;
                textBox28.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = true;
                label20.Enabled = false;
                textBox8.Enabled = false;
                label19.Enabled = true;
                textBox7.Enabled = true;
                textBox6.Enabled = true;

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
            //任务是否可以放弃
            {
                if (comboBox6.Text == "可以放弃")
                {
                    label56.Text = "" ;
                }
                else if (comboBox6.Text == "不可放弃")
                {
                    label56.Text = "[cant giveup]" + "\n" + "\t" + "1" + "\n" + "\n";
                }
            }
            //QP任务点 (label51.Text) - 已初始化
            {
                if (textBox26.Text == "")
                {
                    label51.Text = "[quest point]" + "\n" + "\t" + "0" + "\n" + "\n";
                }
                else
                { 
                    label51.Text = "[quest point]" + "\n" + "\t" + textBox26.Text + "\n" + "\n";
                }
            }
            //发布NPC&对话NPC (label40.Text label41.Text) - 已初始化
            {
                if      (textBox5.Text == "" && textBox25.Text == "")
                {
                    label40.Text = "[npc index]" + "\n" + "\t" + "2" + "\n" + "\n";

                    label41.Text = "[complete npc index]" + "\n" + "\t" + "-1" + "\n" + "\n";
                }
                else if (textBox5.Text == "" && textBox25.Text != "")
                {
                    label40.Text = "[npc index]" + "\n" + "\t" + "2" + "\n" + "\n";

                    label41.Text = "[complete npc index]" + "\n" + "\t" + textBox25.Text + "\n" + "\n";
                }
                else if (textBox5.Text != "" && textBox25.Text == "")
                {
                    label40.Text = "[npc index]" + "\n" + "\t" + textBox5.Text + "\n" + "\n";

                    label41.Text = "[complete npc index]" + "\n" + "\t" + "-1" + "\n" + "\n";
                }
                else if (textBox5.Text != "" && textBox25.Text != "")
                {
                    label40.Text = "[npc index]" + "\n" + "\t" + textBox5.Text + "\n" + "\n";
                    label41.Text = "[complete npc index]" + "\n" + "\t" + textBox25.Text + "\n" + "\n";
                }
            }

            //等级区间 (label42.Text) - 已初始化
            {
                if      (textBox2.Text == "" && textBox3.Text == "")
                {
                    label42.Text = "[level]" + "\n" + "\t" + "1"           + "\t" + "1000"        + "\n" + "\n";
                }
                else if (textBox2.Text == "" && textBox3.Text != "")
                { 
                    label42.Text = "[level]" + "\n" + "\t" + "1"           + "\t" + textBox3.Text + "\n" + "\n";
                }
                else if (textBox2.Text != "" && textBox3.Text == "")
                {
                    label42.Text = "[level]" + "\n" + "\t" + textBox2.Text + "\t" + "1000"        + "\n" + "\n";
                }
                else if (textBox2.Text != "" && textBox3.Text != "")
                {
                    label42.Text = "[level]" + "\n" + "\t" + textBox2.Text + "\t" + textBox3.Text + "\n" + "\n";
                }
            }

            //前置任务 (label39.Text) - 已初始化
            {
                if (label39.Text == "")
                {
                    label39.Text = "[pre required quest]"  + "\n" +
                                   "\t" + "-1"             + "\n" +
                                   "[/pre required quest]" + "\n" + "\n";
                }
                else
                {
                    label39.Text = "[pre required quest]"  + "\n" +
                                   "\t" + textBox4.Text    + "\n" +
                                   "[/pre required quest]" + "\n" + "\n";
                }
            }

            //任务名称&对话 (label38.Text) - 已初始化
            {
                label38.Text = "[name]"              + "\n" + "\t" + "`" + richTextBox6.Text + "`" + "\n" + "\n" +
                               "[depend message]"    + "\n" + "\t" + "`" + richTextBox3.Text + "`" + "\n" + "\n" +
                               "[condition message]" + "\n" + "\t" + "`" + richTextBox4.Text + "`" + "\n" + "\n" +
                               "[solve message]"     + "\n" + "\t" + "`" + richTextBox5.Text + "`" + "\n" + "\n" ;
            }

            //物品判定 (label43.Text) - 已初始化
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

            //奖励输出 (label43.Text) - 已初始化
            {
                if      (comboBox5.Text == "选择")
                {
                    label43.Text = "[reward int data]"            + "\n" +
                                   "[/reward int data]"           + "\n" + "\n" +
                                   "[reward selection int data]"  + "\n" +
                                    label3.Text +  label4.Text    +
                                   label45.Text + label46.Text    +
                                   label47.Text + label48.Text    +
                                   label49.Text + label50.Text    + "\n" +
                                   "[/reward selection int data]" + "\n" + "\n";
                }
                else if (comboBox5.Text == "全部")
                {
                    label43.Text = "[reward int data]"            + "\n" +
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
                    label43.Text = "[reward int data]"            + "\n" +
                                    label3.Text +  label4.Text    +
                                   label45.Text + label46.Text    + "\n" +
                                   "[/reward int data]"    + "\n" + "\n" +
                                   "[reward selection int data]"  + "\n" +
                                   label47.Text + label48.Text    +
                                   label49.Text + label50.Text    + "\n" +
                                   "[/reward selection int data]" + "\n" + "\n";
                }
            }

            //对话 - 寻人
            { 
                if (comboBox4.Text == "寻人")
                {
                    if (textBox6.Text == "")
                    {
                        MessageBox.Show("填入需要寻找的NPC！", "警告！");
                    }
                    else
                    {
                        label41.Text = "[complete npc index]" + "\n" + "\t" + textBox6.Text + "\n" + "\n" ; 
                        label52.Text = "[type]"        + "\n" + "\t" + "`[meet npc]`"       + "\n" + "\n" +
                                       "[sub type]"    + "\n" + "\t" + "-1"                 + "\n" + "\n" +
                                       "[int data]"    + "\n" + "\t" + textBox6.Text        + "\n" + 
                                       "[/int data]"                                        + "\n" + "\n" +
                                       "[reward type]" + "\n" + "\t" + "`[item]`"           + "\n" + "\n" ;
                    }
                }
            }

            //对话 - 材料
            {
                if (comboBox4.Text == "材料")
                {
                    if (textBox6.Text == "" && textBox7.Text == "")
                    {
                        MessageBox.Show("请填入物品ID与数量！", "警告！");
                    }
                    else if (textBox6.Text != "" && textBox7.Text == "")
                    {
                        MessageBox.Show("请填入物品数量！", "警告！");
                    }
                    else if (textBox6.Text == "" && textBox7.Text != "")
                    {
                        MessageBox.Show("请填入物品ID ！", "警告！");
                    }
                    else if (textBox6.Text != "" && textBox7.Text != "")
                    {
                        label52.Text = "[type]"        + "\n" + "\t" + "`[seeking]`" + "\n" + "\n" +
                                       "[sub type]"    + "\n" + "\t" + "-1"          + "\n" + "\n" +
                                       "[int data] "   + "\n" + "\t" + textBox6.Text + "\t" + textBox7.Text + "\n" +
                                       "[/int data]"   + "\n" + "\n" +
                                       "[reward type]" + "\n" + "\t" + "`[item]`"    + "\n" + "\n" ;
                    }
                }
            }
            //对话 - 击杀怪物掉落
            {
                if (comboBox4.Text == "击杀怪物掉落")
                {
                    if (textBox8.Text == "" && textBox6.Text == "" && textBox7.Text == "")
                    {
                        MessageBox.Show("请填入副本ID 、怪物ID 、掉落物品ID ！", "警告！");
                    }
                    else if (textBox8.Text =="" || textBox6.Text =="" || textBox7.Text == "")
                    {
                        MessageBox.Show("请检查副本ID 、怪物ID 、掉落物品ID ，是否填写完整！", "警告！");
                    }
                    else if (textBox8.Text != "" && textBox6.Text != "" && textBox7.Text != "")
                    {
                        label52.Text = "[type]	`[seeking]`" +
                                       "[sub type]	-1" +
                                       "[int data]	3087	1" +
                                       "[/int data]" +
                                       "[reward type]" + "`[item]`" +
                                       "[clear reward item]" +
                                       "	2	-1	3087	1	100	1" +
                                       "[/clear reward item]";
                    }
                }
            }
            //组合窗体输出 (richTextBox1.Text)
            {
                if      (comboBox3.Text == "对话" && comboBox4.Text == "寻人"        )
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "" ;
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "收集" && comboBox4.Text == "材料"        )
                {
                    if (textBox6.Text == "" || textBox7.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "收集" && comboBox4.Text == "击杀怪物掉落")
                {
                    if (textBox8.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "通关" && comboBox4.Text == "指定副本"    )
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "通关" && comboBox4.Text == "限时通关"    )
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "通关" && comboBox4.Text == "限制消耗品"  )
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "通关" && comboBox4.Text == "击杀怪物"    )
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
                else if (comboBox3.Text == "通关" && comboBox4.Text == "不使用复活币")
                {
                    if (textBox6.Text == "")
                    {
                        richTextBox1.Text = "";
                    }
                    else
                    {
                        richTextBox1.Text = label1.Text + label40.Text + label41.Text + label51.Text + label2.Text + label42.Text + label56.Text + label52.Text + label43.Text + label38.Text;
                    }
                }
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
            MessageBox.Show("选择：" + "\n" + "\t" + "填入1-8个奖励，仅供选择其中一个。" + "\n" + 
                            "全部：" + "\n" + "\t" + "填入1-8个奖励，任务完成奖励所有。" + "\n" + 
                            "两者：" + "\n" + "\t" + "在1-4填入选择奖励，在5-8填入全部奖励。" + "\n" +
                            "注意：" + "\n" + "\t" + "如果需要添加更多请手动在预览窗口按格式修改添加。Ps：不会修改勿动！" + "\n" , "关于奖励选项");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
