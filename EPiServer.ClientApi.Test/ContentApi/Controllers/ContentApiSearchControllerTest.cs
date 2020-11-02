using EpiServer.ClientApi;
using EPiServer.ClientApi.Test.SiteConfig;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiServer.ClientApi.Test.ContentApi.Controllers
{
	public class ContentApiSearchControllerTest : ContentApiClientTest
	{
		public const string BaseContentApiRoute = "api/episerver/v2.0/";
		public const string RoutePrefix = BaseContentApiRoute + "search/content";

		[Test]
		public void Search_QuickSilverB2BSiteContext_ShouldReturn200()
		{
            ContentApiClient client = new ContentApiClient(new QuickSilverB2BSiteContext());
            //var result = client.Get(RoutePrefix + "??filter=((ContentType/any(t:t eq 'InfoPageModel') or ContentType/any(t:t eq 'NewsPageModel'))) and ((category/value/id eq 573 and (category/value/id eq 271 or category/value/id eq 243 or category/value/id eq 246 or category/value/id eq 282)) and (category/value/id ne 272 or category/value/id ne 273 or category/value/id ne 278 or category/value/id ne 248 or category/value/id ne 269 or category/value/id ne 270 or category/value/id ne 273 or category/value/id ne 279 or category/value/id ne 281) or (category/value/id eq 271 or category/value/id eq 243 or category/value/id eq 246 or category/value/id eq 282))&orderby=startPublish desc&top=1&skip=0");

            //var result2 = client.Get(RoutePrefix + "??filter=((ContentType/any(t:t eq 'InfoPageModel') or ContentType/any(t:t eq 'NewsPageModel'))) and ((category/value/id eq 573 and (category/value/id eq 271 or category/value/id eq 243 or category/value/id eq 246 or category/value/id eq 282)) and (category/value/id ne 272 or category/value/id ne 273 or category/value/id ne 278 or category/value/id ne 248 or category/value/id ne 269 or category/value/id ne 270 or category/value/id ne 273 or category/value/id ne 279 or category/value/id ne 281) or (category/value/id eq 271 or category/value/id eq 243 or category/value/id eq 246 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 282 or category/value/id eq 283 or category/value/id eq 284 or category/value/id eq 284 or category/value/id eq 284 or category/value/id eq 285 or category/value/id eq 286 or category/value/id eq 284 or category/value/id eq 288 or category/value/id eq 287 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286 or category/value/id eq 286))&orderby=startPublish desc&top=1&skip=0");

            //var result = client.Get(RoutePrefix + "?query=90");
            var result = client.Get(RoutePrefix + "?filter=ContentType%2Fany%28t%3At eq %27TeaserBlock%27%29 and %28visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180295%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180198%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180392%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788190042%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180140%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788190279%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180286%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180391%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180038%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180374%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788190297%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180306%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180382%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788190334%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180309%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180193%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180191%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180272%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180112%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180066%27 or visitorGroupBlock%2FexpandedValue%2FrecommendationCategories%2Fvalue eq %2788180301%27 or visitorGroupBlock%2Fexpa");
		}

        [Test]
        public void Search_AlloySiteContext_ShouldReturn200()
        {
            // AlloySiteContext 11.5.3
            ContentApiClient client = new ContentApiClient(new AlloySiteContext());

            var result = client.Get(RoutePrefix + "?query=alloy");
        }
    }
}
