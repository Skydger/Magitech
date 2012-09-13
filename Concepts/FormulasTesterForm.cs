using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concepts
{
    public partial class FormulasTesterForm : Form
    {
        public FormulasTesterForm(){
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get a reference to the GraphPane instance in the ZedGraphControl
            ZedGraph.GraphPane pn = this.zgcGraph.GraphPane;
            pn.CurveList.Clear();

            // Set the titles and axis labels
            pn.Title.Text = "Demonstration of Dual Y Graph";
            pn.XAxis.Title.Text = "Level";
            pn.YAxis.Title.Text = "?";
            //pn.Y2Axis.Title.Text = "Parameter B";

            // Make up some data points based on the Sine function
            ZedGraph.PointPairList list = new ZedGraph.PointPairList();
            //ZedGraph.PointPairList list2 = new ZedGraph.PointPairList();
            //ZedGraph.PointPairList list3 = new ZedGraph.PointPairList();
            PersonBasics person = new PersonBasics(Class.Mage, 1);

            double max_value = 0;
            int max_level = (int)this.nudMaxLevel.Value;
            for (int i = 1; i <= max_level; i++){
                max_value = (double)person.MaxExpirience;
                list.Add((double)i, max_value);
                person.Level++;
            }
            ZedGraph.LineItem curve = pn.AddCurve("Experience", list, Color.Red, ZedGraph.SymbolType.Diamond);
            // Fill the symbols with white
            curve.Symbol.Fill = new ZedGraph.Fill(Color.White);
            // Show the x axis grid
            pn.XAxis.MajorGrid.IsVisible = true;

            // Make the Y axis scale red
            //pn.YAxis.Scale.FontSpec.FontColor = Color.Red;
            //pn.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            pn.YAxis.MajorTic.IsOpposite = false;
            pn.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            pn.YAxis.MajorGrid.IsZeroLine = false;
            // Align the Y axis labels so they are flush to the axis
            pn.YAxis.Scale.Align = ZedGraph.AlignP.Inside;
            // Manually set the axis range
            pn.YAxis.Scale.Min = 0;
            pn.YAxis.Scale.Max = (double)max_value;

            pn.XAxis.Scale.Min = 0;
            pn.XAxis.Scale.Max = (double)max_level;

            this.zgcGraph.AxisChange();
            this.zgcGraph.Invalidate();
            return;
        }
    }
}