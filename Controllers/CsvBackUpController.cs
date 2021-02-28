﻿using SampleApp_202101.Services.Impl;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SampleApp_202101.Controllers
{
    // バックアップ（ファイルコピー処理）
    // CSVファイル読み込み→バイト配列分取得→CSVファイル書き込み（終わるまで繰り返す
    public class CsvBackUpController : Controller
    {
        // GET: CsvBackUp
        public ActionResult CsvBackUpIndex()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> CsvBackUpStart()
        {
            /*
            //ファイルを空にする
            FileEmpty();

            //ファイルを開く
            using (System.IO.FileStream read = new System.IO.FileStream(
                @"C:\Users\kin_y\Desktop\android-studio-ide-201.7042882-windows.exe",
                //@"C:\Users\kin_y\Desktop\testfile2",
                //@"C:\Users\kin_y\Desktop\csvData.txt",
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read))
            {

                //ファイルを一時的に読み込むバイト型配列を作成する
                byte[] bs = new byte[0x1000];

                //ファイルが存在する場合は、末尾に追加する（ファイルの末尾をシーク）。
                //存在しない場合は、新たに作成する。書き込み時にのみ使用できる。
                using (System.IO.FileStream write = new System.IO.FileStream(
                    @"C:\Users\kin_y\Desktop\copy2.exe",
                    //@"C:\Users\kin_y\Desktop\csvWritten.txt",
                    System.IO.FileMode.Append,
                    System.IO.FileAccess.Write,
                    System.IO.FileShare.ReadWrite))
                {
                    //ファイルをすべて読み込む
                    //chunk ネットワークに接続するときは必要かも
                    for (; ; )
                    {
                        //ファイルの一部を読み込む
                        int readSize = read.Read(bs, 0, bs.Length);
                        //ファイルをすべて読み込んだときは終了する
                        if (readSize == 0)
                            break;

                        //バイト型配列の内容をすべて書き込む
                        write.Write(bs, 0, bs.Length);

                    }
                    //ファイル閉じる
                    write.Close();
                }
            }

            //return RedirectToAction("CsvBackUpIndex");
            return RedirectToAction("CsvBackUpIndex", "CsvBackUp");


            //// 対象のコレクション
            //var list = Enumerable.Range(1, 10);

            //// N 個ずつの N
            //var chunkSize = 3;

            //var chunks = list.Select((v, i) => new { v, i })
            //    .GroupBy(x => x.i / chunkSize)
            //    .Select(g => g.Select(x => x.v));

            //// 動作確認
            //foreach (var chunk in chunks)
            //{
            //    foreach (var item in chunk)
            //        Console.Write($"{item} ");
            //    Console.WriteLine();
            //}
            */
            var srcPath = @"C:\Users\kin_y\Desktop\android-studio-ide-201.7042882-windows.exe";
            var destPath = @"C:\Users\kin_y\Desktop\copy2.exe";
            FileCopyService service = new FileCopyService();
            await service.FileCopyAsync(srcPath, destPath);

            return new EmptyResult();
        }
    }
}