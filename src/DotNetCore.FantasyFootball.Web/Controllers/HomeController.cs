using Microsoft.AspNetCore.Mvc;
using DotNetCore.FantasyFootball.Core;
using DotNetCore.FantasyFootball.Web.ViewModels;
using DotNetCore.FantasyFootball.Core.Models;
using System.Collections.Generic;
using DotNetCore.FantasyFootball.Core.PageParser;

namespace DotNetCore.FantasyFootball.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISiteCollectionProcessor siteCollectionProcessor;

        public HomeController(ISiteCollectionProcessor siteCollectionProcessor)
        {
            this.siteCollectionProcessor = siteCollectionProcessor;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel viewModel)
        {
            var siteCollection = new SiteCollection
            {
                FantasySites = new List<FantasySite>
                {
                    new FantasySite
                    {
                        PageUrl = viewModel.SiteUrl1,
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = viewModel.TableXPath1,
                            NameCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.NameCellXPath1,
                                IndexPosition = viewModel.NameIndexPosition1,
                                SplitOnValue = viewModel.NameSplitOnValue1
                            },
                            RankCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.RankCellXPath1,
                                IndexPosition = viewModel.RankIndexPosition1,
                                SplitOnValue = viewModel.RankSplitOnValue1
                            },
                            PositionCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.PositionCellXPath1,
                                IndexPosition = viewModel.PositionIndexPosition1,
                                SplitOnValue = viewModel.PositionSplitOnValue1
                            }
                        }
                    },
                    new FantasySite
                    {
                        PageUrl = viewModel.SiteUrl2,
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = viewModel.TableXPath2,
                            NameCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.NameCellXPath2,
                                IndexPosition = viewModel.NameIndexPosition2,
                                SplitOnValue = viewModel.NameSplitOnValue2
                            },
                            RankCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.RankCellXPath2,
                                IndexPosition = viewModel.RankIndexPosition2,
                                SplitOnValue = viewModel.RankSplitOnValue2
                            },
                            PositionCellParams = new CellParseParams
                            {
                                CellXPath = viewModel.PositionCellXPath2,
                                IndexPosition = viewModel.PositionIndexPosition2,
                                SplitOnValue = viewModel.PositionSplitOnValue2
                            }
                        }
                    }
                }
            };
            var playersAgrregates = this.siteCollectionProcessor.Process(siteCollection);
            return null;
        }

    }
}
