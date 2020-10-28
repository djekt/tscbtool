using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Dicom.IO;

namespace TSCBTool
{
    public partial class Form1 : Form
    {
        tscbheader h = new tscbheader("",0,0,0,0,0,0,0,0,0,0,0);
        List<tscbentry> m = new List<tscbentry>();
        List<tscbentry> t = new List<tscbentry>();
        string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                filename = openFileDialog1.FileName;
                int i = 0;
                tscbreader r = new tscbreader(openFileDialog1.FileName);
                headerTree.Nodes.Clear();
                materialTree.Nodes.Clear();
                tileTree.Nodes.Clear();

                h = r.Header;
                m = r.Materials;
                t = r.Terrain;

                headerTree.BeginUpdate();
                headerTree.Nodes.Add(h.Magic);
                headerTree.Nodes.Add(h.Version.ToString());
                headerTree.Nodes.Add(h.Unknown1.ToString());
                headerTree.Nodes.Add(h.FileTable.ToString());
                headerTree.Nodes.Add(h.WorldScale.ToString());
                headerTree.Nodes.Add(h.Vscale.ToString());
                headerTree.Nodes.Add(h.MaterialCount.ToString());
                headerTree.Nodes.Add(h.TerrainCount.ToString());
                headerTree.Nodes.Add(h.Padding1.ToString());
                headerTree.Nodes.Add(h.Padding2.ToString());
                headerTree.Nodes.Add(h.TileScale.ToString());
                headerTree.Nodes.Add(h.Unknown2.ToString());
                headerTree.EndUpdate();

                materialTree.BeginUpdate();
                proBar.Maximum = (int)h.MaterialCount;
                while (i < h.MaterialCount)
                {
                    materialTree.Nodes.Add(i.ToString());
                    materialTree.Nodes[i].Nodes.Add(m[i].Index.ToString());
                    materialTree.Nodes[i].Nodes.Add(m[i].U.ToString());
                    materialTree.Nodes[i].Nodes.Add(m[i].V.ToString());
                    materialTree.Nodes[i].Nodes.Add(m[i].Un1.ToString());
                    materialTree.Nodes[i].Nodes.Add(m[i].Un2.ToString());
                    i += 1;
                    proBar.PerformStep();
                }
                materialTree.EndUpdate();
                proBar.Value = 0;

