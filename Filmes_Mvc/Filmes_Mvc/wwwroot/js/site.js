$(function () {
    $('#tabelaDeDados').DataTable({
        language: {
            "decimal": ",",
            "emptyTable": "Dados não disponíveis",
            "info": "<b>Registros Exibidos:</b> _START_ a _END_&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Total de Registros:</b>&nbsp;_TOTAL_",
            "infoEmpty": "Registros Exibidos:</b> 0 a 0&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Total de Registros:</b>&nbsp;0",
            "infoFiltered": "(Filtrado a partir do total de _MAX_ registros)",
            "infoPostFix": "",
            "thousands": ".",
            "lengthMenu": "<b>Tamanho da Página:&nbsp;</b>_MENU_",
            "loadingRecords": "Carregando registros...",
            "processing": "Carregando...",
            "search": "<b>Pesquisar:</b> ",
            "zeroRecords": "Nenhum registro encontrado",
            "paginate": {
                "first": "<i class=\"bi bi-chevron-double-left\"></i>",
                "last": "<i class=\"bi bi-chevron-double-right\"></i>",
                "next": "<i class=\"bi bi-caret-right-square\"></i>",
                "previous": "<i class=\"bi bi-caret-left-square\"></i>"
            },
            "aria": {
                "orderable": "Ordenado por esta coluna",
                "orderableReverse": "Reverter ordem desta coluna"
            }
        },
        "pageLength": 8,
        lengthMenu: [8, 10, 25, 50, 75, 100]
    });

    setTimeout(function () {
        $(".alert").fadeOut("slow"), function () {
            $(this).alert('close');
        }
    }, 5000);
});