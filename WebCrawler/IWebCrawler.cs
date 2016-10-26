﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    public interface IWebCrawler
    {
        Task<CrawlResult> PerformCrawlingAsync(IEnumerable<string> rootUrls);
    }
}