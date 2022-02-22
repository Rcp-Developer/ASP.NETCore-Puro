#pragma checksum "C:\Users\RODRIGO\Documents\GitHub\ASP.NETCore\meu_aula1\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce986f9901a3c79637dcdd3162ab071b612c1caf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce986f9901a3c79637dcdd3162ab071b612c1caf", @"/Views/Item/Index.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\RODRIGO\Documents\GitHub\ASP.NETCore\meu_aula1\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "Item page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Product section-->
<section class=""py-5"">
    <div class=""container px-4 px-lg-5 my-5"">
        <div class=""row gx-4 gx-lg-5 align-items-center"">
            <div class=""col-md-6""><img class=""card-img-top mb-5 mb-md-0"" src=""https://dummyimage.com/600x700/dee2e6/6c757d.jpg"" alt=""..."" /></div>
            <div class=""col-md-6"">
                <div class=""small mb-1"">SKU: BST-498</div>
                <h1 class=""display-5 fw-bolder"">Shop item template</h1>
                <div class=""fs-5 mb-5"">
                    <span class=""text-decoration-line-through"">$45.00</span>
                    <span>$40.00</span>
                </div>
                <p class=""lead"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Praesentium at dolorem quidem modi. Nam sequi consequatur obcaecati excepturi alias magni, accusamus eius blanditiis delectus ipsam minima ea iste laborum vero?</p>
                <div class=""d-flex"">
                    <input class=""form-control text-center me-3"" id=""inpu");
            WriteLiteral(@"tQuantity"" type=""num"" value=""1"" style=""max-width: 3rem"" />
                    <button class=""btn btn-outline-dark flex-shrink-0"" type=""button"">
                        <i class=""bi-cart-fill me-1""></i>
                        Add to cart
                    </button>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Related items section-->
<section class=""py-5 bg-light"">
    <div class=""container px-4 px-lg-5 mt-5"">
        <h2 class=""fw-bolder mb-4"">Related products</h2>
        <div class=""row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center"">
            <div class=""col mb-5"">
                <div class=""card h-100"">
                    <!-- Product image-->
                    <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                    <!-- Product details-->
                    <div class=""card-body p-4"">
                        <div class=""text-center"">
              ");
            WriteLiteral(@"              <!-- Product name-->
                            <h5 class=""fw-bolder"">Fancy Product</h5>
                            <!-- Product price-->
                            $40.00 - $80.00
                        </div>
                    </div>
                    <!-- Product actions-->
                    <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                        <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">View options</a></div>
                    </div>
                </div>
            </div>
            <div class=""col mb-5"">
                <div class=""card h-100"">
                    <!-- Sale badge-->
                    <div class=""badge bg-dark text-white position-absolute"" style=""top: 0.5rem; right: 0.5rem"">Sale</div>
                    <!-- Product image-->
                    <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                    <!-- Product details");
            WriteLiteral(@"-->
                    <div class=""card-body p-4"">
                        <div class=""text-center"">
                            <!-- Product name-->
                            <h5 class=""fw-bolder"">Special Item</h5>
                            <!-- Product reviews-->
                            <div class=""d-flex justify-content-center small text-warning mb-2"">
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                            </div>
                            <!-- Product price-->
                            <span class=""text-muted text-decoration-line-through"">$20.00</span>
                            $18.00
                        </div>
                    </div>
                    <!-- Product actions");
            WriteLiteral(@"-->
                    <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                        <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">Add to cart</a></div>
                    </div>
                </div>
            </div>
            <div class=""col mb-5"">
                <div class=""card h-100"">
                    <!-- Sale badge-->
                    <div class=""badge bg-dark text-white position-absolute"" style=""top: 0.5rem; right: 0.5rem"">Sale</div>
                    <!-- Product image-->
                    <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                    <!-- Product details-->
                    <div class=""card-body p-4"">
                        <div class=""text-center"">
                            <!-- Product name-->
                            <h5 class=""fw-bolder"">Sale Item</h5>
                            <!-- Product price-->
                            <sp");
            WriteLiteral(@"an class=""text-muted text-decoration-line-through"">$50.00</span>
                            $25.00
                        </div>
                    </div>
                    <!-- Product actions-->
                    <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                        <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">Add to cart</a></div>
                    </div>
                </div>
            </div>
            <div class=""col mb-5"">
                <div class=""card h-100"">
                    <!-- Product image-->
                    <img class=""card-img-top"" src=""https://dummyimage.com/450x300/dee2e6/6c757d.jpg"" alt=""..."" />
                    <!-- Product details-->
                    <div class=""card-body p-4"">
                        <div class=""text-center"">
                            <!-- Product name-->
                            <h5 class=""fw-bolder"">Popular Item</h5>
                            <!-- Product");
            WriteLiteral(@" reviews-->
                            <div class=""d-flex justify-content-center small text-warning mb-2"">
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                                <div class=""bi-star-fill""></div>
                            </div>
                            <!-- Product price-->
                            $40.00
                        </div>
                    </div>
                    <!-- Product actions-->
                    <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                        <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">Add to cart</a></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
