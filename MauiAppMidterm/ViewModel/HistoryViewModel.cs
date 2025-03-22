using System;
using System.Collections.ObjectModel; // เพิ่ม namespace นี้
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppMidterm.Pages;

namespace MauiAppMidterm.ViewModel;

public partial class HistoryViewModel : ObservableObject
{
    [ObservableProperty]
    List<String> listDataTerm1 =
    [
        "1204405 - วิทยาศาสตร์ข้อมูล",
        "1204407 - การเรียนรู้ของเครื่อง",
        "1204430 - คอมพิวเตอร์วิสัยทัศน์และการประมวลผลภาพ",
        "1204429 - การพัฒนาโปรแกรมประยุกต์",
        "1204303 - การพัฒนาโปรแกรมประยุกต์บนอุปกรณ์พกพา",
        "1204201 - วิธีการเชิงตัวเลขสำหรับวิทยาการคอมพิวเตอร์",
    ];

    [ObservableProperty]
    List<String> listDataTerm2 = [
        "1204305 - คอมพิวเตอร์กราฟิก",
        "1204306 - วิศวกรรมซอฟต์แวร์",
        "1204307 - ปัญญาประดิษฐ์",
        "1204308 - ทฤษฎีการคำนวณ"
    ];

    [ObservableProperty]
    List<String> listDataTerm3 = [ ""

    ];
}
