//focus input
$('.modal').on('shown.bs.modal', function () {
    $(this).find('[autofocus]').focus();

});

var app = angular.module('MainApp', []);
app.controller("KhachHangController", function ($scope, $http) {
    $scope.funcReload=function() {
        RestoreData();

    }

    $scope.Trang_Thai_add = "Sử dụng";
    RestoreData();
    function RestoreData() {

        $http({
            method: "GET",
            url: "/KH_API/api/KhachHangAPI/getChitieu",
        }).then(function (result) {
            var z = JSON.parse(result.data);
            var listCT = [];
            console.log(z.Item1);
            console.log(z.Item2);


            for (j = 0; j < z.Item2.length; j++) {
                for (var i = 0; i < z.Item1.length; i++) {
                    if (z.Item1[i].Ma_Chi_Tieu_CT == z.Item2[j].Ma_Chi_Tieu) {
                        var ctkh = new ChiTieuKhachHangtmp(z.Item2[j].Ma_Chi_Tieu, z.Item2[j].Nam, z.Item2[j].Ten_Chi_Tieu, z.Item2[j].Status, z.Item1[i].Thang1,
                            z.Item1[i].Thang2, z.Item1[i].Thang3, z.Item1[i].Thang4, z.Item1[i].Thang5, z.Item1[i].Thang6,
                            z.Item1[i].Thang7, z.Item1[i].Thang8, z.Item1[i].Thang9, z.Item1[i].Thang10, z.Item1[i].Thang11,
                            z.Item1[i].Thang12
                        );
                        listCT.push(ctkh);
                    }
                }
            }
            var items = z.Item2.filter((x) => !z.Item1.map((x) => x.Ma_Chi_Tieu_CT).includes(x.Ma_Chi_Tieu));
            if (items) {
              
                for (var p = 0; p < items.length;p++) {
                    var ctkh2 = new ChiTieuKhachHangtmp(items[p].Ma_Chi_Tieu, items[p].Nam, items[p].Ten_Chi_Tieu, items[p].Status,0,0,0,0,0,0,0,0,0,0,0,);
                    listCT.push(ctkh2);
                }
            }
            $scope.arr_temp = listCT;
            $scope.datacount = $scope.arr_temp.length;

        })

    }
 

    // t function object
    function ChiTieuKhachHangMain(Nam, Ten_Chi_Tieu, Trang_Thai, Ma_Chi_Tieu) {
        this.Nam = Nam;
        this.Ten_Chi_Tieu = Ten_Chi_Tieu;
        this.Status = Trang_Thai;
        this.Ma_Chi_Tieu = Ma_Chi_Tieu;
    }
    function ChiTieuKhachHangCTMain(Ma_NV, Ma_Chi_Tieu_CT, Thang1, Thang2, Thang3, Thang4, Thang5, Thang6, Thang7, Thang8, Thang9, Thang10, Thang11, Thang12) {
        this.Ma_Chi_Tieu_CT = Ma_Chi_Tieu_CT;
        this.Ma_NV = Ma_NV;
        this.Thang1 = Thang1;
        this.Thang2 = Thang2;
        this.Thang3 = Thang3;
        this.Thang4 = Thang4;
        this.Thang5 = Thang5;
        this.Thang6 = Thang6;
        this.Thang7 = Thang7;
        this.Thang8 = Thang8;
        this.Thang9 = Thang9;
        this.Thang10 = Thang10;
        this.Thang11 = Thang11;
        this.Thang12 = Thang12;

    }
    //tao 1 object de luu
    function ChiTieuKhachHangtmp(Ma_Chi_Tieu, Nam, Ten_Chi_Tieu, Trang_Thai, Thang1, Thang2, Thang3, Thang4, Thang5, Thang6, Thang7, Thang8, Thang9, Thang10, Thang11, Thang12) {
        this.Ma_Chi_Tieu = Ma_Chi_Tieu;
        this.Nam = Nam;
        this.Ten_Chi_Tieu = Ten_Chi_Tieu;
        this.Trang_Thai = Trang_Thai;
        this.Thang1 = Thang1;
        this.Thang2 = Thang2;
        this.Thang3 = Thang3;
        this.Thang4 = Thang4;
        this.Thang5 = Thang5;
        this.Thang6 = Thang6;
        this.Thang7 = Thang7;
        this.Thang8 = Thang8;
        this.Thang9 = Thang9;
        this.Thang10 = Thang10;
        this.Thang11 = Thang11;
        this.Thang12 = Thang12;
    }
    function ChiTieuKhachHangCT(Ma_Chi_Tieu_CT, Ma_NV, Ten_Chi_Tieu, Thang1, Thang2, Thang3, Thang4, Thang5, Thang6, Thang7, Thang8, Thang9, Thang10, Thang11, Thang12) {
        this.Ma_Chi_Tieu_CT = Ma_Chi_Tieu_CT;
        this.Ma_NV = Ma_NV;
        this.Ten_Chi_Tieu = Ten_Chi_Tieu;
        this.Thang1 = Thang1;
        this.Thang2 = Thang2;
        this.Thang3 = Thang3;
        this.Thang4 = Thang4;
        this.Thang5 = Thang5;
        this.Thang6 = Thang6;
        this.Thang7 = Thang7;
        this.Thang8 = Thang8;
        this.Thang9 = Thang9;
        this.Thang10 = Thang10;
        this.Thang11 = Thang11;
        this.Thang12 = Thang12;
    }

    // end funtion object
    //Reset cac dong ve mac dinh
    function reset() {
        $scope.Nam_add = "";
        $scope.Ten_Chi_Tieu_add = "";
        $scope.Trang_Thai_add = "";

    }

    $scope.ThemMoi = function () {
        $scope.arr_temp_CT = "";
        reset();
        $scope.Trang_Thai_add = "Sử dụng";
        ListCTCTT = [];

    }

    $scope.LuuVaThem = function () {
        var chitieukhachhang = new ChiTieuKhachHangMain(
            $scope.Nam_add, $scope.Ten_Chi_Tieu_add, $scope.Trang_Thai_add, $scope.Ma_Chi_Tieu_add
        );
        //Json.stringyfy
        $http({
            method: 'POST',
            url: '/KH_API/api/KhachHangAPI/ThemMoiChiTieu',
            data: chitieukhachhang
        }).then(function (res) {


        });
        console.log($scope.arr_temp_CT);

        $http({
            method: 'POST',
            url: '/KH_API/api/KhachHangAPI/ThemMoiChiTieuCT',
            data: JSON.stringify($scope.arr_temp_CT)
        }).then(function (res) {

            RestoreData();

        });

        alert("Them thanh cong !!");
        ListCTCTT = [];


    };


    var ListCTCTT = [];
    /// them moi ban ghi
    $scope.LuuVaThemNhanVien = function () {

        if ($scope.FormNhanVien.$invalid) {

            return false;
            $("#myModal2").modal("show");
        }
        else {
            var chitieukhachhangct = new ChiTieuKhachHangCTMain(
                $scope.Ma_NV_add, "", $scope.thang1_add, $scope.thang1_add, $scope.thang1_add,
                $scope.thang2_add, $scope.thang3_add, $scope.thang4_add, $scope.thang5_add,
                $scope.thang6_add, $scope.thang7_add, $scope.thang8_add, $scope.thang9_add,
                $scope.thang10_add, $scope.thang11_add, $scope.thang12_add
            );
            ListCTCTT.push(chitieukhachhangct);
            $scope.arr_temp_CT = ListCTCTT;
            console.log(chitieukhachhangct);

            $("#myModal2").modal("hide");
        }
        ResetNhanVien();

    }

    //

    $scope.toggleAll = function () {
        var toggleStatus = $scope.isAllSelected;
        angular.forEach($scope.arr_temp, function (itm) {
            itm.selected = toggleStatus;
        });

    }
    $scope.optionToggled = function () {
        $scope.isAllSelected = $scope.arr_temp.every(function (itm) { return itm.selected; }

        )
    }




    //reset
    function Reset() {
        $scope.MaKH_add = "";
        $scope.DiaChi_add = "";
        $scope.MaSoThue_add = "";
        $scope.TenKH_add = "";
        $scope.DienThoai_add = "";

    }
    function ResetNhanVien() {
        $scope.Ma_NV_add = "";
        $scope.thang1_add = "";
        $scope.thang2_add = "";
        $scope.thang3_add = "";
        $scope.thang4_add = "";
        $scope.thang5_add = "";
        $scope.thang6_add = "";
        $scope.thang7_add = "";
        $scope.thang8_add = "";
        $scope.thang9_add = "";
        $scope.thang10_add = "";
        $scope.thang11_add = "";
        $scope.thang12_add = "";
    }
    //    //reload data
    //    $scope.funcReload = function () {
    //        $scope.arr_temp = ListKH;
    //    }

    //reset 
    //Sua ban ghi
    function GetRowEdit(e) {
        var ListCTCT = [];
        for (var i = 0; i < $scope.arr_temp.length; i++) {
            if ($scope.arr_temp[i].Ma_Chi_Tieu == e) {
                $scope.Nam_add = $scope.arr_temp[i].Nam;
                $scope.Ten_Chi_Tieu_add = $scope.arr_temp[i].Ten_Chi_Tieu;
                $scope.Trang_Thai_add = $scope.arr_temp[i].Trang_Thai;

            }
        }

        $http({
            method: "GET",
            url: "/KH_API/api/KhachHangAPI/getChitieu2",
        }).then(function (result) {
            var z = JSON.parse(result.data);

            for (var i = 0; i < z.Item1.length; i++) {
                if (z.Item1[i].Ma_Chi_Tieu_CT == e) {
                    var ctkhct = new ChiTieuKhachHangCT(z.Item1[i].Ma_Chi_Tieu_CT, z.Item1[i].Ma_NV, z.Item1[i].Ma_Chi_Tieu_CT, z.Item1[i].Thang1,
                        z.Item1[i].Thang2, z.Item1[i].Thang3, z.Item1[i].Thang4, z.Item1[i].Thang5, z.Item1[i].Thang6,
                        z.Item1[i].Thang7, z.Item1[i].Thang8, z.Item1[i].Thang9, z.Item1[i].Thang10, z.Item1[i].Thang11,
                        z.Item1[i].Thang12
                    );
                    ListCTCT.push(ctkhct);
                }
            }

            $scope.arr_temp_CT = ListCTCT;

        });
    }



    $scope.FunctionEdit = function (e) {

        GetRowEdit(e);
        $('#myModal').modal("show");
        $('#LuuVaThemBtn').prop('disabled', true);
        console.log(e);
        $scope.Save = function () {
            var p = new ChiTieuKhachHangMain($scope.Nam_add, $scope.Ten_Chi_Tieu_add, $scope.Trang_Thai_add, e)
            console.log(p);
            $http({
                method: "POST",
                url: '/KH_API/api/KhachHangAPI/UpdateChiTieu',
                data: p
            }).then(function (data) {

                console.log(data);
            })
            RestoreData();
            //ListKH.splice(y, 1, p);
            //$scope.arr_temp = ListKH;
            //$('#modalsua').modal('hide');
            //ListKH = [];
        }
    }



    //  xoa ban ghi
        var listDelete = [];
        $scope.delete = function () {
            var dem = [];
            for (var i = 0; i < $scope.arr_temp.length; i++) {
                if ($scope.arr_temp[i].selected) {
                    dem.push(i);
                    listDelete.push($scope.arr_temp[i].Ma_Chi_Tieu);
                }
            }
      
            if (confirm("Bạn có muốn xóa " + dem.length + " bản ghi ?")) {

                $http({
                    method: "POST",
                    url: '/KH_API/api/KhachHangAPI/DeleteTieuChi',
                    data: listDelete
                }).then(function (data) {

                    RestoreData();
                });         
            }
        }

    //Tim kiem
    $scope.funcSearch = function (e) {
        if (e != undefined) {
            $http({
                method: 'GET',
                url: '/KH_API/api/KhachHangAPI/SearchChiTieu',
                params: {
                    str: e
                }
            }).then(function (res) {

                var z = JSON.parse(res.data);
                console.log(z);
                var listCT = [];

              
                for (var i = 0; i < z.Item1.length; i++) {
                    for (var j = 0; j < z.Item2.length; j++) {
                        if (z.Item1[i].Ma_Chi_Tieu_CT == z.Item2[j].Ma_Chi_Tieu) {
                   
                            var ctkh = new ChiTieuKhachHangtmp(z.Item1[i].Ma_Chi_Tieu_CT, z.Item2[j].Nam, z.Item2[j].Ten_Chi_Tieu, z.Item2[j].Status, z.Item1[i].Thang1,
                                z.Item1[i].Thang2, z.Item1[i].Thang3, z.Item1[i].Thang4, z.Item1[i].Thang5, z.Item1[i].Thang6,
                                z.Item1[i].Thang7, z.Item1[i].Thang8, z.Item1[i].Thang9, z.Item1[i].Thang10, z.Item1[i].Thang11,
                                z.Item1[i].Thang12
                            );
                            listCT.push(ctkh);
                        }
                    }
                }
                $scope.arr_temp = listCT;
                listCT = [];


            })

        }
        else {

        }
    };
    //        // thay doi trang thai button
    //    $scope.ThemMoi = function () {
    //        console.log("okkk");
    //        Reset();
    //        $scope.mySelect = "Sử dụng";
    //        $('#LuuVaThemBtn').prop('disabled', false);

    //    };


        //Sap xep ban ghi
    $scope.reverse = false;
    $scope.sortBy = function (propertyName) {
        $scope.reverse = ($scope.propertyName === propertyName) ? !$scope.reverse : false;
        $scope.propertyName = propertyName;

    }


});

