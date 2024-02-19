let datatable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    datatable = $('#tblData').datatable([
        "ajax": {
            "url": "/Admin/Bodega/GetAll"
        },
        "columns": [
            { "data": "nombre", "width": "%20" },
            { "data": "descripcion", "width": "%40" },
            {
                "data": "estado",
                "render": function (data) {
                    if (data == true) {
                        return "Activo";
                    } else {
                        return "Inactivo"
                    }
                }, "width": "20%"
            },
            {
                "data": "id",
                "render": function (data){
                    return `<div class="text-center"><a></a></div>`
                })
            },
        ]
    ])
}