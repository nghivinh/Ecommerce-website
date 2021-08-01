#pragma checksum "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7ba87536038c7164f77a2ed381a340d278424d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Details), @"mvc.1.0.view", @"/Views/ProductDetail/Details.cshtml")]
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
#line 1 "D:\Nam4\Ecommerce-website\Logitech\Views\_ViewImports.cshtml"
using Logitech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam4\Ecommerce-website\Logitech\Views\_ViewImports.cshtml"
using Logitech.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7ba87536038c7164f77a2ed381a340d278424d", @"/Views/ProductDetail/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a64b83697e1bc30402c55bd214a09c061f76ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetail_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Logitech.ViewModel.LoadProductDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
  
    ViewData["Title"] = "Chi tiết sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
  
    float starSum = ViewBag.StarSum;
    float starCount = ViewBag.StarCount;

    float agvStar = 0;
    if (starCount > 0)
    {
        agvStar = (starSum / starCount);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container pt-36\">\r\n    <div class=\"grid\">\r\n        <div class=\"grid__row product-detail__wrap\">\r\n            <div class=\"grid__col-40\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 552, "\"", 570, 1);
#nullable restore
#line 25 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
WriteAttributeValue("", 558, Model.Image, 558, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"logo\" class=\"product-detail__img\">\r\n            </div>\r\n\r\n            <div class=\"grid__col-60\">\r\n                <div class=\"product-detail\">\r\n                    <h3 class=\"product-detail__name\">");
#nullable restore
#line 30 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"product-detail__quantity\">\r\n                        <div class=\"product-detail__rating\">\r\n");
#nullable restore
#line 33 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                             if (agvStar == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product-detail__rating-text-no\">Chưa có đánh giá</div>\r\n");
#nullable restore
#line 36 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product-detail__rating-text\">");
#nullable restore
#line 39 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                    Write(Math.Round((double)agvStar, 1).ToString().Replace(",","."));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"product-detail__rating-star\">\r\n");
#nullable restore
#line 41 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                      
                                        var _agvStar = Math.Round((double)agvStar, 0);
                                        for (int i = 0; i < _agvStar; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"product-detail__rating-star--gold fas fa-star\"></i>\r\n");
#nullable restore
#line 46 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                        }
                                        for (int i = 0; i < 5 - _agvStar; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-star\"></i>\r\n");
#nullable restore
#line 50 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 53 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <span class=\"bulkhead\">|</span>\r\n                        <div class=\"product-detail__sold\">\r\n                            <span class=\"product-detail__sold-text\">");
#nullable restore
#line 57 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                               Write(Model.Sold);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <span class=""product-detail__sold-label"">Đã Bán</span>
                        </div>
                        <span class=""bulkhead"">|</span>
                        <div class=""product-detail__store"">
                            <span class=""product-detail__store-text"">");
#nullable restore
#line 62 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                Write(Model.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <span class=""product-detail__store-label"">Sản phẩm có sẵn</span>
                        </div>
                    </div>

                    <div class=""product-detail__content"">
                        <div class=""product-detail__price"">
");
#nullable restore
#line 69 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                             if (Model.SaleOff == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"product-detail__price-new\">");
#nullable restore
#line 71 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                   Write(Model.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>đ</span></span>\r\n");
#nullable restore
#line 72 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                            }
                            else
                            {
                                var priceOld = Model.Price;
                                var priceNew = Model.Price * (100 - Model.SaleOff) / 100;
                                if (priceNew == priceOld)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"product-detail__price-old\">");
#nullable restore
#line 79 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                       Write(priceNew.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>đ</span></span>\r\n");
#nullable restore
#line 80 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"product-detail__price-old\">");
#nullable restore
#line 83 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                       Write(priceOld.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>đ</span></span>\r\n                                    <span class=\"product-detail__price-new\">");
#nullable restore
#line 84 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                       Write(priceNew.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>đ</span></span>\r\n");
#nullable restore
#line 85 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product-detail__price-saleoff\"><span>");
#nullable restore
#line 86 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                            Write(Model.SaleOff);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>% Giảm</div>\r\n");
#nullable restore
#line 87 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""product-detail__button"">
                            <button class=""btn btn__add-to-cart"">
                                <i class=""fas fa-cart-plus""> </i>
                                Thêm Vào Giỏ Hàng
                            </button>
                            <button class=""btn btn__buy-now"">Mua Ngay</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""grid__row mt-36"">
            <div class=""grid__ful-width"">
                <div class=""product-detail__information"">
                    <h2 class=""product-detail__information-heading"">Thông tin Sản Phẩm</h2>
                    <div class=""product-detail__information-text"">
                        ");
#nullable restore
#line 105 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                   Write(Html.Raw(Model.Description.Replace("\r\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""grid__row mt-36 pb-36"">
            <div class=""grid__ful-width"">
                <div id=""feadback"" class=""product-detail__feedback"" >
                    <h2 class=""product-detail__feedback-heading"">Đánh Giá Sản Phẩm</h2>
");
#nullable restore
#line 114 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                     foreach (var item in Model.ListOfReview)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""product-detail__feedback-list"">
                            <div class=""product-detail__feedback-item"">
                                <div class=""product-detail__feedback-item-top"">
                                    <h4 class=""product-detail__feedback-username"">");
