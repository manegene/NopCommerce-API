using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Services.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nop.RestApi.Service.Controllers.Core
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesXmlController : ControllerBase
    {
        #region fields
        private readonly IProductService _productService;
        #endregion fields
        #region _ctor
        public AttributesXmlController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion ctor
        #region methods
        [HttpGet]
        public ActionResult ReturnXmlAttributes(int prodid, [FromQuery] int[] attributeid)
        {
            IList<ProductProductAttributeMapping> productAttributes = _productService.GetProductAttributeMappingsByProductId(prodid);

            string attXml = productAttributes.Aggregate(string.Empty, (attributesXml, attribute) =>
            {
                IList<ProductAttributeValue> attributeValues = _productService.GetProductAttributeValues(attribute.Id);
                foreach (int selectedAttributeId in attributeValues
                    .Where(v => attributeid.Contains(v.Id))
                    .Select(v => v.Id)
                    .ToList())
                {
                    attributesXml = _productService.AddProductAttribute(attributesXml,
                        attribute, selectedAttributeId.ToString());
                }

                return attributesXml;
            });
            return Ok(attXml);

        }
        #endregion methods
    }
}
