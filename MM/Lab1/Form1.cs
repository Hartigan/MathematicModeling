using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Lab1
{
	public partial class FormLab1 : Form
	{
		public FormLab1()
		{
			InitializeComponent();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			zedGraphControl1.GraphPane.CurveList.Clear();
			zedGraphControl1.Invalidate();
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			int seed = int.Parse(Seed.Text);
			IRandomMethod method = new MethodMiddleOfSquare(seed);
			if (radioButton1.Checked) method = new MethodMiddleOfSquare(seed);
			if (radioButton2.Checked) method = new MultiplicativeCongruentialMethod(seed, 3453, 5675673);
			int countNumbers = int.Parse(CountNumbers.Text);
			int countNumbers2 = int.Parse(CountNumbers2.Text);
			int numberSections = int.Parse(textBox1.Text);
			ITestingMethod testingMethod = new EasyTesting();
			double M, D;
			double[] values = testingMethod.TestingUniformity(method, numberSections, countNumbers2, out M, out D);
			double C = testingMethod.TestingtestingIndependence(method, countNumbers);
			Correlation.Text = string.Format("Correlation = {0}", C);
			MValue.Text = string.Format("M = {0}", M);
			DValue.Text = string.Format("D = {0}", D);
			ZedGraph.PointPairList table = new PointPairList();
			for(int i=0;i<numberSections;i++)
			{
				table.Add(i,values[i]);
			}
			zedGraphControl1.GraphPane.AddCurve("", table, Color.Blue, SymbolType.Square);
			zedGraphControl1.AxisChange();
			zedGraphControl1.Invalidate();
		}
	}
}
