using System;
using System.Collections.ObjectModel; // เพิ่ม namespace นี้
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppMidterm.Pages;

namespace MauiAppMidterm.ViewModel;

public partial class EnrollViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> listData = new ObservableCollection<string>
    {
        "1204305 - คอมพิวเตอร์กราฟิก",
        "1204306 - วิศวกรรมซอฟต์แวร์",
        "1204307 - ปัญญาประดิษฐ์",
        "1204308 - ทฤษฎีการคำนวณ"
    };

    [ObservableProperty]
    private ObservableCollection<string> listAllSubject = new ObservableCollection<string>
    {
        "1204305 - คอมพิวเตอร์กราฟิก",
        "1204306 - วิศวกรรมซอฟต์แวร์",
        "1204307 - ปัญญาประดิษฐ์",
        "1204308 - ทฤษฎีการคำนวณ",
        "1204404 - การประมวลผลภาษาธรรมชาติ",
        "1204407 - การเรียนรู้ของเครื่อง",
        "1204302 - การวิเคราะห์และออกแบบขั้นตอนวิธี",
        "1204405 - วิทยาศาสตร์ข้อมูล"
    };

    [ObservableProperty]
    private string searchText = string.Empty; // กำหนดค่าเริ่มต้น

    [ObservableProperty]
    private List<string> searchResults = new List<string>();

    [ObservableProperty]
    private string selectedSubject = string.Empty;

    [RelayCommand]
    private void Search()
    {
        if (string.IsNullOrWhiteSpace(SearchText))
        {
            SearchResults = new List<string>();
            return;
        }

        SearchResults = ListAllSubject
            .Where(subject => subject.Contains(SearchText))
            .ToList();
    }

    [RelayCommand]
    private async Task Register()
    {
        if (string.IsNullOrWhiteSpace(SelectedSubject))
        {
            await Shell.Current.DisplayAlert("Error", "กรุณาเลือกวิชาก่อนลงทะเบียน", "OK");
            return;
        }

        if (ListData.Contains(SelectedSubject))
        {
            await Shell.Current.DisplayAlert("แจ้งเตือน", "คุณได้ลงทะเบียนวิชานี้แล้ว", "OK");
            return;
        }

        // ListData.Add(SelectedSubject); // เพิ่มวิชาลงใน ListData
        // await Shell.Current.DisplayAlert("สำเร็จ", $"ลงทะเบียนวิชา {SelectedSubject} เรียบร้อยแล้ว", "OK");
        // แสดงกล่องข้อความถามยืนยันการลงทะเบียน

        bool answer = await Shell.Current.DisplayAlert("ยืนยันการลงทะเบียน", $"คุณต้องการลงทะเบียนวิชา {SelectedSubject} ใช่หรือไม่?", "ใช่", "ไม่");

        // หากผู้ใช้กด "ใช่"
        if (answer)
        {
            ListData.Add(SelectedSubject); // เพิ่มวิชาลงใน ListData
            await Shell.Current.DisplayAlert("สำเร็จ", $"ลงทะเบียนวิชา {SelectedSubject} เรียบร้อยแล้ว", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert("ยกเลิก", "การลงทะเบียนวิชาถูกยกเลิก", "OK");
        }
    }

    // [RelayCommand]
    // private async Task DeleteSubject(string subject)
    // {
    //     // ตรวจสอบว่ามีวิชาใน ListData หรือไม่
    //     if (!ListData.Contains(subject))
    //     {
    //         await Shell.Current.DisplayAlert("แจ้งเตือน", "ไม่พบวิชานี้ในรายการลงทะเบียน", "OK");
    //         return;
    //     }

    //     // แสดงกล่องข้อความถามยืนยันการลบ
    //     bool answer = await Shell.Current.DisplayAlert("ยืนยันการลบ", $"คุณต้องการลบวิชา {subject} ใช่หรือไม่?", "ใช่", "ไม่");

    //     // หากผู้ใช้กด "ใช่"
    //     if (answer)
    //     {
    //         ListData.Remove(subject); // ลบวิชาออกจาก ListData
    //         await Shell.Current.DisplayAlert("สำเร็จ", $"ลบวิชา {subject} เรียบร้อยแล้ว", "OK");
    //     }
    //     else
    //     {
    //         await Shell.Current.DisplayAlert("ยกเลิก", "การลบวิชาถูกยกเลิก", "OK");
    //     }
    // }

    [RelayCommand]
    public async Task DeleteSubject(string subject)
    {
        // ตรวจสอบว่ามีวิชาใน ListData หรือไม่
        if (!ListData.Contains(subject))
        {
            await Shell.Current.DisplayAlert("แจ้งเตือน", "ไม่พบวิชานี้ในรายการลงทะเบียน", "OK");
            return;
        }

        // แสดงกล่องข้อความถามยืนยันการลบ
        bool answer = await Shell.Current.DisplayAlert("ยืนยันการถอน", $"คุณต้องการถอนวิชา {subject} ใช่หรือไม่?", "ใช่", "ไม่");

        // หากผู้ใช้กด "ใช่"
        if (answer)
        {
            ListData.Remove(subject); // ลบวิชาออกจาก ListData
            await Shell.Current.DisplayAlert("สำเร็จ", $"ถอนวิชา {subject} เรียบร้อยแล้ว", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert("ยกเลิก", "การถอนวิชาถูกยกเลิก", "OK");
        }
    }
}