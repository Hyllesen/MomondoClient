using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace MomondoClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<String> Lines { get; set; }

        public string Line { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            //MomondoService.MomondoWSSoapClient moClient = new MomondoService.MomondoWSSoapClient();

            IEnumerable<string> linesEnum = File.ReadLines(@"C:\Users\mogens\documents\visual studio 2015\Projects\MomondoClient\MomondoClient\airportcodes.txt");

            Lines = new ObservableCollection<string>(linesEnum);

            foreach(string line in Lines)
            {
                Debug.WriteLine(line);
            }

            Debug.WriteLine(Lines.ToString());
        }
    }
}