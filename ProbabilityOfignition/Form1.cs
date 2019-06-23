using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityOfignition
{
    public partial class Form1 : Form
    {
        private Chemical currentChemical = null;
        private LevelBase currentlevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
         
            LoadChemical();
            LoadLevel();
            BindCmb_Chemical();
        }
        private void LoadChemical()
        {

            currentChemical = ChemicalHelper.Instance.GetByName(cmb_Chemical.Text);
            txt_MIE.Text = currentChemical.MIE.ToString();
            txt_AIT.Text = currentChemical.AIT.ToString();
            txt_Temperature.Text =  currentChemical.Temperature.ToString();
            txt_Pressure.Text = currentChemical.Pressure.ToString();
        }

        private void LoadLevel()
        {
            if (tab_Level.SelectedIndex==0)
            {
                lbl_Pressure.Hide();
                txt_Pressure.Hide();
                currentlevel = new LevelOne(currentChemical);
            }
            else
            {
                lbl_Pressure.Show();
                txt_Pressure.Show();      
                currentlevel = new LevelTwo(currentChemical);
            }
           
            txt_POSI.Text = currentlevel.POSI.ToString();
            txt_PONI.Text = currentlevel.PONI.ToString();
            txt_POII.Text = currentlevel.POII.ToString();
            txt_PODIIndoor.Text = currentlevel.PODIIndoor.ToString();
            txt_PODIOutdoor.Text = currentlevel.PODIOutdoor.ToString();
        }
        private void txt_MIE_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txt_MIE.Text,out d))
            {
                currentChemical.MIE = d;
            }
            else
            {
                MessageBox.Show("请输入数字！");
                txt_MIE.Text = currentChemical.MIE.ToString();
            }
            LoadLevel();
        }

        private void txt_AIT_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txt_AIT.Text, out d))
            {
                currentChemical.AIT = d;
            }
            else
            {
                MessageBox.Show("请输入数字！");
                txt_AIT.Text = currentChemical.AIT.ToString();
            }
            LoadLevel();
        }

        private void cmb_Chemical_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChemical();
        }

        private void txt_Temperature_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txt_Temperature.Text, out d))
            {
                currentChemical.Temperature = d;
            }
            else
            {
                MessageBox.Show("请输入数字！");
                txt_Temperature.Text =  currentChemical.Temperature.ToString();
            }
            LoadLevel();
        }

        private void tab_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLevel();
        }

        private void txt_Pressure_TextChanged(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txt_Pressure.Text, out d))
            {
                currentChemical.Pressure = d;
            }
            else
            {
                MessageBox.Show("请输入数字！");
                txt_Pressure.Text = currentChemical.Pressure.ToString();
            }
            LoadLevel();
        }

        private void BindCmb_Chemical()
        {
            var dtList = Excelhelper.GetDtList(@"..\..\Data\材料.xls");
            if (dtList.Any())
            {
                var dtData = dtList.FirstOrDefault(dt => dt.TableName == "ChemicalData");
                if (dtData!=null)
                {
                    var list = new List<string>(dtData.Rows.Count);
                    foreach (DataRow row in dtData.Rows)
                    {
                        var engName = row["Chemical"]?.ToString();
                        var chinese = row["中文"]?.ToString();
                        if (!string.IsNullOrEmpty(engName)&&!string.IsNullOrEmpty(chinese))
                        {
                            var fullname = engName;
                            if (engName!=chinese)
                            {
                                fullname = $"({chinese}){engName}";
                            }
                                                    
                            list.Add(fullname);
                        }
                    }
                    cmb_Chemical.DataSource = list;
                }
            }
          
           
        }
    }
}
