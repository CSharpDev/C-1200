using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FileComminuteUnite
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        #region �ϲ��ļ�
        /// <summary>
        /// �ϲ��ļ�
        /// </summary>
        /// <param name="list">Ҫ�ϲ����ļ�����</param>
        /// <param name="strPath">�ϲ�����ļ�����</param>
        /// <param name="PBar">��������ʾ</param>
        public void CombinFile(string[] strFile, string strPath, ProgressBar PBar)
        {
            PBar.Maximum = strFile.Length;
            FileStream AddStream = null;
            //�Ժϲ�����ļ����ƺʹ򿪷�ʽ����������ʼ��FileStream�ļ���
            AddStream = new FileStream(strPath, FileMode.Append);
            //��FileStream�ļ�������ʼ��BinaryWriter��д���������Ժϲ��ָ���ļ�
            BinaryWriter AddWriter = new BinaryWriter(AddStream);
            FileStream TempStream = null;
            BinaryReader TempReader = null;
            //ѭ���ϲ�С�ļ��������ɺϲ��ļ�
            for (int i = 0; i < strFile.Length; i++)
            {
                //��С�ļ�����Ӧ���ļ����ƺʹ�ģʽ����ʼ��FileStream�ļ��������ȡ�ָ�����
                TempStream = new FileStream(strFile[i].ToString(), FileMode.Open);
                TempReader = new BinaryReader(TempStream);
                //��ȡ�ָ��ļ��е����ݣ������ɺϲ����ļ�
                AddWriter.Write(TempReader.ReadBytes((int)TempStream.Length));
                //�ر�BinaryReader�ļ��Ķ���
                TempReader.Close();
                //�ر�FileStream�ļ���
                TempStream.Close();
                PBar.Value = i + 1;
            }
            //�ر�BinaryWriter�ļ���д��
            AddWriter.Close();
            //�ر�FileStream�ļ���
            AddStream.Close();
            MessageBox.Show("�ļ��ϲ��ɹ���");
        }
        #endregion

        private void frmSplit_Load(object sender, EventArgs e)
        {
            timer1.Start();//������ʱ��
        }

        //ѡ��Ҫ�ϳɵ��ļ�
        private void btnCFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Selectfile = "";
                string[] files = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Selectfile += "," + files[i].ToString();
                }
                if (Selectfile.StartsWith(","))
                {
                    Selectfile = Selectfile.Substring(1);
                }
                if (Selectfile.EndsWith(","))
                {
                    Selectfile.Remove(Selectfile.LastIndexOf(","),1);
                }
                txtCFile.Text = Selectfile;
            }
        }

        //ѡ��ϳɺ���ļ����·��
        private void btnCPath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtCPath.Text = saveFileDialog.FileName;
            }
        }

        //ִ�кϳ��ļ�����
        private void btnCombin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCFile.Text.Trim() == "" || txtCPath.Text.Trim() == "")
                {
                    MessageBox.Show("�뽫��Ϣ����������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtCFile.Text.IndexOf(",") == -1)
                        MessageBox.Show("��ѡ��Ҫ�ϳɵ��ļ�������Ϊ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string[] strFiles = txtCFile.Text.Split(',');
                        CombinFile(strFiles, txtCPath.Text, progressBar);
                    }
                }
            }
            catch { }
        }

        //���ӡ��ϲ�����ť�Ŀ���״̬
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtCFile.Text != "" && txtCPath.Text != "")
                btnCombin.Enabled = true;
            else
                btnCombin.Enabled = false;
        }
    }
}