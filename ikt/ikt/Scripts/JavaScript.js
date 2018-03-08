$("#Date").datepicker(
    $.datepicker.regional['sv'] = {
        closeText: 'Stäng',
        prevText: '< Föregående',
        nextText: 'Nästa >',
        currentText: 'Nu',
        monthNames: ['Januari', 'Februari', 'Mars', 'April', 'Maj', 'Juni', 'Juli', 'Augusti', 'September', 'Oktober', 'November', 'December'],
        monthNamesShort: ['Jan', 'Feb', 'Mar', 'Apr', 'Maj', 'Jun', 'Jul', 'Aug', 'Sep', 'Okt', 'Nov', 'Dec'],
        dayNamesShort: ['Sön', 'Mån', 'Tis', 'Ons', 'Tor', 'Fre', 'Lör'],
        dayNames: ['Söndag', 'Måndag', 'Tisdag', 'Onsdag', 'Torsdag', 'Fredag', 'Lördag'],
        dayNamesMin: ['Sö', 'Må', 'Ti', 'On', 'To', 'Fr', 'Lö'],
        weekHeader: 'V',
        dateFormat: 'yy-mm-dd',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: '',
        showWeek: true
    }
);

$.ajax({
    url: "/FetchData/FetchSubjectData",
    type: 'GET',
    dataType: 'json',
    success(response) {
        var data = [];
        for (i = 0; i < response.length; i++) {
            data.push(response[i].Name);
        }
        $(".subjectList").autocomplete({
            source: data,
            minLength: 0
        }).bind('focus', function () {
            $(this).autocomplete("search", "");
        });
    },
    error(jqXHR, status, errorThrown) {
        console.log(jqXHR);
    }
});

$.ajax({
    url: "/FetchData/FetchClassData",
    type: 'GET',
    dataType: 'json',
    success(response) {
        data = [];
        console.log(response);
        $(".classList").selectize({
            plugins: ['remove_button'],
            delimiter: ',',
            valueField: 'ID',
            labelField: 'Name',
            searchField: 'Name',
            options: response,
            create: false
        });
    },
    error(jqXHR, status, errorThrown) {
        console.log(jqXHR);
    }
});


$(document).ready(function () {
    $('.subjectSelect').on('change', function () {
        this.form.submit();
    });
    $('.gradeSelect').on('change', function () {
        this.form.submit();
    });
    $('#SortBy').on('change', function () {
        this.form.submit();
    });
});




$(function () {

    $(document).on('change', ':file', function () {
        var input = $(this),
            numFiles = input.get(0).files ? input.get(0).files.length : 1,
            label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
        input.trigger('fileselect', [numFiles, label]);
    });

    $(document).ready(function () {
        $(':file').on('fileselect', function (event, numFiles, label) {
            var input = $(this).parents('.input-group').find(':text'),
                log = numFiles > 1 ? numFiles + ' files selected' : label;

            if (input.length) {
                input.val(log);
            } else {
                if (log) alert(log);
            }
        });
    });
});