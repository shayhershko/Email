using CommunityToolkit.Mvvm.Input;
using Email.Model;
using MahApps.Metro.Controls;
using MaterialDesignColors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Email.ViewModel
{
    class EmailViewModel : INotifyPropertyChanged
    {
        #region Variables
        private bool isAscending = true;
        private Visibility progressBarVisible;
        private bool isOverlayVisible;
        private string searchText;
        private DateTime selectedDateReceived;
        private Mail selectedMail;
        private ObservableCollection<Mail> emails;
        private ObservableCollection<Mail> filteredMails;
        private BitmapImage sendetImage;
        private int progress =0;
        private Uri imageUri;
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Properties
        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Progress 
        {
            get { return progress; }
            set 
            {
                progress= value;
                OnPropertyChanged(nameof(Progress));
            }
        }

        public DateTime SelectedDateReceived
        {
            get { return selectedDateReceived; }
            set
            {
                selectedDateReceived = value;
                OnPropertyChanged(nameof(SelectedDateReceived));
            }
        }

        public BitmapImage SendetImage
        {
            get { return sendetImage; } 
            set 
            {
                sendetImage = value;
                OnPropertyChanged(nameof(SendetImage));
            }
        }

        public bool IsAscending
        {
            get
            {
                return isAscending;
            }
            set
            {
                isAscending = value;
                OnPropertyChanged(nameof(IsAscending));
            }
        }

        public Visibility ProgressBarVisible
        {
            get { return progressBarVisible; }
            set
            {
                progressBarVisible = value;
                OnPropertyChanged(nameof(ProgressBarVisible));
            }
        }

        public bool IsOverlayVisible
        {
            get { return isOverlayVisible; }
            set
            {
                isOverlayVisible = value;
                OnPropertyChanged(nameof(IsOverlayVisible));
            }
        }

        public Mail SelectedMail
        {
            get { return selectedMail; }
            set
            {
                selectedMail = value;
                if (value!= null)
                {
                    imageUri = new Uri(selectedMail.SenderImagePath);
                    SendetImage = new BitmapImage(imageUri);
                }
                OnPropertyChanged(nameof(SelectedMail));

            }
        }

        public ObservableCollection<Mail> Emails
        {
            get
            {
                return emails;
            }
            set
            {
                emails = value;
            }
        }

        public ObservableCollection<Mail> FilteredMails
        {
            get { return filteredMails; }
            set
            {
                filteredMails = value;
                OnPropertyChanged();
            }
        }
        private void ToggleAscending()
        {
            IsAscending = !IsAscending;
            if(isAscending)
            {
                FilteredMails = new ObservableCollection<Mail>(FilteredMails.OrderBy(mail => mail.SenderName));
            }
            else 
            {
                FilteredMails = new ObservableCollection<Mail>(FilteredMails.OrderByDescending(mail => mail.SenderName));
            }
        }


        public RelayCommand ToggleImageCommand { get; }

        #endregion

        #region Functions
        public EmailViewModel()
        {
            ToggleImageCommand = new RelayCommand(() => { ToggleAscending(); });
            Emails = new ObservableCollection<Mail>(EmailModel.GetEmails());
            FilteredMails = Emails;
            StartProgressBar();
        }

        // prograss bar logic
        private  async void StartProgressBar()
        {
            IsOverlayVisible = false;
            ProgressBarVisible = Visibility.Visible;


            for (int i = 0; i <= 100; i += 1)
            {
                Progress = i;
                await Task.Delay(50);
            }

            ProgressBarVisible = Visibility.Hidden;
            IsOverlayVisible = true;
        }

        // Show only the mails that have the searched text in the sender name
        private void Search()
        {
            if (SearchText != null)
                FilteredMails = new ObservableCollection<Mail>(
                    Emails.Where(mail => mail.SenderName.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0)
                );
        }

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region Commands

        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new RelayCommand(() => { Search(); }); ;
                }
                return searchCommand;
            }
        }


        #endregion


    }
}
