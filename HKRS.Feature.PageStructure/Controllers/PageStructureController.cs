using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using HKRS.Common.Models.AutoGen.sitecore.templates.User_Defined.HKRS.Feature;

namespace HKRS.Feature.BasicContent.Controllers
{
    public class PageStructureController : Controller
    {

        private IMvcContext _mvcContext;

        public PageStructureController()
        {
            _mvcContext = new MvcContext();
        }

        // GET: PageStructure
        public ActionResult Header()
        {
            var dataSourceItem = _mvcContext.GetDataSourceItem<ISiteHeader>();

            if (dataSourceItem == null && !Sitecore.Context.PageMode.IsExperienceEditorEditing)
                return new EmptyResult();



            return View(dataSourceItem);
        }

        public ActionResult Footer()
        {
            var dataSourceItem = _mvcContext.GetDataSourceItem<ISiteFooter>();

            if (dataSourceItem == null && !Sitecore.Context.PageMode.IsExperienceEditorEditing)
                return new EmptyResult();



            return View(dataSourceItem);
        }

        public ActionResult Navigation()
        {
            //var dataSourceItem = _mvcContext.GetDataSourceItem<IBasicContent>();

            //if (dataSourceItem == null && !Sitecore.Context.PageMode.IsExperienceEditorEditing)
                return new EmptyResult();



            //return View(dataSourceItem);
        }
    }
}