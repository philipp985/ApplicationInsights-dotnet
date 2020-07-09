﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    /// <summary>
    /// Partial class to add the EventData attribute and any additional customizations to the generated type.
    /// </summary>
#if NET45 || NET452
    // .Net 4.5 and .NET 4.5.2 have a custom implementation of RichPayloadEventSource
#else
    [System.Diagnostics.Tracing.EventData(Name = "PartB_PageViewPerfData")]
#endif
    internal partial class PageViewPerfData
    {
        public new PageViewPerfData DeepClone()
        {
            var other = new PageViewPerfData();
            this.ApplyProperties(other);
            return other;
        }

        protected override void ApplyProperties(EventData other)
        {
            base.ApplyProperties(other);
            PageViewPerfData otherPageViewPerf = other as PageViewPerfData;
            if (otherPageViewPerf != null)
            {
                otherPageViewPerf.domProcessing = this.domProcessing;
                otherPageViewPerf.perfTotal = this.perfTotal;
                otherPageViewPerf.networkConnect = this.networkConnect;
                otherPageViewPerf.sentRequest = this.sentRequest;
                otherPageViewPerf.receivedResponse = this.receivedResponse;
            }
        }
    }
}