using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_ZalohovaciNastroj.View.Backup
{
    public partial class BackupLegendFilterResult : Form
    {
        public BackupLegendFilterResult()
        {
            InitializeComponent();
            pb_red.Image = tvwIml.Images[0];
            pb_yellow.Image = tvwIml.Images[1];
            pb_green.Image = tvwIml.Images[2];
            pb_gray.Image = tvwIml.Images[3];
            pb_error.Image = tvwIml.Images[4];
            pb_RedFile.Image = dotList.Images[0];
            pb_GreenFile.Image = dotList.Images[1];
        }
    }
}
