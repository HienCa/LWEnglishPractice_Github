#pragma checksum "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4447828bb135863c7a847cb8d87fb9ef5578a16f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Index), @"mvc.1.0.view", @"/Views/Lessons/Index.cshtml")]
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
#line 2 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
using LWEnglishPractice.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4447828bb135863c7a847cb8d87fb9ef5578a16f", @"/Views/Lessons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fd7d093ed1d7e82ee64326da0003dab9c85e1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LWEnglishPractice.Entities.Lesson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lessons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return onSubmitForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
  
    ListenAndWriteContext context = new ListenAndWriteContext();
    List <Level> level = context.Level.Where(a => a.Active == 1).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 246, "\"", 254, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4447828bb135863c7a847cb8d87fb9ef5578a16f6280", async() => {
                WriteLiteral(@"
        <input id=""action"" type=""hidden"" name=""action"" />
        <input id=""Idlesson"" type=""hidden"" name=""Idlesson"" />
        <div class=""bg-light p-1 border border-secondary rounded"">
            <h2>Lessons Management</h2>

            <div class=""row"">
                <div class=""col-md-6 col-sm-12"">
                    <div class=""row d-flex align-items-center"">
                        <div class=""col-md-2 col-sm-12"">
                            Level
                        </div>
                        <div class=""col-md-10 col-sm-12"">
                            <select id=""multipleSelect"" name=""Idlevel"" class=""Idlevel"" data-search=""true""
                                    data-silent-initial-value-set=""true"">
");
#nullable restore
#line 25 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                 foreach (var item in level)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4447828bb135863c7a847cb8d87fb9ef5578a16f7631", async() => {
#nullable restore
#line 27 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                                             Write(item.Levelname);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                       WriteLiteral(item.Idlevel);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </select>

                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-sm-12"">
                    <div class=""row d-flex align-items-center"">
                        <div class=""col-md-2 col-sm-12"">
                            Lesson Name
                        </div>
                        <div class=""col-md-10 col-sm-12"">
                            <textarea name=""Lessonanme"" id=""Lessonname"" maxlength=""255"" onfocus=""this.value=''"" style=""height:14px"" type=""text"" class=""form-control""></textarea>
                            <span id=""checkLessonname"" class=""text-danger""></span>

                        </div>
                    </div>
                </div>


            </div>
            <div class=""row mt-2"">

                <div class=""col-md-6 col-sm-12"">
                    <div class=""row d-flex align-items-center"">
                        <div class=""col-md-2 col-sm-12"">
         ");
                WriteLiteral(@"                   Describe
                        </div>
                        <div class=""col-md-10 col-sm-12"">
                            <textarea name=""Describe"" id=""Describe"" maxlength=""255"" type=""text"" style=""height:14px"" class=""form-control""></textarea>
                            <span id=""checkDescribe"" class=""text-danger""></span>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-12"">
                    <div class=""row d-flex align-items-center"">

                        <div class=""col-md-4 col-sm-12"">
                            Date Created
                        </div>
                        <div class=""col-md-8 col-sm-12"">
                            <input type=""date"" id=""Datecreate"" disabled name=""Datecreate"" maxlength=""255""
                                   class=""form-control"">
                            <span class=""text-danger""></span>

                        </div>
                   ");
                WriteLiteral(@" </div>
                </div>
                <div class=""col-md-3 col-sm-12 "">
                    <button type=""submit"" style=""float: right;"" class=""btn btn-primary w-100"" id=""btnAdd"">Thêm</button>
                    <div class=""d-flex"">
                        <button type=""button"" style=""display:none;"" class=""btn btn-light w-50"" id=""btnCancel"">Hủy</button>
                        <button type=""submit"" class=""btn btn-primary w-50"" onclick=""onEdit()"" id=""btnUpdate"" style=""display:none; float: right;"">
                            Cập
                            nhật
                        </button>
                    </div>
                </div>

            </div>
            

        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

</div>
<div class=""x_content"">
    <div class=""row"">
        <div class=""col-sm-12"" style=""height:60vh;overflow-y:scroll"">
            <div class=""card-box table-responsive"">


                <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap""
                       cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr class=""text-center"">
                            <th>Level</th>
                            <th>Lesson Name</th>
                            <th>Describe</th>
                            <th>Date Create</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""d-none"">
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>

                        </tr>
");
#nullable restore
#line 121 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 124 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                               Write(item.IdlevelNavigation.Levelname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 125 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                               Write(item.Lessonanme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 126 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                               Write(item.Describe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                \r\n");
#nullable restore
#line 128 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                 if (item.Datecreate != null)
                                {
                                    DateTime Datecreate = (DateTime)item.Datecreate;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 131 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                   Write(Datecreate.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"d-none\">");
#nullable restore
#line 132 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                                  Write(Datecreate.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 133 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td></td>\r\n                                    <td></td>\r\n");
#nullable restore
#line 138 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"d-none\">");
#nullable restore
#line 139 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                              Write(item.Idlesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                <td class=\"table-td-center d-flex\">\r\n                                    <a class=\"btn  btn-sm btn-warning \" onclick=\"onEdit(this)\"><i class=\"fas fa-edit text-white\"></i></a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4447828bb135863c7a847cb8d87fb9ef5578a16f18901", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" class=\"btn  btn-sm btn-danger \"><i class=\"fas fa-trash text-white\"></i></button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                                                                                   WriteLiteral(item.Idlesson);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 150 "D:\ĐH-08CNTT1\HienCa\LWEnglishPractice\Views\Lessons\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>

            </div>
        </div>
    </div>

</div>

<script>
    let deleteBtns = document.querySelectorAll('.formDelete');
    deleteBtns.forEach(function (deleteBtn) {
        deleteBtn.addEventListener('submit', function (e) {

            var form = this;

            e.preventDefault();

            swal({
                title: 'Bạn có chắc chắn muốn xóa?',

                icon: 'warning',
                buttons: ['Hủy bỏ!', 'Xác nhận'],
                dangerMode: true,
            }).then(function (isConfirm) {
                if (isConfirm) {

                    form.submit();
                    swal({
                        title: 'Đã xóa!',
                        icon: 'success',
                        timer: 1500,
                        button: false,
                    });

                } else {
                    swal({
                        title: 'Đã hủy!',
                        bu");
            WriteLiteral(@"tton: false,
                        icon: 'error',
                        timer: 500,
                    });
                }
            });
        });
    })



    function onSubmitForm() {
        let isSubmit = false;
        let checkDescribe = document.getElementById(""checkDescribe"");
        let checkLessonname = document.getElementById(""checkLessonname"");
        let Lessonname = document.getElementById(""Lessonname"").value;
        let Describe = document.getElementById(""Describe"").value;


        let errorMessage = ""Vui lòng cung cấp thông tin!"";

        if (Lessonname.length == 0) {
            checkLessonname.innerText = errorMessage;

        }
       
        if (Describe.length == 0) {
            checkDescribe.innerText = errorMessage;

        }
       
        else {
            isSubmit = true;
        }
        return isSubmit;
    }


    let btnAdd = document.getElementById(""btnAdd"");
    let btnUpdate = document.getElementById(""btnUpdate"");");
            WriteLiteral(@"
    let btnCancel = document.getElementById(""btnCancel"");
    let action = document.getElementById(""action"");

    btnCancel.addEventListener(""click"", function () {
        btnUpdate.style.display = ""none"";
        btnCancel.style.display = ""none"";
        btnAdd.style.display = ""block"";
        document.getElementById(""Datecreate"").disabled = true;
    })


    btnAdd.addEventListener(""click"", function () {
        action.value = ""addItem"";
    })
    btnUpdate.addEventListener(""click"", function () {
        action.value = ""editItem"";

    })


    function onEdit(td) {
        document.getElementById(""Datecreate"").disabled = false;
        selectedRow = td.parentElement.parentElement;
        document.getElementById(""Lessonname"").value = selectedRow.cells[1].innerHTML;
        document.getElementById(""Describe"").value = selectedRow.cells[2].innerHTML;
        if (selectedRow.cells[4].innerHTML != """") {
            var Datecreate = selectedRow.cells[4].innerHTML;
            docum");
            WriteLiteral(@"ent.getElementById(""Datecreate"").value = Datecreate;
        }
        document.getElementById(""Idlesson"").value = selectedRow.cells[5].innerHTML;

      

        btnAdd.style.display = ""none"";
        btnUpdate.style.display = ""block"";
        btnCancel.style.display = ""block"";

    }
    btnUpdate.addEventListener(""click"", function () {
        btnAdd.style.display = ""block"";
        btnUpdate.style.display = ""none"";
        btnCancel.style.display = ""none"";

    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LWEnglishPractice.Entities.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
