function myAdd(){
    var a = parseInt(document.getElementById("Num1").value);
    var b = parseInt(document.getElementById("Num2").value);
    var sum = a + b; 
     document.getElementById("Add").innerHTML = sum;
 }
 function mySub(){
    var a = parseInt(document.getElementById("Num1").value);
    var b = parseInt(document.getElementById("Num2").value);
    var sub = a - b; 
     document.getElementById("Sub").innerHTML = sub;
 }
 function myMul(){
    var a = parseInt(document.getElementById("Num1").value);
    var b = parseInt(document.getElementById("Num2").value);
    var mul = a * b; 
     document.getElementById("Mul").innerHTML = mul;
 }
 function myDiv(){
    var a = parseInt(document.getElementById("Num1").value);
    var b = parseInt(document.getElementById("Num2").value);
    var div = a % b; 
     document.getElementById("Div").innerHTML = div;
 }