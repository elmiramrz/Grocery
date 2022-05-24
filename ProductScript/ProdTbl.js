
    $(document).ready(function () {

        $.getJSON("Home/ProductEdit",
            function (json) {
                var tr;
                //Append each row to html table
                for (var i = 0; i < json.length; i++) {
                    tr = $('<tr/>');
                    tr.append("<td>" + json[i].Id + "</td>");
                    tr.append("<td>" + json[i].Name + "</td>");
                    tr.append("<td>" + json[i].Quantity + "</td>");
                    tr.append("<td>" + json[i].Price + "</td>");
                    tr.append("<td>" + json[i].ExpiryDate + "</td>");
                    tr.append("<td>" +
                        '< input type = "button" class="test" />' + "</td >");
                    $('table').append(tr);
                }
            });
    });
