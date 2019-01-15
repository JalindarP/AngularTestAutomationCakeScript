
function add() {
    var Number1 = (document.getElementById('Num1')).value;
    const Number2 = document.getElementById('Num2').value;
    //alert(Number(Number1) +  Number(Number2));
    document.getElementById('lResult').innerHTML = Number(Number1) + Number(Number2);    
  }