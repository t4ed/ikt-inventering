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
        $(".classList").autocomplete({
            source: data,
            minLength: 0
        }).bind('focus', function () {
            $(this).autocomplete("search", "");
            /*if ($(this).val.length > 3) {
                $(this).trigger("change");
            } */
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

'use strict';

; (function (document, window, index) {
    var inputs = document.querySelectorAll('.inputfile');
    Array.prototype.forEach.call(inputs, function (input) {
        var label = input.nextElementSibling,
            labelVal = label.innerHTML;

        input.addEventListener('change', function (e) {
            var fileName = '';
            if (this.files && this.files.length > 1)
            {
                fileName = (this.getAttribute('data-multiple-caption') || '').replace('{count}', this.files.length);
            } 
            else
                fileName = e.target.value.split('\\').pop();

            if (fileName)
                label.querySelector('span').innerHTML = fileName;
            else
                label.innerHTML = labelVal;
        });

        // Firefox bug fix
        input.addEventListener('focus', function () { input.classList.add('has-focus'); });
        input.addEventListener('blur', function () { input.classList.remove('has-focus'); });
    });
}(document, window, 0));