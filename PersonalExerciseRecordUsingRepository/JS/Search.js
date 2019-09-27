function SearchSchool() {
    var input, filter, table, tr, td, i;
    input = document.getElementById("MySearch");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td) {
            if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                //show
                tr[i].style.display = "";
            } else {
                //hide
                tr[i].style.display = "none";
            }
        }
    }
}

function ValidateInputs() {
    var Result = true;
    x = document.getElementById("Name").value;
    if (x == "")
        Result = false;

    var x;
    // Get the value of the input field with id="numb"
    x = document.getElementById("Age").value;
    // If x is Not a Number or less than 18  or greater than 45
    if (isNaN(x) || x > 45 || x < 18) {
        Result = false;
    }

    if (Result == false)
        alert("Invalid Data");
    return false;

}



var x, text;
// Get the value of the input field with id="numb"
x = document.getElementById("Age").value;
// If x is Not a Number or less than one or greater than 10
if (isNaN(x) || x < 1 || x > 10) {
    text = "Input not valid";
} else {
    text = "Input OK";
}
document.getElementById("demo").innerHTML = text;
