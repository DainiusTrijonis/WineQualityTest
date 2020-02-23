using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Vynas
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public Boolean checking = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knnDataSet.redwine' table. You can move, or remove it, as needed.
            this.redwineTableAdapter.Fill(this.knnDataSet.redwine);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            int k = Convert.ToInt32(kTextBox.Text);
            DataRow lastRow = knnDataSet.redwine.Rows[knnDataSet.redwine.Rows.Count - 1];
            int lastId = Convert.ToInt32(lastRow[0]) + 1;

            Wine wine = new Wine(lastId, Double.Parse(fixedAcidityTextBox.Text, CultureInfo.InvariantCulture), Double.Parse(volatileAcidityTextBox.Text, CultureInfo.InvariantCulture),
                                 Double.Parse(citricAcidTextBox.Text, CultureInfo.InvariantCulture), Double.Parse(residualSugarTextBox.Text, CultureInfo.InvariantCulture),
                                 Double.Parse(chloridesTextBox.Text, CultureInfo.InvariantCulture), Double.Parse(freeSulfurDioxideTextBox.Text, CultureInfo.InvariantCulture),
                                 Double.Parse(totalSulfurDioxideTextBox.Text, CultureInfo.InvariantCulture), Double.Parse(densityTextBox.Text, CultureInfo.InvariantCulture),
                                 Double.Parse(pHTextBox.Text, CultureInfo.InvariantCulture), Double.Parse(sulphatesTextBox.Text, CultureInfo.InvariantCulture),
                                 Double.Parse(alcoholTextBox.Text, CultureInfo.InvariantCulture), -1
                                 );

            List<Distance> calculatedDistanceList = new List<Distance>();
            
            if(firstFormulaRadioButton.Checked)
            {
                foreach (DataRow row in knnDataSet.redwine.Rows)
                {
                    Wine wine1 = new Wine(Convert.ToInt32(row[0]), Convert.ToDouble(row[1]), Convert.ToDouble(row[2]), Convert.ToDouble(row[3]),
                                          Convert.ToDouble(row[4]), Convert.ToDouble(row[5]), Convert.ToDouble(row[6]),
                                          Convert.ToDouble(row[7]), Convert.ToDouble(row[8]), Convert.ToDouble(row[9]),
                                          Convert.ToDouble(row[10]), Convert.ToDouble(row[11]), Convert.ToInt32(row[12])
                                          );

                    calculatedDistanceList.Add(new Distance(wine1.id, wine.calculateDistance2(wine1)));


                }
            }
            if(secondFormulaRadioButton.Checked)
            {
                foreach (DataRow row in knnDataSet.redwine.Rows)
                {
                    Wine wine1 = new Wine(Convert.ToInt32(row[0]), Convert.ToDouble(row[1]), Convert.ToDouble(row[2]), Convert.ToDouble(row[3]),
                                          Convert.ToDouble(row[4]), Convert.ToDouble(row[5]), Convert.ToDouble(row[6]),
                                          Convert.ToDouble(row[7]), Convert.ToDouble(row[8]), Convert.ToDouble(row[9]),
                                          Convert.ToDouble(row[10]), Convert.ToDouble(row[11]), Convert.ToInt32(row[12])
                                          );

                    calculatedDistanceList.Add(new Distance(wine1.id, wine.calculateDistance(wine1)));


                }
            }


            calculatedDistanceList = calculatedDistanceList.OrderBy(Distance => Distance.distance).ToList();

            List<QualityCount> qualityCountList = new List<QualityCount>();

            for(int i=0; i<=10; i++)
            {
                qualityCountList.Add(new QualityCount(i));
            }

            
            for(int i=0; i<k; i++)
            {
                //id of lowest distance
                int id = calculatedDistanceList[i].id;
                foreach(DataRow row in knnDataSet.redwine.Rows)
                {
                    if(Convert.ToInt32(row[0]) == id)
                    {
                        qualityCountList[Convert.ToInt32(row[12])].addCounter();
                    }
                }
            }


            //sort and get quality
            qualityCountList = qualityCountList.OrderByDescending(QualityCount => QualityCount.counter).ToList();
            int quality = qualityCountList[0].quality;  

            MessageBox.Show("QUALITY : " + quality);
            if (MessageBox.Show("Add to database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                wine.quality = quality;

                redwineTableAdapter.Insert(wine.id, wine.fixedAcidity, wine.volatileAcidity, wine.citricAcidity, wine.residualSugar, wine.chlorides, wine.freeSulfurDioxide, wine.totalSulfurDioxide, wine.density, wine.pH, wine.sulphates, wine.alcohol, quality);
                this.redwineTableAdapter.Fill(this.knnDataSet.redwine);

            }
            else
            {

            }
        }

        private void firstFormulaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(!checking)
            {
                checking = true;

                if( secondFormulaRadioButton.Checked)
                {
                    secondFormulaRadioButton.Checked = false;
                }
                firstFormulaRadioButton.Checked = true;
            }
            checking = false;
        }

        private void secondFormulaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!checking)
            {
                checking = true;

                if (firstFormulaRadioButton.Checked)
                {
                    firstFormulaRadioButton.Checked = false;
                }
                secondFormulaRadioButton.Checked = true;
            }
            checking = false;
        }
    }
}
