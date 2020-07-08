$(document).ready(function () {

    GetAllRecords();

    $("#editRecord").click(function (event) {
        event.preventDefault();
        EditRecord();
    });

    $("#addRecord").click(function (event) {
        event.preventDefault();
        AddRecord();
    });

});

function GetAllRecords() {

    $("#createBlock").css('display', 'block');
    $("#editBlock").css('display', 'none');
    $.ajax({
        url: '/api/dict',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function AddRecord() {
    let record = {
        Name: $('#addName').val(),
        Phone: $('#addPhone').val(),
    };

    $.ajax({
        url: '/api/dict/',
        type: 'POST',
        data: JSON.stringify(record),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllRecords();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function DeleteRecord(id) {

    $.ajax({
        url: '/api/dict/' + id,
        type: 'DELETE',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllRecords();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function EditRecord() {
    let id = $('#editId').val()
    let record = {
        Id: $('#editId').val(),
        Name: $('#editName').val(),
        Phone: $('#editPhone').val()
    };
    $.ajax({
        url: '/api/dict/' + id,
        type: 'PUT',
        data: JSON.stringify(record),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllRecords();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function WriteResponse(records) {
    var strResult = "<table><th>ID</th><th>Name</th><th>Phone</th>";
    $.each(records, function (index, record) {
        strResult += "<tr><td>" + record.RecordID + "</td><td> " + record.Name + "</td><td>" +
            record.Phone + "</td><td>" +
            "</td><td><a id='editItem' data-item='" + record.RecordID + "' onclick='EditItem(this);' >Update</a></td>" +
            "<td><a id='delItem' data-item='" + record.RecordID + "' onclick='DeleteItem(this);' >Delete</a></td></tr>";
    });
    strResult += "</table>";
    $("#tableBlock").html(strResult);

}

function DeleteItem(el) {
    var id = $(el).attr('data-item');
    DeleteRecord(id);
}

function EditItem(el) {
    var id = $(el).attr('data-item');
    GetRecord(id);
}

function ShowRecord(record) {
    if (record != null) {
        $("#createBlock").css('display', 'none');
        $("#editBlock").css('display', 'block');
        $("#editId").val(record.RecordID);
        $("#editName").val(record.Name);
        $("#editPhone").val(record.Phone);
    }
    else {
        alert("Such record doesn't exist");
    }
}

function GetRecord(id) {
    $.ajax({
        url: '/api/dict/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            ShowRecord(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}