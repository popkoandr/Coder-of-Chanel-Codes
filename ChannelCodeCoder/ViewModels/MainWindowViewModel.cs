using System.Windows.Controls;
using System.Windows.Media;
using ChannelCodesCoder.Models;
using ChannelCodesCoder.ViewModels.VMBase;

namespace ChanelCodeCoder.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Fields

        private string _inputString = "";

        #endregion

        #region Properties

        private bool Check
        {
            get
            {
                bool res = false;
                foreach (var part in InputString.ToCharArray())
                    if (part == '0' || part == '1')
                        res = true;
                    else return false;
                return res ? true : false;
            }
        }

        public string InputCheck
        {
            get
            {
                return Check ? "Корректные данные" : "Некорректные данные";
            }
        }

        public Brush CheckColor
        {
            get
            {
                return Check ? Brushes.Green : Brushes.Red;
            }
        }

        public string InputString
        {
            get
            {
                return _inputString;
            }
            set
            {

                _inputString = value;

                OnPropertyChanged("Check");
                OnPropertyChanged("InputCheck");
                OnPropertyChanged("CheckColor");
                OnPropertyChanged("InputString");
                OnPropertyChanged("ImpulseContext");
                OnPropertyChanged("DuoContext");
                OnPropertyChanged("CvaziContext");
                OnPropertyChanged("ManchesterContext");
                OnPropertyChanged("R1Context");
                OnPropertyChanged("R2Context");
                OnPropertyChanged("R3Context");
            }
        }

        public Grid ImpulseContext
        {
            get
            {
                return Check ? new ImpulseCode(InputString).Interpret() : new Grid();
            }
        }

        public Grid DuoContext
        {
            get
            {
                return Check ? new DuobinaryCode(InputString).Interpret() : new Grid();
            }
        }

        public Grid CvaziContext
        {
            get
            {
                return Check ? new CvaziCode(InputString).Interpret() : new Grid();
            }
        }

        public Grid ManchesterContext
        {
            get
            {
                return Check ? new ManchesterCode(InputString).Interpret() : new Grid();
            }
        }
        public Grid R1Context
        {
            get
            {
                return Check ? new _4B3TCode(InputString).DoR1() : new Grid();
            }
        }

        public Grid R2Context
        {
            get
            {
                return Check ? new _4B3TCode(InputString).DoR2() : new Grid();
            }
        }

        public Grid R3Context
        {
            get
            {
                return Check ? new _4B3TCode(InputString).DoR3() : new Grid();
            }
        }



        #endregion
    }
}
