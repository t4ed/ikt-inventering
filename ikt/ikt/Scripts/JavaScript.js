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
    });

$.ajax({
    url: "/FetchData/FetchSubjectData",
    type: 'GET',
    dataType: 'json',
    success(response) {
        var data = [];
        for (i = 0; i < response.length; i++) {
            data.push(response[i].Name);
        }
        $("#SubjectID").autocomplete({
            source: data
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
        var data = [];
        for (i = 0; i < response.length; i++) {
            data.push(response[i].Name);
        }
        $("#ClassID").autocomplete({
            source: data
        });
    },
    error(jqXHR, status, errorThrown) {
        console.log(jqXHR);
    }
});

$(document).ready(function () {
    $('#SubjectID').on('change', function () {
        this.form.submit();
    });
    $('#Grade').on('change', function () {
        this.form.submit();
    });
    $('#SortBy').on('change', function () {
        this.form.submit();
    });
});