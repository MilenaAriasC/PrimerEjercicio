﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimerEjercicio
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class view2 : ContentPage
	{
		public view2 ()
		{
			InitializeComponent ();
		}
        void pick_MusicSelectIndexChanged(object serder, System.EventArgs e)
        {
           var elementoSeleccionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Musica", elementoSeleccionado, "Aceptar");

        }

private void btnSimular_Clicked(object sender, EventArgs e)
        {
            var progreso = progressNum.Progress;
            if (progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);
            }
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}