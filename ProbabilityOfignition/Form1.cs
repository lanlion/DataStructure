using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public partial class Form1 : Form
    {
        private Chemical currentChemical = null;
        private LevelBase currentlevel;
        private Dictionary<string, DataRow> dic_Chemical;
        private string filepath;
        List<Control> level2Controls;
        public Form1()
        {
            InitializeComponent();
            level2Controls = new List<Control>()
            {
lbl_Pressure,txt_Pressure,lbl_Strength,txt_Strength,lbl_form,radio_Liquid,radio_Vaqor,lbl_AmountReleased,txt_AmountReleased,
lbl_HoleDiameter,txt_HoleDiameter
            };
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            LoadChemical();
            LoadLevel();
         
            var f = $"{Application.StartupPath}/材料.xls";
            if (File.Exists(f))
            {
                filepath = f;
                BindCmb_Chemical();
            }
           // skinEngine1.SkinFile = $"{Application.StartupPath}/MP10.ssk";
        }
        private void LoadChemical()
        {
            currentChemical = ChemicalHelper.Instance.GetByName(cmb_Chemical.Text,dic_Chemical);
            if (radio_Vaqor.Checked)
            {
                currentChemical.PhaseEnum = PhaseEnum.Vaqor;
            }
            txt_MIE.Text = currentChemical.MIE.ToString();
            txt_AIT.Text = currentChemical.AIT.ToString();
            txt_Temperature.Text =  currentChemical.Temperature.ToString();
            txt_Pressure.Text = currentChemical.Pressure.ToString();
        }

        private void LoadLevel()
        {
            if (tab_Level.SelectedIndex==0)
            {               
                currentlevel = new LevelOne(currentChemical);
            }
            else
            {                 
                currentlevel = new LevelTwo(currentChemical);
            }
            ShowHide();
            txt_POSI.Text =Math.Round( currentlevel.POSI,4).ToString();
            txt_PONI.Text = Math.Round(currentlevel.PONI,4).ToString();
            txt_POII.Text = Math.Round(currentlevel.POII,4).ToString();
            txt_PODIIndoor.Text = Math.Round(currentlevel.PODIIndoor,4).ToString();
            txt_PODIOutdoor.Text = Math.Round(currentlevel.PODIOutdoor,4).ToString();
        }
        private void ShowHide()
        {
            foreach (var item in level2Controls)
            {
                if (tab_Level.SelectedIndex == 0)
                {
                    item.Hide();
                }
                else
                {
                    item.Show();
                }
            }          
        }
     
        private void textChanged(object sender, EventArgs e)
        {
            var temptxt = sender as TextBox;
            double d;
            double back=0; 
            if (double.TryParse(temptxt.Text, out d))
            {
                switch (temptxt.Name)
                {
                    case "txt_Pressure":
                        back = currentChemical.Pressure;
                        currentChemical.Pressure = d;                    
                        break;

                    case "txt_Temperature":
                        back = currentChemical.Temperature;
                        currentChemical.Temperature = d;
                        break;

                    case "txt_AIT":
                        back = currentChemical.AIT;
                        currentChemical.AIT = d;
                        break;

                    case "txt_MIE":
                        back = currentChemical.MIE;
                        currentChemical.MIE = d;
                        break;

                   
                    case "txt_Strength":
                        back = currentChemical.Strength;
                        currentChemical.Strength = d;
                        break;

                    case "txt_AmountReleased":
                        back = currentChemical.AmountReleased;
                        currentChemical.AmountReleased = d;
                        currentChemical.HoleDiameter = 0;
                        currentChemical.LeakEnum = LeakEnum.AmountReleased;
                        break;

                    case "txt_HoleDiameter":
                        back = currentChemical.HoleDiameter;
                        currentChemical.HoleDiameter = d;
                        currentChemical.LeakEnum = LeakEnum.HoleDiameter;
                        currentChemical.AmountReleased = 0;
                        break;
                    default:
                        break;
                }
              
            }
            else
            {
                MessageBox.Show("请输入数字！");
                temptxt.Text = back.ToString();
            }
            LoadLevel();

        }
        private void cmb_Chemical_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChemical();
        }
        private void tab_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_POSI.Text = "";
            txt_PONI.Text = "";
            txt_POII.Text = "";
            txt_PODIIndoor.Text="";
            txt_PODIOutdoor.Text = "";
            LoadLevel();
        }
        private void BindCmb_Chemical()
        {
           
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("请先选择材料文件！");
                return;
            }
            btn_file.Hide();
            var dtList = Excelhelper.GetDtList(filepath);
            if (dtList.Any())
            {
                var dtData = dtList.FirstOrDefault(dt => dt.TableName == "ChemicalData");
                if (dtData!=null)
                {
                    dic_Chemical = new Dictionary<string, DataRow>(dtData.Rows.Count);
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
                                fullname = $"{chinese}-{engName}";
                            }
                            dic_Chemical[fullname] = row;
                            list.Add(fullname);
                        }
                    }
                    cmb_Chemical.DataSource = list;
                }
            }
          
           
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                btn_file.Hide();
                BindCmb_Chemical();
            }
        }
        private void radio_Liquid_CheckedChanged(object sender, EventArgs e)
        {
            currentChemical.PhaseEnum = PhaseEnum.Liquid;
            LoadLevel();
        }
        private void radio_Vaqor_CheckedChanged(object sender, EventArgs e)
        {
            currentChemical.PhaseEnum = PhaseEnum.Vaqor;
            LoadLevel();
        }
    }
}
