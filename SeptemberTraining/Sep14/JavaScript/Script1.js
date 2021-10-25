// JavaScript source code
function jsArray() {
    var array = ["car", "bike", "boat"]
    array[5] = "hall";
    for (var i = 0; i < array.length; i++) {
        console.log(array[i]);
    }
}
function sampleObject() {
    var employee = {
        "Id": 101,
        "Name": "Raja",
        "Age" : 21
    }
    employee.Salary = 30000.43;
    console.log("Employee Name " + employee.Name);
    console.log("Employee salary " + employee.Salary);
}
function objectArray() {
    var employees = [
        {
            "id": 101,
            "name": "Raja",
            "age": 21
        },
        {
            "id": 102,
            "name": "Durai",
            "age": 21
        }];
    var myTable = document.getElementById("empTable");
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
function addEmployee() {
var employees = [
        {
            "id": 101,
            "name": "Raja",
            "age": 21
        },
        {
            "id": 102,
            "name": "Durai",
            "age": 21
        }];
    var id = document.getElementById("empid").value;
    var name = document.getElementById("empname").value;
    var age = document.getElementById("empage").value;
    
}