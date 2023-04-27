"use strict"




// 소트 함수
var arr = [1, 3, 2, 4, 5, 6, 7, 8, 9, 10];
arr.sort(function (a, b) {
    return a - b;
});
console.log(arr);
