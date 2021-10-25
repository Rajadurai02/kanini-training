// JavaScript source code

function addEmployee() {
    //variables store the separate text field details
    var id = document.getElementById("employeeId").value;
    var name = document.getElementById("employeeName").value;
    var age = document.getElementById("employeeAge").value;
    //alerting the user to enter the details in all fields
    if (id == "" || name == "" || age == "") {
        alert("Please fill all fields")
    }
    else {
        //store the details in Array object
        var employees = [
            {
                "id": id,
                "name": name,
                "age": age
            }];
        //printing the array details into the table
        var myTable = document.getElementById("employeeTable");
        for (var i = 0; i < employees.length; i++) {
            var tr = myTable.insertRow(i + 1);
            var id = tr.insertCell(0);
            id.innerHTML = employees[i].id;
            var name = tr.insertCell(1);
            name.innerHTML = employees[i].name;
            var age = tr.insertCell(2);
            age.innerHTML = employees[i].age;
        }
    }
    
}