#nullable restore
#line 119 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                             Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p class=\"product-detail__feedback-createDate\">vào ngày <span>");
#nullable restore
#line 120 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                                             Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                </div>\r\n                                <div class=\"product-detail__feedback-star\">\r\n");
#nullable restore
#line 123 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                      
                                        for (int i = 0; i < item.Star; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"product-detail__feedback-star--gold fas fa-star\"></i>\r\n");
#nullable restore
#line 127 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                        }
                                        for (int i = 0; i < 5 - item.Star; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-star\"></i>\r\n");
#nullable restore
#line 131 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <p class=\"product-detail__feedback-comment\">");
#nullable restore
#line 134 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                                                                       Write(Html.Raw(item.Comment.Replace("\r\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <hr class=\"style-hr\" />\r\n                        </div>\r\n");
#nullable restore
#line 138 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 140 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                     if (HttpContextAccessor.HttpContext.Session.GetString("Id") != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                         using (Html.BeginForm("Add", "ProductDetail", FormMethod.Post, new { onsubmit = "return SubmitComment()" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""product-detail__feedback-write"">
                                <p class=""product-detail__feedback-write-heading"">Viết đánh giá</p>
                                <div class=""product-detail__feedback-write-comment"">
                                    <textarea name=""Comment"" id=""Comment"" required rows=""5""
                                              class=""product-detail__feedback-textarea""
                                              placeholder=""Bạn nhận xét sản phẩm như thế nào?""></textarea>
                                </div>
                                <div class=""product-detail__feedback-rating"">
                                    <p class=""product-detail__feedback-rating-label"">
                                        Bạn đánh giá sản phẩm bao nhiêu sao?<br />(1 sao là rất tệ, 5 sao là rất tốt)
                                    </p>
                                    <div class=""product-detail__feedback-rating-action"">
                ");
            WriteLiteral(@"                        <div onmouseout=""CRateSelected()"">
                                            <span class=""star--normal fas fa-star"" id=""Rate1"" onclick=""CRate(1)"" onmouseover=""CRateOver(1)"" onmouseout=""CRateOut(1)""></span>
                                            <span class=""star--normal fas fa-star"" id=""Rate2"" onclick=""CRate(2)"" onmouseover=""CRateOver(2)"" onmouseout=""CRateOut(2)""></span>
                                            <span class=""star--normal fas fa-star"" id=""Rate3"" onclick=""CRate(3)"" onmouseover=""CRateOver(3)"" onmouseout=""CRateOut(3)""></span>
                                            <span class=""star--normal fas fa-star"" id=""Rate4"" onclick=""CRate(4)"" onmouseover=""CRateOver(4)"" onmouseout=""CRateOut(4)""></span>
                                            <span class=""star--normal fas fa-star"" id=""Rate5"" onclick=""CRate(5)"" onmouseover=""CRateOver(5)"" onmouseout=""CRateOut(5)""></span>
                                        </div>
                                    </div>
  ");
            WriteLiteral("                                  <div class=\"product-detail__feedback-select-star\">\r\n                                        <input type=\"hidden\" name=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 9548, "\"", 9565, 1);
#nullable restore
#line 166 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
WriteAttributeValue("", 9556, Model.Id, 9556, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <input type=\"hidden\" name=\"Star\" id=\"Rating\" value=\"0\" />\r\n                                        <input type=\"hidden\" name=\"AccountId\"");
            BeginWriteAttribute("value", " value=\"", 9747, "\"", 9811, 1);
#nullable restore
#line 168 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
WriteAttributeValue("", 9755, HttpContextAccessor.HttpContext.Session.GetString("Id"), 9755, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <input type=\"submit\" value=\"Gửi đánh giá ngay\" class=\"btn btn--primary\" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 173 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                         
                    } 
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-detail__feedback-write--no\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 10257, "\"", 10291, 1);
#nullable restore
#line 178 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
WriteAttributeValue("", 10264, Url.Action("Login","Home"), 10264, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đăng nhập để Đánh giá</a>\r\n                        </div>\r\n");
#nullable restore
#line 180 "D:\Nam4\Ecommerce-website\Logitech\Views\ProductDetail\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script>
    function SubmitComment() {
        if (document.querySelector(""#Rating"").value == ""0"") {
            alert(""Vui lòng đánh giá bằng sao"");
            return false;
        }
        else {
            return true;
        }
    }

    function CRate(r) {
        document.querySelector(""#Rating"").value = r;
        for (let i = 1; i <= r; i++) {
            document.querySelector(""#Rate"" + i).setAttribute('class', 'star--gold fas fa-star');
        }

        for (let i = r + 1; i <= 5; i++) {
            document.querySelector(""#Rate"" + i).setAttribute('class', 'star--normal fas fa-star');
        }
    }

    function CRateOver(r) {
        for (var i = 1; i <= r; i++) {
            document.querySelector(""#Rate"" + i).setAttribute('class', 'star--gold fas fa-star');
        }
    }

    function CRateOut(r) {
        for (var i = 1; i <= r; i++) {
            document.querySelector(""#R");
            WriteLiteral(@"ate"" + i).setAttribute('class', 'star--normal fas fa-star');
        }
    }

    function CRateSelected() {
        var setRating = document.querySelector(""#Rating"").value;
        for (var i = 1; i <= setRating; i++) {
            document.querySelector(""#Rate"" + i).setAttribute('class', 'star--gold fas fa-star');
        }
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Logitech.ViewModel.LoadProductDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591