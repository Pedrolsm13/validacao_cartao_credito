function verificar(){
  var numero = parseInt(document.getElementById("numero").value);

    var a = numero % 10;
    var b = ((numero % 100)/10);
    var c = ((numero % 1000)/100);
    var d = ((numero % 10000)/1000);

    var e = ((numero % 100000)/10000);
    var f = ((numero % 1000000)/100000);
    var g = ((numero % 10000000)/1000000);
    var h = ((numero % 100000000)/10000000);

    var i = ((numero % 1000000000)/100000000);
    var j = ((numero % 10000000000)/1000000000);
    var k = ((numero % 100000000000)/10000000000);
    var l = ((numero % 1000000000000)/100000000000);

    var m = ((numero % 10000000000000)/1000000000000);
    var n = ((numero % 100000000000000)/10000000000000);
    var o = ((numero % 1000000000000000)/100000000000000);
    var p = (numero / 1000000000000000);

    var aa = ((b*2) % 10);
    var ab = (((b*2) % 100)/10);

    var ac = ((d*2) % 10);
    var ad = (((d*2) % 100)/10);

    var ae = ((f*2) % 10);
    var af = (((f*2) % 100)/10);

    var ag = ((h*2) % 10);
    var ah = (((h*2) % 100)/10);

    var ai = ((j*2) % 10);
    var aj = (((j*2) % 100)/10);

    var ak = ((l*2) % 10);
    var al = (((l*2) % 100)/10);

    var am = ((n*2) % 10);
    var an = (((n*2) % 100)/10);

    var ao = ((p*2) % 10);
    var ap = (((p*2) % 100)/10);

    var z = (aa + ab + ac + ad + ae + af + ag+ ah + ai + aj + ak + al + am + an + ao + ap);
    var zz = (z + a + c + e + g + i + k + m + o);
    var valid = ((zz % 10) == 0);
    var invalid = ((zz % 10) != 0);

      if (valid == true)
    {
        document.getElementById("res1").innerHTML = "Valid";
        do
        {
            if (o == 3 && ((n == 4) || (n == 7)))
            {
                document.getElementById("res2").innerHTML = "amex";
            }
            else if (p == 5 && ((o == 1) || (o == 2) || (o == 3) || (o == 4) || (o == 5)))
            {
                document.getElementById("res2").innerHTML = "mastercard";
            }
            else if (p == 4 || (m == 4 && p != 4 && p != 5))
            {
                document.getElementById("res2").innerHTML = "visa";
            }
        }
        while (invalid);
    }
    else if ((zz % 10) != 0)
        document.getElementById("res1").innerHTML = "invalid";

  //document.getElementById("res").value = res;
  //document.getElementById("res1").innerHTML = res;
}