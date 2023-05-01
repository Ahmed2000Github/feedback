using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace Web.ViewComponents
{
    public class StatisticViewComponent : ViewComponent
    {
        private readonly IUnitOfWork<Product> product;
        private readonly IUnitOfWork<Rating> rating;

        public StatisticViewComponent(IUnitOfWork<Rating> rating, IUnitOfWork<Product> product)
        {
            this.product = product;
            this.rating = rating;
        }
        public IViewComponentResult Invoke(Guid Id)
        {
            var AllRatings = rating.Entity.GetAll().Where(i => i.ProductId == Id).Where(x => x.Level != -1);
            int ratingCount = AllRatings.Count();
            Func<string[]> Starcalc = () =>
            {
                float[] counts = new float[6] { 0, 0, 0, 0, 0, 0 };
                string[] countString = new string[6] { "0","0","0","0","0","0" };
                foreach (var item in AllRatings)
                {
                    switch (item.Level)
                    {
                        case 0:
                            {
                                counts[0] += 1;
                                break;
                            }
                        case 1:
                            {
                                counts[1] += 1;
                                break;
                            }
                        case 2:
                            {
                                counts[2] += 1;
                                break;
                            }
                        case 3:
                            {
                                counts[3] += 1;
                                break;
                            }
                        case 4:
                            {
                                counts[4] += 1;
                                break;
                            }
                        case 5:
                            {
                                counts[5] += 1;
                                break;
                            }
                        default:
                            break;
                    }
                }
                for (int i = 0; i < counts.Length; i++)
                {
                    decimal avg = (decimal)((counts[i] / ratingCount) * 100);
                    countString[i] = Math.Round(avg).ToString();
                }
                return countString;
            };
            Func<float> calcAvg = () =>
            {
                float sumLevel = 0;
                foreach (var item in AllRatings)
                {
                    sumLevel += item.Level;
                }
                float div = (sumLevel / (float)ratingCount);
                return div;
            };
            Func<float, decimal> StarAvg = (float avg) => (Math.Round((decimal)(avg * 20)));
            float _avg = ratingCount != 0 ? calcAvg(): 0;
            StatisticVM data = new StatisticVM()
            {
                CommentNumber = (ratingCount == 0) ? "No comment" : ratingCount.ToString(),
                Avg = _avg.ToString().Length >= 3?_avg.ToString().Substring(0,3): _avg.ToString(),
                BarAvg = ratingCount != 0 ? Starcalc() : new string[6] { "0", "0", "0", "0", "0", "0" },
                StarAvg = _avg == 0 ? "0" : StarAvg(_avg).ToString()
            };
            return View(data);
        }
    }
}
