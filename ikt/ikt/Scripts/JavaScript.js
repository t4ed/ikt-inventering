﻿$("#Date").datepicker(
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

    $(document).ready(function () {  
        $("#SubjectID").autocomplete({  
           source: function(request,response) {  
               $.ajax({  
                   url: "/FetchData/FetchSubjectData",  
                   type: "GET",  
                   dataType: "json",  
                   data: { Prefix: request.term },  
                   success: function (data) {  
                       response($.map(data, function (item) {  
                           return { label: item.Name, value: item.Name};  
                       }))  
  
                   }  
               })  
           },  
           messages: {  
               noResults: "", results: ""  
           }  
       });  
   })  

$("#ClassID").autocomplete({
    
});