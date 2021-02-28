//alert("Hello");
// dropdownlistfor onchange submit
// https://www.sejuku.net/blog/25060
// https://www.it-swarm-ja.tech/ja/c%23/htmldropdownlist%E3%81%AEonchange%E3%82%A4%E3%83%99%E3%83%B3%E3%83%88/1048253936/
// submit https://javascript.programmer-reference.com/js-action-submit/
function SelectChenged() {
    let value = document.getElementById("TodoCategoryContentsList").value;


    let val = $(".TodoCategoryContentsList").length;
    alert(val)

    //$(".TodoCategoryContentsList").value('@Model.TodoCategoryId');

    //alert(value)
    
    //window.location.href = "/Sample/List?value=" + value;

    //Submit形式指定する（post/get）
    //document.TodoCategoryContentsList. = "post";  // 例）POSTに指定する

    //targetを指定する
    //fm.target = "_blank";  // 例）新しいウィンドウに表示

    //action先を指定する
    //document.TodoCategoryContentsList.action = "../Controller/SampleController.cs";  // 例）"/php/sample.php"に指定する

    //Submit実行
    //document.TodoCategoryContentsList.submit();
}

//$('.TodoCategoryContentsList').on('click', function () {
//    alert("クリックされました");
//});






// javascript →　Ajax →　http作成
// <input hidden 作成　→　button押下時にsubmitされる。



