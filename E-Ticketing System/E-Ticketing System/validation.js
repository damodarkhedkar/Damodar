function pass_val(pass)
{
    var regx = "(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}";
    var data = document.getElementById(pass);
    if (regx.test(data.value)) {
        window.("login success");
        return true;
    } 
    else
          return false;
}