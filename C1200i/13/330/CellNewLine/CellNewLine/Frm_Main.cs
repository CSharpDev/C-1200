﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CellNewLine
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            dgv_Message.DataSource = new List<Fruit>() {//绑定数据集合
            new Fruit(){Name="苹果",Price=30},
            new Fruit(){Name="橘子",Price=40},
            new Fruit(){Name="鸭梨",Price=33},
            new Fruit(){Name="水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃水蜜桃"
                ,Price=31}};
            dgv_Message.Columns[0].Width = 200;//设置列宽度
            dgv_Message.Columns[1].Width = 170;//设置列宽度
            dgv_Message.Columns[0].DefaultCellStyle.Alignment =//设置对齐方式
                DataGridViewContentAlignment.MiddleCenter;
            dgv_Message.DefaultCellStyle.WrapMode = //换行显示过长文本内容
                DataGridViewTriState.True;
            dgv_Message.Rows[3].Height = 30;//设置行高度
        }
    }
}
