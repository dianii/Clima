using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Clima.ViewModel
{
    public class WeatherViewModelPage : NotificableViewModel
    {
        #region Atributos
        private string ubicación;
        private string pais;
        private string resultTerm;
        private string region;
        private string ultimaActualizacion;
        private string clima;
        private string temperatura;
        private ImageSource imagen;


        public string Ubicacion
        {
            get { return ubicación; }
            set { SetValue(ref ubicación, value); }

        }

        public string Pais
        {
            get { return pais; }
            set { SetValue(ref pais, value); }

        }
        public string ResultTerm
        {
            get { return resultTerm; }
            set { SetValue(ref resultTerm, value); }

        }
        public string Region
        {
            get { return region; }
            set { SetValue(ref region, value); }

        }
        public string UltimaActualizacion
        {
            get { return ultimaActualizacion; }
            set { SetValue(ref ultimaActualizacion, value); }

        }
        public string Clima
        {
            get { return clima; }
            set { SetValue(ref clima, value); }

        }
        public string Temperatura
        {
            get { return temperatura; }
            set { SetValue(ref temperatura, value); }

        }
        public  ImageSource Imagen
        {
            get { return imagen; }
            set { SetValue(ref imagen, value); }

        }
        #endregion
        #region Comandos
        public ICommand BuscarCommand {
        get {
                return new RelayCommand(Buscar);
            }
        }
        #endregion
        #region Metodos
        private void Buscar()
        {
            throw new NotImplementedException();
        }
        #endregion

    }


}


