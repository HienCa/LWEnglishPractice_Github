#pragma checksum "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1da22d079fded71a38f095d4e04dd7d595d0e05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Statistics), @"mvc.1.0.view", @"/Views/Home/Statistics.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\_ViewImports.cshtml"
using LWEnglishPractice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\_ViewImports.cshtml"
using LWEnglishPractice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
using LWEnglishPractice.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1da22d079fded71a38f095d4e04dd7d595d0e05", @"/Views/Home/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fd7d093ed1d7e82ee64326da0003dab9c85e1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LWEnglishPractice.Entities.History>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Style/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Style/ListenAndWrite.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
  
    Layout = null;



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1da22d079fded71a38f095d4e04dd7d595d0e054921", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Listen And Write English</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1da22d079fded71a38f095d4e04dd7d595d0e055514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a1da22d079fded71a38f095d4e04dd7d595d0e056693", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/4.2.1/chart.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1da22d079fded71a38f095d4e04dd7d595d0e058850", async() => {
                WriteLiteral(@"

    <div class=""row "" style=""width: 100vw; height: 100vh; "">
        <div class=""col-md-2 border border-bottom-0 border-top-0 border-right text-center"" style=""background-image: url('https://leverageedublog.s3.ap-south-1.amazonaws.com/blog/wp-content/uploads/2019/11/23173331/Best-Books-for-GRE.png'); background-position: left; background-repeat: no-repeat; background-size: cover;"">
            <div class="" mt-5"">
                <h3 class=""text-center logoCVG"">CVG ENGLISH</h3>
                <div");
                BeginWriteAttribute("class", " class=\"", 1406, "\"", 1414, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div id=""homeBtn"" class=""d-flex align-items-center rounded-3 sidebar p-4 pt-0 pb-0"">

                        <a href=""/Home/Index"" style=""text-decoration: none;"" class=""text-dark"">
                            <span style=""font-size:32px; margin-right: 10px;"">
                                <i style=""color: #58CC02;""
                                   class=""fa-solid fa-house ""></i>
                            </span> LEARNING
                        </a>
                    </div>
                    <div id=""homeBtn"" class=""d-flex align-items-center rounded-3 sidebar p-4 pt-0 pb-0"">

                        <a href=""/Home/Statistics"" style=""text-decoration: none;"" class=""text-dark"">
                            <span style=""font-size:32px; margin-right: 10px;"">
                                <i style=""color: #58CC02;""
                                   class=""fas fa-chart-bar ""></i>
                            </span> STATISTICS
                        </a>
         ");
                WriteLiteral(@"           </div>
                    <di id=""rankingBtn"" class=""d-flex align-items-center rounded-3 sidebar p-4 pt-0 pb-0"">

                        <a href=""/Home/Ranking"" style=""text-decoration: none;"" class=""text-dark"">
                            <span style=""font-size:32px; margin-right: 10px;"">
                                <i style=""color: #58CC02;""
                                   class=""fa-solid fa-ranking-star ""></i>
                            </span> RANKING

                        </a>
                </div>
                <div id=""profileBtn"" class=""d-flex align-items-center rounded-3 sidebar p-4 pt-0 pb-0"">

                    <a href=""/Home/Profile"" style=""text-decoration: none;"" class=""text-dark"">
                        <span style=""font-size:32px; margin-right: 20px;"">
                            <i style=""color: #58CC02;""
                               class=""fa-solid fa-user ""></i>
                        </span> PROIFILE
                    </a>
               ");
                WriteLiteral(@" </div>
                <div class="" align-items-center rounded-3 sidebar p-4 pt-0 pb-0"" id=""NoCookieName"" style=""display:none"">

                    <a href=""/Login/Logout"" style=""text-decoration: none;"" class=""text-dark"">
                        <span style=""font-size:32px; margin-right: 20px;"">

                            <i style=""color: red;"" class=""fa-solid fa-power-off""></i>
                        </span> LOG OUT
                    </a>
                </div>
                <div class="" align-items-center rounded-3 sidebar p-4 pt-0 pb-0"" id=""HascookieName"" style=""display:none"">

                    <a href=""/Login/Login"" style=""text-decoration: none;"" class=""text-dark"">
                        <span style=""font-size:32px; margin-right: 20px;"">

                            <i style=""color: #58CC02;"" class=""fas fa-user-circle""></i>
                        </span> LOG IN
                    </a>
                </div>
            </div>
        </div>
        <div class=""col-md-10");
                WriteLiteral(" pb-5 border border-bottom-0 border-left-0 border-top-0 border-right\"\r\n             style=\"max-height: 100vh; overflow-y:scroll\">\r\n\r\n\r\n            <div id=\"learning\" class=\"fade\">\r\n\r\n");
#nullable restore
#line 100 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mt-2\">\r\n                        <h1 class=\"text-center\">HISTORY</h1>\r\n                    </div>\r\n");
                WriteLiteral("                    <div class=\"mt-2\">\r\n");
                WriteLiteral("                        <canvas id=\"linechartDay\" class=\"w-100\" style=\"max-height: 50vh;\"></canvas>\r\n                    </div>\r\n");
#nullable restore
#line 111 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                     if (ViewBag.StatisticByDay != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class="" text-right"">
                            <span style="" display:block;font-size:40px;text-align:right;cursor:pointer"" id=""caretDownIcon""><i class=""fa-solid fa-caret-down""></i></span>
                            <span style="" display: none; font-size: 40px; text-align: right; cursor: pointer"" id=""caretUpIcon""><i class=""fa-solid fa-caret-up""></i></span>
                        </div>
                        <div class=""mt-2 container fade"" style=""position:relative; display:none"" id=""statistic-detail"">



                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">#</th>
                                        <th scope=""col"">Level</th>
                                        <th scope=""col"">Lesson Name</th>
                                        <th scope=""col"">Scores</th>
                                        <th scope=""col"">Finish ");
                WriteLiteral("Date</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody class=\"table-group-divider\">\r\n");
#nullable restore
#line 132 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                      
                                        int i = 1;

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                     foreach (var item in ViewBag.StatisticByDay as List<History>)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
#nullable restore
#line 140 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 141 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                           Write(item.IdlessonNavigation.IdlevelNavigation.Levelname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 142 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                           Write(item.IdlessonNavigation.Lessonanme);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 143 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                           Write(item.Score);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 145 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                             if (item.Finishdate != null)
                                            {
                                                DateTime Finishdate = (DateTime)item.Finishdate;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>");
#nullable restore
#line 148 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                               Write(Finishdate.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 149 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td></td>\r\n");
#nullable restore
#line 153 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </tr>\r\n");
#nullable restore
#line 156 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"

                                        i = i + 1;

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 165 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mt-5\">\r\n");
                WriteLiteral("                        <canvas id=\"linechart\" class=\"w-100\" style=\"max-height: 50vh;\"></canvas>\r\n                    </div>\r\n");
                WriteLiteral("                    <div class=\"mt-5\">\r\n");
                WriteLiteral("                        <canvas id=\"linechartYear\" class=\"w-100\" style=\"max-height: 50vh;\"></canvas>\r\n                    </div>\r\n");
#nullable restore
#line 177 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"mt-2\">\r\n                        <h1 class=\"text-center\">NO HISTORY</h1>\r\n                    </div>\r\n");
#nullable restore
#line 184 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>\r\n\r\n    <script>\r\n        let myArr =");
#nullable restore
#line 197 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Home\Statistics.cshtml"
              Write(Html.Raw(ViewBag.dataStatistics));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        let data = myArr;


        /*  theo tháng năm*/

        let scoresByMonth = new Map();

        // Loop through the data and update the scores for each month
        for (let item of data) {
            let date = new Date(item.Finishdate);
            let monthYear = date.toLocaleDateString('en-US', { month: 'long', year: 'numeric' });
            let score = item.Score;

            if (scoresByMonth.has(monthYear)) {
                scoresByMonth.set(monthYear, scoresByMonth.get(monthYear) + score);
            } else {
                scoresByMonth.set(monthYear, score);
            }
        }

        // Convert the Map to an array of key-value pairs
        let chartData = Array.from(scoresByMonth, ([label, value]) => ({ label, value }));

        // Display the chart data
        console.log(chartData);
        let labels = chartData.map(data => {
            let dateObj = new Date(data.Finishdate);
            if (isNaN(dateObj.getTime())) {
                //");
                WriteLiteral(@" handle invalid date input
                return null;
            }
            return dateObj.toLocaleDateString('en-GB', { month: 'long' });
        });
        labels.sort(function (a, b) {
            let monthA = new Date(Date.parse('01 ' + a)).getMonth();
            let monthB = new Date(Date.parse('01 ' + b)).getMonth();
            return monthA - monthB;
        });
        let labelValues = chartData.map(data => data.label);
        let values = chartData.map(data => data.value);
        const ctx = document.getElementById('linechart');

        new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labelValues,
                datasets: [{
                    label: 'Statistics by month',
                    data: values,
                    borderWidth: 1,
                    backgroundColor: '#198754',
                    barThickness: 120


                }]
            },
            options: {
                scales: {
          ");
                WriteLiteral(@"          y: {
                        beginAtZero: true
                    }
                }
            }
        });



       /*  theo ngày*/
        let yy = myArr.map(obj => obj[Object.keys(obj)[1]]);
        let xx = myArr.map(obj => obj[Object.keys(obj)[3]]);


        for (let i = 0; i < xx.length; i++) {
            xx[i] = xx[i].split('T')[0];
            let parts = xx[i].split('-');
            xx[i] = parts[2] + '-' + parts[1] + '-' + parts[0];
        }

        console.log(xx);
        const dates = xx;
        const formattedDates = dates.map(date => {
            const dateObj = new Date(date);
            if (isNaN(dateObj.getTime())) {
                // handle invalid date input
                return null;
            }
            return dateObj.toLocaleDateString('en-GB', { day: '2-digit', month: '2-digit', year: 'numeric' });
        });

        const linechartDay = document.getElementById('linechartDay');

        new Chart(linechartDay, {
      ");
                WriteLiteral(@"      type: 'bar',
            data: {
                labels: xx,
                datasets: [{
                    label: 'Statistics by day',
                    data: yy,
                    borderWidth: 1,
                    backgroundColor: '#20c997',
                    barThickness: 120


                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });




        //theo năm
        let scoresByYear = new Map();

        // Loop through the data and update the scores for each year
        for (let item of data) {
            let date = new Date(item.Finishdate);
            let year = date.getFullYear();
            let score = item.Score;

            if (scoresByYear.has(year)) {
                scoresByYear.set(year, scoresByYear.get(year) + score);
            } else {
                scoresByYear.set(year, score");
                WriteLiteral(@");
            }
        }

        // Convert the Map to an array of key-value pairs
        let chartDataYear = Array.from(scoresByYear, ([label, value]) => ({ label: label.toString(), value }));
        // Tách label và value ra 2 mảng riêng
        let labelsYear = chartDataYear.map(item => item.label);
        let valuesYear = chartDataYear.map(item => item.value);

        // Hiển thị các mảng
        console.log(labelsYear);
        console.log(valuesYear);

        const linechartYear = document.getElementById('linechartYear');

        new Chart(linechartYear, {
            type: 'bar',
            data: {
                labels: labelsYear,
                datasets: [{
                    label: 'Statistics by year',
                    data: valuesYear,
                    borderWidth: 1,
                    backgroundColor: '#022a18',
                    barThickness: 120
                }
                ]
            },
            options: {
                scales:");
                WriteLiteral(@" {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });


    </script>


    <script>
        window.addEventListener('beforeunload', function () {
            var cookies = document.cookie.split(';');
            for (var i = 0; i < cookies.length; i++) {
                var cookie = cookies[i].trim();
                if (cookie.indexOf('HienCaCookie=') === 0) {
                    document.cookie = ""hienca=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;"";
                    break;
                }
            }
        });

    </script>


    <script>

        let myDiv = document.getElementById(""statistic-detail"");
        let caretUpIcon = document.getElementById(""caretUpIcon"");
        let caretDownIcon = document.getElementById(""caretDownIcon"");


        caretDownIcon.addEventListener(""click"", function () {
            if (myDiv.style.display === ""none"") {
                myDiv.style");
                WriteLiteral(@".display = ""block"";
                caretUpIcon.style.display = ""block"";
                caretDownIcon.style.display = ""none"";

            }
        });

        caretUpIcon.addEventListener(""click"", function () {
            if (myDiv.style.display === ""block"") {
                myDiv.style.display = ""none"";
                caretUpIcon.style.display = ""none"";
                caretDownIcon.style.display = ""block"";

            }
        });



    </script>
    <script>

        const myCookie = getCookie('HienCaCookie');
        if (myCookie != null) {
            document.getElementById(""NoCookieName"").style.display = ""flex"";
        } else {
            document.getElementById(""HascookieName"").style.display = ""flex"";

        }

        function getCookie(name) {
            const cookieString = document.cookie;
            const cookies = cookieString.split(';');
            for (let i = 0; i < cookies.length; i++) {
                const cookie = cookies[i].trim();
    ");
                WriteLiteral("            if (cookie.startsWith(name + \'=\')) {\r\n                    return cookie.substring(name.length + 1);\r\n                }\r\n            }\r\n            return null;\r\n        }\r\n\r\n\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LWEnglishPractice.Entities.History>> Html { get; private set; }
    }
}
#pragma warning restore 1591
