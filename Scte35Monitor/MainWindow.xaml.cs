using MaterialDesignThemes.Wpf;
using Scte35Monitor.Vo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scte35Monitor
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool _shouldStop = false;

        public MainWindow()
        {
            InitializeComponent();
            MockUp();
        }

        private void MockUp()
        {
            ObservableCollection<Server> serverList = new ObservableCollection<Server>();

            string[] arr = { "홈앤쇼핑_B", "한국직업방송_M", "한국직업방송_B", "패션N_M", "패션N_B", "큐브TV_M", "큐브TV_B", "채널칭_M", "채널칭_B", "인디필름_M", "인디필름_B", "육아방송_M", "육아방송_B", "연합뉴스TV_M", "연합뉴스TV_B", "스크린골프존_M", "스크린골프존_B", "생활체육_M", "생활체육_B", "뽀요TV_M", "뽀요TV_B", "부동산토마토_M", "부동산토마토_B", "복지TV_HD [주]", "복지TV_HD [예]", "법률방송_M", "법률방송_B", "대교 Baby TV_M", "대교 Baby TV_B", "다문화TV_M", "다문화TV_B", "내외경제_M", "내외경제_B", "Trendy_M", "Trendy_B", "tbsTV_HD [주]", "tbsTV_HD [예]", "tbsTV_HD [리턴]", "STN_M", "STN_B", "SPOTV ON 2_HD [주]", "SPOTV ON 2_HD [예]", "SPOTV ON 1_HD [주]", "SPOTV ON 1_HD [예]", "NQQ_M", "NQQ_B", "NS홈쇼핑_M", "NS홈쇼핑_B", "Now 제주채널_M", "Now 제주채널_B", "Mezzo Live HD_M", "Mezzo Live HD_B", "KBSN LIFE_M", "KBSN LIFE_B", "JJC지방자치TV_M", "JJC지방자치TV_B", "HD_JEIEnglishTV_주", "HD_JEIEnglishTV_예", "HD_JEIEnglishTV_리턴", "HD_History_주", "HD_History_예", "HD_핑크하우스_주", "HD_핑크하우스_예", "HD_플레이런TV_주", "HD_플레이런TV_예", "HD_키즈톡톡+_주", "HD_키즈톡톡+_예", "HD_코미디TV_주", "HD_코미디TV_예", "HD_카톨릭평화방송_주", "HD_카톨릭평화방송_예", "HD_채널뷰_주", "HD_채널뷰_예", "HD_채널W_주", "HD_채널W_예", "HD_차이나_주", "HD_차이나_예", "HD_에듀TV_주", "HD_에듀TV_예", "HD_신기한나라TV_주", "HD_신기한나라TV_예", "HD_시네프 _주", "HD_시네프 _예", "HD_스크린_주", "HD_스크린_예", "HD_소상공인방송_주", "HD_소상공인방송_예", "HD_소비자TV_주", "HD_소비자TV_예", "HD_상생방송_주", "HD_상생방송_예", "HD_부메랑_주", "HD_부메랑_예", "HD_리얼TV_주", "HD_리얼TV_예", "HD_디자이어TV_주", "HD_디자이어TV_예", "HD_드라맥스_주", "HD_드라맥스_예", "HD_드라마큐브_주", "HD_드라마큐브_예", "HD_드라마H_주", "HD_드라마H_예", "HD_다큐원_주", "HD_다큐원_예", "HD_국방TV_주", "HD_국방TV_예", "HD_가요TV_주", "HD_가요TV_예", "HD_W 쇼핑_주", "HD_W 쇼핑_예", "HD_Skypetpark_주", "HD_Skypetpark_예", "HD_SK 스토아_주", "HD_SK 스토아_예", "HD_OUN(방송대학)_주", "HD_OUN(방송대학)_예", "HD_Olive_주", "HD_Olive_예", "HD_OBS_주", "HD_OBS_예", "NS홈쇼핑+_주", "NS홈쇼핑+_예", "HD_NBS_주", "HD_NBS_예", "HD_MBCNET_주", "HD_MBCNET_예", "HD_KTV_주", "HD_KTV_예", "HD_K 쇼핑_주", "HD_K 쇼핑_예", "HD_JTBC4_주", "HD_JTBC4_예", "HD_FUNTV_주", "HD_FUNTV_예", "HD_EBSEnglish_주", "HD_EBSEnglish_예", "HD_EBS+2_주", "HD_EBS+2_예", "HD_EBS+1_주", "HD_EBS+1_예", "HD_CMC가족오락TV_주", "HD_CMC가족오락TV_예", "HD_TV조선2_주", "HD_TV조선2_예", "HD_BBS_주", "HD_BBS_예", "HD_HoneyTV_주", "HD_HoneyTV_예", "HD Anibox _주", "HD Anibox _예", "GS Shop_M", "GS Shop_B", "GS My Shop_M", "GS My Shop_B", "GOODTV_M", "GOODTV_B", "FX_M", "FX_B", "English Gem_M", "English Gem_B", "CookTV_M", "CookTV_B", "CNN US_M", "CNN US_B", "Cartoon_HD [주]", "Cartoon_HD [예]", "Baduk_HD [주]", "Baduk_HD [예]", "eDaily_M", "eDaily_B", "OtvN_M", "OtvN_B", "애니맥스_M", "애니맥스_B", "XtvN_M", "XtvN_B", "HD_DIA_예", "HD_OCN_예", "HD_투니버스_예", "HD_캐치온플러스_예", "HD_온게임넷_예", "HD_캐치온_예", "HD_OCN Thrills_예", "HD_온스타일_예", "HD_OCN Movie_예", "HD_중화TV_예", "HD_DIA_주", "HD_OCN_주", "HD_투니버스_주", "HD_캐치온플러스_주", "HD_온게임넷_주", "HD_캐치온_주", "HD_OCN Thrills_주", "HD_온스타일_주", "HD_OCN Movie_주", "HD_중화TV_주", "HD_tvN_예", "HD_Mnet_예", "HD_tvN_주", "HD_Mnet_주", "HD_The golf_예", "HD_FTV_예", "HD_IB Sports_예", "HD_라이프타임_예", "HD_Playboy_예", "HD_대교어린이_예", "HD_헬스메디_예", "한국시니어TV_주", "한국시니어TV_예", "채널i_주", "채널i_예", "SBS F!L_주", "SBS F!L_예", "HD_The golf_주", "HD_FTV_주", "HD_IB Sports_주", "HD_라이프타임_주", "HD_Playboy_주", "HD_대교어린이_주", "HD_헬스메디_주", "월드 클래식 무비_주", "월드 클래식 무비_예", "국악방송_주", "국악방송_예", "씨네플러스_주", "씨네플러스_예", "AsiaM_주", "AsiaM_예", "채널이엠_주", "채널이엠_예", "HQ+_주", "HQ+_예", "실버아이TV_주", "실버아이TV_예", "SBS-AfreecaTV_주", "SBS-AfreecaTV_예", "아이넷라이프_주", "아이넷라이프_예", "재능TV_예", "재능TV_주", "SK_KBS2_권역분리_대전", "SK_KBS2_권역분리_광주", "SK_KBS2_권역분리_대구", "SK_KBS2_권역분리_부산", "KT_KBS2_권역분리_대전", "KT_KBS2_권역분리_광주", "KT_KBS2_권역분리_대구", "KT_KBS2_권역분리_부산", "LGU_KBS2_권역분리_대전", "LGU_KBS2_권역분리_광주", "LGU_KBS2_권역분리_대구", "LGU_KBS2_권역분리_부산", "K 바둑_주", "K 바둑_예", "신세계쇼핑_예", "MTN_주", "MTN_예", "신세계쇼핑_주", "더 라이프_M", "더 라이프_B", "아시아N_주", "아시아N_예", "MBC Every1_B", "MBC Dramanet_B", "TV조선_B", "MBC Every1_M", "MBC Dramanet_M", "TV조선_M", "KBS Joy_M", "KBS Joy_B", "KBS Drama_M", "KBS Drama_B", "SBS Plus_M", "SBS Plus_B", "SBS Fune_M", "SBS Fune_B", "YTN_M", "YTN_B", "JTBC_B", "JTBC2_M", "JTBC2_B", "MBN_M", "MBN_B", "JTBC_M", "클레시카_M", "클레시카_B", "CJ오쇼핑+_B", "SPOTV_M", "SPOTV_B", "SPOTV2_M", "SPOTV2_B", "채널A_M", "채널A_B", "CJ오쇼핑+_M", "SPOTV Golf&Health_M", "SPOTV Golf&Health_B", "STA TV_M", "STA TV_B", "디스커버리_M", "디스커버리_B", "지상파_KBS2_권역분리_예", "롯데홈쇼핑_DR", "롯데 One_DR", "더드라마_B", "더드라마_M", "UMAX_주", "UMAX_예", "드림TV_주", "드림TV_예", "비너스_주", "비너스_예", "DR", "DR", "DR", "SBS MTV_B", "SBS Golf_B", "SBS Sports_B", "SBS Nick_B", "SBS Biz_B", "SBS MTV_M", "SBS Golf_M", "SBS Sports_M", "SBS Nick_M", "SBS Biz_M", "폴라리스_M", "텔라노벨라_B", "채널동아_B", "SEN TV_B", "EBS U_B", "9Colors_B", "더 드라마_DR", "더 라이프_DR", "디스커버리_DR", "폴라리스_B", "텔라노벨라_M", "채널동아_M", "SEN TV_M", "EBS U_M", "9Colors_M", "W쇼핑_DR", "Addressable TV ", "채널S_M", "채널S_B", "KTV to KBS", "하이라이트_M", "하이라이트_B", "쿠키건강_M" };

            for (int i = 0; i < 140; i++)
            {
                Server s = new Server();
                s.Name = arr[i];
                s.Property = "Start";
                s.Background = "#00000000";
                s.Color = "#24D56B";
                if (i == 100 || i == 101 || i == 102)
                {
                    s.Property = "Sync Loss";
                    s.Color = "#EE0000";
                }
                serverList.Add(s);
            }

            ServerListItem.ItemsSource = serverList;

            ObservableCollection<LogItem> logList = new ObservableCollection<LogItem>();
            LogItem l = new LogItem();
            l.Name = "KBS";
            l.Ip = "192.168.2.100";
            l.EventId = "101";
            l.EventTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            l.EventType = "SpliceInsert";
            l.Direction = "ArrowUpThick";
            l.Preroll = 1000;

            logList.Add(l);

            LogItem l2 = new LogItem();
            l2.Name = "KBS";
            l2.Ip = "192.168.2.100";
            l2.EventId = "103";
            l2.EventTime = DateTime.Now.AddSeconds(30).ToString("yyyy-MM-dd HH:mm:ss");
            l2.EventType = "SpliceInsert";
            l2.Direction = "ArrowDownThick";
            l2.Preroll = 1000;

            logList.Add(l2);

            lvLog.ItemsSource = logList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() => Worker(1));
        }

        private async void Worker(double sleep)
        {
            TimeSpan ts = TimeSpan.FromSeconds((double)sleep);

            while (!_shouldStop)
            {
                await Task.Delay(ts);
                Debug.WriteLine("service is alive");
            }
        }

        private void ClosingServerDialog(object sender, DialogClosingEventArgs eventArgs)
        {
        }

        private void BtnServerAdd_Click(object sender, RoutedEventArgs e)
        {
            var result = DialogHost.Show("DialogServer");
        }
    }
}