﻿using ModelDesigner.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelDesigner
{
    /// <summary>主界面</summary>
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>打开文件</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fName = openFileDialog.FileName;
            }
        }

    }
}
