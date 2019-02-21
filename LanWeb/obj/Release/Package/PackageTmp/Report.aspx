<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="LanWeb.Report" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="scripts/jquery-3.3.1.js"></script>
    <script src="scripts/Chart.js"></script>
</head>
<body>
   <input type="button" name="name" value="前一天" id="before" />
     <input type="date" id="date" value="<%=DateTime.Now.ToString("yyyy-MM-dd") %>" onfocus="javascript:{$('#date').trigger('change')}"" />
    <input type="button" name="name" value="后一天" id="after" />
    <br />
   数量 <select id="size">
        <option value="value">15</option>
           <option value="value">20</option>
           <option value="value" selected="selected">30</option>
    </select>
      <div id="div_data">             
    </div>
    <script>  
	</script>
    <script>

        $("#date").bind("change", function () {
            loadData();
        });
        $("#size").change(function () {
            loadData();
        });
        $("#before").click(function () {
            var time = Date.parse( $("#date").val());
            $("#date").val(addDate(time, -1));
            loadData();
        });
        $("#after").click(function () {
            var time = Date.parse($("#date").val());
            $("#date").val(addDate(time, 1));
            loadData();
        });
        function addDate(date, days) {
            if (days == undefined || days == '') {
                days = 1;
            }
            var date = new Date(date);
            date.setDate(date.getDate() + days);
            var month = date.getMonth() + 1;
            var day = date.getDate();
            return date.getFullYear() + '-' + getFormatDate(month) + '-' + getFormatDate(day);
        }
        function getFormatDate(arg) {
            if (arg == undefined || arg == '') {
                return '';
            }
            var re = arg + '';
            if (re.length < 2) {
                re = '0' + re;
            }
            return re;
        }
        function loadData() {
            $("#div_data").html("");
            var time = $("#date").val();
            var response = $.ajax({ url: "load.ashx?time=" + time, async: false, dataType: "json" });
            if (response) {
                var json = JSON.parse(response.responseText);
                if (json) {
                    var size = $("#size  option:selected").text();;
                    var total = json.length;
                    var circleCount = 0;
                    while (total > 0) {

                        var lineChartData = {
                            labels: [],
                            datasets: [
                                {
                                    fillColor: "rgba(151,187,205,0.5)",
                                    strokeColor: "rgba(151,187,205,1)",
                                    pointColor: "rgba(151,187,205,1)",
                                    pointStrokeColor: "#fff",
                                    data: []
                                }
                            ]
                        }
                        for (var i = size * circleCount; i < size * (circleCount + 1) ; i++) {
                            if (json[i]) {
                                lineChartData.labels.push(json[i].name);
                                lineChartData.datasets[0].data.push(json[i].value);
                                total = total - 1;
                            }
                        }
                        var element = document.createElement("canvas");
                        element.id = "canvas" + circleCount;
                        element.height = "450";
                        element.width = "1800";
                        $("#div_data").append(element);
                        var myLine = new Chart(element.getContext("2d")).Line(lineChartData);
                        circleCount++;
                    }
                }
            }
        }
        loadData();
    </script>
  
</body>
</html>
