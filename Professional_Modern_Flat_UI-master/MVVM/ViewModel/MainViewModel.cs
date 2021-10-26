
using Professional_Modern_Flat_UI.Core;

namespace Professional_Modern_Flat_UI.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        #region 필드
        private object _currentView;
        #endregion

        #region Property
        //  RelayCommnad : View에서 일어나는 이벤트 가져오기
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        // 메인 뷰 변경하는 get,set
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region construct
        public MainViewModel()
        {
            // 뷰 생성자 
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            
            // 메인 뷰 HomeVM
            CurrentView = HomeVM;

            // RelayCommadn로 들어온 뷰를 메인뷰로 세팅
            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
        }
        #endregion
    }
}
