using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace КофеАвтомат
{
	public partial class coffeAftom : UserControl
	{
		public coffeAftom()
		{
			InitializeComponent();
		}
		private void coffeAftom_Load(object sender, EventArgs e)
		{

		}






		private void Potstavka_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(coffe.info());

			if ((potstavka1.pos == 1) && potstavka1.IsFull)// в кофе машине
			{
				potstavka1.Location = new Point(335, 358);
				potstavka1.InPlace = false;
				potstavka1.IsFull = false;
				potstavka1.pos = 2;
				infoScrean1.Write("Асортимент");
			}
			else if (potstavka1.pos == 2)// "в руках"
			{
				potstavka1.Location = new Point(159, 358);
				potstavka1.remove();
			}
		}


		private void Stakan_Click(object sender, EventArgs e)
		{
			potstavka1.addStakan();
			potstavka1.InPlace = true;
			potstavka1.pos = 1;
			

		}

		private void Trash_Click(object sender, EventArgs e)
		{
			CoffePlace.Text = "";
			potstavka1.remove();
			potstavka1.pos = 0;
			infoScrean1.Write("Асортимент");

			potstavka1.hat = false;
			potstavka1.InPlace = false;
			potstavka1.IsFull = false;
				
			Shokosirop.count = 0;
			Vanilsirop.count = 0;
			Karamsirop.count = 0;
			sugar.count = 0;	

			Kaputino.selected = false;
			Espresso.selected = false;
			Amerikano.selected = false;
			Latte.selected = false;
			Raf.selected = false;
			Mokatino.selected = false;
			Kompot.selected = false;
			Tea.selected = false;
		}
		private async void Sirp_Click(object sender, EventArgs e)
		{
			if (potstavka1.InPlace)
			{

				Sirop sirp = sender as Sirop;
				sirp.count += 1;
				potstavka1.addsirp();
			}

		}




		private void Hats_Click(object sender, EventArgs e)
		{
			potstavka1.addhat();
		}

		private void CoffePlace_Click(object sender, EventArgs e)
		{
			CoffePlace.Text = "";
		}

		private async void AnyCofe_Click(object sender, EventArgs e)
		{
			if (terminal1.payd)
			{
				if (potstavka1.InPlace)
				{
					if (!potstavka1.IsFull)
					{

						CoffeName Scoffe = sender as CoffeName;
						Scoffe.selected = true;
						potstavka1.IsFull = true;
						kran.Play_Animation();
						Scoffe.Selected();
						infoScrean1.Cooking(Scoffe.CoffeeType);
						terminal1.payd = false;
					}
					else
					{
						infoScrean1.Write("Стакан полон");
					}
				}
				else
				{
					infoScrean1.Write("Поставьте стакан");
				}
			}
			else
			{
				infoScrean1.Write("Сначало оплатите");
			}
		}
	}
}