                tileTree.BeginUpdate();
                i = 0;
                proBar.Maximum = (int)h.TerrainCount;
                while (i < h.TerrainCount)
                {
                    tileTree.Nodes.Add(i.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].X.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Y.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Area_Size.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Mint.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Maxt.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Minw.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Maxw.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Uni1.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].File);
                    tileTree.Nodes[i].Nodes.Add(t[i].Uni2.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Uni3.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Water.ToString());
                    tileTree.Nodes[i].Nodes.Add(t[i].Grass.ToString());
                    i += 1;
                    proBar.PerformStep();
                }
                tileTree.EndUpdate();
                proBar.Value = 0;
                saveToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem1.Enabled = true;
            }
        }

        private void tileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tileTree.SelectedNode.Level == 0)
            {
                xBox.Text = tileTree.SelectedNode.Nodes[0].Text;
                yBox.Text = tileTree.SelectedNode.Nodes[1].Text;
                areaBox.Text = tileTree.SelectedNode.Nodes[2].Text;
                terrminBox.Text = tileTree.SelectedNode.Nodes[3].Text;
                terrmaxBox.Text = tileTree.SelectedNode.Nodes[4].Text;
                watminBox.Text = tileTree.SelectedNode.Nodes[5].Text;
                watmaxBox.Text = tileTree.SelectedNode.Nodes[6].Text;
                fnameBox.Text = tileTree.SelectedNode.Nodes[8].Text;

                if (tileTree.SelectedNode.Nodes[11].Text == "True" && tileTree.SelectedNode.Nodes[12].Text == "True")
                {
                    bothRad.Checked = true;
                }
                else if (tileTree.SelectedNode.Nodes[11].Text == "True" && tileTree.SelectedNode.Nodes[12].Text == "False")
                {
                    waterRad.Checked = true;
                }
                else if (tileTree.SelectedNode.Nodes[11].Text == "False" && tileTree.SelectedNode.Nodes[12].Text == "True")
                {
                    grassRad.Checked = true;
                }
                else
                {
                    noneRad.Checked = true;
                }
            }
            else
            {
                TreeNode n = tileTree.SelectedNode;
                while (n.Parent != null)
                {
                    n = n.Parent;
                }
                tileTree.SelectedNode = n;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                tscbwriter write = new tscbwriter(saveFileDialog1.FileName, h, m, t);
            }
        }

        private void kill_LOD_Click(object sender, EventArgs e)
        {
            t.RemoveAll(r => r.File[1] == LODcomboBox.Text[0]);
            int i = 0;
            int c = tileTree.Nodes.Count;
            tileTree.BeginUpdate();
            while (i < c)
            {
                proBar.Maximum = c;
                if (tileTree.Nodes[i].Nodes[8].Text[1] == LODcomboBox.Text[0])
                {
                    tileTree.Nodes[i].Remove();
                    i -= 1;
                    c = tileTree.Nodes.Count;
                }
                else
                {
                    i += 1;
                    proBar.PerformStep();
                }
            }
            tileTree.EndUpdate();
            proBar.Value = 0;
            h.TerrainCount = (uint)t.Count;
            headerTree.Nodes[7].Text = t.Count.ToString();
        }

        private void normaliseBtn_Click(object sender, EventArgs e)
        {
            int c = 0;
            proBar.Maximum = tileTree.Nodes.Count;
            while (c < tileTree.Nodes.Count)
            {
                tileTree.Nodes[c].Nodes[3].Text = "0";
                tileTree.Nodes[c].Nodes[4].Text = "1";
                tileTree.Nodes[c].Nodes[5].Text = "0";
                tileTree.Nodes[c].Nodes[6].Text = "1";
                t[c].Mint = 0;
                t[c].Maxt = 1;
                t[c].Minw = 0;
                t[c].Maxw = 1;
                c += 1;
                proBar.PerformStep();
            }
            proBar.Value = 0;
        }

        private void headerTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (headerTree.SelectedNode.Index)
            {
                case 5:
                    vscaleBox.Text = headerTree.SelectedNode.Text;
                    break;
                case 4:
                    hscaleBox.Text = headerTree.SelectedNode.Text;
                    break;
            }
        }

        private void vscaleUpdate_Click(object sender, EventArgs e)
        {
            if (vscaleBox.Text != "")
            {
                headerTree.Nodes[5].Text = vscaleBox.Text;
                h.Vscale = Convert.ToSingle(vscaleBox.Text);
            }
        }

        private void hscaleUpdate_Click(object sender, EventArgs e)
        {
            if (hscaleBox.Text != "")
            {
                headerTree.Nodes[4].Text = hscaleBox.Text;
                h.WorldScale = Convert.ToSingle(hscaleBox.Text);
            }
        }

        private void extraInfoUpdate(int i)
        {
            if (bothRad.Checked == true)
            {
                tileTree.Nodes[i].Nodes[11].Text = "True";
                tileTree.Nodes[i].Nodes[12].Text = "True";
                t[i].Water = true;
                t[i].Grass = true;
            }
            else if (waterRad.Checked == true)
            {
                tileTree.Nodes[i].Nodes[11].Text = "True";
                tileTree.Nodes[i].Nodes[12].Text = "False";
                t[i].Water = true;
                t[i].Grass = false;
            }
            else if (grassRad.Checked == true)
            {
                tileTree.Nodes[i].Nodes[11].Text = "False";
                tileTree.Nodes[i].Nodes[12].Text = "True";
                t[i].Water = false;
                t[i].Grass = true;
            }
            else if (noneRad.Checked == true)
            {
                tileTree.Nodes[i].Nodes[11].Text = "False";
                tileTree.Nodes[i].Nodes[12].Text = "False";
                t[i].Water = false;
                t[i].Grass = false;
            }
        }

        private void updtileBtn_Click(object sender, EventArgs e)
        {
            tileTree.BeginUpdate();
            tileTree.SelectedNode.Nodes[0].Text = xBox.Text;
            t[tileTree.SelectedNode.Index].X = Convert.ToSingle(xBox.Text);
            tileTree.SelectedNode.Nodes[1].Text = yBox.Text;
            t[tileTree.SelectedNode.Index].Y = Convert.ToSingle(yBox.Text);
            tileTree.SelectedNode.Nodes[2].Text = areaBox.Text;
            t[tileTree.SelectedNode.Index].Area_Size = Convert.ToSingle(areaBox.Text);
            tileTree.SelectedNode.Nodes[3].Text = terrminBox.Text;
            t[tileTree.SelectedNode.Index].Mint = Convert.ToSingle(terrminBox.Text);
            tileTree.SelectedNode.Nodes[4].Text = terrmaxBox.Text;
            t[tileTree.SelectedNode.Index].Maxt = Convert.ToSingle(terrmaxBox.Text);
            tileTree.SelectedNode.Nodes[5].Text = watminBox.Text;
            t[tileTree.SelectedNode.Index].Minw = Convert.ToSingle(watminBox.Text);
            tileTree.SelectedNode.Nodes[6].Text = watmaxBox.Text;
            t[tileTree.SelectedNode.Index].Maxw = Convert.ToSingle(watmaxBox.Text);
            tileTree.SelectedNode.Nodes[8].Nodes[0].Text = fnameBox.Text;
            t[tileTree.SelectedNode.Index].File = fnameBox.Text;
            extraInfoUpdate(tileTree.SelectedNode.Index);
            tileTree.EndUpdate();
        }

        private void setAllBtn_Click(object sender, EventArgs e)
        {
            tileTree.BeginUpdate();
            proBar.Maximum = tileTree.Nodes.Count;
            proBar.Value = 0;
            int u = 0;
            while (u < tileTree.Nodes.Count)
            {
                extraInfoUpdate(u);
                proBar.PerformStep();
                u += 1;
            }
            proBar.Value = 0;
            tileTree.EndUpdate();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tscbwriter write = new tscbwriter(filename, h, m, t);
        }
    }
}
