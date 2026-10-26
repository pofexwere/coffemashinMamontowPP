using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class Potstavka : UserControl
	{
		public Potstavka()
		{
			InitializeComponent();
			Place.Click += (s, e) => this.OnClick(e);
		}
		public bool hat = false;
		public bool InPlace = false;
		public bool IsFull = false;
		public int pos=0;
		public async void addsirp()
		{
			if (hat)
			{
				Place.Text = "💧";
				await Task.Delay(500);

				Place.Text = "🥤";
			}
			else
			{
				Place.Text = "💧";
				await Task.Delay(500);

				Place.Text = "\U0001f95b";
			}
		}
		public void addhat()
		{
			if (InPlace && IsFull && !hat) { 
				hat = true;
				Place.Text = "🥤";
			}
		}
		public void remove()
		{
			Place.Text = "";
		}
		public void addStakan()
		{
			Place.Text = "🥛";
		}

	}
}
